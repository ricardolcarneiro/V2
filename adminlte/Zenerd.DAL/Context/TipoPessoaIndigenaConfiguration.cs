
// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning



namespace ZeNerd.DAL.Context
{



    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]

    public class TipoPessoaIndigenaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TipoPessoaIndigena>
    {
        public TipoPessoaIndigenaConfiguration()
            : this("dbo")
        {
        }

        public TipoPessoaIndigenaConfiguration(string schema)
        {

            ToTable("tipo_pessoa_indigena", schema);

            HasKey(x => x.Id);



            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            Property(x => x.Nome).HasColumnName(@"nome").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);



        }
    }



}
// </auto-generated>
