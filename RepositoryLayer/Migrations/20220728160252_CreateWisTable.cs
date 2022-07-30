using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class CreateWisTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BeehiveDemos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeadingBeehive = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentBeehive = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    imagesBeehive = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    titletemplate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_BeehiveDemosid", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BeehiveFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeadingFeatures = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentFeatures = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    iconFeatures = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    titleFeatures = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    slidesFeatures = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_BeehiveFeaturesid", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogrightsidebarCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeadingBlog = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconBlog = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    titleBlog = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_BlogrightsidebarCategoriesid", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogrightsidebarIntro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThumbnaiLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleBlogrightsidebarIntro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeadingBlog = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentBlog = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("BlogrightsidebarCategoriesid", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChatbotBlog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    headingBlog = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagesBlog = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentBlog = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleBlog = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileBlog = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailBlog = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ChatbotBlogId", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChatbotRelated",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeadingRelated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleRelated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagesgRelated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ChatbotRelatedId", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ComputervisonFormcontact",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeadingFormcontact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentFormcontact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InputFormcontact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ComputervisonFormcontactId", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_contactid", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConversationDemo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeadingConversation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagesConversation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Buttonstart = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ButtonDemo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ConversationDemoId", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConversationDoiTac",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleConversation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagesConversation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ButtonLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ConversationDoiTacId", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConversationIntro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContentConversation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoConversation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ButtonWatch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagesConversation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ConversationIntroId", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConversationPricing",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeadingPricing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitlePricing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ListPricing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PricePricing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ButtonPricing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ConversationPricingId", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DatasciencesDemo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContentData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ButtonStarted = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagesData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_DatasciencesDemoId", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DatasciencesExpertise",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeadingExpertise = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentExpertise = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleExpertise = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconExpertise = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ButtonExpertise = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_DatasciencesExpertiseId", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EkycAIBody",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContentEkyc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoEkyc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ButtonEkyc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ekycAIBodyId", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ListFooter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logo_ListFooter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title_ListFooter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ListFooterid", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ListMenu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    littleMenu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ListMenuid", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoginForm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_LoginFormid", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MobileBacked",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeadingBacked = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagesBacked = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentBacked = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TextBacked = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconBacked = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_MobileBackedid", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MobileDemo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LayerMobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeadingMobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentMobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DowloadMobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BulletMobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagesMobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_MobileDemoid", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MobileSubscribe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeadingSubscribe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InputSubscribe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ButtonSubscribe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconSubscribe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_MobileSubscribeid", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Navdrop",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    text = table.Column<int>(type: "int", nullable: false),
                    Id_nav = table.Column<int>(type: "int", nullable: false),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_navdropid", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OurapproachDemo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagesOurapproach = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlayOurapproach = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeadingOurapproach = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleOurapproach = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_OurapproachDemoid", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OurapproachIntro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeadingOurapproach = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DividerOurapproach = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconOurapproach = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleOurapproach = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_OurapproachIntroid", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OurapproachSolution",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeadingOurapproach = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentOurapproach = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagesOurapproach = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconOurapproach = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleOurapproach = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_OurapproachSolutionid", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoBertAIBody",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagesRoBertAI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleRoBertAI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentRoBertAI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconRoBertAI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_RoBertAIBodyid", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoBertAIIntro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagesRoBertAI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoRoBertAI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleRoBertAI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentRoBertAI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_RoBertAIIntroid", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoBertAIPricing",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeadingRoBertAI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PricesRoBertAI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pricetitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_RoBertAIPricingid", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoBertAIReviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IconRoBertAILAB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentRoBertAI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagesRoBertAI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeadingRoBertAI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_RoBertAIReviewsid", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SmartCiTyDigital",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeadingDigital = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentDigital = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleDigital = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconDigital = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkDigital = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagesDigital = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_SmartCiTyDigitalid", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SmartCiTyEmpower",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageEmpower = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeadingEmpower = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentEmpower = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_SmartCiTyEmpowerid", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SmartCiTySolution",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeadingSolution = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkSolution = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagesSolution = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleSolution = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentSolution = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_SmartCiTySolutionid", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpeechtotextDemo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContentDemo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagesDemo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    inputDemo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    labelDemo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_SpeechtotextDemoid", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpeechtotextIntro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContentIntro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoIntro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagesIntro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_SpeechtotextIntroid", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpeechtotextPricing",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeadingPricing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    titlePricing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentPricing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pricePricing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_SpeechtotextPricingid", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TexTSDemo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeadingDemo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagesDemo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    formtext = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    selectmenu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    playingDemo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_TexTSDemoid", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TexTSIntro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContentIntro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoIntro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagesIntro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_TexTSIntroid", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TexTSPricing",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeadingPricing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    titlePricing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentPricing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pricePricing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_TexTSPricingid", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Footer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logo_Footer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title_Footer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ListFooterId = table.Column<int>(type: "INT", nullable: true),
                    ContactId = table.Column<int>(type: "INT", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_Footerid", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Footer_Contact_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contact",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Footer_ListFooter_ListFooterId",
                        column: x => x.ListFooterId,
                        principalTable: "ListFooter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MenuGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mainMenu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Images_menuGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    listMenuId = table.Column<int>(type: "INT", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_MenuGroupid", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuGroup_ListMenu_listMenuId",
                        column: x => x.listMenuId,
                        principalTable: "ListMenu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Nav",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Contact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Page = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NavdropId = table.Column<int>(type: "INT", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_navid", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nav_Navdrop_NavdropId",
                        column: x => x.NavdropId,
                        principalTable: "Navdrop",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Footer_ContactId",
                table: "Footer",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Footer_ListFooterId",
                table: "Footer",
                column: "ListFooterId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuGroup_listMenuId",
                table: "MenuGroup",
                column: "listMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Nav_NavdropId",
                table: "Nav",
                column: "NavdropId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BeehiveDemos");

            migrationBuilder.DropTable(
                name: "BeehiveFeatures");

            migrationBuilder.DropTable(
                name: "BlogrightsidebarCategories");

            migrationBuilder.DropTable(
                name: "BlogrightsidebarIntro");

            migrationBuilder.DropTable(
                name: "ChatbotBlog");

            migrationBuilder.DropTable(
                name: "ChatbotRelated");

            migrationBuilder.DropTable(
                name: "ComputervisonFormcontact");

            migrationBuilder.DropTable(
                name: "ConversationDemo");

            migrationBuilder.DropTable(
                name: "ConversationDoiTac");

            migrationBuilder.DropTable(
                name: "ConversationIntro");

            migrationBuilder.DropTable(
                name: "ConversationPricing");

            migrationBuilder.DropTable(
                name: "DatasciencesDemo");

            migrationBuilder.DropTable(
                name: "DatasciencesExpertise");

            migrationBuilder.DropTable(
                name: "EkycAIBody");

            migrationBuilder.DropTable(
                name: "Footer");

            migrationBuilder.DropTable(
                name: "LoginForm");

            migrationBuilder.DropTable(
                name: "MenuGroup");

            migrationBuilder.DropTable(
                name: "MobileBacked");

            migrationBuilder.DropTable(
                name: "MobileDemo");

            migrationBuilder.DropTable(
                name: "MobileSubscribe");

            migrationBuilder.DropTable(
                name: "Nav");

            migrationBuilder.DropTable(
                name: "OurapproachDemo");

            migrationBuilder.DropTable(
                name: "OurapproachIntro");

            migrationBuilder.DropTable(
                name: "OurapproachSolution");

            migrationBuilder.DropTable(
                name: "RoBertAIBody");

            migrationBuilder.DropTable(
                name: "RoBertAIIntro");

            migrationBuilder.DropTable(
                name: "RoBertAIPricing");

            migrationBuilder.DropTable(
                name: "RoBertAIReviews");

            migrationBuilder.DropTable(
                name: "SmartCiTyDigital");

            migrationBuilder.DropTable(
                name: "SmartCiTyEmpower");

            migrationBuilder.DropTable(
                name: "SmartCiTySolution");

            migrationBuilder.DropTable(
                name: "SpeechtotextDemo");

            migrationBuilder.DropTable(
                name: "SpeechtotextIntro");

            migrationBuilder.DropTable(
                name: "SpeechtotextPricing");

            migrationBuilder.DropTable(
                name: "TexTSDemo");

            migrationBuilder.DropTable(
                name: "TexTSIntro");

            migrationBuilder.DropTable(
                name: "TexTSPricing");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "ListFooter");

            migrationBuilder.DropTable(
                name: "ListMenu");

            migrationBuilder.DropTable(
                name: "Navdrop");
        }
    }
}
