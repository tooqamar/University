﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lib.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DB_RTLEntities : DbContext
    {
        public DB_RTLEntities()
            : base("name=DB_RTLEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_Student> tbl_Student { get; set; }
        public virtual DbSet<tbl_Student_Subject_Grade> tbl_Student_Subject_Grade { get; set; }
        public virtual DbSet<tblCours> tblCourses { get; set; }
        public virtual DbSet<tblGrade> tblGrades { get; set; }
        public virtual DbSet<tblSubject> tblSubjects { get; set; }
        public virtual DbSet<tblTeacher> tblTeachers { get; set; }
        public virtual DbSet<vListTeacher> vListTeachers { get; set; }
        public virtual DbSet<vListResult> vListResults { get; set; }
        public virtual DbSet<vListStudent> vListStudents { get; set; }
        public virtual DbSet<vListSubject> vListSubjects { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }
    
        public virtual int spAccountsFiscalYears_Periods_L(Nullable<int> actionFlag, Nullable<int> iD, string fiscalYear, string year, string month, Nullable<bool> closed, Nullable<bool> locked, string entryUser, Nullable<System.DateTime> entryDate)
        {
            var actionFlagParameter = actionFlag.HasValue ?
                new ObjectParameter("ActionFlag", actionFlag) :
                new ObjectParameter("ActionFlag", typeof(int));
    
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var fiscalYearParameter = fiscalYear != null ?
                new ObjectParameter("FiscalYear", fiscalYear) :
                new ObjectParameter("FiscalYear", typeof(string));
    
            var yearParameter = year != null ?
                new ObjectParameter("Year", year) :
                new ObjectParameter("Year", typeof(string));
    
            var monthParameter = month != null ?
                new ObjectParameter("Month", month) :
                new ObjectParameter("Month", typeof(string));
    
            var closedParameter = closed.HasValue ?
                new ObjectParameter("Closed", closed) :
                new ObjectParameter("Closed", typeof(bool));
    
            var lockedParameter = locked.HasValue ?
                new ObjectParameter("Locked", locked) :
                new ObjectParameter("Locked", typeof(bool));
    
            var entryUserParameter = entryUser != null ?
                new ObjectParameter("EntryUser", entryUser) :
                new ObjectParameter("EntryUser", typeof(string));
    
            var entryDateParameter = entryDate.HasValue ?
                new ObjectParameter("EntryDate", entryDate) :
                new ObjectParameter("EntryDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAccountsFiscalYears_Periods_L", actionFlagParameter, iDParameter, fiscalYearParameter, yearParameter, monthParameter, closedParameter, lockedParameter, entryUserParameter, entryDateParameter);
        }
    
        public virtual ObjectResult<spStockByNameDATE_Result> spStockByNameDATE(Nullable<System.DateTime> sdate, Nullable<System.DateTime> edate)
        {
            var sdateParameter = sdate.HasValue ?
                new ObjectParameter("sdate", sdate) :
                new ObjectParameter("sdate", typeof(System.DateTime));
    
            var edateParameter = edate.HasValue ?
                new ObjectParameter("edate", edate) :
                new ObjectParameter("edate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spStockByNameDATE_Result>("spStockByNameDATE", sdateParameter, edateParameter);
        }
    
        public virtual ObjectResult<spStockByPrice_Result> spStockByPrice(Nullable<System.DateTime> sdate, Nullable<System.DateTime> edate)
        {
            var sdateParameter = sdate.HasValue ?
                new ObjectParameter("sdate", sdate) :
                new ObjectParameter("sdate", typeof(System.DateTime));
    
            var edateParameter = edate.HasValue ?
                new ObjectParameter("edate", edate) :
                new ObjectParameter("edate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spStockByPrice_Result>("spStockByPrice", sdateParameter, edateParameter);
        }
    }
}