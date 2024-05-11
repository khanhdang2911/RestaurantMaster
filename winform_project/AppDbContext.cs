using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace winform_project
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(): base("myConnect")
        {
        }

        protected override void OnModelCreating(DbModelBuilder dbModelBuilder)
        {
            base.OnModelCreating(dbModelBuilder);
            dbModelBuilder.Entity<SanPhamBan>()
            .HasKey(c => new { c.BanId, c.SanPhamId });

        }
        public DbSet<NguoiDung>nguoiDungs { get; set; }
        public DbSet<Role>roles { get; set; }
        public DbSet<DanhMuc>danhMucs { get; set; }
        public DbSet<SanPham> sanPhams { set; get; }
        public DbSet<Ban> bans { set; get; }
        public DbSet<SanPhamBan> sanPhamBans { set; get; }
        public DbSet<HoaDon> HoaDon { set; get; }
    }
}
