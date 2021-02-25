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