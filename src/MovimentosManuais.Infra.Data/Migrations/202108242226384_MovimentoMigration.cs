﻿namespace MovimentosManuais.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovimentoMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MOVIMENTO_MANUAL",
                c => new
                    {
                        DAT_MES = c.Decimal(nullable: false, precision: 2, scale: 0, storeType: "numeric"),
                        DAT_ANO = c.Decimal(nullable: false, precision: 4, scale: 0, storeType: "numeric"),
                        NUM_LANCAMENTO = c.Decimal(nullable: false, precision: 18, scale: 0, storeType: "numeric"),
                        COD_PRODUTO = c.String(nullable: false, maxLength: 4, fixedLength: true, unicode: false),
                        COD_COSIF = c.String(nullable: false, maxLength: 11, fixedLength: true, unicode: false),
                        DES_DESCRICAO = c.String(nullable: false, maxLength: 50, unicode: false),
                        DAT_MOVIMENTO = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        COD_USUARIO = c.String(nullable: false, maxLength: 15, unicode: false),
                        VAL_VALOR = c.Decimal(nullable: false, precision: 18, scale: 2, storeType: "numeric"),
                    })
                .PrimaryKey(t => new { t.DAT_MES, t.DAT_ANO, t.NUM_LANCAMENTO, t.COD_PRODUTO, t.COD_COSIF })
                .ForeignKey("dbo.PRODUTO_COSIF", t => new { t.COD_PRODUTO, t.COD_COSIF })
                .Index(t => new { t.COD_PRODUTO, t.COD_COSIF });
            
            CreateTable(
                "dbo.PRODUTO_COSIF",
                c => new
                    {
                        COD_PRODUTO = c.String(nullable: false, maxLength: 4, fixedLength: true, unicode: false),
                        COD_COSIF = c.String(nullable: false, maxLength: 11, fixedLength: true, unicode: false),
                        COD_CLASSIFICACAO = c.String(maxLength: 6, fixedLength: true, unicode: false),
                        STA_STATUS = c.String(maxLength: 1, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => new { t.COD_PRODUTO, t.COD_COSIF })
                .ForeignKey("dbo.PRODUTO", t => t.COD_PRODUTO)
                .Index(t => t.COD_PRODUTO);
            
            CreateTable(
                "dbo.PRODUTO",
                c => new
                    {
                        COD_PRODUTO = c.String(nullable: false, maxLength: 4, fixedLength: true, unicode: false),
                        DES_PRODUTO = c.String(maxLength: 30, unicode: false),
                        STA_STATUS = c.String(maxLength: 1, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => t.COD_PRODUTO);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PRODUTO_COSIF", "COD_PRODUTO", "dbo.PRODUTO");
            DropForeignKey("dbo.MOVIMENTO_MANUAL", new[] { "COD_PRODUTO", "COD_COSIF" }, "dbo.ProdutoCosifs");
            DropIndex("dbo.PRODUTO_COSIF", new[] { "COD_PRODUTO" });
            DropIndex("dbo.MOVIMENTO_MANUAL", new[] { "COD_PRODUTO", "COD_COSIF" });
            DropTable("dbo.PRODUTO");
            DropTable("dbo.PRODUTO_COSIF");
            DropTable("dbo.MOVIMENTO_MANUAL");
        }
    }
}
