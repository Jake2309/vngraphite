using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VNGraphiteCore.Models
{
    public class SampleData
    {

        public static List<Category> CategoryData = new List<Category>
        {
            new Category{Id = 1, CategoryName = "Dự án"},
            new Category{Id = 2, CategoryName = "Tin tức"},
        };

        public static List<NewsModel> NewsData = new List<NewsModel> {
            new NewsModel{
                Id = 1,
                CategoryID = 1,
                Slug = "du-an-dau-tu-xay-dung-nha-may-che-bien-graphite-yen-bai",
                ShortDescription = "Dự án đầu tư xây dựng nhà máy chế biến Graphite Yên Bái là dự án lớn được cấp giấy chứng nhận đầu tư số 16102100018...",
                Title = "Dự án đầu tư xây dựng nhà máy chế biến graphite yên bái",
                ShortcutImage = "/dist/images/short-news-2.jpg",
                CreatedDate = DateTime.Now.ToString("dd/MM/yyyy"),
                PublishDate = DateTime.Now.ToString("dd/MM/yyyy"),
                TextBlocks = new List<TextBlockModel>{
                    new TextBlockModel
                    {
                        Id = 1,
                        Content = "Dự án đầu tư xây dựng nhà máy chế biến Graphite Yên Bái là dự án lớn được cấp giấy chứng nhận đầu tư số 16102100018, cấp ngày 27/05/2013",
                        Position = 1
                    },
                    new TextBlockModel
                    {
                        Id = 2,
                        Content = "Với mục tiêu cung cấp cho thị trường, tạo việc làm và thu nhập cho lao động trong doanh nghiệp, đóng góp nguồn thu cho ngân sách nhà nước. Dự án được xây dựng tại xã Báo Đáp, huyện Trấn Yên, tỉnh Yên Bái với diện tịch 33ha, tổng vốn đầu tư (dự kiến) là 1.068 tỷ đồng (Một nghìn không trăm sáu mươi tám tỷ đồng)",
                        Position = 2
                    },
                    new TextBlockModel
                    {
                        Id = 3,
                        Content = "Dự án đầu tư xây dựng nhà máy chế biến Graphite Yên Bái bao gồm hai giai đoạn:<br /> - Giai đoạn 1:<br /> + 1. Tuyển nổi Graphite đạt hàm lượng C=95% với công suất 40.000 tấn/năm;<br /> + 2: Tuyển hóa Graphite hàm lượng cacbon 99% với công suất 40.000 tấn/năm(Tuyển lại hàm lượng 95% của dây chuyền tuyển nổi).<br /> - Giai đoạn 2: Tuyển hóa Graphite đạt hàm lượng cacbon 99,99% (Tuyển lại 30% sản lượng Graphite hàm lượng cacbon 99%).",
                        Position = 1
                    }
                },
                Images = new List<ImageModels> {
                    new ImageModels
                    {
                        TextBlockId = 1,
                        Position = 1,
                        ImgUrl = "/dist/images/detail-images/detail-1.jpg",
                        ShortDescription = "Đây là dự án với 100% vốn sở hữu của Công ty TNHH Thương mại Ngọc Viễn Đông."
                    },
                    new ImageModels
                    {
                        TextBlockId = 2,
                        Position = 2,
                        ImgUrl = "/dist/images/detail-images/detail-1-1.jpg",
                        ShortDescription = "Nhà máy chế biến Graphite với quy mô lớn đang dần đi vào hoàn thiện."
                    },
                    new ImageModels
                    {
                        TextBlockId = 3,
                        Position = 3,
                        ImgUrl = "/dist/images/detail-images/detail-1-2.jpg",
                        ShortDescription = "Dây chuyền công nghệ tối tân nhất được Công ty trang bị để phục vụ cho việc sản xuất Graphite có chất lượng tốt nhất phục vụ thị trường"
                    }
                }
            },
            new NewsModel{
                Id = 2,
                CategoryID = 1,
                Slug = "du-an-dau-tu-xay-dung-cong-trinh-khai-thac-mo-graphite-yen-bai",
                ShortDescription = "Hiện tại, Công ty TNHH Thương mại Ngọc Viễn Đông đang triển khai Dự án khai thác và chế biến Graphite Yên Bái bao gồm hai Dự án lớn...",
                Title = "Dự án đầu tư xây dựng công trình khai thác mỏ graphite yên bái",
                ShortcutImage = "/dist/images/new-small-3.jpg",
                CreatedDate = DateTime.Now.ToString("dd/MM/yyyy"),
                PublishDate = DateTime.Now.ToString("dd/MM/yyyy"),
                TextBlocks = new List<TextBlockModel>{
                    new TextBlockModel
                    {
                        Id = 1,
                        Content = "Hiện tại, Công ty TNHH Thương mại Ngọc Viễn Đông đang triển khai Dự án khai thác và chế biến Graphite Yên Bái bao gồm hai Dự án lớn đó là: Dự án đầu tư xây dựng nhà máy chế biến Graphite Yên Bái tại khu phố Hóp, xã Báo Đáp, huyện Trấn Yên, tỉnh Yên Bái và Dự án xây dựng công trình khai thác mỏ Graphite Yên Bái tại xã Yên Thái, huyện Văn Yên, tỉnh Yên Bái. Sản phẩm của Dự án là Graphite với hàm lượng Cacbon khác nhau nhằm đáp ứng thi trường trong và ngoài nước.",
                        Position = 1
                    },
                    new TextBlockModel
                    {
                        Id = 2,
                        Content = "Dự án đầu tư xây dựng công trình khai thác mỏ Graphite Yên Bái với 100% vốn chủ sở hữu và chủ đầu tư là Công ty TNHH Thương mại Ngọc Viễn Đông.<br/>Dự án ĐTXD công trình khai thác mỏ Graphite với mục tiêu cung cấp nguyên liệu cho nhà máy chế biến Graphite của doanh nghiệp đầu tư tại tỉnh Yên Bái, tạo việc làm và thu nhập cho người lao động trong doanh nghiệp, đóng góp nguồn thu cho ngân sách nhà nước.<br/>Địa điểm thực hiện dự án tại xã Yên Thái, huyện Văn Yên, tỉnh Yên Bái. Diện tích đất dự kiến sử dụng là 38,1ha (Ba mươi tám phẩy một héc ta). Trong đó: Diện tích khai thác khoáng sản: 11ha (Mười một héc ta); Diện tích xây dựng văn phòng, bãi thải, công trình phụ trợ: 6,1 ha(Sáu phẩy một héc ta); Diện tích hành lang an toàn khai thác: 21ha(Hai mươi mốt héc ta).<br/>Tổng vốn đầu tư(dự kiến): 146,7 tỷ đồng(Một trăm bốn sáu phẩy bẩy tỷ đồng) với công suất 250.000 tấn quặng nguyên khai mỗi năm.Dự án được cấp giấy chứng nhận đầu tư số 16102100030, cấp ngày 11 tháng 09 năm 2013 do Ủy ban nhân dân tỉnh Yên Bái cấp.",
                        Position = 2
                    }
                },
                Images = new List<ImageModels> {
                    new ImageModels
                    {
                        TextBlockId = 1,
                        Position = 1,
                        ImgUrl = "/dist/images/detail-images/news-2.jpg",
                        ShortDescription = ""
                    }
                }
            },
            new NewsModel{
                Id = 3,
                CategoryID = 2,
                Slug = "chuong-trinh-tu-thien-chan-am-ngay-dong",
                ShortDescription = "Công ty TNHH Thương mại Ngọc Viễn Đông đã trao 200 suất chăn...",
                Title = "Chương trình từ thiện “chăn ấm ngày đông”",
                ShortcutImage = "/dist/images/chan-am-small.jpg",
                CreatedDate = DateTime.Now.ToString("dd/MM/yyyy"),
                PublishDate = DateTime.Now.ToString("dd/MM/yyyy"),
                TextBlocks = new List<TextBlockModel>{
                    new TextBlockModel
                    {
                        Id = 1,
                        Content = "Xuất phát từ tâm khảm mong muốn người dân vùng cao có một mùa đông ấm áp. Chủ tịch Hội đồng thành viên Nguyễn Đức Lượng – Công ty TNHH Thương mại Ngọc Viễn  Đông đã tình nguyện trao 200 chiếc chăn đến các gia đình  đang chịu đựng những cơn rét cắt da, cắt thịt trong mùa đông tại Sapa, Lào cái với Tên gọi “ Chăn ấm ngày đông”.",
                        Position = 1
                    },
                    new TextBlockModel
                    {
                        Id = 2,
                        Content = "Ngày 30 tháng 01 năm 2016 và ngày 31 tháng 01 năm 2016, Công ty TNHH Thương mại Ngọc Viễn Đông đã trao 200 suất chăn cho các gia đình nghèo tại xã Sử Phán, huyện SâP, tỉnh Lào Cai.",
                        Position = 2
                    }
                },
                Images = new List<ImageModels> {
                    new ImageModels
                    {
                        TextBlockId = 1,
                        Position = 1,
                        ImgUrl = "/dist/images/detail-images/chan-am-1.jpg",
                        ShortDescription = "Hơn 200 chiếc chăn của chương trình “ Chăn ấm ngày đông”"
                    },new ImageModels
                    {
                        TextBlockId = 2,
                        Position = 2,
                        ImgUrl = "/dist/images/detail-images/chan-am-2.jpg",
                        ShortDescription = ""
                    },new ImageModels
                    {
                        TextBlockId = 2,
                        Position = 3,
                        ImgUrl = "/dist/images/detail-images/chan-am-3.jpg",
                        ShortDescription = "Công ty Ngọc Viễn Đông đã trao tận tay những chiếc chăn cho các gia đình nghèo tại xã Sử Phán, Sapa, Lào Cai."
                    }
                }
            },
            new NewsModel{
                Id = 4,
                CategoryID = 1,
                Slug = "lo-hang-thiet-bi-may-moc-dau-tien",
                ShortDescription = "Ngày 18 tháng 01 năm 2016, lô máy móc thiết bị đầu tiên phục vụ cho “ Dự án khai thác và chế biến Graphite Yên Bái”...",
                Title = "Lô hàng thiết bị máy móc đầu tiên đã được nhập về",
                ShortcutImage = "/dist/images/may-nhap-small.jpg",
                CreatedDate = DateTime.Now.ToString("dd/MM/yyyy"),
                PublishDate = DateTime.Now.ToString("dd/MM/yyyy"),
                TextBlocks = new List<TextBlockModel>{
                    new TextBlockModel
                    {
                        Id = 1,
                        Content = "Ngày 18 tháng 01 năm 2016, lô máy móc thiết bị đầu tiên của dây chuyền công nghệ phục vụ cho “ Dự án khai thác và chế biến Graphite Yên Bái” đã được nhập về thành công.",
                        Position = 1
                    }
                },
                Images = new List<ImageModels> {
                    new ImageModels
                    {
                        TextBlockId = 1,
                        Position = 1,
                        ImgUrl = "/dist/images/detail-images/may-nhap-1.jpg",
                        ShortDescription = "Đây là đợt nhập máy đầu tiên cho Dự án khai thác và chế biến Graphite Yên Bái với hàm lượng Cacbon cao.”"
                    },
                    new ImageModels
                    {
                        TextBlockId = 1,
                        Position = 2,
                        ImgUrl = "/dist/images/detail-images/may-nhap-2.jpg",
                        ShortDescription = "Ngân hàng Agribank – CN Tây Hồ cùng Công ty TNHH Thương mại Ngọc Viễn Đông và nhân viên kỹ thuật đang kiểm tra lo máy vừa nhập về."
                    }
                }
            },
            new NewsModel{
                Id = 5,
                CategoryID = 2,
                Slug = "khai-xuan-binh-than",
                ShortDescription = "Công ty TNHH Thương mại Ngọc Viễn Đông long trọng tổ chức Khai xuân...",
                Title = "Khai xuân bính thân 2016",
                ShortcutImage = "/dist/images/khai-xuan-small.jpg",
                CreatedDate = DateTime.Now.ToString("dd/MM/yyyy"),
                PublishDate = DateTime.Now.ToString("dd/MM/yyyy"),
                TextBlocks = new List<TextBlockModel>{
                    new TextBlockModel
                    {
                        Id = 1,
                        Content = "Trong không khi rộn ràng của xuân mới, ngày 16 tháng 02 năm 2016 (Mùng 09/01/2016 Tết Bính Thân), Công ty TNHH Thương mại Ngọc Viễn Đông long trọng tổ chức Khai xuân. Mọi người họp mặt đông  đủ, chúc nhau lời chúc vui vẻ, bắt đầu một năm làm việc bình an và thành công.<br/> Tại trụ sở Công ty – Tầng 15, tòa nhà Việt Á, phố Duy Tân, quận Cầu Giấy, thành phố Hà Nội tràn ngập sắc đào tô thắm, cây quất trĩu quả cũng những bao lì xì, thiệp mừng năm mới chứa đựng những điều may mắn.<br/>Chủ tịch HĐTV Ông Nguyễn Đức Lượng đã khu rượu vang, tặng lì xì may mắn đầu năm và chúc toàn thể cán bộ công nhân viên cùng gia đình mạnh khỏe, hạnh phúc, hoàn thành xuất sắc kế hoạch nhiệm vụ năm 2016.",
                        Position = 1
                    }
                },
                Images = new List<ImageModels> {
                    new ImageModels
                    {
                        TextBlockId = 1,
                        Position = 1,
                        ImgUrl = "/dist/images/detail-images/khai-xuan-1.jpg",
                        ShortDescription = "Chủ tịch HĐTV Nguyễn Đức Lượng gửi lời chúc mừng đến CB-CNV Công ty"
                    },
                    new ImageModels
                    {
                        TextBlockId = 1,
                        Position = 2,
                        ImgUrl = "/dist/images/detail-images/khai-xuan-2.jpg",
                        ShortDescription = "Mọi người cùng nâng lý, chúc một năm mới nhiều may mắn và thành công"
                    },
                    new ImageModels
                    {
                        TextBlockId = 1,
                        Position = 3,
                        ImgUrl = "/dist/images/detail-images/khai-xuan-3.jpg",
                        ShortDescription = "Giám đốc Ngân hàng Agribank – Chi nhánh Tây Hồ đến chúc mừng Công ty"
                    }
                }
            },
            new NewsModel{
                Id = 6,
                CategoryID = 2,
                Slug = "lich-nghi-tet-2016",
                ShortDescription = "Công ty TNHH Thương mại Ngọc Viễn Đông thông báo lịch nghỉ tết nguyên đán năm 2016...",
                Title = "Thông báo lịch nghỉ tết nguyên đán năm 2016",
                ShortcutImage = "/dist/images/nghi-tet-small.jpg",
                CreatedDate = DateTime.Now.ToString("dd/MM/yyyy"),
                PublishDate = DateTime.Now.ToString("dd/MM/yyyy"),
                TextBlocks = new List<TextBlockModel>{
                    new TextBlockModel
                    {
                        Content = "<strong>Kính gửi: Quý khách hàng cùng Quý đối tác .</strong><br/>Lời đầu tiên, thay mặt Ban lãnh đạo Công ty và toàn thể Cán bộ công nhân viên Công ty TNHH Thương mại Ngọc Viễn Đông, chúng tôi trân trọng cám ơn Quý công ty đã tín nhiệm và ủng hộ Công ty trong suốt thời gian vừa qua.<br/>Ngọc Viễn Đông trân trọng thông báo đến Quý công ty lịch nghỉ Tết Nguyên Đán Bính Thân 2016 của Ngọc Viễn Đông như sau:<br/>- Nghỉ Tết bắt đầu ngày 06/02/2016 đến hết ngày 15/02/2016 (Tức ngày 28/12/2015 đến Mùng 08/01/2016 – Âm lịch).<br/>- Thời gian nghỉ Tết: 10 ngày.<br/>Nhân dịp năm mới, Ban lãnh đạo và toàn thể cán bộ công nhân viên Công ty TNHH Thương mại Ngọc Viễn Đông kính chúc Quý khách hàng, Quý đối tác cùng Gia đình một năm mới hạnh phúc – An khang – Thịnh vượng.",
                        Position = 1
                    }
                }
            }
        };
    }
}
