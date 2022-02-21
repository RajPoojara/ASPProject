using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASPProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ASPProject.Models.Subject> Subjects { get; set; }
        public DbSet<ASPProject.Models.UserInfo> UserInfos { get; set; }
        public DbSet<ASPProject.Models.Faculty> Faculties { get; set; }
        public DbSet<ASPProject.Models.Project> Projects { get; set; }
        public DbSet<ASPProject.Models.SubmissionDetail> SubmissionDetails { get; set; }
        public DbSet<ASPProject.Models.Student> Students { get; set; }

    }
}
