using EntityFramworkCore.Models;
using Microsoft.EntityFrameworkCore;    //IEntityTypeConfiguration
using Microsoft.EntityFrameworkCore.Metadata.Builders;   //configure

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramworkCore.Configrations
{
    public class BlogEntityTypeConfigration:IEntityTypeConfiguration<Blog>
    {
        //public void configure(EntityTypeBuilder<Blog> builder)
        //{
        //    builder
        //            .Property(m => m.Url)
        //            .IsRequired();
        //}

        void IEntityTypeConfiguration<Blog>.Configure(EntityTypeBuilder<Blog> builder)
        {
            builder
                    .Property(m => m.Url)
                    .IsRequired();
        }
    }
}
