# OpenData

# CSharpOpenData

# Vocabulary :

* ### Property 
-> Semblable à une fusion entre un attribut et une méthode. En général elle contient 2 methodes, ses accesseurs, {get; set;}

* ### Deserialize
 -> Convertit une chaîne JSON en objet du type spécifié. (ex : ``` public object Deserialize (string input, Type targetType); ```)

* ### JSon (JavaScript Objet Notation)
 -> format de texte indépendant de tout langage. I permet l'échange de données textuelles. 

*  ### Inteface 
-> Une interface ne peut pas être instanciée directement. Ses membres sont implémentées par une classe ou un struct qui implémentent l'interface.
Une classe ou un struct peuvent implémenter plusieurs interfaces. Une classe peut hériter d'une classe de base et également implémenter une ou plusieurs interfaces.

*  ### Library dll 
-> Bibliothèque qui contient du code et des données qui peuvent être utilisés par plusieurs programmes en même temps.

* ### Nuget 
-> gestionnaire de paquets de la plate forme de développement Microsoft . NET. C'est un logiciel libre et open source principalement développé par Microsoft.

* ### using System... 
-> Les fichers System viennent du framework .NET à l'installation

*  ### Console. 
           *  Write() -> Ecrit la representation textuelle des objets en paramètres.
           *  WriteLine() -> Écrit la valeur de chaîne spécifiée en paramètre
           *  Read() -> Lit le caractère suivant du flux d'entrée standard.
          

* ### Framework.NET // Core.Net 
-> .NET Core peut être utilisé aussi bien sur Windows que sur Linux et OS X.
La conséquence de cette ouverture est le manque de support d’applications qui reposent sur des technologies Microsoft comme WPF, WinForms ou encore ASP.NET WebForms.

* ### [TestMethod()] 
-> Balise qui permet de marquer les methodes tests à executer par le programme

* ### Windows Presentation Foundation (WPF)
 ->  Infrastructure d’interface utilisateur qui permet de créer des applications de bureau clientes. WPF utilise le langage XAML (Extensible Application Markup Language) pour fournir un modèle déclaratif utilisé pour la programmation d’applications. Le Framework fait partie de .NET.

 * ### Modèle Model-View-ViewModel (MVVM) 
 -> _**La vue « sait » le modèle de vue et le modèle de vue « connaît » le modèle, mais le modèle n’est pas conscient du modèle de vue et le modèle de vue n’est pas conscient de la vue.**_
"Permet de séparer correctement la logique métier et de présentation d’une application à partir de son interface utilisateur. Permet de résoudre de nombreux problèmes de développement et peut rendre une application plus facile à tester, à gérer et à évoluer. "
 
![image info](https://docs.microsoft.com/fr-fr/xamarin/xamarin-forms/enterprise-application-patterns/mvvm-images/mvvm.png)

 * ### Relation entre Vue <-> Vue-Modèle <-> Modèle  

![image info](https://japf.developpez.com/tutoriels/dotnet/mvvm-pour-des-applications-wpf-bien-architecturees-et-testables/images/collaboration-designer-developper.png)

* ### Différence entre MVVM & MVC
-> MVC est un modèle architectural couramment utilisé pour développer des interfaces utilisateur qui divise une application en trois parties interconnectées appelées modèle, vue et contrôleur. MVVM est un modèle d'architecture logicielle qui facilite la séparation du développement des interfaces utilisateur graphiques du développement de la logique métier. C’est la différence conceptuelle entre MVC et MVVM.
