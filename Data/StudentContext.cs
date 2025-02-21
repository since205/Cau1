namespace EmtityWithNet.Data
{

    using Microsoft.AspNetCore.Hosting.Server;
    //using System.Data.Entity;//winform
    using Microsoft.EntityFrameworkCore;
    using System.Security.Cryptography;
    using System;
    using Model;
    using System.Collections.Generic;


    namespace ett1_web_api.Data
    {
        public class StudentContext : DbContext
        {
            // public StudentContext() : base("name=StudentDBConnectionString") //winform
            public StudentContext(DbContextOptions<StudentContext> options) : base(options) //webapi
            {
            }

            public DbSet<Student> Students { get; set; }

        }
    }
}
