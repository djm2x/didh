update Recommendations
set AnneeDisplay = 'de 2011', AnneeDisplayAr = 'مند 2011'
where annee = 2020;

update Recommendations
set AnneeDisplay = 'Avant  2011', AnneeDisplayAr = 'قبل 2011'
where annee = 2008;

alter table Questionnaires ADD 
IdAxe int  FOREIGN KEY (IdAxe) REFERENCES Axes(id),
IdSousAxe int  FOREIGN KEY (IdSousAxe) REFERENCES SousAxes(id)
;

--rememebre to make all filed in questionnaire optional
---

-- 1. Changer « توصية مستمرة» par «إنجاز مستمر » (recuperer le dernier version, apres faire update)
-- 2. Lister le tableau des organes de traités par ordre décroissant (par quelle champs)
-- ok 3. Changer la forme des tableaux pour qu’ils soient un peu lisible (y a un chevauchement au niveau des champs) 
-- 4. Ajouter un bouton « télécharger » au niveau des tableaux / des graphes.
-- ok 5. supprimer les champs « reporter » et « reporter ar » du formulaire d’ajout du questionnaire
