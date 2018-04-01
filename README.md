# Service Oriented Computing Project
Auteur : David LANG


Lien du sujet : [http://www.tigli.fr/doku.php?id=cours:ws-rest_and_ws-soap:lab](http://www.tigli.fr/doku.php?id=cours:ws-rest_and_ws-soap:lab).

## Extensions réalisées
* Monitoring
* Client graphique
* Cache du côté serveur pour minimiser les interactions avec l'api [jcdecaux](https://developer.jcdecaux.com/#/opendata/vls?page=getstarted)


## Lancements des solutions

Toutes les solutions doivent être lancées avec Visual Studio.
Le serveur doit être lancé dans Visual Studio avec les droits administrateur.

## Instruction pour tester le projet

### Lancer le serveur
Lancer le serveur se trouvant dans le dossier server avec Visual Studio. Visual Studio doit être lancé avec les droits adminstrateur !

### Lancer le client console
Lancer le client console se trouvant dans le dossier client-console. Trois commandes sont disponibles :
* city : pour selectionner une ville
* station : pour lister les stations de la ville courrante puis selectionner une station afin d'afficher les informations de celle-ci.
* exit : pour quitter l'invité de commande

### Lancer le client graphique
Lancer le client graphique se trouvant dans le dossier client. Deux listes selectionnables sont à disposition pour choisir la ville et la station. Il suffit de cliquer sur le bouton "récupérer les information" pour effectuer la requête sur le serveur.

### Lancer le client monitoring
Lancer le client monitoring se trouvant dans le dossier client-monitoring. Selectionner les deux dates voulues puis cliquer sur le bouton actualiser pour afficher les informations de monitoring. Attention, il y a problème sur les dates (je n'ai pas réussi à le résoudre), il faut selectionner un interval de temps plus large d'un jour pour obtenir les résultats.  

