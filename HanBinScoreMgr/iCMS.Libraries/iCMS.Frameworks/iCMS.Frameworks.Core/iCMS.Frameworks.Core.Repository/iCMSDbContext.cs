﻿using System;
using System.Data.Entity;
using HanBin.Core.DB.Models;
using iCMS.Common.Component.Tool;


namespace iCMS.Frameworks.Core.Repository
{
    public class iCMSDbContext : DbContext, IDisposable
    {
        public iCMSDbContext()
            : base(EcanSecurity.Decode(Utilitys.GetAppConfigForExe("iCMS")))// 做手动推送时候，为了使更改的App.Config能够立即生效，故而将
        {                                                                   // GetAppConfig => GetAppConfigForExe,若调试出错，请联系QXM, 2017/02/21
            Database.SetInitializer<iCMSDbContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }

        public DbSet<HBUser> HBUsers { get; set; }

        public DbSet<HBRole> HBRoles { get; set; }

        public DbSet<Organization> Organizations { get; set; }

        public DbSet<Officer> Officers { get; set; }

        public DbSet<OrganType> OrganTypes { get; set; }

        public DbSet<OrganCategory> OrganCategories { get; set; }

        public DbSet<UploadFile> UploadFiles { get; set; }

        public DbSet<ScoreApply> ScoreApplies { get; set; }

        public DbSet<ScoreItem> ScoreItems { get; set; }

        public DbSet<ScoreChangeHistory> ScoreChangeHistories { get; set; }

        public DbSet<OfficerLevelType> OfficerLevelTypes { get; set; }
    }
}