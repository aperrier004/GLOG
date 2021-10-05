using System;
using System.Collections.Generic;
using DAL;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace DALTests
{
    class TestRepository : Repository
    {
        internal static void ResetSchema()
        {
            Session.Clear();
            new SchemaExport(Configuration).Execute(false, true, false);
        }

        internal static void ClearSession()
        {
            Session.Clear();
        }

        internal static void Execute(string sql)
        {
            ISQLQuery query = Session.CreateSQLQuery(sql);
            query.ExecuteUpdate();
        }

        /// <summary>
        /// Load database with test data
        /// </summary>
        public static void InitDB()
        {
            ResetSchema();

            //BD content serie
            Execute
                ("insert into serie values (1, 'Scott Pilgrim');" +
                "insert into serie values (2, 'Les Aventures extraordinaires d Adèle Blanc-Sec');" +
                "insert into serie values(3, 'L attaque des Titans');" +
                "insert into serie values(4, 'Le château des étoiles');");

            // BD content categorie
            Execute
                ("insert into categorie values(1, 'Comics');" +
                "insert into categorie values (2, 'Manga');" +
                "insert into categorie values (3, 'Bande Dessinée');"
                );

            //BD content auteurs
            Execute
                ("insert into auteur values(1, 'Lee O Maley', 'Bryan');" +
                "insert into auteur values(2, 'Tardi', 'Jacques');" +
                "insert into auteur values(3,'Hajime', 'Isayama');" +
                "insert into auteur values(4,'Alex', 'Alice');"
                );

            //BD content genre
            Execute
                ("insert into genre values(1, 'Contemporain');" +
                "insert into genre values(2, 'Aventure'); " +
                "insert into genre values(3, 'Fantasy historique'); " +
                "insert into genre values(4, 'Action');"
                );


            // BD Content albums
            Execute
                (
                "insert into album values(1, 'https://static.fnac-static.com/multimedia/FR/Images_Produits/FR/fnac.com/Visual_Principal_340/8/3/2/9782811203238/tsp20120919192820/Precious-little-life.jpg', 'Scott Pilgrim s Precious Little Life', 'Milady', 1, 1);" +
                "insert into album values(2, 'https://static.fnac-static.com/multimedia/FR/Images_Produits/FR/fnac.com/Visual_Principal_340/8/2/5/9782811203528/tsp20120919181839/Us-the-world.jpg', 'Scott Pilgrim vs. the World', 'Milady', 1, 1);" +
                "insert into album values(3, 'https://www.casterman.com/media/cache/couverture_large/casterman_img/Couvertures/9782203148444.jpg', 'Adèle et la Bête', 'casterman', 2, 3); " +
                "insert into album values(4, 'https://static.fnac-static.com/multimedia/Images/FR/NR/89/cf/4a/4902793/1540-1/tsp20131021170210/L-attaque-des-Titans.jpg', 'Tome 1: L attaque des Titans', 'Pika Edition', 3, 2); "
                );

            //BD Content genres/album
            Execute
                (
                "insert into album_genres values(1, 1); " +
                "insert into album_genres values(1,2);  " +
                "insert into album_genres values(2,3);  " +
                "insert into album_genres values(3,3);  " +
                "insert into album_genres values(4,4);  ");

            //BD content album / auteurs
            Execute
                (
                "insert into album_auteurs values(1, 1); " +
                "insert into album_auteurs values(1, 2); " +
                "insert into album_auteurs values(2, 3); " +
                "insert into album_auteurs values(3, 4);");

            // BD Content Utilisateurs & co
            Execute
                (
                "insert into administrateur values(1, 'admin', 'admin');" +
                "insert into utilisateur values(1, 'Doe', 'John', 'john002', 'monSuperMDP'); "+
                "insert into album_souhaites values(1, 2); "+
                "insert into album_souhaites values(1, 3);"+
                "insert into album_achetes values(1, 1); "
                );



        }
    }
}
