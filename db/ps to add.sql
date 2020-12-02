update recommendations
set annee=2020;


SET IDENTITY_INSERT visites ON 
insert into visites (Id,Mandat,MandatAr,Discours,Date,LienRapport,MiseOeuvrePiece,LienUpload) values(9, N'Groupe de travail sur les disparitions forcées ou involontaires', N'لفريق العامل المعني بحالات الاختفاء القسري أو غير الطوعي', N'', N'2020-12-01', N'', N'', N''),
(10, N'Rapporteur spécial sur le droit à l’éducation', N'المقرر الخاص المعني بالحق في التعليم', N'', N'2020-12-01', N'', N'', N''),
(11, N'Rapporteuse spéciale sur les droits de l’homme des migrants', N'المقرر الخاص المعني بحقوق الإنسان للمهاجرين', N'', N'2020-12-01', N'', N'', N''),
(12, N'Rapporteuse spéciale chargée d"étudier la question de la vente d"enfants, de la prostitution des enfants et de la pornographie impliquant des enfants', N'المقرر الخاص المعني بمسألة بيع الأطفال وبغاء الأطفال واستغلال الأطفال في المواد الإباحية', N'', N'2020-12-01', N'', N'', N'');
SET IDENTITY_INSERT visites OFF


