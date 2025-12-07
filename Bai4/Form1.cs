using System;
using System.Collections.Generic;
using System.Drawing; 
using System.IO;      
using System.Linq;
using System.Net;     
using System.Net.Http;
using System.Net.Mail;
using System.Net.Mime;
using System.Windows.Forms;
using HtmlAgilityPack; 

namespace Bai4
{
    public partial class Form1 : Form
    {
        const string MY_EMAIL = "tdruucc20056@gmail.com";    
        const string MY_APP_PASSWORD = "xrep oxeb tdqf aody";  

        public class Movie
        {
            public string Title { get; set; }
            public string PosterUrl { get; set; }
            public decimal Price { get; set; } = 85000;
        }

        List<Movie> movies = new List<Movie>();
        List<CheckBox> seatCheckBoxes = new List<CheckBox>();
        HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
            InitSeats();
            LoadMovieDataFromWeb();
        }

        private void InitSeats()
        {
            flpGhe.Controls.Clear();
            seatCheckBoxes.Clear();

            char[] rows = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };

            foreach (char row in rows)
            {
                
                for (int i = 1; i <= 10; i++)
                {
                    CheckBox chk = new CheckBox();
                    chk.Text = $"{row}{i}"; 
                    chk.Size = new Size(40, 32); 
                    chk.Appearance = Appearance.Button;
                    chk.TextAlign = ContentAlignment.MiddleCenter;
                    chk.BackColor = Color.White;
                    chk.Margin = new Padding(3);
                    chk.Cursor = Cursors.Hand;
                    chk.Font = new Font("Segoe UI", 8F, FontStyle.Bold); 

                    chk.CheckedChanged += (s, e) => {
                        var c = s as CheckBox;
                        c.BackColor = c.Checked ? Color.Orange : Color.White;
                        c.ForeColor = c.Checked ? Color.White : Color.Black;
                    };

                    flpGhe.Controls.Add(chk);
                    seatCheckBoxes.Add(chk);

                    if (i == 10)
                    {
                        flpGhe.SetFlowBreak(chk, true);
                    }
                }
            }
        }

        private async void LoadMovieDataFromWeb()
        {
            btnBook.Enabled = false;
            lblStatus.Text = "Đang kết nối Beta Cinemas...";

            movies.Clear();
            cboPhim.DataSource = null;

            try
            {
                string url = "https://betacinemas.vn/phim.htm";
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/115.0.0.0 Safari/537.36");

                string htmlContent = await client.GetStringAsync(url);

                HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
                document.LoadHtml(htmlContent);
                var movieNodes = document.DocumentNode.SelectNodes("//div[contains(@class, 'tab-pane') and contains(@class, 'active')]//div[contains(@class, 'col-lg-4')]");

                
                if (movieNodes != null)
                {
                    foreach (var node in movieNodes)
                    {
                        var titleNode = node.SelectSingleNode(".//h3/a");
                        var imgNode = node.SelectSingleNode(".//img");

                        if (titleNode != null && imgNode != null)
                        {
                            string title = titleNode.InnerText.Trim();
                            string imgUrl = imgNode.GetAttributeValue("src", "");
                            if (!imgUrl.StartsWith("http"))
                            {
                                imgUrl = "https://betacinemas.vn" + imgUrl;
                            }

                            if (!string.IsNullOrEmpty(title))
                            {
                                movies.Add(new Movie
                                {
                                    Title = title,
                                    PosterUrl = imgUrl,
                                    Price = 40000 
                                });
                            }
                        }
                    }
                }

                if (movies.Count > 0)
                {
                    cboPhim.DataSource = movies;
                    cboPhim.DisplayMember = "Title";
                    CboPhim_SelectedIndexChanged(null, null);

                    lblStatus.Text = $"Đã tải thành công {movies.Count} phim.";
                }
                else
                {
                    lblStatus.Text = "Không tìm thấy phim nào (Web thay đổi cấu trúc?)";
                    movies.Add(new Movie { Title = "Phim Mẫu (Lỗi Web)", PosterUrl = "https://via.placeholder.com/260x380" });
                    cboPhim.DataSource = movies;
                    cboPhim.DisplayMember = "Title";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cào dữ liệu: " + ex.Message);
                lblStatus.Text = "Lỗi kết nối.";
            }
            finally
            {
                btnBook.Enabled = true;
            }
        }
        private void CboPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            var movie = cboPhim.SelectedItem as Movie;
            if (movie == null) return;

            try
            {
                if (!string.IsNullOrEmpty(movie.PosterUrl))
                    pbPoster.Load(movie.PosterUrl);
            }
            catch
            {
                pbPoster.Image = null;
            }
        }

        private async void BtnBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên và Email!", "Thiếu thông tin");
                return;
            }

            var selectedSeats = seatCheckBoxes.Where(x => x.Checked).Select(x => x.Text).ToList();
            if (selectedSeats.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 ghế!", "Chưa chọn ghế");
                return;
            }

            btnBook.Enabled = false;
            btnBook.Text = "ĐANG GỬI...";
            lblStatus.Text = "Đang kết nối SMTP...";

            try
            {
                var movie = cboPhim.SelectedItem as Movie;
                decimal total = selectedSeats.Count * movie.Price;
                string seatStr = string.Join(", ", selectedSeats);

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(MY_EMAIL);
                mail.To.Add(txtEmail.Text.Trim());
                mail.Subject = $"Vé xem phim: {movie.Title}";

                string htmlBody = $@"
                    <div style='font-family: Arial; padding: 20px; border: 2px solid #3498db;'>
                        <h2 style='color: #e74c3c;'>XÁC NHẬN ĐẶT VÉ THÀNH CÔNG</h2>
                        <p>Xin chào <b>{txtName.Text}</b>,</p>
                        <table style='width:100%'>
                            <tr>
                                <td style='vertical-align:top'>
                                    <p>Phim: <b>{movie.Title}</b></p>
                                    <p>Ghế: <b style='color:blue; font-size:18px'>{seatStr}</b></p>
                                    <p>Giá vé: <b>{total:N0} VNĐ</b></p>
                                    <p><i>Cảm ơn bạn đã sử dụng dịch vụ!</i></p>
                                </td>
                                <td>
                                    <img src='cid:PosterImg' width='120' style='border:1px solid #ccc'/>
                                </td>
                            </tr>
                        </table>
                    </div>";

                AlternateView htmlView = AlternateView.CreateAlternateViewFromString(htmlBody, null, MediaTypeNames.Text.Html);

                MemoryStream ms = new MemoryStream();
                if (pbPoster.Image != null)
                {
                    pbPoster.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    ms.Position = 0;
                }
                else
                {
                    new Bitmap(1, 1).Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    ms.Position = 0;
                }

                LinkedResource imgRes = new LinkedResource(ms, "image/png");
                imgRes.ContentId = "PosterImg";
                htmlView.LinkedResources.Add(imgRes);

                mail.AlternateViews.Add(htmlView);
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential(MY_EMAIL, MY_APP_PASSWORD);

                await smtp.SendMailAsync(mail);

                MessageBox.Show("Đặt vé thành công! Vui lòng kiểm tra Email.", "Ông Trùm Winforms");
                lblStatus.Text = "Gửi thành công.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi gửi mail: " + ex.Message, "Error");
                lblStatus.Text = "Lỗi.";
            }
            finally
            {
                btnBook.Enabled = true;
                btnBook.Text = "ĐẶT VÉ & GỬI MAIL";
            }
        }
    }
}