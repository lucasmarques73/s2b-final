namespace S2B_Final.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDenuncia : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DenunciaModels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DescricaoOcorrido = c.String(),
                        DataOcorrido = c.DateTime(nullable: false),
                        HorarioOcorrido = c.String(),
                        LocalOcorrido = c.String(),
                        TipoOcorrencia = c.String(),
                        CaracteristicasSuspeito = c.String(),
                        Ip = c.String(),
                        Navegador = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DenunciaModels");
        }
    }
}
