

insert into serie values
(1, 'Scott Pilgrim');
insert into serie values
(2, "Les Aventures extraordinaires d'Adèle Blanc-Sec");
insert into serie values
(3, "L'attaque des Titans");
insert into serie values
(4, 'Le château des étoiles');
insert into serie values
(5, 'Bone');
insert into serie values
(6, 'X-Men');
insert into serie values
(7, 'Your Lie in April');
insert into serie values
(8, 'Maliki');


insert into categorie values
(1, 'Comics');
insert into categorie values
(2, 'Manga');
insert into categorie values
(3, 'Bande Dessinée');


insert into auteur values
(1, "Lee O'Maley", "Bryan");
insert into auteur values
(2, "Tardi", "Jacques");
insert into auteur values
(3,'Hajime', 'Isayama');
insert into auteur values
(4,'Alex', 'Alice');
insert into auteur values
(5,'Smith', 'Jeff');
insert into auteur values
(6,'Lemire', 'Jeff');
insert into auteur values
(7,'Hopeless', 'Dennis');
insert into auteur values
(8,'Ibáñez', 'Victor');
insert into auteur values
(9,'Naoshi', 'Arakawa');
insert into auteur values
(10,'Souillon','');


insert into genre values
(1, 'Contemporain');
insert into genre values
(2, 'Aventure');
insert into genre values
(3, 'Fantasy historique');
insert into genre values
(4, 'Action');
insert into genre values
(5, 'Dark Fantasy');
insert into genre values
(6, 'Horreur');
insert into genre values
(7, 'Science Fiction');
insert into genre values
(8, 'Humour');
insert into genre values
(9, 'Tranche de Vie');
insert into genre values
(10, 'Drame');
insert into genre values
(11, 'Romance');
insert into genre values
(12, 'Fantastique');


-- (id, img, titre, editeur, serie, categorie)
insert into album values
(1, 'https://static.fnac-static.com/multimedia/FR/Images_Produits/FR/fnac.com/Visual_Principal_340/8/3/2/9782811203238/tsp20120919192820/Precious-little-life.jpg', "Scott Pilgrim's Precious Little Life", 'Milady', 1, 1); 
insert into album values
(2, 'https://static.fnac-static.com/multimedia/FR/Images_Produits/FR/fnac.com/Visual_Principal_340/8/2/5/9782811203528/tsp20120919181839/Us-the-world.jpg', "Scott Pilgrim vs. the World", 'Milady', 1, 1);

insert into album values
(3, 'https://www.casterman.com/media/cache/couverture_large/casterman_img/Couvertures/9782203148444.jpg', "Adèle et la Bête", 'casterman', 2, 3);

insert into album values
(4, 'https://static.fnac-static.com/multimedia/Images/FR/NR/89/cf/4a/4902793/1540-1/tsp20131021170210/L-attaque-des-Titans.jpg', "Tome 1: L'attaque des Titans", 
'Pika Edition', 3, 2);

insert into album values
(5, 'https://static.fnac-static.com/multimedia/Images/FR/NR/3f/7c/5a/5930047/1540-1/tsp20200327070555/Le-chateau-des-etoiles-Tome-1-1-ere-partie.jpg', "1869 : La Conquête de l'espace Tome 1", 
'Rue De Sevres', 4, 3);
insert into album values
(6, 'https://static.fnac-static.com/multimedia/Images/FR/NR/f0/34/6e/7222512/1540-1/tsp20200327070555/Le-chateau-des-etoiles-Tome-2-2-eme-partie.jpg', "1869 : La Conquête de l'espace Tome 2", 
'Rue De Sevres', 4, 3);
insert into album values
(7, 'https://images.fr.shopping.rakuten.com/photo/chateau-des-etoiles-le-tome-3-les-chevaliers-de-mars-1333026144_ML.jpg', "Les Chevaliers de Mars", 
'Rue De Sevres', 4, 3);
-- Bone
insert into album values
(8, 'https://www.bdfugue.com/media/catalog/product/cache/1/image/400x/17f82f742ffe127f42dca9de82fb58b1/9/7/9782756006598_1_75.jpg', "La Forêt sans retour", 
'Delcourt', 5, 1);
-- X Men
insert into album values
(9, 'https://static.fnac-static.com/multimedia/Images/FR/NR/dd/cd/84/8703453/1540-1/tsp20170607120522/X-Men.jpg', "Tome 1", 
'Panini Comics', 6, 1);
insert into album values
(10, 'https://static.fnac-static.com/multimedia/Images/FR/NR/bc/5a/86/8805052/1540-1/tsp20170718170703/X-Men.jpg', "Tome 2", 
'Panini Comics', 6, 1);
-- Your lie in april
insert into album values
(11, 'https://static.fnac-static.com/multimedia/Images/FR/NR/52/4a/63/6507090/1540-1/tsp20150304150520/Your-lie-in-april.jpg', "Tome 1", 
'Ki-oon', 7, 2);
insert into album values
(12, 'https://static.fnac-static.com/multimedia/Images/FR/NR/53/4a/63/6507091/1540-1/tsp20150304150520/Your-lie-in-april.jpg', "Tome 2", 
'Ki-oon', 7, 2);
-- Maliki
insert into album values
(13, 'https://cdn1.ankama-shop.com/304-large_default/maliki-tome-1.jpg', "Broie la vie en rose", 
'Ankama Editions', 8, 3);
insert into album values
(14, 'https://static.fnac-static.com/multimedia/Images/FR/NR/b4/77/21/2193332/1540-1/tsp20171127094300/Maliki.jpg', "Une rose à l'amer", 
'Ankama Editions', 8, 3);
insert into album values
(15, 'https://static.fnac-static.com/multimedia/Images/FR/NR/c9/f7/27/2619337/1540-1/tsp20171127094253/Mots-roses-au-clair-de-lune.jpg', "Mots roses au clair de lune", 
'Ankama Editions', 8, 3);

-- (id genre, id album)
/*associe genre à album */
insert into album_genres values
(1,1);  -- Contemporain a pour album scott pilgrim PLL
insert into album_genres values
(1,2); -- Contemporain a pour album scott pilgrim VS the world
insert into album_genres values
(2,3);
insert into album_genres values
(3,3);
-- attaque des titans : action, horreur, dark fantasy
insert into album_genres values
(4,4);
insert into album_genres values
(5,4);
insert into album_genres values
(6,4);
-- Le chateau des étoiles
insert into album_genres values
(7,5);
insert into album_genres values
(7,6);
insert into album_genres values
(7,7);
-- Bone
insert into album_genres values
(8,8);
-- X Men
insert into album_genres values
(4,9); 
insert into album_genres values
(7,9); 
insert into album_genres values
(4,10); 
insert into album_genres values
(7,10);
-- You lie in april
insert into album_genres values
(9,11);
insert into album_genres values
(10,11);
insert into album_genres values
(11,11);
insert into album_genres values
(9,12);
insert into album_genres values
(10,12);
insert into album_genres values
(11,12);
-- Maliki
insert into album_genres values
(12,13);
insert into album_genres values
(12,14);
insert into album_genres values
(12,15);

-- id auteur id album
/* associe auteur à album*/
insert into album_auteurs values
(1,1); -- Bryan O'Maley est l'auteur de Scott Pilgrim PLL.
insert into album_auteurs values
(1,2);-- Bryan O'Maley est l'auteur de Scott Pilgrim VS The world.
-- Adele Blanc Sec
insert into album_auteurs values
(2,3);
-- L'attaque des titans
insert into album_auteurs values
(3,4);
-- Le chateau des étoiles
insert into album_auteurs values
(4,5);
insert into album_auteurs values
(4,6);
insert into album_auteurs values
(4,7);
-- Bone
insert into album_auteurs values
(5,8);
-- X Men
insert into album_auteurs values
(6,9);
insert into album_auteurs values
(7,9);
insert into album_auteurs values
(8,9);
insert into album_auteurs values
(6,10);
insert into album_auteurs values
(7,10);
insert into album_auteurs values
(8,10);
-- Your Lie in April
insert into album_auteurs values
(9,11);
insert into album_auteurs values
(9,12);
-- Maliki
insert into album_auteurs values
(10,13);
insert into album_auteurs values
(10,14);
insert into album_auteurs values
(10,15);

insert into administrateur values
(1, 'admin', 'admin');


insert into utilisateur values
(1, 'Doe', 'John', 'john002', 'monSuperMDP');




insert into album_souhaites values
(1, 2); -- John Doe veut le tome 2 de Scott Pilgrim
insert into album_souhaites values
(1, 3);-- John Doe veut le tome 1 de Adele Blanc Sec

insert into album_achetes values
(1, 1); -- John Doe a le tome 1 de Scott Pilgrim