(window.webpackJsonp=window.webpackJsonp||[]).push([[29],{VyW6:function(t,e,i){"use strict";i.r(e),i.d(e,"VisiteModule",function(){return yt});var n=i("Dgsr"),a=i("ofXK"),o=i("mrSG"),c=i("ukCm"),s=i("fXoL"),r=i("M9IT"),l=i("Dh3D"),b=i("XNiG"),m=i("VRyK"),d=i("0IaG"),u=i("3Pt+"),p=i("7q3A"),h=i("/t3+"),f=i("f0Cb"),g=i("kmnG"),S=i("qFsG"),T=i("iadO"),v=i("3IEU"),C=i("bTqV"),O=i("sYmb");let P=(()=>{class t{constructor(t,e,i,n){this.dialogRef=t,this.data=e,this.fb=i,this.uow=n,this.title="",this.folderToSaveInServer="visite",this.lienUploadTo=new b.a,this.lienUploadFrom=new b.a,this.discoursTo=new b.a,this.discoursFrom=new b.a,this.miseOeuvrePieceTo=new b.a,this.miseOeuvrePieceFrom=new b.a,this.commentaireTo=new b.a,this.commentaireFrom=new b.a,this.eventSubmitFromParent=new b.a}ngOnInit(){this.o=this.data.model,this.title=this.data.title,this.createForm(),this.discoursFrom.subscribe(t=>this.myForm.get("discours").setValue(t)),this.lienUploadFrom.subscribe(t=>this.myForm.get("lienUpload").setValue(t)),this.miseOeuvrePieceFrom.subscribe(t=>this.myForm.get("miseOeuvrePiece").setValue(t)),this.commentaireFrom.subscribe(t=>this.myForm.get("commentaire").setValue(t)),setTimeout(()=>{this.miseOeuvrePieceTo.next(this.o.miseOeuvrePiece),this.lienUploadTo.next(this.o.lienUpload),this.discoursTo.next(this.o.discours),this.commentaireTo.next(this.o.commentaire)},100)}createForm(){this.myForm=this.fb.group({id:this.o.id,mandat:[this.o.mandat,u.s.required],mandatAr:[this.o.mandatAr,u.s.required],discours:[this.o.discours],date:[this.o.date,u.s.required],lienRapport:[this.o.lienRapport],lienUpload:[this.o.lienUpload],miseOeuvrePiece:[this.o.miseOeuvrePiece],commentaire:[this.o.commentaire]})}onNoClick(){this.dialogRef.close()}onOkClick(t){this.submit(t)}submit(t){t.date=this.uow.valideDate(t.date),0===this.o.id?this.uow.visites.post(t).subscribe(t=>Object(o.a)(this,void 0,void 0,function*(){this.eventSubmitFromParent.next(!0),this.dialogRef.close(!0)})):this.uow.visites.put(t.id,t).subscribe(t=>Object(o.a)(this,void 0,void 0,function*(){this.eventSubmitFromParent.next(!0),this.dialogRef.close(!0)}))}resetForm(){this.o=new c.q,this.createForm()}}return t.\u0275fac=function(e){return new(e||t)(s.Nb(d.g),s.Nb(d.a),s.Nb(u.d),s.Nb(p.a))},t.\u0275cmp=s.Hb({type:t,selectors:[["app-update"]],decls:53,vars:54,consts:[[1,"dialog"],["mat-dialog-title",""],["role","toolbar",1,"task-header"],[1,"content"],["mat-dialog-content",""],[3,"formGroup"],["appearance","fill"],["matInput","","formControlName","mandat","required",""],["matInput","","formControlName","mandatAr","required",""],["matInput","","formControlName","discours","placeholder","Discours du pr\xe9sident"],["matInput","","formControlName","date",3,"matDatepicker"],["matSuffix","",3,"for"],["picker",""],[3,"nameBtn","folderToSaveInServer","propertyOfParent","eventSubmitToParent","eventSubmitFromParent"],["matInput","","formControlName","lienRapport"],["mat-dialog-actions","",1,"actions"],["mat-button","","type","button",3,"click"],["mat-raised-button","","cdkFocusInitial","","color","primary",3,"disabled","click"]],template:function(t,e){if(1&t&&(s.Tb(0,"div",0),s.Tb(1,"h1",1),s.Tb(2,"mat-toolbar",2),s.Tb(3,"span"),s.Cc(4),s.Sb(),s.Sb(),s.Ob(5,"mat-divider"),s.Sb(),s.Tb(6,"div",3),s.Tb(7,"div",4),s.Tb(8,"form",5),s.Tb(9,"mat-form-field",6),s.Tb(10,"mat-label"),s.Cc(11),s.fc(12,"translate"),s.Sb(),s.Ob(13,"input",7),s.Sb(),s.Tb(14,"mat-form-field",6),s.Tb(15,"mat-label"),s.Cc(16),s.fc(17,"translate"),s.Sb(),s.Ob(18,"input",8),s.Sb(),s.Tb(19,"mat-form-field",6),s.Tb(20,"mat-label"),s.Cc(21),s.fc(22,"translate"),s.Sb(),s.Ob(23,"textarea",9),s.Sb(),s.Tb(24,"mat-form-field",6),s.Tb(25,"mat-label"),s.Cc(26),s.fc(27,"translate"),s.Sb(),s.Ob(28,"input",10),s.Ob(29,"mat-datepicker-toggle",11),s.Ob(30,"mat-datepicker",null,12),s.Sb(),s.Ob(32,"app-upload-select",13),s.fc(33,"translate"),s.Ob(34,"app-upload-select",13),s.fc(35,"translate"),s.Ob(36,"app-upload-select",13),s.fc(37,"translate"),s.Ob(38,"app-upload-select",13),s.fc(39,"translate"),s.Tb(40,"mat-form-field",6),s.Tb(41,"mat-label"),s.Cc(42),s.fc(43,"translate"),s.Sb(),s.Ob(44,"input",14),s.Sb(),s.Sb(),s.Sb(),s.Tb(45,"div",15),s.Tb(46,"button",16),s.ac("click",function(){return e.onNoClick()}),s.Cc(47),s.fc(48,"translate"),s.Sb(),s.Cc(49,"\xa0\xa0 "),s.Tb(50,"button",17),s.ac("click",function(){return e.onOkClick(e.myForm.value)}),s.Cc(51),s.fc(52,"translate"),s.Sb(),s.Sb(),s.Sb(),s.Sb()),2&t){const t=s.qc(31);s.Bb(4),s.Dc(e.title),s.Bb(4),s.kc("formGroup",e.myForm),s.Bb(3),s.Dc(s.gc(12,32,"admin.ps.update.Mandat")),s.Bb(5),s.Dc(s.gc(17,34,"admin.ps.update.MandatAr")),s.Bb(5),s.Dc(s.gc(22,36,"admin.ps.update.Discours_du_pr\xe9sident")),s.Bb(5),s.Dc(s.gc(27,38,"admin.ps.update.Date_pr\xe9vue")),s.Bb(2),s.kc("matDatepicker",t),s.Bb(1),s.kc("for",t),s.Bb(3),s.lc("nameBtn",s.gc(33,40,"admin.ps.update.RAPPORT_NATIONAL_DE_LA_VISITE")),s.kc("folderToSaveInServer",e.folderToSaveInServer)("propertyOfParent",e.lienUploadTo)("eventSubmitToParent",e.lienUploadFrom)("eventSubmitFromParent",e.eventSubmitFromParent),s.Bb(2),s.lc("nameBtn",s.gc(35,42,"admin.ps.update.RAPPORT_DE_LA_PROCEDURE_REACTION_NATIONALE")),s.kc("folderToSaveInServer",e.folderToSaveInServer)("propertyOfParent",e.discoursTo)("eventSubmitToParent",e.discoursFrom)("eventSubmitFromParent",e.eventSubmitFromParent),s.Bb(2),s.lc("nameBtn",s.gc(37,44,"admin.ps.update.PLAN_DE_MISE_EN_OEUVRE")),s.kc("folderToSaveInServer",e.folderToSaveInServer)("propertyOfParent",e.miseOeuvrePieceTo)("eventSubmitToParent",e.miseOeuvrePieceFrom)("eventSubmitFromParent",e.eventSubmitFromParent),s.Bb(2),s.lc("nameBtn",s.gc(39,46,"admin.ps.commentaire")),s.kc("folderToSaveInServer",e.folderToSaveInServer)("propertyOfParent",e.commentaireTo)("eventSubmitToParent",e.commentaireFrom)("eventSubmitFromParent",e.eventSubmitFromParent),s.Bb(4),s.Dc(s.gc(43,48,"admin.ps.update.Lien_externe")),s.Bb(5),s.Dc(s.gc(48,50,"admin.Retour")),s.Bb(3),s.kc("disabled",e.myForm.invalid),s.Bb(1),s.Dc(s.gc(52,52,"admin.Enregistre"))}},directives:[d.h,h.a,f.a,d.e,u.t,u.n,u.h,g.c,g.f,S.b,u.c,u.m,u.g,u.r,T.b,T.d,g.g,T.a,v.a,d.c,C.a],pipes:[O.c],styles:["mat-form-field[_ngcontent-%COMP%]{width:100%}.dialog[_ngcontent-%COMP%]{overflow-x:hidden;overflow-y:hidden}.dialog[_ngcontent-%COMP%]   h1[_ngcontent-%COMP%]   span[_ngcontent-%COMP%]{padding:0 5px}.dialog[_ngcontent-%COMP%]   .content[_ngcontent-%COMP%]{padding:0 20px 25px}.dialog[_ngcontent-%COMP%]   .actions[_ngcontent-%COMP%]{display:flex;flex-direction:row-reverse}.myrow[_ngcontent-%COMP%]{display:flex;align-items:center}img[_ngcontent-%COMP%]{height:20px}"]}),t})(),y=(()=>{class t{constructor(t,e){this.dialogRef=t,this.data=e,this.title=""}ngOnInit(){this.o=this.data.model,this.title=this.data.title,console.log(this.o)}onNoClick(){this.dialogRef.close()}onOkClick(t){}}return t.\u0275fac=function(e){return new(e||t)(s.Nb(d.g),s.Nb(d.a))},t.\u0275cmp=s.Hb({type:t,selectors:[["app-update"]],decls:17,vars:6,consts:[[1,"dialog"],["mat-dialog-title",""],["role","toolbar",1,"task-header"],[1,"content"],["mat-dialog-content",""],["mat-dialog-actions","",1,"actions"],["mat-button","","type","button",3,"click"]],template:function(t,e){1&t&&(s.Tb(0,"div",0),s.Tb(1,"h1",1),s.Tb(2,"mat-toolbar",2),s.Tb(3,"span"),s.Cc(4),s.Sb(),s.Sb(),s.Ob(5,"mat-divider"),s.Sb(),s.Tb(6,"div",3),s.Tb(7,"div",4),s.Tb(8,"ul"),s.Tb(9,"li"),s.Cc(10),s.Sb(),s.Tb(11,"li"),s.Cc(12),s.fc(13,"date"),s.Sb(),s.Sb(),s.Sb(),s.Tb(14,"div",5),s.Tb(15,"button",6),s.ac("click",function(){return e.onNoClick()}),s.Cc(16,"Retour"),s.Sb(),s.Sb(),s.Sb(),s.Sb()),2&t&&(s.Bb(4),s.Dc(e.title),s.Bb(6),s.Ec("Objet: ",e.o.mandat,""),s.Bb(2),s.Ec("Date pr\xe9vu: ",s.hc(13,3,e.o.date,"dd/MM/yyyy"),""))},directives:[d.h,h.a,f.a,d.e,d.c,C.a],pipes:[a.e],styles:["mat-form-field[_ngcontent-%COMP%]{width:100%}.dialog[_ngcontent-%COMP%]{overflow-x:hidden;overflow-y:hidden}.dialog[_ngcontent-%COMP%]   h1[_ngcontent-%COMP%]   span[_ngcontent-%COMP%]{padding:0 5px}.dialog[_ngcontent-%COMP%]   .content[_ngcontent-%COMP%]{padding:0 20px 25px}.dialog[_ngcontent-%COMP%]   .actions[_ngcontent-%COMP%]{display:flex;flex-direction:row-reverse}.myrow[_ngcontent-%COMP%]{display:flex;align-items:center}"]}),t})();var w=i("MutI"),B=i("FKr1");function D(t,e){if(1&t){const t=s.Ub();s.Tb(0,"mat-list-item",12),s.ac("click",function(){s.sc(t);const i=e.$implicit;return s.ec().download(i.substring(0,i.length-1))}),s.Tb(1,"span",13),s.Cc(2),s.Sb(),s.Sb()}if(2&t){const t=e.$implicit;s.Bb(2),s.Ec("- ",t.substring(14,t.length-1),"")}}function _(t,e){if(1&t){const t=s.Ub();s.Tb(0,"mat-list-item",12),s.ac("click",function(){s.sc(t);const i=e.$implicit;return s.ec().download(i.substring(0,i.length-1))}),s.Tb(1,"span",13),s.Cc(2),s.Sb(),s.Sb()}if(2&t){const t=e.$implicit;s.Bb(2),s.Ec("- ",t.substring(14,t.length-1),"")}}function x(t,e){if(1&t){const t=s.Ub();s.Tb(0,"mat-list-item",12),s.ac("click",function(){s.sc(t);const i=e.$implicit;return s.ec().download(i.substring(0,i.length-1))}),s.Tb(1,"span",13),s.Cc(2),s.Sb(),s.Sb()}if(2&t){const t=e.$implicit;s.Bb(2),s.Ec("- ",t.substring(14,t.length-1),"")}}function k(t,e){if(1&t){const t=s.Ub();s.Tb(0,"mat-list-item",12),s.ac("click",function(){s.sc(t);const i=e.$implicit;return s.ec().download(i.substring(0,i.length-1))}),s.Tb(1,"span",13),s.Cc(2),s.Sb(),s.Sb()}if(2&t){const t=e.$implicit;s.Bb(2),s.Ec("- ",t.substring(14,t.length-1),"")}}let M=(()=>{class t{constructor(t,e,i){this.dialogRef=t,this.data=e,this.url=i,this.title="",this.folder="organe"}ngOnInit(){this.o=this.data.model,this.title=this.data.title}propertyToList(t){if(t){const e=t.split(";");return e.pop(),e}return[]}download(t){window.open(`${this.url}/${this.folder}/${t}`)}}return t.\u0275fac=function(e){return new(e||t)(s.Nb(d.g),s.Nb(d.a),s.Nb("BASE_URL"))},t.\u0275cmp=s.Hb({type:t,selectors:[["app-archive"]],decls:33,vars:8,consts:[[1,"dialog"],["mat-dialog-title",""],["role","toolbar",1,"task-header"],[1,"content"],["mat-dialog-content",""],[1,"row"],[1,"col"],[2,"font-weight","bold"],["role","list"],["matRipple","","style","cursor: pointer;",3,"click",4,"ngFor","ngForOf"],["mat-dialog-actions","",1,"actions"],["mat-button","","type","button",3,"click"],["matRipple","",2,"cursor","pointer",3,"click"],[2,"font-size",".9em"]],template:function(t,e){1&t&&(s.Tb(0,"div",0),s.Tb(1,"h1",1),s.Tb(2,"mat-toolbar",2),s.Tb(3,"span"),s.Cc(4),s.Sb(),s.Sb(),s.Ob(5,"mat-divider"),s.Sb(),s.Tb(6,"div",3),s.Tb(7,"div",4),s.Tb(8,"div",5),s.Tb(9,"div",6),s.Tb(10,"p",7),s.Cc(11,"Rapport"),s.Sb(),s.Tb(12,"mat-list",8),s.Bc(13,D,3,1,"mat-list-item",9),s.Sb(),s.Sb(),s.Tb(14,"div",6),s.Tb(15,"p",7),s.Cc(16,"Discours du pr\xe9sident"),s.Sb(),s.Tb(17,"mat-list",8),s.Bc(18,_,3,1,"mat-list-item",9),s.Sb(),s.Sb(),s.Tb(19,"div",6),s.Tb(20,"p",7),s.Cc(21,"Plan de mise en \u0153uvre"),s.Sb(),s.Tb(22,"mat-list",8),s.Bc(23,x,3,1,"mat-list-item",9),s.Sb(),s.Sb(),s.Tb(24,"div",6),s.Tb(25,"p",7),s.Cc(26),s.fc(27,"translate"),s.Sb(),s.Tb(28,"mat-list",8),s.Bc(29,k,3,1,"mat-list-item",9),s.Sb(),s.Sb(),s.Sb(),s.Sb(),s.Tb(30,"div",10),s.Tb(31,"button",11),s.ac("click",function(){return e.dialogRef.close()}),s.Cc(32,"Retour"),s.Sb(),s.Sb(),s.Sb(),s.Sb()),2&t&&(s.Bb(4),s.Dc(e.title),s.Bb(9),s.kc("ngForOf",e.propertyToList(e.o.lienUpload)),s.Bb(5),s.kc("ngForOf",e.propertyToList(e.o.discours)),s.Bb(5),s.kc("ngForOf",e.propertyToList(e.o.miseOeuvrePiece)),s.Bb(3),s.Dc(s.gc(27,6,"admin.ps.commentaire")),s.Bb(3),s.kc("ngForOf",e.propertyToList(e.o.commentaire)))},directives:[d.h,h.a,f.a,d.e,w.a,a.l,d.c,C.a,w.b,B.t],pipes:[O.c],styles:["mat-form-field[_ngcontent-%COMP%]{width:100%}.dialog[_ngcontent-%COMP%]{overflow-x:hidden;overflow-y:hidden}.dialog[_ngcontent-%COMP%]   h1[_ngcontent-%COMP%]   span[_ngcontent-%COMP%]{padding:0 5px}.dialog[_ngcontent-%COMP%]   .content[_ngcontent-%COMP%]{padding:0 20px 25px}.dialog[_ngcontent-%COMP%]   .actions[_ngcontent-%COMP%]{display:flex;flex-direction:row-reverse}.myrow[_ngcontent-%COMP%]{display:flex;align-items:center}img[_ngcontent-%COMP%]{height:20px}"]}),t})();var R=i("ZTdd"),N=i("5F3i"),I=i("2ChS"),F=i("tyNb"),E=i("0hB7"),A=i("J3i2"),L=i("/ysL"),U=i("2HI4"),$=i("+Ya6"),V=i("x3GN"),z=i("oTHA"),j=i("+0xr"),q=i("NFeN"),H=i("Xa2L"),Q=i("Qu3c");function G(t,e){if(1&t){const t=s.Ub();s.Tb(0,"div",26),s.Tb(1,"button",27),s.ac("click",function(){return s.sc(t),s.ec().add()}),s.Tb(2,"mat-icon"),s.Cc(3,"add"),s.Sb(),s.Cc(4),s.fc(5,"translate"),s.Sb(),s.Sb()}2&t&&(s.Bb(4),s.Ec(" ",s.gc(5,1,"admin.ps.Proc\xe9dure_sp\xe9ciale")," "))}function J(t,e){1&t&&s.Ob(0,"mat-spinner")}function K(t,e){if(1&t&&(s.Tb(0,"div",28),s.Bc(1,J,1,0,"mat-spinner",29),s.Sb()),2&t){const t=s.ec();s.Bb(1),s.kc("ngIf",t.isLoadingResults)}}function X(t,e){1&t&&(s.Tb(0,"th",30),s.Cc(1),s.fc(2,"translate"),s.Sb()),2&t&&(s.Bb(1),s.Dc(s.gc(2,1,"admin.ps.list.MANDAT")))}function Y(t,e){if(1&t&&(s.Tb(0,"td",31),s.Cc(1),s.Sb()),2&t){const t=e.$implicit,i=s.ec();s.Bb(1),s.Dc("fr"===i.mytranslate.langSync?t.mandat:t.mandatAr)}}function Z(t,e){1&t&&(s.Tb(0,"th",30),s.Cc(1),s.fc(2,"translate"),s.Sb()),2&t&&(s.Bb(1),s.Dc(s.gc(2,1,"admin.ps.list.Date_de_la_visite")))}function W(t,e){if(1&t&&(s.Tb(0,"td",31),s.Cc(1),s.fc(2,"date"),s.Sb()),2&t){const t=e.$implicit,i=s.ec();s.Bb(1),s.Dc(s.hc(2,1,t[i.columnDefs[1].columnDef],"dd/MM/yyyy"))}}function tt(t,e){1&t&&(s.Tb(0,"th",32),s.Cc(1),s.fc(2,"translate"),s.Sb()),2&t&&(s.Bb(1),s.Ec(" ",s.gc(2,1,"admin.ps.list.RAPPORT_DE_LA_PROCEDURE_REACTION_NATIONALE"),""))}function et(t,e){if(1&t){const t=s.Ub();s.Tb(0,"td",31),s.Tb(1,"button",33),s.ac("click",function(){s.sc(t);const i=e.$implicit;return s.ec().showPieceJoin(i.discours)}),s.Tb(2,"mat-icon"),s.Cc(3,"cloud_download"),s.Sb(),s.Sb(),s.Sb()}if(2&t){const t=e.$implicit,i=s.ec();s.Bb(1),s.kc("disabled",i.disable(t.discours))("matTooltip",t.discours)}}function it(t,e){1&t&&(s.Tb(0,"th",32),s.Cc(1),s.fc(2,"translate"),s.Sb()),2&t&&(s.Bb(1),s.Dc(s.gc(2,1,"admin.ps.list.PLAN_DE_MISE_EN_OEUVRE")))}function nt(t,e){if(1&t){const t=s.Ub();s.Tb(0,"td",31),s.Tb(1,"button",34),s.ac("click",function(){s.sc(t);const i=e.$implicit;return s.ec().showPieceJoin(i.miseOeuvrePiece)}),s.Tb(2,"mat-icon"),s.Cc(3,"cloud_download"),s.Sb(),s.Sb(),s.Sb()}if(2&t){const t=e.$implicit,i=s.ec();s.Bb(1),s.kc("disabled",i.disable(t.miseOeuvrePiece))("matTooltip",t.miseOeuvrePiece)}}function at(t,e){1&t&&(s.Tb(0,"th",32),s.Cc(1),s.fc(2,"translate"),s.Sb()),2&t&&(s.Bb(1),s.Dc(s.gc(2,1,"admin.ps.list.RAPPORT_NATIONAL_DE_LA_VISITE")))}function ot(t,e){if(1&t){const t=s.Ub();s.Tb(0,"td",31),s.Tb(1,"button",33),s.ac("click",function(){s.sc(t);const i=e.$implicit;return s.ec().showPieceJoin(i.lienUpload)}),s.Tb(2,"mat-icon"),s.Cc(3,"cloud_download"),s.Sb(),s.Sb(),s.Sb()}if(2&t){const t=e.$implicit,i=s.ec();s.Bb(1),s.kc("disabled",i.disable(t.lienUpload))("matTooltip",t.lienUpload)}}function ct(t,e){1&t&&(s.Tb(0,"th",32),s.Cc(1),s.fc(2,"translate"),s.Sb()),2&t&&(s.Bb(1),s.Dc(s.gc(2,1,"admin.ps.commentaire")))}function st(t,e){if(1&t){const t=s.Ub();s.Tb(0,"td",31),s.Tb(1,"button",33),s.ac("click",function(){s.sc(t);const i=e.$implicit;return s.ec().showPieceJoin(i.commentaire)}),s.Tb(2,"mat-icon"),s.Cc(3,"cloud_download"),s.Sb(),s.Sb(),s.Sb()}if(2&t){const t=e.$implicit,i=s.ec();s.Bb(1),s.kc("disabled",i.disable(t.commentaire))("matTooltip",t.commentaire)}}function rt(t,e){1&t&&s.Ob(0,"th",32)}function lt(t,e){if(1&t){const t=s.Ub();s.Tb(0,"button",37),s.ac("click",function(){s.sc(t);const e=s.ec(2).$implicit;return s.ec().edit(e)}),s.Tb(1,"mat-icon"),s.Cc(2,"create"),s.Sb(),s.Sb()}}function bt(t,e){if(1&t){const t=s.Ub();s.Tb(0,"button",41),s.ac("click",function(){s.sc(t);const e=s.ec(2).$implicit;return s.ec().archive(e)}),s.Tb(1,"mat-icon"),s.Cc(2,"unarchive"),s.Sb(),s.Sb()}}function mt(t,e){if(1&t){const t=s.Ub();s.Tb(0,"button",42),s.ac("click",function(){s.sc(t);const e=s.ec(2).$implicit;return s.ec().delete(e)}),s.Tb(1,"mat-icon"),s.Cc(2,"delete_sweep"),s.Sb(),s.Sb()}}function dt(t,e){if(1&t){const t=s.Ub();s.Tb(0,"div",36),s.Tb(1,"button",37),s.ac("click",function(){s.sc(t);const e=s.ec().$implicit;return s.ec().openDialogDetail(e)}),s.Tb(2,"mat-icon"),s.Cc(3,"visibility"),s.Sb(),s.Sb(),s.Bc(4,lt,3,0,"button",38),s.Bc(5,bt,3,0,"button",39),s.Bc(6,mt,3,0,"button",40),s.Sb()}if(2&t){const t=s.ec(2);s.Bb(4),s.kc("ngIf",!t.session.isPointFocal&&!t.session.isSuperViseur),s.Bb(1),s.kc("ngIf",!t.session.isPointFocal&&!t.session.isSuperViseur),s.Bb(1),s.kc("ngIf",!t.session.isPointFocal&&!t.session.isSuperViseur)}}function ut(t,e){if(1&t&&(s.Tb(0,"td",31),s.Bc(1,dt,7,3,"div",35),s.Sb()),2&t){const t=s.ec();s.Bb(1),s.kc("ngIf",!t.session.isPublic)}}function pt(t,e){1&t&&s.Ob(0,"tr",43)}function ht(t,e){1&t&&s.Ob(0,"tr",44)}const ft=function(){return[10,25,50,100,250]},gt=[{path:"",redirectTo:"list",pathMatch:"full"},{path:"list",component:(()=>{class t{constructor(t,e,i,n,a,o,c,r){this.uow=t,this.dialog=e,this.mydialog=i,this.bottomSheet=n,this.url=a,this.route=o,this.session=c,this.mytranslate=r,this.update=new s.o,this.isLoadingResults=!0,this.resultsLength=0,this.isRateLimitReached=!1,this.dataSource=[],this.columnDefs=[{columnDef:"mandat",headName:"MANDAT"},{columnDef:"date",headName:"Date de la visite"},{columnDef:"lienUpload",headName:"RAPPORT NATIONAL DE LA VISITE"},{columnDef:"discours",headName:"RAPPORT DE LA PROCEDURE/REACTION NATIONALE"},{columnDef:"miseOeuvrePiece",headName:"PLAN DE MISE EN OEUVRE"},{columnDef:"commentaire",headName:"commentaire"},{columnDef:"option",headName:"OPTION"}].map(t=>(t.headName=""===t.headName?t.columnDef.toUpperCase():t.headName.toUpperCase(),t)),this.displayedColumns=this.columnDefs.filter(t=>"discours"!==t.columnDef&&"miseOeuvrePiece"!==t.columnDef).map(t=>t.columnDef),this.progress=0,this.formData=new FormData,this.text="",this.text2=this.text.substring(0,600),this.countRec=new b.a,this.mecanismeState=new b.a,this.stateByMecanisme=new b.a,this.stateDetailByMecanisme=new b.a}ngOnInit(){setTimeout(()=>this.getPage(0,10,"id","desc"),300),Object(m.a)(this.sort.sortChange,this.paginator.page,this.update).subscribe(t=>{!0===t?this.paginator.pageIndex=0:t=t,this.paginator.pageSize?t=t:this.paginator.pageSize=10;const e=this.paginator.pageIndex*this.paginator.pageSize;this.isLoadingResults=!0,this.getPage(e,this.paginator.pageSize,this.sort.active?this.sort.active:"id",this.sort.direction?this.sort.direction:"desc")}),this.route.queryParams.subscribe(t=>{const e=t.data;e&&this.uow.visites.getOne(e).subscribe(t=>{this.openDialogDetail(t)})}),this.getMecanismeState(),this.getStateByMecanisme(),this.getStateDetailByMecanisme(),this.uow.recommendations.mecanismeCount("visite").subscribe(t=>this.countRec.next(t))}disable(t){return!t||""===t}openDialogDetail(t){return this.dialog.open(y,{width:"7100px",disableClose:!0,data:{model:t,title:"Visite"}}).afterClosed()}moreInfo(){this.text2=600===this.text2.length?this.text:this.text.substring(0,600)}getPage(t,e,i,n){this.uow.visites.getList(t,e,i,n).subscribe(t=>{console.log(t.list),this.dataSource=t.list,this.resultsLength=t.count,this.isLoadingResults=!1})}openDialog(t,e){return this.dialog.open(P,{width:"7100px",disableClose:!0,data:{model:t,title:e}}).afterClosed()}add(){this.openDialog(new c.q,this.mytranslate.get("admin.ps.list.Ajouter_Proc\xe9dure_sp\xe9ciale")).subscribe(t=>{t&&this.update.next(!0)})}archive(t){this.dialog.open(M,{width:"80vw",disableClose:!0,data:{model:t,title:t.mandat}})}edit(t){this.openDialog(t,this.mytranslate.get("admin.ps.list.Modifier_Proc\xe9dure_sp\xe9ciale")).subscribe(t=>{t&&this.update.next(!0)})}delete(t){return Object(o.a)(this,void 0,void 0,function*(){if("ok"===(yield this.mydialog.openDialog("Proc\xe9dure sp\xe9ciale").toPromise())){let e=[];""!==t.lienUpload?e.push(...this.uow.decoupe(t.lienUpload)):e=e,""!==t.discours?e.push(...this.uow.decoupe(t.discours)):e=e,this.uow.files.deleteFiles(e,"visite").subscribe(e=>{this.uow.examens.delete(t.id).subscribe(()=>this.update.next(!0))})}})}showPieceJoin(t){this.bottomSheet.open(R.a,{data:{fileName:t,folder:"visite"}})}getMecanismeState(){this.uow.visites.mecanismeState().subscribe(t=>{const e=[];e.push(this.mytranslate.get("NonR\xe9alis\xe9")),e.push(this.mytranslate.get("EnCours")),e.push(this.mytranslate.get("Recommendation_continue")),e.push(this.mytranslate.get("R\xe9alis\xe9"));const i=[],n=[];i.push(100*t.one/t.total),i.push(100*t.two/t.total),i.push(100*t.three/t.total),i.push(100*t.four/t.total),n.push(t.one,t.two,t.three,t.four),this.mecanismeState.next({chartLabels:e,chartData:i,chartColors:["#db0707","#f7801e","#2d71a1","#2b960b","#ffffff"],dataToShowInTable:n,title:this.mytranslate.get("admin.header.Etat de mise en \u0153uvre")})})}getStateByMecanisme(){this.uow.visites.stateByMecanisme().subscribe(t=>{const e=t.map(t=>t.name),i=t.map(t=>+t.one.toFixed(0));this.stateByMecanisme.next({chartLabels:e,chartData:i,chartColors:[],dataToShowInTable:[],title:this.mytranslate.get("admin.ps.list.Tauxderecommandationsparvisite")})})}getStateDetailByMecanisme(){this.uow.visites.stateDetailByMecanisme().subscribe(t=>{const e=(t=t.filter(t=>null!==t.name)).map(t=>t.name),i=[{data:[],label:this.mytranslate.get("NonR\xe9alis\xe9")},{data:[],label:this.mytranslate.get("EnCours")},{data:[],label:this.mytranslate.get("Recommendation_continue")},{data:[],label:this.mytranslate.get("R\xe9alis\xe9")}];t.forEach(t=>{i[0].data.push(+(100*t.one/t.total).toFixed(0)),i[1].data.push(+(100*t.two/t.total).toFixed(0)),i[2].data.push(+(100*t.three/t.total).toFixed(0)),i[3].data.push(+(100*t.four/t.total).toFixed(0))}),this.stateDetailByMecanisme.next({barChartLabels:e,barChartData:i,title:this.mytranslate.get("admin.organe.list.Miseen\u0153uvredesrecommandationsparOrganesdeTrait\xe9s")})})}}return t.\u0275fac=function(e){return new(e||t)(s.Nb(p.a),s.Nb(d.b),s.Nb(N.a),s.Nb(I.b),s.Nb("BASE_URL"),s.Nb(F.a),s.Nb(E.a),s.Nb(A.a))},t.\u0275cmp=s.Hb({type:t,selectors:[["app-visite"]],viewQuery:function(t,e){if(1&t&&(s.xc(r.a,!0),s.xc(l.a,!0)),2&t){let t;s.pc(t=s.bc())&&(e.paginator=t.first),s.pc(t=s.bc())&&(e.sort=t.first)}},decls:46,vars:27,consts:[[1,"host"],[3,"title"],["class","right",4,"ngIf"],["mecanisme","ps"],[1,"row","mb-4","justify-content-center"],[1,"col-md-5"],[3,"obs"],[1,"col-md-2","p-0"],[3,"title","count","height"],[1,"col-md-12"],[1,"chart-size"],[3,"col","height","dataSubject"],[1,"example-container","mat-elevation-z8"],["class","example-loading-shade",4,"ngIf"],[1,"example-table-container"],["mat-table","","multiTemplateDataRows","","aria-label","Elements","matSort","",3,"dataSource"],["table",""],[3,"matColumnDef"],["mat-header-cell","","mat-sort-header","",4,"matHeaderCellDef"],["mat-cell","",4,"matCellDef"],["mat-header-cell","",4,"matHeaderCellDef"],["matColumnDef","option",2,"flex-direction","row-reverse"],["mat-header-row","",4,"matHeaderRowDef"],["mat-row","",4,"matRowDef","matRowDefColumns"],["pageIndex","0","pageSize","10","showFirstLastButtons","",3,"length","pageSizeOptions"],["paginator",""],[1,"right"],["mat-raised-button","","color","primary",1,"mt-3",3,"click"],[1,"example-loading-shade"],[4,"ngIf"],["mat-header-cell","","mat-sort-header",""],["mat-cell",""],["mat-header-cell",""],["mat-icon-button","","color","accent",3,"disabled","matTooltip","click"],["mat-icon-button","","color","accent",1,"center",3,"disabled","matTooltip","click"],["class","button-row",4,"ngIf"],[1,"button-row"],["mat-icon-button","","color","primary",3,"click"],["mat-icon-button","","color","primary",3,"click",4,"ngIf"],["mat-icon-button","","color","accent",3,"click",4,"ngIf"],["mat-icon-button","","color","warn",3,"click",4,"ngIf"],["mat-icon-button","","color","accent",3,"click"],["mat-icon-button","","color","warn",3,"click"],["mat-header-row",""],["mat-row",""]],template:function(t,e){1&t&&(s.Tb(0,"div",0),s.Ob(1,"app-title",1),s.fc(2,"translate"),s.Bc(3,G,6,3,"div",2),s.Ob(4,"app-intros",3),s.Tb(5,"div",4),s.Tb(6,"div",5),s.Ob(7,"app-pie",6),s.Sb(),s.Tb(8,"div",7),s.Ob(9,"app-count",8),s.fc(10,"translate"),s.Sb(),s.Tb(11,"div",5),s.Ob(12,"app-pie",6),s.Sb(),s.Tb(13,"div",9),s.Tb(14,"div",10),s.Ob(15,"app-bar",11),s.Sb(),s.Sb(),s.Sb(),s.Tb(16,"div",12),s.Bc(17,K,2,1,"div",13),s.Tb(18,"div",14),s.Tb(19,"table",15,16),s.Rb(21,17),s.Bc(22,X,3,3,"th",18),s.Bc(23,Y,2,1,"td",19),s.Qb(),s.Rb(24,17),s.Bc(25,Z,3,3,"th",18),s.Bc(26,W,3,4,"td",19),s.Qb(),s.Rb(27,17),s.Bc(28,tt,3,3,"th",20),s.Bc(29,et,4,2,"td",19),s.Qb(),s.Rb(30,17),s.Bc(31,it,3,3,"th",20),s.Bc(32,nt,4,2,"td",19),s.Qb(),s.Rb(33,17),s.Bc(34,at,3,3,"th",20),s.Bc(35,ot,4,2,"td",19),s.Qb(),s.Rb(36,17),s.Bc(37,ct,3,3,"th",20),s.Bc(38,st,4,2,"td",19),s.Qb(),s.Rb(39,21),s.Bc(40,rt,1,0,"th",20),s.Bc(41,ut,2,1,"td",19),s.Qb(),s.Bc(42,pt,1,0,"tr",22),s.Bc(43,ht,1,0,"tr",23),s.Sb(),s.Sb(),s.Ob(44,"mat-paginator",24,25),s.Sb(),s.Sb()),2&t&&(s.Bb(1),s.lc("title",s.gc(2,22,"admin.ps.Proc\xe9dure_sp\xe9ciales")),s.Bb(2),s.kc("ngIf",e.session.isAdmin),s.Bb(4),s.kc("obs",e.mecanismeState),s.Bb(2),s.kc("title",s.gc(10,24,"admin.header.visiteCount"))("count",e.countRec)("height","55vh"),s.Bb(3),s.kc("obs",e.stateByMecanisme),s.Bb(3),s.kc("col",12)("height","70vh")("dataSubject",e.stateDetailByMecanisme),s.Bb(2),s.kc("ngIf",e.isLoadingResults),s.Bb(2),s.kc("dataSource",e.dataSource),s.Bb(2),s.kc("matColumnDef",e.columnDefs[0].columnDef),s.Bb(3),s.kc("matColumnDef",e.columnDefs[1].columnDef),s.Bb(3),s.kc("matColumnDef",e.columnDefs[2].columnDef),s.Bb(3),s.kc("matColumnDef",e.columnDefs[3].columnDef),s.Bb(3),s.kc("matColumnDef",e.columnDefs[4].columnDef),s.Bb(3),s.kc("matColumnDef",e.columnDefs[5].columnDef),s.Bb(6),s.kc("matHeaderRowDef",e.displayedColumns),s.Bb(1),s.kc("matRowDefColumns",e.displayedColumns),s.Bb(1),s.kc("length",e.resultsLength)("pageSizeOptions",s.mc(26,ft)))},directives:[L.a,a.m,U.a,$.a,V.a,z.a,j.j,l.a,j.c,j.e,j.b,j.g,j.i,r.a,C.a,q.a,H.b,j.d,l.b,j.a,Q.a,j.f,j.h],pipes:[O.c,a.e],styles:['section[_ngcontent-%COMP%]{display:flex!important;justify-content:space-between!important;align-items:center!important}  h3{margin:0!important}.mat-cell[_ngcontent-%COMP%]:last-child,   .mat-header-cell:last-child{width:180px!important}.border-left[_ngcontent-%COMP%]{border-left:10px solid #a19b9e}.border-right[_ngcontent-%COMP%]{border-right:10px solid #a19b9e}.super-title[_ngcontent-%COMP%]{height:45px}.super-title[_ngcontent-%COMP%], .super-title[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]{display:flex;align-items:center}.super-title[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]{background-color:#d17c36;height:35px}.super-title[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]   h3[_ngcontent-%COMP%]{color:#fff;margin:0;padding:0 5px}.super-title2[_ngcontent-%COMP%]{height:45px;display:flex;align-items:center}.super-title2[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]{height:35px;display:flex;align-items:center}.super-title2[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]   h3[_ngcontent-%COMP%]{color:#a19b9e;margin:0;padding:0 5px;font-size:1.8em}.host[_ngcontent-%COMP%]{margin:1em!important}  .mat-progress-spinner circle{fill:rgba(0,0,0,.03137254901960784)!important}h3[_ngcontent-%COMP%]{margin:20px 0 10px;color:var(--primary);text-align:center;font-size:medium}.axes[_ngcontent-%COMP%]{display:flex;flex-direction:column;box-shadow:1px 1px 5px #ddd;padding:5px;margin-bottom:5px}.axes[_ngcontent-%COMP%]   p[_ngcontent-%COMP%]{margin:0;font-size:.8em}.axes[_ngcontent-%COMP%]   .title[_ngcontent-%COMP%]{font-weight:700;margin-bottom:10px;font-size:.9em}@font-face{font-family:Satisfy;font-style:normal;font-weight:400;font-display:swap;src:local("Satisfy Regular"),local("Satisfy-Regular"),url(https://fonts.gstatic.com/s/satisfy/v11/rP2Hp2yn6lkG50LoCZOIHQ.woff2) format("woff2");unicode-range:u+00??,u+0131,u+0152-0153,u+02bb-02bc,u+02c6,u+02da,u+02dc,u+2000-206f,u+2074,u+20ac,u+2122,u+2191,u+2193,u+2212,u+2215,u+feff,u+fffd}.textAlign-left[_ngcontent-%COMP%]{text-align:left}.textAlign-right[_ngcontent-%COMP%], .textSouTitre[_ngcontent-%COMP%]{text-align:right}.textSouTitre[_ngcontent-%COMP%]{margin-bottom:2%;font-size:.9em;color:rgba(0,0,0,.4392156862745098)}']}),t})()}];let St=(()=>{class t{}return t.\u0275mod=s.Lb({type:t}),t.\u0275inj=s.Kb({factory:function(e){return new(e||t)},imports:[[F.h.forChild(gt)],F.h]}),t})();var Tt=i("tk/3"),vt=i("2thQ"),Ct=i("Fr4G"),Ot=i("Ry++"),Pt=i("gct3");let yt=(()=>{class t{}return t.\u0275mod=s.Lb({type:t}),t.\u0275inj=s.Kb({factory:function(e){return new(e||t)},providers:[],imports:[[a.c,St,Tt.c,vt.a,u.i,u.q,n.a,Ct.a,Ot.a,O.b,Pt.a]]}),t})()}}]);