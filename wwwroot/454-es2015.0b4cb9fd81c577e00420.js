(self.webpackChunkmy_app=self.webpackChunkmy_app||[]).push([[454],{47454:function(t,e,i){"use strict";i.r(e),i.d(e,{VisiteModule:function(){return Pt}});var n=i(97866),o=i(61116),a=i(64762),s=i(18314),r=i(35366),l=i(5609),c=i(59241),m=i(55959),d=i(31906),u=i(92935),p=i(31041),g=i(92572),h=i(37112),f=i(36278),Z=i(13070),x=i(9550),b=i(69024),A=i(68085),_=i(84369),T=i(60649);let v=(()=>{class t{constructor(t,e,i,n){this.dialogRef=t,this.data=e,this.fb=i,this.uow=n,this.title="",this.folderToSaveInServer="visite",this.lienUploadTo=new m.xQ,this.lienUploadFrom=new m.xQ,this.discoursTo=new m.xQ,this.discoursFrom=new m.xQ,this.miseOeuvrePieceTo=new m.xQ,this.miseOeuvrePieceFrom=new m.xQ,this.commentaireTo=new m.xQ,this.commentaireFrom=new m.xQ,this.eventSubmitFromParent=new m.xQ}ngOnInit(){this.o=this.data.model,this.title=this.data.title,this.createForm(),this.discoursFrom.subscribe(t=>this.myForm.get("discours").setValue(t)),this.lienUploadFrom.subscribe(t=>this.myForm.get("lienUpload").setValue(t)),this.miseOeuvrePieceFrom.subscribe(t=>this.myForm.get("miseOeuvrePiece").setValue(t)),this.commentaireFrom.subscribe(t=>this.myForm.get("commentaire").setValue(t)),setTimeout(()=>{this.miseOeuvrePieceTo.next(this.o.miseOeuvrePiece),this.lienUploadTo.next(this.o.lienUpload),this.discoursTo.next(this.o.discours),this.commentaireTo.next(this.o.commentaire)},100)}createForm(){this.myForm=this.fb.group({id:this.o.id,mandat:[this.o.mandat,p.kI.required],mandatAr:[this.o.mandatAr,p.kI.required],abr:[this.o.abr],abrAr:[this.o.abrAr],discours:[this.o.discours],date:[this.o.date,p.kI.required],lienRapport:[this.o.lienRapport],lienUpload:[this.o.lienUpload],miseOeuvrePiece:[this.o.miseOeuvrePiece],commentaire:[this.o.commentaire]})}onNoClick(){this.dialogRef.close()}onOkClick(t){this.submit(t)}submit(t){t.date=this.uow.valideDate(t.date),0===this.o.id?this.uow.visites.post(t).subscribe(t=>(0,a.mG)(this,void 0,void 0,function*(){this.eventSubmitFromParent.next(!0),this.dialogRef.close(!0)})):this.uow.visites.put(t.id,t).subscribe(t=>(0,a.mG)(this,void 0,void 0,function*(){this.eventSubmitFromParent.next(!0),this.dialogRef.close(!0)}))}resetForm(){this.o=new s.zY,this.createForm()}}return t.\u0275fac=function(e){return new(e||t)(r.Y36(u.so),r.Y36(u.WI),r.Y36(p.qu),r.Y36(g.Z))},t.\u0275cmp=r.Xpm({type:t,selectors:[["app-update"]],decls:63,vars:60,consts:[[1,"dialog"],["mat-dialog-title",""],["role","toolbar",1,"task-header"],[1,"content"],["mat-dialog-content",""],[3,"formGroup"],["appearance","fill"],["matInput","","formControlName","mandat","required",""],["matInput","","formControlName","mandatAr","required",""],["matInput","","formControlName","abr","required",""],["matInput","","formControlName","abrAr","required",""],["matInput","","formControlName","discours","placeholder","Discours du pr\xe9sident"],["matInput","","formControlName","date",3,"matDatepicker"],["matSuffix","",3,"for"],["picker",""],[3,"nameBtn","folderToSaveInServer","propertyOfParent","eventSubmitToParent","eventSubmitFromParent"],["matInput","","formControlName","lienRapport"],["mat-dialog-actions","",1,"actions"],["mat-button","","type","button",3,"click"],["mat-raised-button","","cdkFocusInitial","","color","primary",3,"disabled","click"]],template:function(t,e){if(1&t&&(r.TgZ(0,"div",0),r.TgZ(1,"h1",1),r.TgZ(2,"mat-toolbar",2),r.TgZ(3,"span"),r._uU(4),r.qZA(),r.qZA(),r._UZ(5,"mat-divider"),r.qZA(),r.TgZ(6,"div",3),r.TgZ(7,"div",4),r.TgZ(8,"form",5),r.TgZ(9,"mat-form-field",6),r.TgZ(10,"mat-label"),r._uU(11),r.ALo(12,"translate"),r.qZA(),r._UZ(13,"input",7),r.qZA(),r.TgZ(14,"mat-form-field",6),r.TgZ(15,"mat-label"),r._uU(16),r.ALo(17,"translate"),r.qZA(),r._UZ(18,"input",8),r.qZA(),r.TgZ(19,"mat-form-field",6),r.TgZ(20,"mat-label"),r._uU(21),r.ALo(22,"translate"),r.qZA(),r._UZ(23,"input",9),r.qZA(),r.TgZ(24,"mat-form-field",6),r.TgZ(25,"mat-label"),r._uU(26),r.ALo(27,"translate"),r.qZA(),r._UZ(28,"input",10),r.qZA(),r.TgZ(29,"mat-form-field",6),r.TgZ(30,"mat-label"),r._uU(31),r.ALo(32,"translate"),r.qZA(),r._UZ(33,"textarea",11),r.qZA(),r.TgZ(34,"mat-form-field",6),r.TgZ(35,"mat-label"),r._uU(36),r.ALo(37,"translate"),r.qZA(),r._UZ(38,"input",12),r._UZ(39,"mat-datepicker-toggle",13),r._UZ(40,"mat-datepicker",null,14),r.qZA(),r._UZ(42,"app-upload-select",15),r.ALo(43,"translate"),r._UZ(44,"app-upload-select",15),r.ALo(45,"translate"),r._UZ(46,"app-upload-select",15),r.ALo(47,"translate"),r._UZ(48,"app-upload-select",15),r.ALo(49,"translate"),r.TgZ(50,"mat-form-field",6),r.TgZ(51,"mat-label"),r._uU(52),r.ALo(53,"translate"),r.qZA(),r._UZ(54,"input",16),r.qZA(),r.qZA(),r.qZA(),r.TgZ(55,"div",17),r.TgZ(56,"button",18),r.NdJ("click",function(){return e.onNoClick()}),r._uU(57),r.ALo(58,"translate"),r.qZA(),r._uU(59,"\xa0\xa0 "),r.TgZ(60,"button",19),r.NdJ("click",function(){return e.onOkClick(e.myForm.value)}),r._uU(61),r.ALo(62,"translate"),r.qZA(),r.qZA(),r.qZA(),r.qZA()),2&t){const t=r.MAs(41);r.xp6(4),r.Oqu(e.title),r.xp6(4),r.Q6J("formGroup",e.myForm),r.xp6(3),r.Oqu(r.lcZ(12,34,"admin.ps.update.Mandat")),r.xp6(5),r.Oqu(r.lcZ(17,36,"admin.ps.update.MandatAr")),r.xp6(5),r.Oqu(r.lcZ(22,38,"Abr\xe9viation")),r.xp6(5),r.Oqu(r.lcZ(27,40,"Abr\xe9viation arab")),r.xp6(5),r.Oqu(r.lcZ(32,42,"admin.ps.update.Discours_du_pr\xe9sident")),r.xp6(5),r.Oqu(r.lcZ(37,44,"admin.ps.update.Date_pr\xe9vue")),r.xp6(2),r.Q6J("matDatepicker",t),r.xp6(1),r.Q6J("for",t),r.xp6(3),r.s9C("nameBtn",r.lcZ(43,46,"admin.ps.update.RAPPORT_NATIONAL_DE_LA_VISITE")),r.Q6J("folderToSaveInServer",e.folderToSaveInServer)("propertyOfParent",e.lienUploadTo)("eventSubmitToParent",e.lienUploadFrom)("eventSubmitFromParent",e.eventSubmitFromParent),r.xp6(2),r.s9C("nameBtn",r.lcZ(45,48,"admin.ps.update.RAPPORT_DE_LA_PROCEDURE_REACTION_NATIONALE")),r.Q6J("folderToSaveInServer",e.folderToSaveInServer)("propertyOfParent",e.discoursTo)("eventSubmitToParent",e.discoursFrom)("eventSubmitFromParent",e.eventSubmitFromParent),r.xp6(2),r.s9C("nameBtn",r.lcZ(47,50,"admin.ps.update.PLAN_DE_MISE_EN_OEUVRE")),r.Q6J("folderToSaveInServer",e.folderToSaveInServer)("propertyOfParent",e.miseOeuvrePieceTo)("eventSubmitToParent",e.miseOeuvrePieceFrom)("eventSubmitFromParent",e.eventSubmitFromParent),r.xp6(2),r.s9C("nameBtn",r.lcZ(49,52,"admin.ps.commentaire")),r.Q6J("folderToSaveInServer",e.folderToSaveInServer)("propertyOfParent",e.commentaireTo)("eventSubmitToParent",e.commentaireFrom)("eventSubmitFromParent",e.eventSubmitFromParent),r.xp6(4),r.Oqu(r.lcZ(53,54,"admin.ps.update.Lien_externe")),r.xp6(5),r.Oqu(r.lcZ(58,56,"admin.Retour")),r.xp6(3),r.Q6J("disabled",e.myForm.invalid),r.xp6(1),r.Oqu(r.lcZ(62,58,"admin.Enregistre"))}},directives:[u.uh,h.Ye,f.d,u.xY,p._Y,p.JL,p.sg,Z.KE,Z.hX,x.Nt,p.Fj,p.JJ,p.u,p.Q7,b.hl,b.nW,Z.R9,b.Mq,A.k,u.H8,_.lW],pipes:[T.X$],styles:["mat-form-field[_ngcontent-%COMP%]{width:100%}.dialog[_ngcontent-%COMP%]{overflow-x:hidden;overflow-y:hidden}.dialog[_ngcontent-%COMP%]   h1[_ngcontent-%COMP%]   span[_ngcontent-%COMP%]{padding:0 5px}.dialog[_ngcontent-%COMP%]   .content[_ngcontent-%COMP%]{padding:0 20px 25px}.dialog[_ngcontent-%COMP%]   .actions[_ngcontent-%COMP%]{display:flex;flex-direction:row-reverse}.myrow[_ngcontent-%COMP%]{display:flex;align-items:center}img[_ngcontent-%COMP%]{height:20px}"]}),t})(),O=(()=>{class t{constructor(t,e){this.dialogRef=t,this.data=e,this.title=""}ngOnInit(){this.o=this.data.model,this.title=this.data.title}onNoClick(){this.dialogRef.close()}onOkClick(t){}}return t.\u0275fac=function(e){return new(e||t)(r.Y36(u.so),r.Y36(u.WI))},t.\u0275cmp=r.Xpm({type:t,selectors:[["app-update"]],decls:17,vars:6,consts:[[1,"dialog"],["mat-dialog-title",""],["role","toolbar",1,"task-header"],[1,"content"],["mat-dialog-content",""],["mat-dialog-actions","",1,"actions"],["mat-button","","type","button",3,"click"]],template:function(t,e){1&t&&(r.TgZ(0,"div",0),r.TgZ(1,"h1",1),r.TgZ(2,"mat-toolbar",2),r.TgZ(3,"span"),r._uU(4),r.qZA(),r.qZA(),r._UZ(5,"mat-divider"),r.qZA(),r.TgZ(6,"div",3),r.TgZ(7,"div",4),r.TgZ(8,"ul"),r.TgZ(9,"li"),r._uU(10),r.qZA(),r.TgZ(11,"li"),r._uU(12),r.ALo(13,"date"),r.qZA(),r.qZA(),r.qZA(),r.TgZ(14,"div",5),r.TgZ(15,"button",6),r.NdJ("click",function(){return e.onNoClick()}),r._uU(16,"Retour"),r.qZA(),r.qZA(),r.qZA(),r.qZA()),2&t&&(r.xp6(4),r.Oqu(e.title),r.xp6(6),r.hij("Objet: ",e.o.mandat,""),r.xp6(2),r.hij("Date pr\xe9vu: ",r.xi3(13,3,e.o.date,"dd/MM/yyyy"),""))},directives:[u.uh,h.Ye,f.d,u.xY,u.H8,_.lW],pipes:[o.uU],styles:["mat-form-field[_ngcontent-%COMP%]{width:100%}.dialog[_ngcontent-%COMP%]{overflow-x:hidden;overflow-y:hidden}.dialog[_ngcontent-%COMP%]   h1[_ngcontent-%COMP%]   span[_ngcontent-%COMP%]{padding:0 5px}.dialog[_ngcontent-%COMP%]   .content[_ngcontent-%COMP%]{padding:0 20px 25px}.dialog[_ngcontent-%COMP%]   .actions[_ngcontent-%COMP%]{display:flex;flex-direction:row-reverse}.myrow[_ngcontent-%COMP%]{display:flex;align-items:center}"]}),t})();var P=i(85078),w=i(87064);function C(t,e){if(1&t){const t=r.EpF();r.TgZ(0,"mat-list-item",12),r.NdJ("click",function(){const e=r.CHM(t).$implicit;return r.oxw().download(e.substring(0,e.length-1))}),r.TgZ(1,"span",13),r._uU(2),r.qZA(),r.qZA()}if(2&t){const t=e.$implicit;r.xp6(2),r.hij("- ",t.substring(14,t.length-1),"")}}function q(t,e){if(1&t){const t=r.EpF();r.TgZ(0,"mat-list-item",12),r.NdJ("click",function(){const e=r.CHM(t).$implicit;return r.oxw().download(e.substring(0,e.length-1))}),r.TgZ(1,"span",13),r._uU(2),r.qZA(),r.qZA()}if(2&t){const t=e.$implicit;r.xp6(2),r.hij("- ",t.substring(14,t.length-1),"")}}function y(t,e){if(1&t){const t=r.EpF();r.TgZ(0,"mat-list-item",12),r.NdJ("click",function(){const e=r.CHM(t).$implicit;return r.oxw().download(e.substring(0,e.length-1))}),r.TgZ(1,"span",13),r._uU(2),r.qZA(),r.qZA()}if(2&t){const t=e.$implicit;r.xp6(2),r.hij("- ",t.substring(14,t.length-1),"")}}function M(t,e){if(1&t){const t=r.EpF();r.TgZ(0,"mat-list-item",12),r.NdJ("click",function(){const e=r.CHM(t).$implicit;return r.oxw().download(e.substring(0,e.length-1))}),r.TgZ(1,"span",13),r._uU(2),r.qZA(),r.qZA()}if(2&t){const t=e.$implicit;r.xp6(2),r.hij("- ",t.substring(14,t.length-1),"")}}let U=(()=>{class t{constructor(t,e,i){this.dialogRef=t,this.data=e,this.url=i,this.title="",this.folder="organe"}ngOnInit(){this.o=this.data.model,this.title=this.data.title}propertyToList(t){if(t){const e=t.split(";");return e.pop(),e}return[]}download(t){window.open(`${this.url}/${this.folder}/${t}`)}}return t.\u0275fac=function(e){return new(e||t)(r.Y36(u.so),r.Y36(u.WI),r.Y36("BASE_URL"))},t.\u0275cmp=r.Xpm({type:t,selectors:[["app-archive"]],decls:33,vars:8,consts:[[1,"dialog"],["mat-dialog-title",""],["role","toolbar",1,"task-header"],[1,"content"],["mat-dialog-content",""],[1,"row"],[1,"col"],[2,"font-weight","bold"],["role","list"],["matRipple","","style","cursor: pointer;",3,"click",4,"ngFor","ngForOf"],["mat-dialog-actions","",1,"actions"],["mat-button","","type","button",3,"click"],["matRipple","",2,"cursor","pointer",3,"click"],[2,"font-size",".9em"]],template:function(t,e){1&t&&(r.TgZ(0,"div",0),r.TgZ(1,"h1",1),r.TgZ(2,"mat-toolbar",2),r.TgZ(3,"span"),r._uU(4),r.qZA(),r.qZA(),r._UZ(5,"mat-divider"),r.qZA(),r.TgZ(6,"div",3),r.TgZ(7,"div",4),r.TgZ(8,"div",5),r.TgZ(9,"div",6),r.TgZ(10,"p",7),r._uU(11,"Rapport"),r.qZA(),r.TgZ(12,"mat-list",8),r.YNc(13,C,3,1,"mat-list-item",9),r.qZA(),r.qZA(),r.TgZ(14,"div",6),r.TgZ(15,"p",7),r._uU(16,"Discours du pr\xe9sident"),r.qZA(),r.TgZ(17,"mat-list",8),r.YNc(18,q,3,1,"mat-list-item",9),r.qZA(),r.qZA(),r.TgZ(19,"div",6),r.TgZ(20,"p",7),r._uU(21,"Plan de mise en \u0153uvre"),r.qZA(),r.TgZ(22,"mat-list",8),r.YNc(23,y,3,1,"mat-list-item",9),r.qZA(),r.qZA(),r.TgZ(24,"div",6),r.TgZ(25,"p",7),r._uU(26),r.ALo(27,"translate"),r.qZA(),r.TgZ(28,"mat-list",8),r.YNc(29,M,3,1,"mat-list-item",9),r.qZA(),r.qZA(),r.qZA(),r.qZA(),r.TgZ(30,"div",10),r.TgZ(31,"button",11),r.NdJ("click",function(){return e.dialogRef.close()}),r._uU(32,"Retour"),r.qZA(),r.qZA(),r.qZA(),r.qZA()),2&t&&(r.xp6(4),r.Oqu(e.title),r.xp6(9),r.Q6J("ngForOf",e.propertyToList(e.o.lienUpload)),r.xp6(5),r.Q6J("ngForOf",e.propertyToList(e.o.discours)),r.xp6(5),r.Q6J("ngForOf",e.propertyToList(e.o.miseOeuvrePiece)),r.xp6(3),r.Oqu(r.lcZ(27,6,"admin.ps.commentaire")),r.xp6(3),r.Q6J("ngForOf",e.propertyToList(e.o.commentaire)))},directives:[u.uh,h.Ye,f.d,u.xY,P.i$,o.sg,u.H8,_.lW,P.Tg,w.wG],pipes:[T.X$],styles:["mat-form-field[_ngcontent-%COMP%]{width:100%}.dialog[_ngcontent-%COMP%]{overflow-x:hidden;overflow-y:hidden}.dialog[_ngcontent-%COMP%]   h1[_ngcontent-%COMP%]   span[_ngcontent-%COMP%]{padding:0 5px}.dialog[_ngcontent-%COMP%]   .content[_ngcontent-%COMP%]{padding:0 20px 25px}.dialog[_ngcontent-%COMP%]   .actions[_ngcontent-%COMP%]{display:flex;flex-direction:row-reverse}.myrow[_ngcontent-%COMP%]{display:flex;align-items:center}img[_ngcontent-%COMP%]{height:20px}"]}),t})();var N=i(12996),D=i(56238),S=i(94589),R=i(34411),k=i(63337),F=i(50545),I=i(31496),J=i(20707),L=i(3942),Q=i(75163),E=i(3017),Y=i(16056),B=i(47340),$=i(77307),H=i(87672),z=i(24311);function j(t,e){if(1&t){const t=r.EpF();r.TgZ(0,"div",26),r.TgZ(1,"button",27),r.NdJ("click",function(){return r.CHM(t),r.oxw().add()}),r.TgZ(2,"mat-icon"),r._uU(3,"add"),r.qZA(),r._uU(4),r.ALo(5,"translate"),r.qZA(),r.qZA()}2&t&&(r.xp6(4),r.hij(" ",r.lcZ(5,1,"admin.ps.Proc\xe9dure_sp\xe9ciale")," "))}function V(t,e){1&t&&r._UZ(0,"mat-spinner")}function G(t,e){if(1&t&&(r.TgZ(0,"div",28),r.YNc(1,V,1,0,"mat-spinner",29),r.qZA()),2&t){const t=r.oxw();r.xp6(1),r.Q6J("ngIf",t.isLoadingResults)}}function W(t,e){1&t&&(r.TgZ(0,"th",30),r._uU(1),r.ALo(2,"translate"),r.qZA()),2&t&&(r.xp6(1),r.Oqu(r.lcZ(2,1,"admin.ps.list.MANDAT")))}function X(t,e){if(1&t&&(r.TgZ(0,"td",31),r._uU(1),r.qZA()),2&t){const t=e.$implicit,i=r.oxw();r.xp6(1),r.Oqu("fr"===i.mytranslate.langSync?t.mandat:t.mandatAr)}}function K(t,e){1&t&&(r.TgZ(0,"th",30),r._uU(1),r.ALo(2,"translate"),r.qZA()),2&t&&(r.xp6(1),r.Oqu(r.lcZ(2,1,"admin.ps.list.Date_de_la_visite")))}function tt(t,e){if(1&t&&(r.TgZ(0,"td",31),r._uU(1),r.ALo(2,"date"),r.qZA()),2&t){const t=e.$implicit,i=r.oxw();r.xp6(1),r.Oqu(r.xi3(2,1,t[i.columnDefs[1].columnDef],"dd/MM/yyyy"))}}function et(t,e){1&t&&(r.TgZ(0,"th",32),r._uU(1),r.ALo(2,"translate"),r.qZA()),2&t&&(r.xp6(1),r.hij(" ",r.lcZ(2,1,"admin.ps.list.RAPPORT_DE_LA_PROCEDURE_REACTION_NATIONALE"),""))}function it(t,e){if(1&t){const t=r.EpF();r.TgZ(0,"td",31),r.TgZ(1,"button",33),r.NdJ("click",function(){const e=r.CHM(t).$implicit;return r.oxw().showPieceJoin(e.discours)}),r.TgZ(2,"mat-icon"),r._uU(3,"cloud_download"),r.qZA(),r.qZA(),r.qZA()}if(2&t){const t=e.$implicit,i=r.oxw();r.xp6(1),r.Q6J("disabled",i.disable(t.discours))("matTooltip",t.discours)}}function nt(t,e){1&t&&(r.TgZ(0,"th",32),r._uU(1),r.ALo(2,"translate"),r.qZA()),2&t&&(r.xp6(1),r.Oqu(r.lcZ(2,1,"admin.ps.list.PLAN_DE_MISE_EN_OEUVRE")))}function ot(t,e){if(1&t){const t=r.EpF();r.TgZ(0,"td",31),r.TgZ(1,"button",34),r.NdJ("click",function(){const e=r.CHM(t).$implicit;return r.oxw().showPieceJoin(e.miseOeuvrePiece)}),r.TgZ(2,"mat-icon"),r._uU(3,"cloud_download"),r.qZA(),r.qZA(),r.qZA()}if(2&t){const t=e.$implicit,i=r.oxw();r.xp6(1),r.Q6J("disabled",i.disable(t.miseOeuvrePiece))("matTooltip",t.miseOeuvrePiece)}}function at(t,e){1&t&&(r.TgZ(0,"th",32),r._uU(1),r.ALo(2,"translate"),r.qZA()),2&t&&(r.xp6(1),r.Oqu(r.lcZ(2,1,"admin.ps.list.RAPPORT_NATIONAL_DE_LA_VISITE")))}function st(t,e){if(1&t){const t=r.EpF();r.TgZ(0,"td",31),r.TgZ(1,"button",33),r.NdJ("click",function(){const e=r.CHM(t).$implicit;return r.oxw().showPieceJoin(e.lienUpload)}),r.TgZ(2,"mat-icon"),r._uU(3,"cloud_download"),r.qZA(),r.qZA(),r.qZA()}if(2&t){const t=e.$implicit,i=r.oxw();r.xp6(1),r.Q6J("disabled",i.disable(t.lienUpload))("matTooltip",t.lienUpload)}}function rt(t,e){1&t&&(r.TgZ(0,"th",32),r._uU(1),r.ALo(2,"translate"),r.qZA()),2&t&&(r.xp6(1),r.Oqu(r.lcZ(2,1,"admin.ps.commentaire")))}function lt(t,e){if(1&t){const t=r.EpF();r.TgZ(0,"td",31),r.TgZ(1,"button",33),r.NdJ("click",function(){const e=r.CHM(t).$implicit;return r.oxw().showPieceJoin(e.commentaire)}),r.TgZ(2,"mat-icon"),r._uU(3,"cloud_download"),r.qZA(),r.qZA(),r.qZA()}if(2&t){const t=e.$implicit,i=r.oxw();r.xp6(1),r.Q6J("disabled",i.disable(t.commentaire))("matTooltip",t.commentaire)}}function ct(t,e){1&t&&r._UZ(0,"th",32)}function mt(t,e){if(1&t){const t=r.EpF();r.TgZ(0,"button",40),r.NdJ("click",function(){r.CHM(t);const e=r.oxw(2).$implicit;return r.oxw().edit(e)}),r.TgZ(1,"mat-icon"),r._uU(2,"create"),r.qZA(),r.qZA()}}function dt(t,e){if(1&t){const t=r.EpF();r.TgZ(0,"button",41),r.NdJ("click",function(){r.CHM(t);const e=r.oxw(2).$implicit;return r.oxw().archive(e)}),r.TgZ(1,"mat-icon"),r._uU(2,"unarchive"),r.qZA(),r.qZA()}}function ut(t,e){if(1&t){const t=r.EpF();r.TgZ(0,"button",42),r.NdJ("click",function(){r.CHM(t);const e=r.oxw(2).$implicit;return r.oxw().delete(e)}),r.TgZ(1,"mat-icon"),r._uU(2,"delete_sweep"),r.qZA(),r.qZA()}}function pt(t,e){if(1&t&&(r.TgZ(0,"div",36),r.YNc(1,mt,3,0,"button",37),r.YNc(2,dt,3,0,"button",38),r.YNc(3,ut,3,0,"button",39),r.qZA()),2&t){const t=r.oxw(2);r.xp6(1),r.Q6J("ngIf",!t.session.isPointFocal&&!t.session.isSuperViseur),r.xp6(1),r.Q6J("ngIf",!t.session.isPointFocal&&!t.session.isSuperViseur),r.xp6(1),r.Q6J("ngIf",!t.session.isPointFocal&&!t.session.isSuperViseur)}}function gt(t,e){if(1&t&&(r.TgZ(0,"td",31),r.YNc(1,pt,4,3,"div",35),r.qZA()),2&t){const t=r.oxw();r.xp6(1),r.Q6J("ngIf",!t.session.isPublic)}}function ht(t,e){1&t&&r._UZ(0,"tr",43)}function ft(t,e){1&t&&r._UZ(0,"tr",44)}const Zt=function(){return[10,25,50,100,250]},xt=[{path:"",redirectTo:"list",pathMatch:"full"},{path:"list",component:(()=>{class t{constructor(t,e,i,n,o,a,s,l){this.uow=t,this.dialog=e,this.mydialog=i,this.bottomSheet=n,this.url=o,this.route=a,this.session=s,this.mytranslate=l,this.update=new r.vpe,this.isLoadingResults=!0,this.resultsLength=0,this.isRateLimitReached=!1,this.dataSource=[],this.columnDefs=[{columnDef:"mandat",headName:"MANDAT"},{columnDef:"date",headName:"Date de la visite"},{columnDef:"lienUpload",headName:"RAPPORT NATIONAL DE LA VISITE"},{columnDef:"discours",headName:"RAPPORT DE LA PROCEDURE/REACTION NATIONALE"},{columnDef:"miseOeuvrePiece",headName:"PLAN DE MISE EN OEUVRE"},{columnDef:"commentaire",headName:"commentaire"},{columnDef:"option",headName:"OPTION"}].map(t=>(t.headName=""===t.headName?t.columnDef.toUpperCase():t.headName.toUpperCase(),t)),this.displayedColumns=this.columnDefs.filter(t=>"discours"!==t.columnDef&&"miseOeuvrePiece"!==t.columnDef).map(t=>t.columnDef),this.progress=0,this.formData=new FormData,this.text="",this.text2=this.text.substring(0,600),this.countRec=new m.xQ,this.mecanismeState=new m.xQ,this.stateByMecanisme=new m.xQ,this.stateDetailByMecanisme=new m.xQ}ngOnInit(){(0,d.T)(this.sort.sortChange,this.paginator.page,this.update).pipe((0,D.O)(null)).subscribe(t=>{!0===t?this.paginator.pageIndex=0:t=t,this.paginator.pageSize?t=t:this.paginator.pageSize=10;const e=this.paginator.pageIndex*this.paginator.pageSize;this.isLoadingResults=!0,this.getPage(e,this.paginator.pageSize,this.sort.active?this.sort.active:"id",this.sort.direction?this.sort.direction:"desc")}),this.route.queryParams.subscribe(t=>{const e=t.data;e&&this.uow.visites.getOne(e).subscribe(t=>{this.openDialogDetail(t)})}),this.getMecanismeState(),this.getStateByMecanisme(),this.getStateDetailByMecanisme(),this.uow.recommendations.mecanismeCount("visite").subscribe(t=>this.countRec.next(t))}disable(t){return!t||""===t}openDialogDetail(t){return this.dialog.open(O,{width:"7100px",disableClose:!0,data:{model:t,title:"Visite"}}).afterClosed()}moreInfo(){this.text2=600===this.text2.length?this.text:this.text.substring(0,600)}getPage(t,e,i,n){this.uow.visites.getList(t,e,i,n).subscribe(t=>{this.dataSource=t.list,this.resultsLength=t.count,this.isLoadingResults=!1})}openDialog(t,e){return this.dialog.open(v,{width:"7100px",disableClose:!0,data:{model:t,title:e}}).afterClosed()}add(){this.openDialog(new s.zY,this.mytranslate.get("admin.ps.list.Ajouter_Proc\xe9dure_sp\xe9ciale")).subscribe(t=>{t&&this.update.next(!0)})}archive(t){this.dialog.open(U,{width:"80vw",disableClose:!0,data:{model:t,title:t.mandat}})}edit(t){this.openDialog(t,this.mytranslate.get("admin.ps.list.Modifier_Proc\xe9dure_sp\xe9ciale")).subscribe(t=>{t&&this.update.next(!0)})}delete(t){return(0,a.mG)(this,void 0,void 0,function*(){if("ok"===(yield this.mydialog.openDialog("Proc\xe9dure sp\xe9ciale").toPromise())){let e=[];""!==t.lienUpload?e.push(...this.uow.decoupe(t.lienUpload)):e=e,""!==t.discours?e.push(...this.uow.decoupe(t.discours)):e=e,this.uow.files.deleteFiles(e,"visite").subscribe(e=>{this.uow.examens.delete(t.id).subscribe(()=>this.update.next(!0))})}})}showPieceJoin(t){this.bottomSheet.open(N.x,{data:{fileName:t,folder:"visite"}})}getMecanismeState(){this.uow.visites.mecanismeState().subscribe(t=>{const e=[];e.push(this.mytranslate.get("R\xe9alis\xe9")),e.push(this.mytranslate.get("NonR\xe9alis\xe9")),e.push(this.mytranslate.get("EnCours")),e.push(this.mytranslate.get("Recommendation_continue"));const i=[],n=[];i.push(100*t.four/t.total),i.push(100*t.one/t.total),i.push(100*t.two/t.total),i.push(100*t.three/t.total),n.push(t.one,t.two,t.three,t.four),this.mecanismeState.next({chartLabels:e,chartData:i,chartColors:["#2b960b","#db0707","#f7801e","#2d71a1","#ffffff"],dataToShowInTable:n,title:this.mytranslate.get("admin.header.Etat de mise en \u0153uvre")})})}getStateByMecanisme(){this.uow.visites.stateByMecanisme().subscribe(t=>{const e=t.map(t=>t.name),i=t.map(t=>+t.one.toFixed(0));this.stateByMecanisme.next({chartLabels:e,chartData:i,chartColors:[],dataToShowInTable:[],title:this.mytranslate.get("admin.ps.list.Tauxderecommandationsparvisite")})})}getStateDetailByMecanisme(){this.uow.visites.stateDetailByMecanisme().subscribe(t=>{const e=(t=t.filter(t=>null!==t.name)).map(t=>t.name),i=[{data:t.map(t=>+(100*t.four/t.total).toFixed(0)),label:this.mytranslate.get("R\xe9alis\xe9")},{data:t.map(t=>+(100*t.three/t.total).toFixed(0)),label:this.mytranslate.get("Recommendation_continue")},{data:t.map(t=>+(100*t.two/t.total).toFixed(0)),label:this.mytranslate.get("EnCours")},{data:t.map(t=>+(100*t.one/t.total).toFixed(0)),label:this.mytranslate.get("NonR\xe9alis\xe9")}];this.stateDetailByMecanisme.next({barChartLabels:e,barChartData:i,title:this.mytranslate.get("admin.ps.list.Mise en \u0153uvre des recommandations par Proc\xe9dure sp\xe9ciale")})})}}return t.\u0275fac=function(e){return new(e||t)(r.Y36(g.Z),r.Y36(u.uw),r.Y36(S.b),r.Y36(R.ch),r.Y36("BASE_URL"),r.Y36(k.gz),r.Y36(F.m),r.Y36(I.n))},t.\u0275cmp=r.Xpm({type:t,selectors:[["app-visite"]],viewQuery:function(t,e){if(1&t&&(r.Gf(l.NW,7),r.Gf(c.YE,7)),2&t){let t;r.iGM(t=r.CRH())&&(e.paginator=t.first),r.iGM(t=r.CRH())&&(e.sort=t.first)}},decls:46,vars:27,consts:[[1,"host"],[3,"title"],["class","right",4,"ngIf"],["mecanisme","ps"],[1,"row","mb-4","justify-content-center"],[1,"col-md-5"],[3,"obs"],[1,"col-md-2","p-0"],[3,"title","count","height"],[1,"col-md-12"],[1,"chart-size"],[3,"col","height","dataSubject"],[1,"example-container","mat-elevation-z8"],["class","example-loading-shade",4,"ngIf"],[1,"example-table-container"],["mat-table","","multiTemplateDataRows","","aria-label","Elements","matSort","",3,"dataSource"],["table",""],[3,"matColumnDef"],["mat-header-cell","","mat-sort-header","",4,"matHeaderCellDef"],["mat-cell","",4,"matCellDef"],["mat-header-cell","",4,"matHeaderCellDef"],["matColumnDef","option",2,"flex-direction","row-reverse"],["mat-header-row","",4,"matHeaderRowDef"],["mat-row","",4,"matRowDef","matRowDefColumns"],["pageIndex","0","pageSize","10","showFirstLastButtons","",3,"length","pageSizeOptions"],["paginator",""],[1,"right"],["mat-raised-button","","color","primary",1,"mt-3",3,"click"],[1,"example-loading-shade"],[4,"ngIf"],["mat-header-cell","","mat-sort-header",""],["mat-cell",""],["mat-header-cell",""],["mat-icon-button","","color","accent",3,"disabled","matTooltip","click"],["mat-icon-button","","color","accent",1,"center",3,"disabled","matTooltip","click"],["class","button-row",4,"ngIf"],[1,"button-row"],["mat-icon-button","","color","primary",3,"click",4,"ngIf"],["mat-icon-button","","color","accent",3,"click",4,"ngIf"],["mat-icon-button","","color","warn",3,"click",4,"ngIf"],["mat-icon-button","","color","primary",3,"click"],["mat-icon-button","","color","accent",3,"click"],["mat-icon-button","","color","warn",3,"click"],["mat-header-row",""],["mat-row",""]],template:function(t,e){1&t&&(r.TgZ(0,"div",0),r._UZ(1,"app-title",1),r.ALo(2,"translate"),r.YNc(3,j,6,3,"div",2),r._UZ(4,"app-intros",3),r.TgZ(5,"div",4),r.TgZ(6,"div",5),r._UZ(7,"app-pie",6),r.qZA(),r.TgZ(8,"div",7),r._UZ(9,"app-count",8),r.ALo(10,"translate"),r.qZA(),r.TgZ(11,"div",5),r._UZ(12,"app-pie",6),r.qZA(),r.TgZ(13,"div",9),r.TgZ(14,"div",10),r._UZ(15,"app-bar",11),r.qZA(),r.qZA(),r.qZA(),r.TgZ(16,"div",12),r.YNc(17,G,2,1,"div",13),r.TgZ(18,"div",14),r.TgZ(19,"table",15,16),r.ynx(21,17),r.YNc(22,W,3,3,"th",18),r.YNc(23,X,2,1,"td",19),r.BQk(),r.ynx(24,17),r.YNc(25,K,3,3,"th",18),r.YNc(26,tt,3,4,"td",19),r.BQk(),r.ynx(27,17),r.YNc(28,et,3,3,"th",20),r.YNc(29,it,4,2,"td",19),r.BQk(),r.ynx(30,17),r.YNc(31,nt,3,3,"th",20),r.YNc(32,ot,4,2,"td",19),r.BQk(),r.ynx(33,17),r.YNc(34,at,3,3,"th",20),r.YNc(35,st,4,2,"td",19),r.BQk(),r.ynx(36,17),r.YNc(37,rt,3,3,"th",20),r.YNc(38,lt,4,2,"td",19),r.BQk(),r.ynx(39,21),r.YNc(40,ct,1,0,"th",20),r.YNc(41,gt,2,1,"td",19),r.BQk(),r.YNc(42,ht,1,0,"tr",22),r.YNc(43,ft,1,0,"tr",23),r.qZA(),r.qZA(),r._UZ(44,"mat-paginator",24,25),r.qZA(),r.qZA()),2&t&&(r.xp6(1),r.s9C("title",r.lcZ(2,22,"admin.ps.Proc\xe9dure_sp\xe9ciales")),r.xp6(2),r.Q6J("ngIf",e.session.isAdmin),r.xp6(4),r.Q6J("obs",e.mecanismeState),r.xp6(2),r.Q6J("title",r.lcZ(10,24,"admin.header.visiteCount"))("count",e.countRec)("height","55vh"),r.xp6(3),r.Q6J("obs",e.stateByMecanisme),r.xp6(3),r.Q6J("col",12)("height","70vh")("dataSubject",e.stateDetailByMecanisme),r.xp6(2),r.Q6J("ngIf",e.isLoadingResults),r.xp6(2),r.Q6J("dataSource",e.dataSource),r.xp6(2),r.Q6J("matColumnDef",e.columnDefs[0].columnDef),r.xp6(3),r.Q6J("matColumnDef",e.columnDefs[1].columnDef),r.xp6(3),r.Q6J("matColumnDef",e.columnDefs[2].columnDef),r.xp6(3),r.Q6J("matColumnDef",e.columnDefs[3].columnDef),r.xp6(3),r.Q6J("matColumnDef",e.columnDefs[4].columnDef),r.xp6(3),r.Q6J("matColumnDef",e.columnDefs[5].columnDef),r.xp6(6),r.Q6J("matHeaderRowDef",e.displayedColumns),r.xp6(1),r.Q6J("matRowDefColumns",e.displayedColumns),r.xp6(1),r.Q6J("length",e.resultsLength)("pageSizeOptions",r.DdM(26,Zt)))},directives:[J.r,o.O5,L.e,Q.R,E.S,Y.R,B.BZ,c.YE,B.w1,B.fO,B.Dz,B.as,B.nj,l.NW,_.lW,$.Hw,H.$g,B.ge,c.nU,B.ev,z.gM,B.XQ,B.Gk],pipes:[T.X$,o.uU],styles:['section[_ngcontent-%COMP%]{display:flex!important;justify-content:space-between!important;align-items:center!important}  h3{margin:0!important}.mat-cell[_ngcontent-%COMP%]:last-child,   .mat-header-cell:last-child{width:180px!important}.border-left[_ngcontent-%COMP%]{border-left:10px solid #a19b9e}.border-right[_ngcontent-%COMP%]{border-right:10px solid #a19b9e}.super-title[_ngcontent-%COMP%]{height:45px}.super-title[_ngcontent-%COMP%], .super-title[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]{display:flex;align-items:center}.super-title[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]{background-color:#d17c36;height:35px}.super-title[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]   h3[_ngcontent-%COMP%]{color:#fff;margin:0;padding:0 5px}.super-title2[_ngcontent-%COMP%]{height:45px;display:flex;align-items:center}.super-title2[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]{height:35px;display:flex;align-items:center}.super-title2[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]   h3[_ngcontent-%COMP%]{color:#a19b9e;margin:0;padding:0 5px;font-size:1.8em}.host[_ngcontent-%COMP%]{margin:1em!important}  .mat-progress-spinner circle{fill:#00000008!important}h3[_ngcontent-%COMP%]{margin:20px 0 10px;color:var(--primary);text-align:center;font-size:medium}.axes[_ngcontent-%COMP%]{display:flex;flex-direction:column;box-shadow:1px 1px 5px #ddd;padding:5px;margin-bottom:5px}.axes[_ngcontent-%COMP%]   p[_ngcontent-%COMP%]{margin:0;font-size:.8em}.axes[_ngcontent-%COMP%]   .title[_ngcontent-%COMP%]{font-weight:700;margin-bottom:10px;font-size:.9em}@font-face{font-family:Satisfy;font-style:normal;font-weight:400;font-display:swap;src:local("Satisfy Regular"),local("Satisfy-Regular"),url(https://fonts.gstatic.com/s/satisfy/v11/rP2Hp2yn6lkG50LoCZOIHQ.woff2) format("woff2");unicode-range:u+00??,u+0131,u+0152-0153,u+02bb-02bc,u+02c6,u+02da,u+02dc,u+2000-206f,u+2074,u+20ac,u+2122,u+2191,u+2193,u+2212,u+2215,u+feff,u+fffd}.textAlign-left[_ngcontent-%COMP%]{text-align:left}.textAlign-right[_ngcontent-%COMP%], .textSouTitre[_ngcontent-%COMP%]{text-align:right}.textSouTitre[_ngcontent-%COMP%]{margin-bottom:2%;font-size:.9em;color:#00000070}']}),t})()}];let bt=(()=>{class t{}return t.\u0275fac=function(e){return new(e||t)},t.\u0275mod=r.oAB({type:t}),t.\u0275inj=r.cJS({imports:[[k.Bz.forChild(xt)],k.Bz]}),t})();var At=i(42693),_t=i(57823),Tt=i(15675),vt=i(23928),Ot=i(4967);let Pt=(()=>{class t{}return t.\u0275fac=function(e){return new(e||t)},t.\u0275mod=r.oAB({type:t}),t.\u0275inj=r.cJS({providers:[],imports:[[o.ez,bt,At.JF,_t.R,p.u5,p.UX,n.i,Tt.f,vt.N,T.aw,Ot.O]]}),t})()}}]);