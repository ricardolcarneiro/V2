
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



    public interface IDatabaseContext : System.IDisposable
    {

        System.Data.Entity.DbSet<AspNetRoles> AspNetRoles { get; set; }



        System.Data.Entity.DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }



        System.Data.Entity.DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }



        System.Data.Entity.DbSet<AspNetUsers> AspNetUsers { get; set; }



        System.Data.Entity.DbSet<GrupoUsuario> GrupoUsuario { get; set; }



        System.Data.Entity.DbSet<Menu> Menu { get; set; }



        System.Data.Entity.DbSet<Morador> Morador { get; set; }



        System.Data.Entity.DbSet<RotaDestino> RotaDestino { get; set; }



        System.Data.Entity.DbSet<RotaFuga> RotaFuga { get; set; }



        System.Data.Entity.DbSet<TipoDomicilio> TipoDomicilio { get; set; }



        System.Data.Entity.DbSet<TipoEducacao> TipoEducacao { get; set; }



        System.Data.Entity.DbSet<TipoEspecieDomicilioOcupado> TipoEspecieDomicilioOcupado { get; set; }



        System.Data.Entity.DbSet<TipoEtinoRacial> TipoEtinoRacial { get; set; }



        System.Data.Entity.DbSet<TipoFalaLinguaIndigena> TipoFalaLinguaIndigena { get; set; }



        System.Data.Entity.DbSet<TipoLinguaPortuquesa> TipoLinguaPortuquesa { get; set; }



        System.Data.Entity.DbSet<TipoParantesco> TipoParantesco { get; set; }



        System.Data.Entity.DbSet<TipoPessoaIndigena> TipoPessoaIndigena { get; set; }



        System.Data.Entity.DbSet<TipoQuilombolas> TipoQuilombolas { get; set; }



        System.Data.Entity.DbSet<TipoRegistroCivil> TipoRegistroCivil { get; set; }



        System.Data.Entity.DbSet<TipoSexo> TipoSexo { get; set; }



        System.Data.Entity.DbSet<Usuario> Usuario { get; set; }



        System.Data.Entity.DbSet<Usuarioold> Usuarioold { get; set; }






        int SaveChanges();

        System.Threading.Tasks.Task<int> SaveChangesAsync();
        System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken);

        System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get; }
        System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get; }
        System.Data.Entity.Database Database { get; }
        System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        System.Data.Entity.Infrastructure.DbEntityEntry Entry(object entity);
        System.Collections.Generic.IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> GetValidationErrors();
        System.Data.Entity.DbSet Set(System.Type entityType);
        System.Data.Entity.DbSet<TEntity> Set<TEntity>() where TEntity : class;
        string ToString();


    }


}
// </auto-generated>
