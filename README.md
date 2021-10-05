# Projet GLOG 2020
Projet de génie logiciel de deuxième année
Projet réalisé par Coline BINET et Alban PERRIER

L’objectif de ce projet est la réalisation d’une application de gestion de collection de BD.
Un rapport lié à ce projet a été rédigé et se situe sur ce dépôt.

# Notice d'installation
Pour installer notre application ainsi que sa base de données associées, vous devez   des logiciels suivants (ou leurs équivalents) : 
Visual Studio 2019
Xampp  
Une fois ces logiciels installés sur votre ordinateur, vous pouvez récupérer le code source de notre projet sur le lien github suivant (nécessite d’être connecté) : https://github.com/ensc-glog/projet-2020-coline-alban
À partir de ce lien, clonez le dépôt ou bien téléchargez le en ZIP (une extraction du dossier sera nécessaire dans ce cas).
Ensuite, ouvrez le fichier solution au format .sln : “projet-2020-coline-alban.sln” avec Visual Studio.
Puis lancez Xampp, et cliquez sur les boutons “start” des lignes correspondant à “Apache” et “MySQL”, après quelques secondes les deux modules devraient être de couleur verte.


Vous pouvez désormais normalement accéder à cette URL dans votre navigateur préféré : http://localhost/phpmyadmin/

Ensuite, sur la solution chargée sur Visual Studio, vous pouvez ouvrir le fichier “bdtheque_database.sql” contenu dans le dossier DAL/DB, copiez-en le contenu.
Retournez sur phpmyadmin (sur votre navigateur), et cliquez sur l’onglet en haut “SQL”. Collez le contenu du fichier sql copié, puis cliquez sur le bouton “Go” ou “Éxecuter” (selon la version de langue) en bas à droite. Vous venez de créer votre base de données.
Désormais, vous pouvez lancer le projet “Exporteur” dans la solution Visual Studio.

Cela devrait vous ouvrir une fenêtre de console en écrivant les scripts SQL créant la structure de la base de données, laissez le s’exécuter jusqu’à ce qu’il affiche le message “Done!”, vous indiquant que vous pouvez désormais fermer la console.
Maintenant, allez dans le fichier “bdtheque_data.sql” contenu dans le dossier DAL/DB et copié/collé en le contenu dans l’onglet SQL de phpmyadmin, une fois que vous aurez sélectionné la base de donnée nommée “bdtheque” dans le menu à gauche et ensuite l’onglet SQL en haut.


Vous venez de remplir votre base de données de contenu, maintenant vous pouvez utiliser l’application correctement.
Pour cela, il vous suffit de sélectionner le projet “App” dans Visual Studio et de le démarrer.


