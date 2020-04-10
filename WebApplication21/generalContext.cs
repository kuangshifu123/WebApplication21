using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication21
{
    public partial class generalContext : DbContext
    {
        public generalContext()
        {
        }

        public generalContext(DbContextOptions<generalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CmcCategory> CmcCategory { get; set; }
        public virtual DbSet<CmcCategoryCoil> CmcCategoryCoil { get; set; }
        public virtual DbSet<EipBigTable> EipBigTable { get; set; }
        public virtual DbSet<EipCategory> EipCategory { get; set; }
        public virtual DbSet<EipCategoryCoil> EipCategoryCoil { get; set; }
        public virtual DbSet<EipCon> EipCon { get; set; }
        public virtual DbSet<EipConEng> EipConEng { get; set; }
        public virtual DbSet<EipConMatItem> EipConMatItem { get; set; }
        public virtual DbSet<EipConPurEngRlt> EipConPurEngRlt { get; set; }
        public virtual DbSet<EipEngPro> EipEngPro { get; set; }
        public virtual DbSet<EipEntity> EipEntity { get; set; }
        public virtual DbSet<EipIpoWoRel> EipIpoWoRel { get; set; }
        public virtual DbSet<EipMatCode> EipMatCode { get; set; }
        public virtual DbSet<EipMatInventory> EipMatInventory { get; set; }
        public virtual DbSet<EipMatInventorySup> EipMatInventorySup { get; set; }
        public virtual DbSet<EipMatMaxCat> EipMatMaxCat { get; set; }
        public virtual DbSet<EipMatMedCat> EipMatMedCat { get; set; }
        public virtual DbSet<EipMatMinCat> EipMatMinCat { get; set; }
        public virtual DbSet<EipPo> EipPo { get; set; }
        public virtual DbSet<EipPoItem> EipPoItem { get; set; }
        public virtual DbSet<EipProcessReport> EipProcessReport { get; set; }
        public virtual DbSet<EipProductionSchedule> EipProductionSchedule { get; set; }
        public virtual DbSet<EipSupplier> EipSupplier { get; set; }
        public virtual DbSet<EipSupplierIpo> EipSupplierIpo { get; set; }
        public virtual DbSet<EipSupplierPoSoRel> EipSupplierPoSoRel { get; set; }
        public virtual DbSet<EipSupplierSo> EipSupplierSo { get; set; }
        public virtual DbSet<EipSupplierSoLineitem> EipSupplierSoLineitem { get; set; }
        public virtual DbSet<EipSupplierWo> EipSupplierWo { get; set; }
        public virtual DbSet<EipSupplierWoPoRel> EipSupplierWoPoRel { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=192.168.0.74;user id=root;password=iot123;database=general", x => x.ServerVersion("5.6.35-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CmcCategory>(entity =>
            {
                entity.ToTable("cmc_category");

                entity.HasComment("品类表");

                entity.HasIndex(e => e.CategoryCode)
                    .HasName("cmc_category_CATEGORY_CODE_index");

                entity.HasIndex(e => e.Id)
                    .HasName("cmc_category_ID_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.IsDeleted)
                    .HasName("cmc_category_IS_DELETED_index");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20)")
                    .HasComment("主键");

                entity.Property(e => e.CategoryCode)
                    .IsRequired()
                    .HasColumnName("CATEGORY_CODE")
                    .HasColumnType("varchar(10)")
                    .HasComment("编号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasColumnName("CATEGORY_NAME")
                    .HasColumnType("varchar(10)")
                    .HasComment("品类名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("CREATE_TIME")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("创建时间")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasColumnName("CREATOR")
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasColumnName("IS_DELETED")
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("'0'")
                    .HasComment("逻辑删除（\"1\".是，\"0\".否）")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Modifier)
                    .IsRequired()
                    .HasColumnName("MODIFIER")
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModifyTime)
                    .HasColumnName("MODIFY_TIME")
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.Remark)
                    .HasColumnName("REMARK")
                    .HasColumnType("varchar(1000)")
                    .HasComment("备注")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CmcCategoryCoil>(entity =>
            {
                entity.ToTable("cmc_category_coil");

                entity.HasComment("种类表");

                entity.HasIndex(e => e.CategoryCoilCode)
                    .HasName("cmc_category_coil_CATEGORY_COIL_CODE_index");

                entity.HasIndex(e => e.Id)
                    .HasName("cmc_category_coil_ID_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.IsDeleted)
                    .HasName("cmc_category_coil_IS_DELETED_index");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20)")
                    .HasComment("主键");

                entity.Property(e => e.CategoryCode)
                    .HasColumnName("CATEGORY_CODE")
                    .HasColumnType("int(11)")
                    .HasComment("品类编号");

                entity.Property(e => e.CategoryCoilCode)
                    .IsRequired()
                    .HasColumnName("CATEGORY_COIL_CODE")
                    .HasColumnType("varchar(10)")
                    .HasComment("编号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CategoryCoilName)
                    .IsRequired()
                    .HasColumnName("CATEGORY_COIL_NAME")
                    .HasColumnType("varchar(50)")
                    .HasComment("小类名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("CREATE_TIME")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("创建时间")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasColumnName("CREATOR")
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasColumnName("IS_DELETED")
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("'0'")
                    .HasComment("逻辑删除（\"1\".是，\"0\".否）")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Modifier)
                    .IsRequired()
                    .HasColumnName("MODIFIER")
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModifyTime)
                    .HasColumnName("MODIFY_TIME")
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.Remark)
                    .HasColumnName("REMARK")
                    .HasColumnType("varchar(1000)")
                    .HasComment("备注")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<EipBigTable>(entity =>
            {
                entity.HasKey(e => e.EipBigId)
                    .HasName("PRIMARY");

                entity.ToTable("eip_big_table");

                entity.Property(e => e.EipBigId)
                    .HasColumnName("eip_big_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("主键id");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("int(11)")
                    .HasComment("采购数量");

                entity.Property(e => e.BidBatCode)
                    .HasColumnName("bid_bat_code")
                    .HasColumnType("varchar(64)")
                    .HasComment("招标批次号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ConCode)
                    .HasColumnName("con_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("合同标识符")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ConLawCode)
                    .HasColumnName("con_law_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("合同经法编号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ConName)
                    .HasColumnName("con_name")
                    .HasColumnType("varchar(200)")
                    .HasComment("合同名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ConType)
                    .HasColumnName("con_type")
                    .HasColumnType("int(11)")
                    .HasComment("合同类型");

                entity.Property(e => e.ExtDes)
                    .HasColumnName("ext_des")
                    .HasColumnType("varchar(256)")
                    .HasComment("固化ID描述")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FixedTechId)
                    .HasColumnName("fixed_techId")
                    .HasColumnType("varchar(48)")
                    .HasComment("采购技术固化ID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MatCode)
                    .HasColumnName("mat_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("物资编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MatMaxCode)
                    .HasColumnName("mat_max_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("物资大类编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MatMaxName)
                    .HasColumnName("mat_max_name")
                    .HasColumnType("varchar(128)")
                    .HasComment("物资大类名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MatMedCode)
                    .HasColumnName("mat_med_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("物资中类编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MatMedName)
                    .HasColumnName("mat_med_name")
                    .HasColumnType("varchar(128)")
                    .HasComment("物资中类名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MatMinCode)
                    .HasColumnName("mat_min_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("物资小类编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MatMinName)
                    .HasColumnName("mat_min_name")
                    .HasColumnType("varchar(128)")
                    .HasComment("物资小类名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MaterialCode)
                    .HasColumnName("material_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("采购方物料编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MaterialDesc)
                    .HasColumnName("material_desc")
                    .HasColumnType("varchar(1000)")
                    .HasComment("采购方物料描述")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModifyTime)
                    .HasColumnName("modify_time")
                    .HasColumnType("date")
                    .HasComment("更新时间");

                entity.Property(e => e.PkgNo)
                    .HasColumnName("pkg_no")
                    .HasColumnType("varchar(64)")
                    .HasComment("合同包号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PoItemId)
                    .HasColumnName("po_item_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("采购订单行项目id");

                entity.Property(e => e.PoItemNo)
                    .HasColumnName("po_item_no")
                    .HasColumnType("varchar(48)")
                    .HasComment("采购订单行项目编号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PoNo)
                    .HasColumnName("po_no")
                    .HasColumnType("varchar(48)")
                    .HasComment("采购订单编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PrjCode)
                    .HasColumnName("prj_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("项目编号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PrjName)
                    .HasColumnName("prj_name")
                    .HasColumnType("varchar(100)")
                    .HasComment("工程项目名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PurchaseName)
                    .HasColumnName("purchase_name")
                    .HasColumnType("varchar(2000)")
                    .HasComment("采购方公司名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PurchaserHqCode)
                    .HasColumnName("purchaser_hq_code")
                    .HasColumnType("varchar(12)")
                    .HasComment("采购方总部编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SellerSignTime)
                    .HasColumnName("seller_sign_time")
                    .HasColumnType("date")
                    .HasComment("卖方签订日期");

                entity.Property(e => e.SerialNumber)
                    .HasColumnName("serial_number")
                    .HasColumnType("varchar(100)")
                    .HasComment("技术规范流水号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SupplierCode)
                    .HasColumnName("supplier_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("供应商编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SupplierName)
                    .HasColumnName("supplier_name")
                    .HasColumnType("varchar(100)")
                    .HasComment("供应商名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<EipCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PRIMARY");

                entity.ToTable("eip_category");

                entity.HasComment("品类信息");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("主键id");

                entity.Property(e => e.CategoryCode)
                    .HasColumnName("category_code")
                    .HasColumnType("varchar(10)")
                    .HasComment("品类编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CategoryName)
                    .HasColumnName("category_name")
                    .HasColumnType("varchar(10)")
                    .HasComment("品类名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("创建时间");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasColumnName("creator")
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSource)
                    .HasColumnName("data_source")
                    .HasColumnType("varchar(60)")
                    .HasComment("数据来源")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSourceCreatetime)
                    .HasColumnName("data_source_createtime")
                    .HasColumnType("datetime")
                    .HasComment("来源数据创建时间");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasColumnType("tinyint(19)")
                    .HasDefaultValueSql("'0'")
                    .HasComment("逻辑删除 1.是，0.否");

                entity.Property(e => e.Modifier)
                    .HasColumnName("modifier")
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModifyTime)
                    .HasColumnName("modify_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("修改时间")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.OpenId)
                    .HasColumnName("open_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据查看者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OwnerId)
                    .HasColumnName("owner_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据所有者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("varchar(1000)")
                    .HasComment("备注")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<EipCategoryCoil>(entity =>
            {
                entity.HasKey(e => e.CategoryCoilId)
                    .HasName("PRIMARY");

                entity.ToTable("eip_category_coil");

                entity.HasComment("种类信息");

                entity.Property(e => e.CategoryCoilId)
                    .HasColumnName("category_coil_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("主键id");

                entity.Property(e => e.CategoryCoilCode)
                    .HasColumnName("category_coil_code")
                    .HasColumnType("varchar(10)")
                    .HasComment("种类编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CategoryCoilName)
                    .HasColumnName("category_coil_name")
                    .HasColumnType("varchar(10)")
                    .HasComment("种类名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("品类id");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("创建时间");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasColumnName("creator")
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSource)
                    .HasColumnName("data_source")
                    .HasColumnType("varchar(60)")
                    .HasComment("数据来源")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSourceCreatetime)
                    .HasColumnName("data_source_createtime")
                    .HasColumnType("datetime")
                    .HasComment("来源数据创建时间");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasColumnType("tinyint(19)")
                    .HasDefaultValueSql("'0'")
                    .HasComment("逻辑删除 1.是，0.否");

                entity.Property(e => e.Modifier)
                    .HasColumnName("modifier")
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModifyTime)
                    .HasColumnName("modify_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("修改时间")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.OpenId)
                    .HasColumnName("open_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据查看者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OwnerId)
                    .HasColumnName("owner_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据所有者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("varchar(1000)")
                    .HasComment("备注")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<EipCon>(entity =>
            {
                entity.HasKey(e => e.ConId)
                    .HasName("PRIMARY");

                entity.ToTable("eip_con");

                entity.HasComment("合同");

                entity.Property(e => e.ConId)
                    .HasColumnName("con_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("主键id");

                entity.Property(e => e.BuyerId)
                    .HasColumnName("buyer_id")
                    .HasColumnType("varchar(48)")
                    .HasComment("买方组织机构id")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BuyerName)
                    .HasColumnName("buyer_name")
                    .HasColumnType("varchar(100)")
                    .HasComment("买方名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BuyerSignTime)
                    .HasColumnName("buyer_sign_time")
                    .HasColumnType("date")
                    .HasComment("买方签订日期");

                entity.Property(e => e.CancelFlag)
                    .HasColumnName("cancel_flag")
                    .HasColumnType("int(11)")
                    .HasComment("解除标识");

                entity.Property(e => e.ConCode)
                    .HasColumnName("con_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("合同标识符")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ConDlvErp)
                    .HasColumnName("con_dlv_erp")
                    .HasColumnType("int(11)")
                    .HasComment("合同下发的ERP");

                entity.Property(e => e.ConLawCode)
                    .HasColumnName("con_law_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("合同经法编号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ConName)
                    .HasColumnName("con_name")
                    .HasColumnType("varchar(200)")
                    .HasComment("合同名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ConStatus)
                    .HasColumnName("con_status")
                    .HasColumnType("int(11)")
                    .HasComment("合同状态");

                entity.Property(e => e.ConTransTime)
                    .HasColumnName("con_trans_time")
                    .HasColumnType("date")
                    .HasComment("合同流转日期");

                entity.Property(e => e.ConType)
                    .HasColumnName("con_type")
                    .HasColumnType("int(11)")
                    .HasComment("合同类型");

                entity.Property(e => e.ConValidTime)
                    .HasColumnName("con_valid_time")
                    .HasColumnType("date")
                    .HasComment("合同生效日期");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("创建时间");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasColumnName("creator")
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSource)
                    .HasColumnName("data_source")
                    .HasColumnType("varchar(48)")
                    .HasComment("数据来源")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSourceCreatetime)
                    .HasColumnName("data_source_createtime")
                    .HasColumnType("datetime")
                    .HasComment("来源数据创建时间");

                entity.Property(e => e.DelayEndTime)
                    .HasColumnName("delay_end_time")
                    .HasColumnType("date")
                    .HasComment("延期截止日期");

                entity.Property(e => e.DelayFlag)
                    .HasColumnName("delay_flag")
                    .HasColumnType("int(11)")
                    .HasComment("是否延期");

                entity.Property(e => e.DemandOrgName)
                    .HasColumnName("demand_org_name")
                    .HasColumnType("varchar(200)")
                    .HasComment("需求单位名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ESignStatus)
                    .HasColumnName("e_sign_status")
                    .HasColumnType("int(11)")
                    .HasComment("合同电子签章状态");

                entity.Property(e => e.EngCode)
                    .HasColumnName("eng_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("工程编号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EngName)
                    .HasColumnName("eng_name")
                    .HasColumnType("varchar(100)")
                    .HasComment("工程名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ErpAgreementCode)
                    .HasColumnName("erp_agreement_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("ERP协议库存号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FrzFlag)
                    .HasColumnName("frz_flag")
                    .HasColumnType("int(11)")
                    .HasComment("是否冻结");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasDefaultValueSql("'0'")
                    .HasComment("逻辑删除 1.是，0.否");

                entity.Property(e => e.Modifier)
                    .HasColumnName("modifier")
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModifyTime)
                    .HasColumnName("modify_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("修改时间")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.OpenId)
                    .HasColumnName("open_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据查看者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OwnerId)
                    .HasColumnName("owner_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据所有者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PrjCode)
                    .HasColumnName("prj_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("项目编号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PrjName)
                    .HasColumnName("prj_name")
                    .HasColumnType("varchar(100)")
                    .HasComment("项目名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PurchaseId)
                    .HasColumnName("purchase_id")
                    .HasColumnType("varchar(48)")
                    .HasComment("采购方组织机构id")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PurchaseName)
                    .HasColumnName("purchase_name")
                    .HasColumnType("varchar(100)")
                    .HasComment("采购方名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("varchar(1000)")
                    .HasComment("备注")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SellerConCode)
                    .HasColumnName("seller_con_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("卖方合同编号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SellerSignTime)
                    .HasColumnName("seller_sign_time")
                    .HasColumnType("date")
                    .HasComment("卖方签订日期");

                entity.Property(e => e.SerialNumber)
                    .HasColumnName("serial_number")
                    .HasColumnType("varchar(100)")
                    .HasComment("技术规范流水号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SuppOrgId)
                    .HasColumnName("supp_org_id")
                    .HasColumnType("varchar(48)")
                    .HasComment("供应商组织机构ID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SupplierCode)
                    .HasColumnName("supplier_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("供应商编码（冗余）")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SupplierName)
                    .HasColumnName("supplier_name")
                    .HasColumnType("varchar(100)")
                    .HasComment("供应名称（冗余）")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TaxAmt)
                    .HasColumnName("tax_amt")
                    .HasColumnType("decimal(20,2)")
                    .HasComment("含税金额");

                entity.Property(e => e.ValidCond)
                    .HasColumnName("valid_cond")
                    .HasColumnType("varchar(200)")
                    .HasComment("生效条件")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Warr)
                    .HasColumnName("warr")
                    .HasColumnType("int(11)")
                    .HasComment("质保期");
            });

            modelBuilder.Entity<EipConEng>(entity =>
            {
                entity.HasKey(e => e.ConEngId)
                    .HasName("PRIMARY");

                entity.ToTable("eip_con_eng");

                entity.HasComment("合同工程");

                entity.Property(e => e.ConEngId)
                    .HasColumnName("con_eng_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("主键id");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("创建时间");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasColumnName("creator")
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSource)
                    .HasColumnName("data_source")
                    .HasColumnType("varchar(60)")
                    .HasComment("数据来源")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSourceCreatetime)
                    .HasColumnName("data_source_createtime")
                    .HasColumnType("datetime")
                    .HasComment("来源数据创建时间");

                entity.Property(e => e.EngCode)
                    .HasColumnName("eng_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("工程编号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EngName)
                    .HasColumnName("eng_name")
                    .HasColumnType("varchar(200)")
                    .HasComment("工程名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasDefaultValueSql("'0'")
                    .HasComment("逻辑删除 1.是，0.否");

                entity.Property(e => e.Modifier)
                    .HasColumnName("modifier")
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModifyTime)
                    .HasColumnName("modify_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("修改时间")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.OpenId)
                    .HasColumnName("open_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据查看者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OwnerId)
                    .HasColumnName("owner_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据所有者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("varchar(1000)")
                    .HasComment("备注")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<EipConMatItem>(entity =>
            {
                entity.HasKey(e => e.ConMatItemId)
                    .HasName("PRIMARY");

                entity.ToTable("eip_con_mat_item");

                entity.HasComment("合同物料项");

                entity.Property(e => e.ConMatItemId)
                    .HasColumnName("con_mat_item_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("主键id");

                entity.Property(e => e.CfmDlvTime)
                    .HasColumnName("cfm_dlv_time")
                    .HasColumnType("date")
                    .HasComment("确定交货期");

                entity.Property(e => e.ConDlvTime)
                    .HasColumnName("con_dlv_time")
                    .HasColumnType("date")
                    .HasComment("合同交货期");

                entity.Property(e => e.ConId)
                    .HasColumnName("con_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("合同ID");

                entity.Property(e => e.ConItemCode)
                    .HasColumnName("con_item_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("合同行编号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("创建时间");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasColumnName("creator")
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSource)
                    .HasColumnName("data_source")
                    .HasColumnType("varchar(60)")
                    .HasComment("数据来源")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSourceCreatetime)
                    .HasColumnName("data_source_createtime")
                    .HasColumnType("datetime")
                    .HasComment("来源数据创建时间");

                entity.Property(e => e.DemandOrgCode)
                    .HasColumnName("demand_org_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("需求单位编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DemandOrgName)
                    .HasColumnName("demand_org_name")
                    .HasColumnType("varchar(200)")
                    .HasComment("需求单位名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DepositMat)
                    .HasColumnName("deposit_mat")
                    .HasColumnType("int(11)")
                    .HasComment("是否为寄存物资");

                entity.Property(e => e.DlvAddr)
                    .HasColumnName("dlv_addr")
                    .HasColumnType("varchar(200)")
                    .HasComment("交货地点")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DlvTime)
                    .HasColumnName("dlv_time")
                    .HasColumnType("date")
                    .HasComment("交货时间");

                entity.Property(e => e.EngName)
                    .HasColumnName("eng_name")
                    .HasColumnType("varchar(200)")
                    .HasComment("工程项目名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EngPrjId)
                    .HasColumnName("eng_prj_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("工程项目ID");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasDefaultValueSql("'0'")
                    .HasComment("逻辑删除 1.是，0.否");

                entity.Property(e => e.MatCat)
                    .HasColumnName("mat_cat")
                    .HasColumnType("varchar(100)")
                    .HasComment("物资分类")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MatCode)
                    .HasColumnName("mat_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("物料编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MatCodeId)
                    .HasColumnName("mat_code_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("物料编码ID");

                entity.Property(e => e.MatDes)
                    .HasColumnName("mat_des")
                    .HasColumnType("varchar(255)")
                    .HasComment("物料描述")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MatMaxCode)
                    .HasColumnName("mat_max_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("物资大类编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MatMaxName)
                    .HasColumnName("mat_max_name")
                    .HasColumnType("varchar(100)")
                    .HasComment("物资大类名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MatMedCode)
                    .HasColumnName("mat_med_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("物资中类编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MatMedName)
                    .HasColumnName("mat_med_name")
                    .HasColumnType("varchar(100)")
                    .HasComment("物资中类名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MatMinCode)
                    .HasColumnName("mat_min_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("物资小类编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MatMinName)
                    .HasColumnName("mat_min_name")
                    .HasColumnType("varchar(100)")
                    .HasComment("物资小类名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MatName)
                    .HasColumnName("mat_name")
                    .HasColumnType("varchar(48)")
                    .HasComment("物料名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MeasUnitType)
                    .HasColumnName("meas_unit_type")
                    .HasColumnType("varchar(10)")
                    .HasComment("计量单位")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Modifier)
                    .HasColumnName("modifier")
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModifyTime)
                    .HasColumnName("modify_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("修改时间")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.OpenId)
                    .HasColumnName("open_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据查看者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OwnerId)
                    .HasColumnName("owner_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据所有者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PoId)
                    .HasColumnName("po_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("采购订单id（冗余）");

                entity.Property(e => e.PoItemId)
                    .HasColumnName("po_item_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("采购订单行项目id");

                entity.Property(e => e.PoNo)
                    .HasColumnName("po_no")
                    .HasColumnType("varchar(48)")
                    .HasComment("采购订单行项目号（冗余）")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PrjCode)
                    .HasColumnName("prj_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("项目编号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PrjName)
                    .HasColumnName("prj_name")
                    .HasColumnType("varchar(50)")
                    .HasComment("项目名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PurchaseNo)
                    .HasColumnName("purchase_no")
                    .HasColumnType("varchar(48)")
                    .HasComment("采购订单号（冗余）")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Qty)
                    .HasColumnName("qty")
                    .HasColumnType("int(11)")
                    .HasComment("数量");

                entity.Property(e => e.RealDlvTime)
                    .HasColumnName("real_dlv_time")
                    .HasColumnType("date")
                    .HasComment("实际交货期");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("varchar(1000)")
                    .HasComment("备注")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TaxRate)
                    .HasColumnName("tax_rate")
                    .HasColumnType("varchar(20)")
                    .HasComment("税率")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TaxTotPrice)
                    .HasColumnName("tax_tot_price")
                    .HasColumnType("decimal(20,2)")
                    .HasComment("含税总价");

                entity.Property(e => e.TaxUnitPrice)
                    .HasColumnName("tax_unit_price")
                    .HasColumnType("decimal(20,2)")
                    .HasComment("含税单价");

                entity.Property(e => e.UntaxTotPrice)
                    .HasColumnName("untax_tot_price")
                    .HasColumnType("decimal(20,2)")
                    .HasComment("不含税总价");

                entity.Property(e => e.UntaxUnitPrice)
                    .HasColumnName("untax_unit_price")
                    .HasColumnType("decimal(20,2)")
                    .HasComment("不含税单价");
            });

            modelBuilder.Entity<EipConPurEngRlt>(entity =>
            {
                entity.HasKey(e => e.ConPurEngRltId)
                    .HasName("PRIMARY");

                entity.ToTable("eip_con_pur_eng_rlt");

                entity.HasComment("合同采购工程关系");

                entity.Property(e => e.ConPurEngRltId)
                    .HasColumnName("con_pur_eng_rlt_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("主键id");

                entity.Property(e => e.ConEngId)
                    .HasColumnName("con_eng_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("合同工程ID");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("创建人创建时间");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasColumnName("creator")
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSource)
                    .HasColumnName("data_source")
                    .HasColumnType("varchar(60)")
                    .HasComment("数据来源")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSourceCreatetime)
                    .HasColumnName("data_source_createtime")
                    .HasColumnType("datetime")
                    .HasComment("来源数据创建时间");

                entity.Property(e => e.EngPrjId)
                    .HasColumnName("eng_prj_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("工程项目ID");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasDefaultValueSql("'0'")
                    .HasComment("逻辑删除 1.是，0.否");

                entity.Property(e => e.Modifier)
                    .HasColumnName("modifier")
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModifyTime)
                    .HasColumnName("modify_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("修改时间")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.OpenId)
                    .HasColumnName("open_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据查看者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OwnerId)
                    .HasColumnName("owner_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据所有者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("varchar(1000)")
                    .HasComment("备注")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<EipEngPro>(entity =>
            {
                entity.HasKey(e => e.EngPrjId)
                    .HasName("PRIMARY");

                entity.ToTable("eip_eng_pro");

                entity.HasComment("工程项目");

                entity.Property(e => e.EngPrjId)
                    .HasColumnName("eng_prj_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("主键ID");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("创建时间");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasColumnName("creator")
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSource)
                    .HasColumnName("data_source")
                    .HasColumnType("varchar(60)")
                    .HasComment("数据来源")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSourceCreatetime)
                    .HasColumnName("data_source_createtime")
                    .HasColumnType("datetime")
                    .HasComment("来源数据创建时间");

                entity.Property(e => e.EngNote)
                    .HasColumnName("eng_note")
                    .HasColumnType("varchar(1000)")
                    .HasComment("工程描述")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EngPrjLev)
                    .HasColumnName("eng_prj_lev")
                    .HasColumnType("int(11)")
                    .HasComment("工程项目级别");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasDefaultValueSql("'0'")
                    .HasComment("逻辑删除 1.是，0.否");

                entity.Property(e => e.Modifier)
                    .HasColumnName("modifier")
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModifyTime)
                    .HasColumnName("modify_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("修改时间")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.OpenId)
                    .HasColumnName("open_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据查看者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OwnerId)
                    .HasColumnName("owner_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据所有者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ParEngPrjId)
                    .HasColumnName("par_eng_prj_id")
                    .HasColumnType("int(11)")
                    .HasComment("父工程ID");

                entity.Property(e => e.PrjBeginTime)
                    .HasColumnName("prj_begin_time")
                    .HasColumnType("date")
                    .HasComment("开工时间");

                entity.Property(e => e.PrjCode)
                    .HasColumnName("prj_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("工程项目编号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PrjEndTime)
                    .HasColumnName("prj_end_time")
                    .HasColumnType("date")
                    .HasComment("完工时间");

                entity.Property(e => e.PrjName)
                    .HasColumnName("prj_name")
                    .HasColumnType("varchar(200)")
                    .HasComment("工程项目名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("varchar(1000)")
                    .HasComment("备注")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VolVal)
                    .HasColumnName("vol_val")
                    .HasColumnType("varchar(48)")
                    .HasComment("电压等级")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<EipEntity>(entity =>
            {
                entity.ToTable("eip_entity");

                entity.HasComment("实物id信息");

                entity.Property(e => e.EipEntityId)
                    .HasColumnName("eip_entity_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("主键id");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("创建时间");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasColumnName("creator")
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSource)
                    .HasColumnName("data_source")
                    .HasColumnType("varchar(60)")
                    .HasComment("数据来源")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSourceCreatetime)
                    .HasColumnName("data_source_createtime")
                    .HasColumnType("timestamp")
                    .HasComment("来源数据创建时间");

                entity.Property(e => e.EntityCode)
                    .HasColumnName("entity_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("实物序号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasColumnType("tinyint(19)")
                    .HasDefaultValueSql("'0'")
                    .HasComment("逻辑删除 1.是，0.否");

                entity.Property(e => e.Modifier)
                    .HasColumnName("modifier")
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModifyTime)
                    .HasColumnName("modify_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("修改时间")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.OpenId)
                    .HasColumnName("open_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据查看者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OwnerId)
                    .HasColumnName("owner_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据所有者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PoItemId)
                    .HasColumnName("po_item_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("采购订单行项目id");

                entity.Property(e => e.PurchaserHqCode)
                    .HasColumnName("purchaser_hq_code")
                    .HasColumnType("varchar(20)")
                    .HasComment("采购方总部编码，国家电网：sgcc")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("varchar(1000)")
                    .HasComment("备注")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SupplierCode)
                    .HasColumnName("supplier_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("供应商编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SupplierName)
                    .HasColumnName("supplier_name")
                    .HasColumnType("varchar(50)")
                    .HasComment("供应商名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<EipIpoWoRel>(entity =>
            {
                entity.HasKey(e => e.IpoWoRelId)
                    .HasName("PRIMARY");

                entity.ToTable("eip_ipo_wo_rel");

                entity.HasComment("生产订单与生产工单关联关系");

                entity.Property(e => e.IpoWoRelId)
                    .HasColumnName("ipo_wo_rel_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("主键id");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("创建时间");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasColumnName("creator")
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSource)
                    .HasColumnName("data_source")
                    .HasColumnType("varchar(60)")
                    .HasComment("数据来源")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSourceCreatetime)
                    .HasColumnName("data_source_createtime")
                    .HasColumnType("datetime")
                    .HasComment("来源数据创建时间");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasColumnType("tinyint(19)")
                    .HasDefaultValueSql("'0'")
                    .HasComment("逻辑删除 1.是，0.否");

                entity.Property(e => e.Modifier)
                    .HasColumnName("modifier")
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModifyTime)
                    .HasColumnName("modify_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("修改时间")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.OpenId)
                    .HasColumnName("open_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据查看者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OwnerId)
                    .HasColumnName("owner_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据所有者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("varchar(1000)")
                    .HasComment("备注")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SupplierIpoId)
                    .HasColumnName("supplier_ipo_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("生产订单id");

                entity.Property(e => e.SupplierWoId)
                    .HasColumnName("supplier_wo_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("生产工单id");
            });

            modelBuilder.Entity<EipMatCode>(entity =>
            {
                entity.HasKey(e => e.MatCodeId)
                    .HasName("PRIMARY");

                entity.ToTable("eip_mat_code");

                entity.HasComment("物料编码 ");

                entity.Property(e => e.MatCodeId)
                    .HasColumnName("mat_code_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("主键id");

                entity.Property(e => e.CategoryCoilId)
                    .HasColumnName("category_coil_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("种类id");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("创建时间");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasColumnName("creator")
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSource)
                    .HasColumnName("data_source")
                    .HasColumnType("varchar(60)")
                    .HasComment("数据来源")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSourceCreatetime)
                    .HasColumnName("data_source_createtime")
                    .HasColumnType("datetime")
                    .HasComment("来源数据创建时间");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasColumnType("tinyint(19)")
                    .HasDefaultValueSql("'0'")
                    .HasComment("逻辑删除 1.是，0.否");

                entity.Property(e => e.MatCode)
                    .HasColumnName("mat_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("物料编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MatCodeDetDes)
                    .HasColumnName("mat_code_det_des")
                    .HasColumnType("varchar(2000)")
                    .HasComment("物料长描述")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MatDes)
                    .HasColumnName("mat_des")
                    .HasColumnType("varchar(1000)")
                    .HasComment("物料描述")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MatMinCatId)
                    .HasColumnName("mat_min_cat_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("物资小类id");

                entity.Property(e => e.MatStatus)
                    .HasColumnName("mat_status")
                    .HasColumnType("int(11)")
                    .HasComment("物料编码状态");

                entity.Property(e => e.Modifier)
                    .HasColumnName("modifier")
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModifyTime)
                    .HasColumnName("modify_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("修改时间")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.OpenId)
                    .HasColumnName("open_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据查看者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OwnerId)
                    .HasColumnName("owner_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据所有者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("varchar(1000)")
                    .HasComment("备注")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<EipMatInventory>(entity =>
            {
                entity.HasKey(e => e.MatInventoryId)
                    .HasName("PRIMARY");

                entity.ToTable("eip_mat_inventory");

                entity.HasComment("供应商重点原材料库存");

                entity.Property(e => e.MatInventoryId)
                    .HasColumnName("mat_inventory_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("主键id");

                entity.Property(e => e.CategoryCode)
                    .HasColumnName("category_code")
                    .HasColumnType("varchar(10)")
                    .HasComment("品类")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("创建时间");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasColumnName("creator")
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSource)
                    .HasColumnName("data_source")
                    .HasColumnType("varchar(60)")
                    .HasComment("数据来源")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSourceCreatetime)
                    .HasColumnName("data_source_createtime")
                    .HasColumnType("datetime")
                    .HasComment("来源数据创建时间");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasComment("逻辑删除 1.是，0.否");

                entity.Property(e => e.MatCode)
                    .HasColumnName("mat_code")
                    .HasColumnType("varchar(100)")
                    .HasComment("原材料编号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MatName)
                    .HasColumnName("mat_name")
                    .HasColumnType("varchar(100)")
                    .HasComment("原材料名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MatNum)
                    .HasColumnName("mat_num")
                    .HasComment("原材料库存数量");

                entity.Property(e => e.MatUnit)
                    .HasColumnName("mat_unit")
                    .HasColumnType("varchar(10)")
                    .HasComment("计量单位")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Modifier)
                    .HasColumnName("modifier")
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModifyTime)
                    .HasColumnName("modify_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("修改时间")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.OpenId)
                    .HasColumnName("open_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据查看者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OwnerId)
                    .HasColumnName("owner_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据所有者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PoItemId)
                    .HasColumnName("po_item_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("采购订单行项目id");

                entity.Property(e => e.PurchaserHqCode)
                    .HasColumnName("purchaser_hq_code")
                    .HasColumnType("varchar(20)")
                    .HasComment("采购方总部编码，国家电网：sgcc")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PurchasingAmount)
                    .HasColumnName("purchasing_amount")
                    .HasComment("下次采购数量");

                entity.Property(e => e.PurchasingPeriod)
                    .HasColumnName("purchasing_period")
                    .HasColumnType("datetime")
                    .HasComment("下次采购时间");

                entity.Property(e => e.QuantityRequired)
                    .HasColumnName("quantity_required")
                    .HasComment("国网侧需求数量");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("varchar(1000)")
                    .HasComment("备注")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SubclassCode)
                    .HasColumnName("subclass_code")
                    .HasColumnType("varchar(10)")
                    .HasComment("种类")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SupplierCode)
                    .HasColumnName("supplier_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("供应商编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SupplierName)
                    .HasColumnName("supplier_name")
                    .HasColumnType("varchar(50)")
                    .HasComment("供应商名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<EipMatInventorySup>(entity =>
            {
                entity.HasKey(e => e.MatInventorySupId)
                    .HasName("PRIMARY");

                entity.ToTable("eip_mat_inventory_sup");

                entity.HasComment("供应商重点原材料库存");

                entity.Property(e => e.MatInventorySupId)
                    .HasColumnName("mat_inventory_sup_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("主键id");

                entity.Property(e => e.ArrivalTime)
                    .HasColumnName("arrival_time")
                    .HasColumnType("datetime")
                    .HasComment("到货时间");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("创建时间");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasColumnName("creator")
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSource)
                    .HasColumnName("data_source")
                    .HasColumnType("varchar(60)")
                    .HasComment("数据来源")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSourceCreatetime)
                    .HasColumnName("data_source_createtime")
                    .HasColumnType("datetime")
                    .HasComment("来源数据创建时间");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasComment("逻辑删除 1.是，0.否");

                entity.Property(e => e.MatInventoryId)
                    .HasColumnName("mat_inventory_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("供应商重点原材料库存id");

                entity.Property(e => e.MatSupplier)
                    .HasColumnName("mat_supplier")
                    .HasColumnType("varchar(48)")
                    .HasComment("原材料供应商")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Modifier)
                    .HasColumnName("modifier")
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModifyTime)
                    .HasColumnName("modify_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("修改时间")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.OpenId)
                    .HasColumnName("open_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据查看者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OwnerId)
                    .HasColumnName("owner_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据所有者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PurchasingAmount)
                    .HasColumnName("purchasing_amount")
                    .HasComment("采购数量");

                entity.Property(e => e.PurchasingPeriod)
                    .HasColumnName("purchasing_period")
                    .HasColumnType("datetime")
                    .HasComment("采购时间");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("varchar(1000)")
                    .HasComment("备注")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<EipMatMaxCat>(entity =>
            {
                entity.HasKey(e => e.MatMaxId)
                    .HasName("PRIMARY");

                entity.ToTable("eip_mat_max_cat");

                entity.HasComment("物资大类 ");

                entity.Property(e => e.MatMaxId)
                    .HasColumnName("mat_max_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("主键id");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("创建时间");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasColumnName("creator")
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSource)
                    .HasColumnName("data_source")
                    .HasColumnType("varchar(60)")
                    .HasComment("数据来源")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSourceCreatetime)
                    .HasColumnName("data_source_createtime")
                    .HasColumnType("datetime")
                    .HasComment("来源数据创建时间");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasColumnType("tinyint(19)")
                    .HasDefaultValueSql("'0'")
                    .HasComment("逻辑删除 1.是，0.否");

                entity.Property(e => e.MatCatCode)
                    .HasColumnName("mat_cat_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("物资分类编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MaxCatCode)
                    .HasColumnName("max_cat_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("物资大类编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MaxCatName)
                    .HasColumnName("max_cat_name")
                    .HasColumnType("varchar(100)")
                    .HasComment("物资大类名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Modifier)
                    .HasColumnName("modifier")
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModifyTime)
                    .HasColumnName("modify_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("修改时间")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.OpenId)
                    .HasColumnName("open_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据查看者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OwnerId)
                    .HasColumnName("owner_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据所有者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("varchar(1000)")
                    .HasComment("备注")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<EipMatMedCat>(entity =>
            {
                entity.HasKey(e => e.MatMedCatId)
                    .HasName("PRIMARY");

                entity.ToTable("eip_mat_med_cat");

                entity.HasComment("物资中类");

                entity.Property(e => e.MatMedCatId)
                    .HasColumnName("mat_med_cat_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("主键id");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("创建时间");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasColumnName("creator")
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSource)
                    .HasColumnName("data_source")
                    .HasColumnType("varchar(60)")
                    .HasComment("数据来源")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSourceCreatetime)
                    .HasColumnName("data_source_createtime")
                    .HasColumnType("datetime")
                    .HasComment("来源数据创建时间");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasDefaultValueSql("'0'")
                    .HasComment("逻辑删除 1.是，0.否");

                entity.Property(e => e.MatMaxId)
                    .HasColumnName("mat_max_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("物资大类ID");

                entity.Property(e => e.MedCatCode)
                    .HasColumnName("med_cat_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("物资中类编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MedCatName)
                    .HasColumnName("med_cat_name")
                    .HasColumnType("varchar(100)")
                    .HasComment("物资中类名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Modifier)
                    .HasColumnName("modifier")
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModifyTime)
                    .HasColumnName("modify_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("修改时间")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.OpenId)
                    .HasColumnName("open_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据查看者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OwnerId)
                    .HasColumnName("owner_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据所有者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("varchar(1000)")
                    .HasComment("备注")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<EipMatMinCat>(entity =>
            {
                entity.HasKey(e => e.MatMinCatId)
                    .HasName("PRIMARY");

                entity.ToTable("eip_mat_min_cat");

                entity.HasComment("物资小类");

                entity.Property(e => e.MatMinCatId)
                    .HasColumnName("mat_min_cat_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("主键id");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("创建时间");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasColumnName("creator")
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSource)
                    .HasColumnName("data_source")
                    .HasColumnType("varchar(60)")
                    .HasComment("数据来源")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSourceCreatetime)
                    .HasColumnName("data_source_createtime")
                    .HasColumnType("datetime")
                    .HasComment("来源数据创建时间");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasDefaultValueSql("'0'")
                    .HasComment("逻辑删除 1.是，0.否");

                entity.Property(e => e.MatMedCatId)
                    .HasColumnName("mat_med_cat_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("物资中类ID");

                entity.Property(e => e.MatMinCatStatus)
                    .HasColumnName("mat_min_cat_status")
                    .HasColumnType("int(11)")
                    .HasComment("物资小类状态");

                entity.Property(e => e.MinCatCode)
                    .HasColumnName("min_cat_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("物资小类编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MinCatName)
                    .HasColumnName("min_cat_name")
                    .HasColumnType("varchar(100)")
                    .HasComment("物料小类名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Modifier)
                    .HasColumnName("modifier")
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModifyTime)
                    .HasColumnName("modify_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("修改时间")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.OpenId)
                    .HasColumnName("open_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据查看者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OwnerId)
                    .HasColumnName("owner_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据所有者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("varchar(1000)")
                    .HasComment("备注")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<EipPo>(entity =>
            {
                entity.HasKey(e => e.PoId)
                    .HasName("PRIMARY");

                entity.ToTable("eip_po");

                entity.HasComment("采购订单");

                entity.Property(e => e.PoId)
                    .HasColumnName("po_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("主键id");

                entity.Property(e => e.ConId)
                    .HasColumnName("con_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("合同id");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("创建时间");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasColumnName("creator")
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSource)
                    .HasColumnName("data_source")
                    .HasColumnType("varchar(60)")
                    .HasComment("数据来源")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSourceCreatetime)
                    .HasColumnName("data_source_createtime")
                    .HasColumnType("datetime")
                    .HasComment("来源数据创建时间");

                entity.Property(e => e.ErpAgreementCode)
                    .HasColumnName("erp_agreement_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("ERP协议库存号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasDefaultValueSql("'0'")
                    .HasComment("逻辑删除 1.是，0.否");

                entity.Property(e => e.Modifier)
                    .HasColumnName("modifier")
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModifyTime)
                    .HasColumnName("modify_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("修改时间")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.OpenId)
                    .HasColumnName("open_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据查看者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OwnerId)
                    .HasColumnName("owner_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据所有者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PoNo)
                    .HasColumnName("po_no")
                    .HasColumnType("varchar(48)")
                    .HasComment("采购订单编号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PoStatus)
                    .HasColumnName("po_status")
                    .HasColumnType("int(11)")
                    .HasComment("订单状态，具体取值待确定");

                entity.Property(e => e.ProjectCode)
                    .HasColumnName("project_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("项目编号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProjectName)
                    .HasColumnName("project_name")
                    .HasColumnType("varchar(100)")
                    .HasComment("项目名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PurchaseCode)
                    .HasColumnName("purchase_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("采购方公司编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PurchaseId)
                    .HasColumnName("purchase_id")
                    .HasColumnType("varchar(48)")
                    .HasComment("采购方组织机构id（冗余）")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PurchaseName)
                    .HasColumnName("purchase_name")
                    .HasColumnType("varchar(2000)")
                    .HasComment("采购方公司名称(冗余)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PurchaseType)
                    .HasColumnName("purchase_type")
                    .HasColumnType("int(11)")
                    .HasComment("订单类型，具体取值待确定");

                entity.Property(e => e.PurchaserHqCode)
                    .HasColumnName("purchaser_hq_code")
                    .HasColumnType("varchar(200)")
                    .HasComment("采购方总部编码，国家电网：sgcc")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("varchar(1000)")
                    .HasComment("备注")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SigningDate)
                    .HasColumnName("signing_date")
                    .HasColumnType("date")
                    .HasComment("签订日期");

                entity.Property(e => e.SupplierCode)
                    .HasColumnName("supplier_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("供应商编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SupplierId)
                    .HasColumnName("supplier_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("供应商id");

                entity.Property(e => e.SupplierName)
                    .HasColumnName("supplier_name")
                    .HasColumnType("varchar(100)")
                    .HasComment("供应商名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<EipPoItem>(entity =>
            {
                entity.HasKey(e => e.PoItemId)
                    .HasName("PRIMARY");

                entity.ToTable("eip_po_item");

                entity.HasComment("采购订单行项目");

                entity.Property(e => e.PoItemId)
                    .HasColumnName("po_item_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("主键id");

                entity.Property(e => e.AutoMatchFlag)
                    .HasColumnName("auto_match_flag")
                    .HasColumnType("int(11)")
                    .HasComment("国内外采购标识");

                entity.Property(e => e.CategoryCode)
                    .HasColumnName("category_code")
                    .HasColumnType("varchar(10)")
                    .HasComment("品类编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("创建时间");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasColumnName("creator")
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSource)
                    .HasColumnName("data_source")
                    .HasColumnType("varchar(60)")
                    .HasComment("数据来源")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSourceCreatetime)
                    .HasColumnName("data_source_createtime")
                    .HasColumnType("datetime")
                    .HasComment("来源数据创建时间");

                entity.Property(e => e.DemandOrg)
                    .HasColumnName("demand_org")
                    .HasColumnType("varchar(100)")
                    .HasComment("需求单位")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DlvAddr)
                    .HasColumnName("dlv_addr")
                    .HasColumnType("varchar(100)")
                    .HasComment("交货地点")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DlvTime)
                    .HasColumnName("dlv_time")
                    .HasColumnType("date")
                    .HasComment("交货日期");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasColumnType("tinyint(19)")
                    .HasDefaultValueSql("'0'")
                    .HasComment("逻辑删除 1.是，0.否");

                entity.Property(e => e.MatName)
                    .HasColumnName("mat_name")
                    .HasColumnType("varchar(100)")
                    .HasComment("物料名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MatQty)
                    .HasColumnName("mat_qty")
                    .HasColumnType("int(11)")
                    .HasComment("数量");

                entity.Property(e => e.MaterialCode)
                    .HasColumnName("material_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("物料编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MeasUnit)
                    .HasColumnName("meas_unit")
                    .HasColumnType("varchar(50)")
                    .HasComment("基本计量单位描述")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Modifier)
                    .HasColumnName("modifier")
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModifyTime)
                    .HasColumnName("modify_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("修改时间")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.OpenId)
                    .HasColumnName("open_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据查看者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrdStatus)
                    .HasColumnName("ord_status")
                    .HasColumnType("int(11)")
                    .HasComment("行项目状态");

                entity.Property(e => e.OwnerId)
                    .HasColumnName("owner_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据所有者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PoId)
                    .HasColumnName("po_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("采购订单id");

                entity.Property(e => e.PoItemNo)
                    .HasColumnName("po_item_no")
                    .HasColumnType("varchar(48)")
                    .HasComment("采购订单行项目编号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PrjCode)
                    .HasColumnName("prj_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("项目编号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PrjName)
                    .HasColumnName("prj_name")
                    .HasColumnType("varchar(100)")
                    .HasComment("项目名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PurchaseId)
                    .HasColumnName("purchase_id")
                    .HasColumnType("varchar(48)")
                    .HasComment("采购方组织机构id（冗余）")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PurchaseName)
                    .HasColumnName("purchase_name")
                    .HasColumnType("varchar(2000)")
                    .HasComment("采购方公司名称(冗余)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PurchaseNo)
                    .HasColumnName("purchase_no")
                    .HasColumnType("varchar(48)")
                    .HasComment("采购订单编号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PurchaserHqCode)
                    .HasColumnName("purchaser_hq_code")
                    .HasColumnType("varchar(20)")
                    .HasComment("采购方总部编码，国家电网：sgcc")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("varchar(1000)")
                    .HasComment("备注")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SubclassCode)
                    .HasColumnName("subclass_code")
                    .HasColumnType("varchar(10)")
                    .HasComment("种类编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SupplierCode)
                    .HasColumnName("supplier_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("供应商编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SupplierName)
                    .HasColumnName("supplier_name")
                    .HasColumnType("varchar(100)")
                    .HasComment("供应商名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<EipProcessReport>(entity =>
            {
                entity.HasKey(e => e.ProcessReportId)
                    .HasName("PRIMARY");

                entity.ToTable("eip_process_report");

                entity.HasComment("报工");

                entity.Property(e => e.ProcessReportId)
                    .HasColumnName("process_report_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("主键id");

                entity.Property(e => e.ActualFinishDate)
                    .HasColumnName("actual_finish_date")
                    .HasColumnType("date")
                    .HasComment("实际完成时间");

                entity.Property(e => e.ActualStartDate)
                    .HasColumnName("actual_start_date")
                    .HasColumnType("date")
                    .HasComment("实际开始时间");

                entity.Property(e => e.BuyerProvince)
                    .HasColumnName("buyer_province")
                    .HasColumnType("varchar(10)")
                    .HasComment("客户所属省份，不带“省”字")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CategoryCode)
                    .HasColumnName("category_code")
                    .HasColumnType("varchar(10)")
                    .HasComment("种类编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("创建时间");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasColumnName("creator")
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSource)
                    .HasColumnName("data_source")
                    .HasColumnType("varchar(60)")
                    .HasComment("数据来源")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSourceCreatetime)
                    .HasColumnName("data_source_createtime")
                    .HasColumnType("datetime")
                    .HasComment("来源数据创建时间");

                entity.Property(e => e.DeviceNo)
                    .HasColumnName("device_no")
                    .HasColumnType("varchar(48)")
                    .HasComment("设备编号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EntityId)
                    .HasColumnName("entity_id")
                    .HasColumnType("varchar(48)")
                    .HasComment("实物id")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InsideNo)
                    .HasColumnName("inside_no")
                    .HasColumnType("varchar(60)")
                    .HasComment("产品内部id号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IpoNo)
                    .HasColumnName("ipo_no")
                    .HasColumnType("varchar(48)")
                    .HasComment("生产订单编号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasColumnType("tinyint(19)")
                    .HasDefaultValueSql("'0'")
                    .HasComment("逻辑删除 1.是，0.否");

                entity.Property(e => e.Modifier)
                    .HasColumnName("modifier")
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModifyTime)
                    .HasColumnName("modify_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("修改时间")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.OpenId)
                    .HasColumnName("open_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据查看者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderStatus)
                    .HasColumnName("order_status")
                    .HasColumnType("int(11)")
                    .HasComment("订单状态，具体取值待确定");

                entity.Property(e => e.OwnerId)
                    .HasColumnName("owner_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据所有者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PlanFinishDate)
                    .HasColumnName("plan_finish_date")
                    .HasColumnType("date")
                    .HasComment("计划完成时间");

                entity.Property(e => e.PlanStartDate)
                    .HasColumnName("plan_start_date")
                    .HasColumnType("date")
                    .HasComment("计划开始时间");

                entity.Property(e => e.ProcessCode)
                    .HasColumnName("process_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("工序编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProcessName)
                    .HasColumnName("process_name")
                    .HasColumnType("varchar(50)")
                    .HasComment("工序名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProcessNo)
                    .HasColumnName("process_no")
                    .HasColumnType("varchar(60)")
                    .HasComment("生产工艺路线编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductBatchNo)
                    .HasColumnName("product_batch_no")
                    .HasColumnType("varchar(200)")
                    .HasComment("生产批次号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PurchaserHqCode)
                    .HasColumnName("purchaser_hq_code")
                    .HasColumnType("varchar(20)")
                    .HasComment("采购方总部编码，国家电网：sgcc")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("varchar(1000)")
                    .HasComment("备注")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SubclassCode)
                    .HasColumnName("subclass_code")
                    .HasColumnType("varchar(10)")
                    .HasComment("种类编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SupplierCode)
                    .HasColumnName("supplier_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("供应商编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SupplierId)
                    .HasColumnName("supplier_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("供应商id");

                entity.Property(e => e.SupplierIpoId)
                    .HasColumnName("supplier_ipo_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("生产订单id");

                entity.Property(e => e.SupplierName)
                    .HasColumnName("supplier_name")
                    .HasColumnType("varchar(50)")
                    .HasComment("供应商名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WoNo)
                    .HasColumnName("wo_no")
                    .HasColumnType("varchar(48)")
                    .HasComment("生产工单编号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WorkshopCode)
                    .HasColumnName("workshop_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("生产车间编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WorkshopId)
                    .HasColumnName("workshop_id")
                    .HasColumnType("int(11)")
                    .HasComment("生产车间id");

                entity.Property(e => e.WorkshopName)
                    .HasColumnName("workshop_name")
                    .HasColumnType("varchar(50)")
                    .HasComment("生产车间名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<EipProductionSchedule>(entity =>
            {
                entity.HasKey(e => e.ProductionScheduleId)
                    .HasName("PRIMARY");

                entity.ToTable("eip_production_schedule");

                entity.HasComment("排产计划");

                entity.Property(e => e.ProductionScheduleId)
                    .HasColumnName("production_schedule_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("主键id");

                entity.Property(e => e.ActualFinishDate)
                    .HasColumnName("actual_finish_date")
                    .HasColumnType("date")
                    .HasComment("实际完成日期");

                entity.Property(e => e.ActualPeriod)
                    .HasColumnName("actual_period")
                    .HasColumnType("varchar(10)")
                    .HasComment("实际工期")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ActualStartDate)
                    .HasColumnName("actual_start_date")
                    .HasColumnType("date")
                    .HasComment("实际开始日期");

                entity.Property(e => e.CategoryCode)
                    .HasColumnName("category_code")
                    .HasColumnType("varchar(255)")
                    .HasComment("品类编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("创建时间");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasColumnName("creator")
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSource)
                    .HasColumnName("data_source")
                    .HasColumnType("varchar(60)")
                    .HasComment("数据来源")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSourceCreatetime)
                    .HasColumnName("data_source_createtime")
                    .HasColumnType("timestamp")
                    .HasComment("来源数据创建时间");

                entity.Property(e => e.DueDate)
                    .HasColumnName("due_date")
                    .HasColumnType("date")
                    .HasComment("交付日期（最后日期，底线）");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasColumnType("tinyint(19)")
                    .HasDefaultValueSql("'0'")
                    .HasComment("逻辑删除 1.是，0.否");

                entity.Property(e => e.MaterialCode)
                    .HasColumnName("material_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("物料编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MaterialDesc)
                    .HasColumnName("material_desc")
                    .HasColumnType("varchar(255)")
                    .HasComment("物料描述")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Modifier)
                    .HasColumnName("modifier")
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModifyTime)
                    .HasColumnName("modify_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("修改时间")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.OpenId)
                    .HasColumnName("open_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据查看者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OwnerId)
                    .HasColumnName("owner_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据所有者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PlanFinishDate)
                    .HasColumnName("plan_finish_date")
                    .HasColumnType("date")
                    .HasComment("计划完成日期");

                entity.Property(e => e.PlanPeriod)
                    .HasColumnName("plan_period")
                    .HasColumnType("varchar(10)")
                    .HasComment("计划工期")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PlanStartDate)
                    .HasColumnName("plan_start_date")
                    .HasColumnType("date")
                    .HasComment("计划开始日期");

                entity.Property(e => e.PoItemId)
                    .HasColumnName("po_item_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("采购订单行项目id");

                entity.Property(e => e.PurchaserHqCode)
                    .HasColumnName("purchaser_hq_code")
                    .HasColumnType("varchar(20)")
                    .HasComment("采购方总部编码，国家电网：sgcc")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("varchar(1000)")
                    .HasComment("备注")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Schedule)
                    .HasColumnName("schedule")
                    .HasColumnType("varchar(10)")
                    .HasComment("进度")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ScheduleAmount)
                    .HasColumnName("schedule_amount")
                    .HasColumnType("varchar(10)")
                    .HasComment("排产数量")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ScheduleCode)
                    .HasColumnName("schedule_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("排产计划编号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SubclassCode)
                    .HasColumnName("subclass_code")
                    .HasColumnType("varchar(255)")
                    .HasComment("种类编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SupplierCode)
                    .HasColumnName("supplier_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("供应商编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SupplierId)
                    .HasColumnName("supplier_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("供应商id");

                entity.Property(e => e.SupplierName)
                    .HasColumnName("supplier_name")
                    .HasColumnType("varchar(50)")
                    .HasComment("供应商名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SupplierSoItemId)
                    .HasColumnName("supplier_so_item_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("销售订单行项目id");
            });

            modelBuilder.Entity<EipSupplier>(entity =>
            {
                entity.HasKey(e => e.SupplierId)
                    .HasName("PRIMARY");

                entity.ToTable("eip_supplier");

                entity.HasComment("供应商基础信息");

                entity.Property(e => e.SupplierId)
                    .HasColumnName("supplier_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("主键id");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("创建时间");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasColumnName("creator")
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSource)
                    .HasColumnName("data_source")
                    .HasColumnType("varchar(60)")
                    .HasComment("数据来源")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSourceCreatetime)
                    .HasColumnName("data_source_createtime")
                    .HasColumnType("datetime")
                    .HasComment("来源数据创建时间");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasColumnType("tinyint(19)")
                    .HasDefaultValueSql("'0'")
                    .HasComment("逻辑删除 1.是，0.否");

                entity.Property(e => e.Modifier)
                    .HasColumnName("modifier")
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModifyTime)
                    .HasColumnName("modify_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("修改时间")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.OpenId)
                    .HasColumnName("open_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据查看者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OwnerId)
                    .HasColumnName("owner_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据所有者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.QueryTimes)
                    .HasColumnName("query_times")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'0'")
                    .HasComment("供应商采购订单信息查询次数");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("varchar(1000)")
                    .HasComment("备注")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SupperAddr)
                    .HasColumnName("supper_addr")
                    .HasColumnType("varchar(100)")
                    .HasComment("地址（省市区）")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SupperContacts)
                    .HasColumnName("supper_contacts")
                    .HasColumnType("varchar(20)")
                    .HasComment("联系人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SupplierCode)
                    .HasColumnName("supplier_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("供应商编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SupplierFax)
                    .HasColumnName("supplier_fax")
                    .HasColumnType("varchar(45)")
                    .HasComment("传真")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SupplierMail)
                    .HasColumnName("supplier_mail")
                    .HasColumnType("varchar(45)")
                    .HasComment("邮箱")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SupplierName)
                    .HasColumnName("supplier_name")
                    .HasColumnType("varchar(50)")
                    .HasComment("供应商名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SupplierOrgCode)
                    .HasColumnName("supplier_org_code")
                    .HasColumnType("varchar(45)")
                    .HasComment("组织机构id")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SupplierPhone)
                    .HasColumnName("supplier_phone")
                    .HasColumnType("varchar(45)")
                    .HasComment("电话")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SupplierScc)
                    .HasColumnName("supplier_scc")
                    .HasColumnType("varchar(45)")
                    .HasComment("信用码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<EipSupplierIpo>(entity =>
            {
                entity.HasKey(e => e.SupplierIpoId)
                    .HasName("PRIMARY");

                entity.ToTable("eip_supplier_ipo");

                entity.HasComment("供应商侧生产订单");

                entity.Property(e => e.SupplierIpoId)
                    .HasColumnName("supplier_ipo_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("主键id");

                entity.Property(e => e.ActualFinishDate)
                    .HasColumnName("actual_finish_date")
                    .HasColumnType("date")
                    .HasComment("实际完成日期");

                entity.Property(e => e.ActualStartDate)
                    .HasColumnName("actual_start_date")
                    .HasColumnType("date")
                    .HasComment("实际开始日期");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(15,3)")
                    .HasComment("生产数量");

                entity.Property(e => e.CategoryCode)
                    .HasColumnName("category_code")
                    .HasColumnType("varchar(10)")
                    .HasComment("品类编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Center)
                    .HasColumnName("center")
                    .HasColumnType("varchar(100)")
                    .HasComment("生产中心")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Creator)
                    .HasColumnName("creator")
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSource)
                    .HasColumnName("data_source")
                    .HasColumnType("varchar(60)")
                    .HasComment("数据来源")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSourceCreatetime)
                    .HasColumnName("data_source_createtime")
                    .HasColumnType("datetime")
                    .HasComment("来源数据创建时间");

                entity.Property(e => e.IpoNo)
                    .HasColumnName("ipo_no")
                    .HasColumnType("varchar(48)")
                    .HasComment("生产订单号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IpoStatus)
                    .HasColumnName("ipo_status")
                    .HasColumnType("int(11)")
                    .HasComment("生产订单状态");

                entity.Property(e => e.IpoType)
                    .HasColumnName("ipo_type")
                    .HasColumnType("int(11)")
                    .HasComment("订单类型");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasColumnType("tinyint(19)")
                    .HasDefaultValueSql("'0'")
                    .HasComment("逻辑删除 1.是，0.否");

                entity.Property(e => e.MaterialCode)
                    .HasColumnName("material_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("厂家物料编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MaterialDesc)
                    .HasColumnName("material_desc")
                    .HasColumnType("varchar(200)")
                    .HasComment("厂家物料描述")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MaterialName)
                    .HasColumnName("material_name")
                    .HasColumnType("varchar(50)")
                    .HasComment("厂家物料名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MaterialUnit)
                    .HasColumnName("material_unit")
                    .HasColumnType("varchar(10)")
                    .HasComment("厂家物资单位")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Modifier)
                    .HasColumnName("modifier")
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModifyTime)
                    .HasColumnName("modify_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("修改时间")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.OpenId)
                    .HasColumnName("open_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据查看者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OwnerId)
                    .HasColumnName("owner_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据所有者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PlanFinishDate)
                    .HasColumnName("plan_finish_date")
                    .HasColumnType("date")
                    .HasComment("计划完成日期");

                entity.Property(e => e.PlanStartDate)
                    .HasColumnName("plan_start_date")
                    .HasColumnType("date")
                    .HasComment("计划开始日期");

                entity.Property(e => e.PlantName)
                    .HasColumnName("plant_name")
                    .HasColumnType("varchar(50)")
                    .HasComment("生产工厂名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PoItemId)
                    .HasColumnName("po_item_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("采购订单行项目id");

                entity.Property(e => e.ProductIdGrpNo)
                    .HasColumnName("product_id_grp_no")
                    .HasColumnType("varchar(50)")
                    .HasComment("物资id分组")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductIdType)
                    .HasColumnName("product_id_type")
                    .HasColumnType("varchar(10)")
                    .HasComment("物资id类型(采购方侧，如国网侧)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductModel)
                    .HasColumnName("product_model")
                    .HasColumnType("varchar(50)")
                    .HasComment("产品型号（供应商侧）")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PurchaserHqCode)
                    .HasColumnName("purchaser_hq_code")
                    .HasColumnType("varchar(20)")
                    .HasComment("采购方总部编码，国家电网：sgcc")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("varchar(1000)")
                    .HasComment("备注")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ScheduleCode)
                    .HasColumnName("schedule_code")
                    .HasColumnType("varchar(50)")
                    .HasComment("排产计划编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SubclassCode)
                    .HasColumnName("subclass_code")
                    .HasColumnType("varchar(10)")
                    .HasComment("种类编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SupplierCode)
                    .HasColumnName("supplier_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("供应商编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SupplierId)
                    .HasColumnName("supplier_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("供应商id");

                entity.Property(e => e.SupplierName)
                    .HasColumnName("supplier_name")
                    .HasColumnType("varchar(50)")
                    .HasComment("供应商名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SupplierSoItemId)
                    .HasColumnName("supplier_so_item_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("销售订单行项目id");

                entity.Property(e => e.Unit)
                    .HasColumnName("unit")
                    .HasColumnType("varchar(10)")
                    .HasComment("计量单位")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WorkshopName)
                    .HasColumnName("workshop_name")
                    .HasColumnType("varchar(50)")
                    .HasComment("生产车间名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<EipSupplierPoSoRel>(entity =>
            {
                entity.HasKey(e => e.PoSoRelId)
                    .HasName("PRIMARY");

                entity.ToTable("eip_supplier_po_so_rel");

                entity.HasComment("采购订单与销售订单关联关系表");

                entity.Property(e => e.PoSoRelId)
                    .HasColumnName("po_so_rel_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("主键id");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("创建时间");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasColumnName("creator")
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSource)
                    .HasColumnName("data_source")
                    .HasColumnType("varchar(60)")
                    .HasComment("数据来源")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSourceCreatetime)
                    .HasColumnName("data_source_createtime")
                    .HasColumnType("datetime")
                    .HasComment("来源数据创建时间");

                entity.Property(e => e.EipPoId)
                    .HasColumnName("eip_po_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("采购订单行项目id");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasColumnType("tinyint(19)")
                    .HasDefaultValueSql("'0'")
                    .HasComment("逻辑删除 1.是，0.否");

                entity.Property(e => e.Modifier)
                    .HasColumnName("modifier")
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModifyTime)
                    .HasColumnName("modify_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("修改时间")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.OpenId)
                    .HasColumnName("open_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据查看者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OwnerId)
                    .HasColumnName("owner_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据所有者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("varchar(1000)")
                    .HasComment("备注")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SupplierSoItemId)
                    .HasColumnName("supplier_so_item_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("销售订单行项目id");
            });

            modelBuilder.Entity<EipSupplierSo>(entity =>
            {
                entity.HasKey(e => e.SupplierSoId)
                    .HasName("PRIMARY");

                entity.ToTable("eip_supplier_so");

                entity.HasComment("供应商侧销售订单");

                entity.Property(e => e.SupplierSoId)
                    .HasColumnName("supplier_so_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("主键id");

                entity.Property(e => e.BuyerCode)
                    .HasColumnName("buyer_code")
                    .HasColumnType("varchar(20)")
                    .HasComment("采购方公司编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BuyerName)
                    .HasColumnName("buyer_name")
                    .HasColumnType("varchar(2000)")
                    .HasComment("采购方公司名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BuyerProvince)
                    .HasColumnName("buyer_province")
                    .HasColumnType("varchar(10)")
                    .HasComment("采购方公司省份")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CategoryCode)
                    .HasColumnName("category_code")
                    .HasColumnType("varchar(10)")
                    .HasComment("品类编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("创建时间");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasColumnName("creator")
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSource)
                    .HasColumnName("data_source")
                    .HasColumnType("varchar(60)")
                    .HasComment("数据来源")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSourceCreatetime)
                    .HasColumnName("data_source_createtime")
                    .HasColumnType("datetime")
                    .HasComment("来源数据创建时间");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasColumnType("tinyint(19)")
                    .HasDefaultValueSql("'0'")
                    .HasComment("逻辑删除 1.是，0.否");

                entity.Property(e => e.Modifier)
                    .HasColumnName("modifier")
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModifyTime)
                    .HasColumnName("modify_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("修改时间")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.OpenId)
                    .HasColumnName("open_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据查看者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OwnerId)
                    .HasColumnName("owner_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据所有者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PurchaserHqCode)
                    .HasColumnName("purchaser_hq_code")
                    .HasColumnType("varchar(20)")
                    .HasComment("采购方总部编码，国家电网：sgcc")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("varchar(1000)")
                    .HasComment("备注")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SoNo)
                    .HasColumnName("so_no")
                    .HasColumnType("varchar(48)")
                    .HasComment("销售订单号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SoStatus)
                    .HasColumnName("so_status")
                    .HasColumnType("int(11)")
                    .HasComment("销售订单状态");

                entity.Property(e => e.SupplierCode)
                    .HasColumnName("supplier_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("供应商编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SupplierId)
                    .HasColumnName("supplier_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("供应商id");

                entity.Property(e => e.SupplierName)
                    .HasColumnName("supplier_name")
                    .HasColumnType("varchar(50)")
                    .HasComment("供应商名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<EipSupplierSoLineitem>(entity =>
            {
                entity.HasKey(e => e.SupplierSoItemId)
                    .HasName("PRIMARY");

                entity.ToTable("eip_supplier_so_lineitem");

                entity.HasComment("供应商侧销售订单行项目");

                entity.Property(e => e.SupplierSoItemId)
                    .HasColumnName("supplier_so_item_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("主键id");

                entity.Property(e => e.CategoryCode)
                    .HasColumnName("category_code")
                    .HasColumnType("varchar(10)")
                    .HasComment("品类编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("创建时间");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasColumnName("creator")
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSource)
                    .HasColumnName("data_source")
                    .HasColumnType("varchar(60)")
                    .HasComment("数据来源")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSourceCreatetime)
                    .HasColumnName("data_source_createtime")
                    .HasColumnType("datetime")
                    .HasComment("来源数据创建时间");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasColumnType("tinyint(19)")
                    .HasDefaultValueSql("'0'")
                    .HasComment("逻辑删除 1.是，0.否");

                entity.Property(e => e.Modifier)
                    .HasColumnName("modifier")
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModifyTime)
                    .HasColumnName("modify_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("修改时间")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.OpenId)
                    .HasColumnName("open_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据查看者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OwnerId)
                    .HasColumnName("owner_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据所有者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductAmount)
                    .HasColumnName("product_amount")
                    .HasColumnType("varchar(2000)")
                    .HasComment("物资数量")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductCode)
                    .HasColumnName("product_code")
                    .HasColumnType("varchar(20)")
                    .HasComment("物资编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductName)
                    .HasColumnName("product_name")
                    .HasColumnType("varchar(50)")
                    .HasComment("物资名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductUnit)
                    .HasColumnName("product_unit")
                    .HasColumnType("varchar(5)")
                    .HasComment("物资单位")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PurchaserHqCode)
                    .HasColumnName("purchaser_hq_code")
                    .HasColumnType("varchar(20)")
                    .HasComment("采购方总部编码，国家电网：sgcc")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("varchar(1000)")
                    .HasComment("备注")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SoItemNo)
                    .HasColumnName("so_item_no")
                    .HasColumnType("varchar(48)")
                    .HasComment("销售订单行项目号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SoNo)
                    .HasColumnName("so_no")
                    .HasColumnType("varchar(48)")
                    .HasComment("销售订单号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SubclassCode)
                    .HasColumnName("subclass_code")
                    .HasColumnType("varchar(10)")
                    .HasComment("种类编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SupplierSoId)
                    .HasColumnName("supplier_so_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("供应商销售订单id");
            });

            modelBuilder.Entity<EipSupplierWo>(entity =>
            {
                entity.HasKey(e => e.SupplierWoId)
                    .HasName("PRIMARY");

                entity.ToTable("eip_supplier_wo");

                entity.HasComment("供应商侧生产订单");

                entity.Property(e => e.SupplierWoId)
                    .HasColumnName("supplier_wo_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("主键id");

                entity.Property(e => e.ActualFinishDate)
                    .HasColumnName("actual_finish_date")
                    .HasColumnType("date")
                    .HasComment("实际完成日期");

                entity.Property(e => e.ActualStartDate)
                    .HasColumnName("actual_start_date")
                    .HasColumnType("date")
                    .HasComment("实际开始日期");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("varchar(2000)")
                    .HasComment("生产数量(存储加密)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CategoryCode)
                    .HasColumnName("category_code")
                    .HasColumnType("varchar(10)")
                    .HasComment("品类编码(冗余)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("创建时间");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasColumnName("creator")
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSource)
                    .HasColumnName("data_source")
                    .HasColumnType("varchar(60)")
                    .HasComment("数据来源")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSourceCreatetime)
                    .HasColumnName("data_source_createtime")
                    .HasColumnType("datetime")
                    .HasComment("来源数据创建时间");

                entity.Property(e => e.IpoNo)
                    .HasColumnName("ipo_no")
                    .HasColumnType("varchar(50)")
                    .HasComment("供应商生产订单编号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasColumnType("tinyint(19)")
                    .HasDefaultValueSql("'0'")
                    .HasComment("逻辑删除 1.是，0.否");

                entity.Property(e => e.MaterialsBatch)
                    .HasColumnName("materials_batch")
                    .HasColumnType("varchar(50)")
                    .HasComment("物料批次")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MaterialsCode)
                    .HasColumnName("materials_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("厂家物资编码(冗余)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MaterialsDesc)
                    .HasColumnName("materials_desc")
                    .HasColumnType("varchar(200)")
                    .HasComment("厂家物料描述(冗余)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Modifier)
                    .HasColumnName("modifier")
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModifyTime)
                    .HasColumnName("modify_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("修改时间")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.OpenId)
                    .HasColumnName("open_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据查看者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OwnerId)
                    .HasColumnName("owner_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据所有者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PlanFinishDate)
                    .HasColumnName("plan_finish_date")
                    .HasColumnType("date")
                    .HasComment("计划完成日期");

                entity.Property(e => e.PlanStartDate)
                    .HasColumnName("plan_start_date")
                    .HasColumnType("date")
                    .HasComment("计划开始日期");

                entity.Property(e => e.ProcessRouteNo)
                    .HasColumnName("process_route_no")
                    .HasColumnType("varchar(48)")
                    .HasComment("工艺路线编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PurchaserHqCode)
                    .HasColumnName("purchaser_hq_code")
                    .HasColumnType("varchar(20)")
                    .HasComment("采购方总部编码，国家电网：sgcc")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("varchar(1000)")
                    .HasComment("备注")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SubclassCode)
                    .HasColumnName("subclass_code")
                    .HasColumnType("varchar(10)")
                    .HasComment("种类编码(冗余)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SupplierCode)
                    .HasColumnName("supplier_code")
                    .HasColumnType("varchar(48)")
                    .HasComment("供应商编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SupplierId)
                    .HasColumnName("supplier_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("供应商id");

                entity.Property(e => e.SupplierName)
                    .HasColumnName("supplier_name")
                    .HasColumnType("varchar(50)")
                    .HasComment("供应商名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Unit)
                    .HasColumnName("unit")
                    .HasColumnType("varchar(5)")
                    .HasComment("计量单位")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WoNo)
                    .HasColumnName("wo_no")
                    .HasColumnType("varchar(48)")
                    .HasComment("生产工单编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WoStatus)
                    .HasColumnName("wo_status")
                    .HasColumnType("int(11)")
                    .HasComment("工单状态 1：创建，2:原材料检验，3：生产中，4：出厂试验，5：包装入库");
            });

            modelBuilder.Entity<EipSupplierWoPoRel>(entity =>
            {
                entity.HasKey(e => e.WoPoRelId)
                    .HasName("PRIMARY");

                entity.ToTable("eip_supplier_wo_po_rel");

                entity.HasComment("生产订单与采购订单关联表");

                entity.Property(e => e.WoPoRelId)
                    .HasColumnName("wo_po_rel_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("主键id");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("创建时间");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasColumnName("creator")
                    .HasColumnType("varchar(50)")
                    .HasComment("创建人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSource)
                    .HasColumnName("data_source")
                    .HasColumnType("varchar(60)")
                    .HasComment("数据来源")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataSourceCreatetime)
                    .HasColumnName("data_source_createtime")
                    .HasColumnType("datetime")
                    .HasComment("来源数据创建时间");

                entity.Property(e => e.EipPoId)
                    .HasColumnName("eip_po_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("采购订单行项目id");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasColumnType("tinyint(19)")
                    .HasDefaultValueSql("'0'")
                    .HasComment("逻辑删除 1.是，0.否");

                entity.Property(e => e.Modifier)
                    .HasColumnName("modifier")
                    .HasColumnType("varchar(50)")
                    .HasComment("修改人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModifyTime)
                    .HasColumnName("modify_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("修改时间")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.OpenId)
                    .HasColumnName("open_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据查看者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OwnerId)
                    .HasColumnName("owner_id")
                    .HasColumnType("varchar(50)")
                    .HasComment("数据所有者的在EIP中的业务组织机构编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("varchar(1000)")
                    .HasComment("备注")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SupplierIpoId)
                    .HasColumnName("supplier_ipo_id")
                    .HasColumnType("bigint(19)")
                    .HasComment("生产订单id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
