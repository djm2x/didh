(window.webpackJsonp=window.webpackJsonp||[]).push([[29],{VyW6:function(t,e,i){"use strict";i.r(e),i.d(e,"VisiteModule",function(){return Ct});var n=i("Dgsr"),a=i("ofXK"),o=i("mrSG"),s=i("ukCm"),c=i("fXoL"),r=i("M9IT"),l=i("Dh3D"),d=i("XNiG"),b=i("VRyK"),m=i("0IaG"),u=i("3Pt+"),p=i("7q3A"),h=i("/t3+"),f=i("f0Cb"),g=i("kmnG"),S=i("qFsG"),T=i("iadO"),O=i("3IEU"),C=i("bTqV"),v=i("sYmb");let P=(()=>{class t{constructor(t,e,i,n){this.dialogRef=t,this.data=e,this.fb=i,this.uow=n,this.title="",this.folderToSaveInServer="visite",this.lienUploadTo=new d.a,this.lienUploadFrom=new d.a,this.discoursTo=new d.a,this.discoursFrom=new d.a,this.miseOeuvrePieceTo=new d.a,this.miseOeuvrePieceFrom=new d.a,this.eventSubmitFromParent=new d.a}ngOnInit(){this.o=this.data.model,this.title=this.data.title,this.createForm(),this.discoursFrom.subscribe(t=>this.myForm.get("discours").setValue(t)),this.lienUploadFrom.subscribe(t=>this.myForm.get("lienUpload").setValue(t)),this.miseOeuvrePieceFrom.subscribe(t=>this.myForm.get("miseOeuvrePiece").setValue(t)),setTimeout(()=>{this.miseOeuvrePieceTo.next(this.o.miseOeuvrePiece),this.lienUploadTo.next(this.o.lienUpload),this.discoursTo.next(this.o.discours)},100)}createForm(){this.myForm=this.fb.group({id:this.o.id,mandat:[this.o.mandat,u.s.required],mandatAr:[this.o.mandatAr,u.s.required],discours:[this.o.discours],date:[this.o.date,u.s.required],lienRapport:[this.o.lienRapport],lienUpload:[this.o.lienUpload],miseOeuvrePiece:[this.o.miseOeuvrePiece]})}onNoClick(){this.dialogRef.close()}onOkClick(t){this.submit(t)}submit(t){t.date=this.uow.valideDate(t.date),0===this.o.id?this.uow.visites.post(t).subscribe(t=>Object(o.a)(this,void 0,void 0,function*(){this.eventSubmitFromParent.next(!0),this.dialogRef.close(!0)})):this.uow.visites.put(t.id,t).subscribe(t=>Object(o.a)(this,void 0,void 0,function*(){this.eventSubmitFromParent.next(!0),this.dialogRef.close(!0)}))}resetForm(){this.o=new s.q,this.createForm()}}return t.\u0275fac=function(e){return new(e||t)(c.Nb(m.g),c.Nb(m.a),c.Nb(u.d),c.Nb(p.a))},t.\u0275cmp=c.Hb({type:t,selectors:[["app-update"]],decls:51,vars:47,consts:[[1,"dialog"],["mat-dialog-title",""],["role","toolbar",1,"task-header"],[1,"content"],["mat-dialog-content",""],[3,"formGroup"],["appearance","fill"],["matInput","","formControlName","mandat","required",""],["matInput","","formControlName","mandatAr","required",""],["matInput","","formControlName","discours","placeholder","Discours du pr\xe9sident"],["matInput","","formControlName","date",3,"matDatepicker"],["matSuffix","",3,"for"],["picker",""],[3,"nameBtn","folderToSaveInServer","propertyOfParent","eventSubmitToParent","eventSubmitFromParent"],["matInput","","formControlName","lienRapport"],["mat-dialog-actions","",1,"actions"],["mat-button","","type","button",3,"click"],["mat-raised-button","","cdkFocusInitial","","color","primary",3,"disabled","click"]],template:function(t,e){if(1&t&&(c.Tb(0,"div",0),c.Tb(1,"h1",1),c.Tb(2,"mat-toolbar",2),c.Tb(3,"span"),c.Cc(4),c.Sb(),c.Sb(),c.Ob(5,"mat-divider"),c.Sb(),c.Tb(6,"div",3),c.Tb(7,"div",4),c.Tb(8,"form",5),c.Tb(9,"mat-form-field",6),c.Tb(10,"mat-label"),c.Cc(11),c.fc(12,"translate"),c.Sb(),c.Ob(13,"input",7),c.Sb(),c.Tb(14,"mat-form-field",6),c.Tb(15,"mat-label"),c.Cc(16),c.fc(17,"translate"),c.Sb(),c.Ob(18,"input",8),c.Sb(),c.Tb(19,"mat-form-field",6),c.Tb(20,"mat-label"),c.Cc(21),c.fc(22,"translate"),c.Sb(),c.Ob(23,"textarea",9),c.Sb(),c.Tb(24,"mat-form-field",6),c.Tb(25,"mat-label"),c.Cc(26),c.fc(27,"translate"),c.Sb(),c.Ob(28,"input",10),c.Ob(29,"mat-datepicker-toggle",11),c.Ob(30,"mat-datepicker",null,12),c.Sb(),c.Ob(32,"app-upload-select",13),c.fc(33,"translate"),c.Ob(34,"app-upload-select",13),c.fc(35,"translate"),c.Ob(36,"app-upload-select",13),c.fc(37,"translate"),c.Tb(38,"mat-form-field",6),c.Tb(39,"mat-label"),c.Cc(40),c.fc(41,"translate"),c.Sb(),c.Ob(42,"input",14),c.Sb(),c.Sb(),c.Sb(),c.Tb(43,"div",15),c.Tb(44,"button",16),c.ac("click",function(){return e.onNoClick()}),c.Cc(45),c.fc(46,"translate"),c.Sb(),c.Cc(47,"\xa0\xa0 "),c.Tb(48,"button",17),c.ac("click",function(){return e.onOkClick(e.myForm.value)}),c.Cc(49),c.fc(50,"translate"),c.Sb(),c.Sb(),c.Sb(),c.Sb()),2&t){const t=c.qc(31);c.Bb(4),c.Dc(e.title),c.Bb(4),c.kc("formGroup",e.myForm),c.Bb(3),c.Dc(c.gc(12,27,"admin.ps.update.Mandat")),c.Bb(5),c.Dc(c.gc(17,29,"admin.ps.update.MandatAr")),c.Bb(5),c.Dc(c.gc(22,31,"admin.ps.update.Discours_du_pr\xe9sident")),c.Bb(5),c.Dc(c.gc(27,33,"admin.ps.update.Date_pr\xe9vue")),c.Bb(2),c.kc("matDatepicker",t),c.Bb(1),c.kc("for",t),c.Bb(3),c.lc("nameBtn",c.gc(33,35,"admin.ps.update.RAPPORT_NATIONAL_DE_LA_VISITE")),c.kc("folderToSaveInServer",e.folderToSaveInServer)("propertyOfParent",e.lienUploadTo)("eventSubmitToParent",e.lienUploadFrom)("eventSubmitFromParent",e.eventSubmitFromParent),c.Bb(2),c.lc("nameBtn",c.gc(35,37,"admin.ps.update.RAPPORT_DE_LA_PROCEDURE_REACTION_NATIONALE")),c.kc("folderToSaveInServer",e.folderToSaveInServer)("propertyOfParent",e.discoursTo)("eventSubmitToParent",e.discoursFrom)("eventSubmitFromParent",e.eventSubmitFromParent),c.Bb(2),c.lc("nameBtn",c.gc(37,39,"admin.ps.update.PLAN_DE_MISE_EN_OEUVRE")),c.kc("folderToSaveInServer",e.folderToSaveInServer)("propertyOfParent",e.miseOeuvrePieceTo)("eventSubmitToParent",e.miseOeuvrePieceFrom)("eventSubmitFromParent",e.eventSubmitFromParent),c.Bb(4),c.Dc(c.gc(41,41,"admin.ps.update.Lien_externe")),c.Bb(5),c.Dc(c.gc(46,43,"admin.Retour")),c.Bb(3),c.kc("disabled",e.myForm.invalid),c.Bb(1),c.Dc(c.gc(50,45,"admin.Enregistre"))}},directives:[m.h,h.a,f.a,m.e,u.t,u.n,u.h,g.c,g.f,S.b,u.c,u.m,u.g,u.r,T.b,T.d,g.g,T.a,O.a,m.c,C.a],pipes:[v.c],styles:["mat-form-field[_ngcontent-%COMP%]{width:100%}.dialog[_ngcontent-%COMP%]{overflow-x:hidden;overflow-y:hidden}.dialog[_ngcontent-%COMP%]   h1[_ngcontent-%COMP%]   span[_ngcontent-%COMP%]{padding:0 5px}.dialog[_ngcontent-%COMP%]   .content[_ngcontent-%COMP%]{padding:0 20px 25px}.dialog[_ngcontent-%COMP%]   .actions[_ngcontent-%COMP%]{display:flex;flex-direction:row-reverse}.myrow[_ngcontent-%COMP%]{display:flex;align-items:center}img[_ngcontent-%COMP%]{height:20px}"]}),t})(),y=(()=>{class t{constructor(t,e){this.dialogRef=t,this.data=e,this.title=""}ngOnInit(){this.o=this.data.model,this.title=this.data.title,console.log(this.o)}onNoClick(){this.dialogRef.close()}onOkClick(t){}}return t.\u0275fac=function(e){return new(e||t)(c.Nb(m.g),c.Nb(m.a))},t.\u0275cmp=c.Hb({type:t,selectors:[["app-update"]],decls:17,vars:6,consts:[[1,"dialog"],["mat-dialog-title",""],["role","toolbar",1,"task-header"],[1,"content"],["mat-dialog-content",""],["mat-dialog-actions","",1,"actions"],["mat-button","","type","button",3,"click"]],template:function(t,e){1&t&&(c.Tb(0,"div",0),c.Tb(1,"h1",1),c.Tb(2,"mat-toolbar",2),c.Tb(3,"span"),c.Cc(4),c.Sb(),c.Sb(),c.Ob(5,"mat-divider"),c.Sb(),c.Tb(6,"div",3),c.Tb(7,"div",4),c.Tb(8,"ul"),c.Tb(9,"li"),c.Cc(10),c.Sb(),c.Tb(11,"li"),c.Cc(12),c.fc(13,"date"),c.Sb(),c.Sb(),c.Sb(),c.Tb(14,"div",5),c.Tb(15,"button",6),c.ac("click",function(){return e.onNoClick()}),c.Cc(16,"Retour"),c.Sb(),c.Sb(),c.Sb(),c.Sb()),2&t&&(c.Bb(4),c.Dc(e.title),c.Bb(6),c.Ec("Objet: ",e.o.mandat,""),c.Bb(2),c.Ec("Date pr\xe9vu: ",c.hc(13,3,e.o.date,"dd/MM/yyyy"),""))},directives:[m.h,h.a,f.a,m.e,m.c,C.a],pipes:[a.e],styles:["mat-form-field[_ngcontent-%COMP%]{width:100%}.dialog[_ngcontent-%COMP%]{overflow-x:hidden;overflow-y:hidden}.dialog[_ngcontent-%COMP%]   h1[_ngcontent-%COMP%]   span[_ngcontent-%COMP%]{padding:0 5px}.dialog[_ngcontent-%COMP%]   .content[_ngcontent-%COMP%]{padding:0 20px 25px}.dialog[_ngcontent-%COMP%]   .actions[_ngcontent-%COMP%]{display:flex;flex-direction:row-reverse}.myrow[_ngcontent-%COMP%]{display:flex;align-items:center}"]}),t})();var _=i("MutI"),w=i("FKr1");function D(t,e){if(1&t){const t=c.Ub();c.Tb(0,"mat-list-item",12),c.ac("click",function(){c.sc(t);const i=e.$implicit;return c.ec().download(i.substring(0,i.length-1))}),c.Tb(1,"span",13),c.Cc(2),c.Sb(),c.Sb()}if(2&t){const t=e.$implicit;c.Bb(2),c.Ec("- ",t.substring(14,t.length-1),"")}}function B(t,e){if(1&t){const t=c.Ub();c.Tb(0,"mat-list-item",12),c.ac("click",function(){c.sc(t);const i=e.$implicit;return c.ec().download(i.substring(0,i.length-1))}),c.Tb(1,"span",13),c.Cc(2),c.Sb(),c.Sb()}if(2&t){const t=e.$implicit;c.Bb(2),c.Ec("- ",t.substring(14,t.length-1),"")}}function x(t,e){if(1&t){const t=c.Ub();c.Tb(0,"mat-list-item",12),c.ac("click",function(){c.sc(t);const i=e.$implicit;return c.ec().download(i.substring(0,i.length-1))}),c.Tb(1,"span",13),c.Cc(2),c.Sb(),c.Sb()}if(2&t){const t=e.$implicit;c.Bb(2),c.Ec("- ",t.substring(14,t.length-1),"")}}let M=(()=>{class t{constructor(t,e,i){this.dialogRef=t,this.data=e,this.url=i,this.title="",this.folder="organe"}ngOnInit(){this.o=this.data.model,this.title=this.data.title}propertyToList(t){if(t){const e=t.split(";");return e.pop(),e}return[]}download(t){window.open(`${this.url}/${this.folder}/${t}`)}}return t.\u0275fac=function(e){return new(e||t)(c.Nb(m.g),c.Nb(m.a),c.Nb("BASE_URL"))},t.\u0275cmp=c.Hb({type:t,selectors:[["app-archive"]],decls:27,vars:4,consts:[[1,"dialog"],["mat-dialog-title",""],["role","toolbar",1,"task-header"],[1,"content"],["mat-dialog-content",""],[1,"row"],[1,"col"],[2,"font-weight","bold"],["role","list"],["matRipple","","style","cursor: pointer;",3,"click",4,"ngFor","ngForOf"],["mat-dialog-actions","",1,"actions"],["mat-button","","type","button",3,"click"],["matRipple","",2,"cursor","pointer",3,"click"],[2,"font-size",".9em"]],template:function(t,e){1&t&&(c.Tb(0,"div",0),c.Tb(1,"h1",1),c.Tb(2,"mat-toolbar",2),c.Tb(3,"span"),c.Cc(4),c.Sb(),c.Sb(),c.Ob(5,"mat-divider"),c.Sb(),c.Tb(6,"div",3),c.Tb(7,"div",4),c.Tb(8,"div",5),c.Tb(9,"div",6),c.Tb(10,"p",7),c.Cc(11,"Rapport"),c.Sb(),c.Tb(12,"mat-list",8),c.Bc(13,D,3,1,"mat-list-item",9),c.Sb(),c.Sb(),c.Tb(14,"div",6),c.Tb(15,"p",7),c.Cc(16,"Discours du pr\xe9sident"),c.Sb(),c.Tb(17,"mat-list",8),c.Bc(18,B,3,1,"mat-list-item",9),c.Sb(),c.Sb(),c.Tb(19,"div",6),c.Tb(20,"p",7),c.Cc(21,"Plan de mise en \u0153uvre"),c.Sb(),c.Tb(22,"mat-list",8),c.Bc(23,x,3,1,"mat-list-item",9),c.Sb(),c.Sb(),c.Sb(),c.Sb(),c.Tb(24,"div",10),c.Tb(25,"button",11),c.ac("click",function(){return e.dialogRef.close()}),c.Cc(26,"Retour"),c.Sb(),c.Sb(),c.Sb(),c.Sb()),2&t&&(c.Bb(4),c.Dc(e.title),c.Bb(9),c.kc("ngForOf",e.propertyToList(e.o.lienUpload)),c.Bb(5),c.kc("ngForOf",e.propertyToList(e.o.discours)),c.Bb(5),c.kc("ngForOf",e.propertyToList(e.o.miseOeuvrePiece)))},directives:[m.h,h.a,f.a,m.e,_.a,a.l,m.c,C.a,_.b,w.t],styles:["mat-form-field[_ngcontent-%COMP%]{width:100%}.dialog[_ngcontent-%COMP%]{overflow-x:hidden;overflow-y:hidden}.dialog[_ngcontent-%COMP%]   h1[_ngcontent-%COMP%]   span[_ngcontent-%COMP%]{padding:0 5px}.dialog[_ngcontent-%COMP%]   .content[_ngcontent-%COMP%]{padding:0 20px 25px}.dialog[_ngcontent-%COMP%]   .actions[_ngcontent-%COMP%]{display:flex;flex-direction:row-reverse}.myrow[_ngcontent-%COMP%]{display:flex;align-items:center}img[_ngcontent-%COMP%]{height:20px}"]}),t})();var k=i("ZTdd"),R=i("5F3i"),N=i("2ChS"),I=i("tyNb"),E=i("0hB7"),F=i("J3i2"),A=i("/ysL"),L=i("2HI4"),U=i("+Ya6"),$=i("x3GN"),V=i("oTHA"),z=i("+0xr"),j=i("NFeN"),q=i("Xa2L"),H=i("Qu3c");function G(t,e){if(1&t){const t=c.Ub();c.Tb(0,"div",26),c.Tb(1,"button",27),c.ac("click",function(){return c.sc(t),c.ec().add()}),c.Tb(2,"mat-icon"),c.Cc(3,"add"),c.Sb(),c.Cc(4),c.fc(5,"translate"),c.Sb(),c.Sb()}2&t&&(c.Bb(4),c.Ec(" ",c.gc(5,1,"admin.ps.Proc\xe9dure_sp\xe9ciale")," "))}function Q(t,e){1&t&&c.Ob(0,"mat-spinner")}function J(t,e){if(1&t&&(c.Tb(0,"div",28),c.Bc(1,Q,1,0,"mat-spinner",29),c.Sb()),2&t){const t=c.ec();c.Bb(1),c.kc("ngIf",t.isLoadingResults)}}function K(t,e){1&t&&(c.Tb(0,"th",30),c.Cc(1),c.fc(2,"translate"),c.Sb()),2&t&&(c.Bb(1),c.Dc(c.gc(2,1,"admin.ps.list.MANDAT")))}function X(t,e){if(1&t&&(c.Tb(0,"td",31),c.Cc(1),c.Sb()),2&t){const t=e.$implicit,i=c.ec();c.Bb(1),c.Dc("fr"===i.mytranslate.langSync?t.mandat:t.mandatAr)}}function Y(t,e){1&t&&(c.Tb(0,"th",30),c.Cc(1),c.fc(2,"translate"),c.Sb()),2&t&&(c.Bb(1),c.Dc(c.gc(2,1,"admin.ps.list.Date_de_la_visite")))}function Z(t,e){if(1&t&&(c.Tb(0,"td",31),c.Cc(1),c.fc(2,"date"),c.Sb()),2&t){const t=e.$implicit,i=c.ec();c.Bb(1),c.Dc(c.hc(2,1,t[i.columnDefs[1].columnDef],"dd/MM/yyyy"))}}function W(t,e){1&t&&(c.Tb(0,"th",32),c.Cc(1),c.fc(2,"translate"),c.Sb()),2&t&&(c.Bb(1),c.Ec(" ",c.gc(2,1,"admin.ps.list.RAPPORT_DE_LA_PROCEDURE_REACTION_NATIONALE"),""))}function tt(t,e){if(1&t){const t=c.Ub();c.Tb(0,"td",31),c.Tb(1,"button",33),c.ac("click",function(){c.sc(t);const i=e.$implicit;return c.ec().showPieceJoin(i.discours)}),c.Tb(2,"mat-icon"),c.Cc(3,"cloud_download"),c.Sb(),c.Sb(),c.Sb()}if(2&t){const t=e.$implicit,i=c.ec();c.Bb(1),c.kc("disabled",i.disable(t.discours))("matTooltip",t.discours)}}function et(t,e){1&t&&(c.Tb(0,"th",32),c.Cc(1),c.fc(2,"translate"),c.Sb()),2&t&&(c.Bb(1),c.Dc(c.gc(2,1,"admin.ps.list.PLAN_DE_MISE_EN_OEUVRE")))}function it(t,e){if(1&t){const t=c.Ub();c.Tb(0,"td",31),c.Tb(1,"button",34),c.ac("click",function(){c.sc(t);const i=e.$implicit;return c.ec().showPieceJoin(i.miseOeuvrePiece)}),c.Tb(2,"mat-icon"),c.Cc(3,"cloud_download"),c.Sb(),c.Sb(),c.Sb()}if(2&t){const t=e.$implicit,i=c.ec();c.Bb(1),c.kc("disabled",i.disable(t.miseOeuvrePiece))("matTooltip",t.miseOeuvrePiece)}}function nt(t,e){1&t&&(c.Tb(0,"th",32),c.Cc(1),c.fc(2,"translate"),c.Sb()),2&t&&(c.Bb(1),c.Dc(c.gc(2,1,"admin.ps.list.RAPPORT_NATIONAL_DE_LA_VISITE")))}function at(t,e){if(1&t){const t=c.Ub();c.Tb(0,"td",31),c.Tb(1,"button",33),c.ac("click",function(){c.sc(t);const i=e.$implicit;return c.ec().showPieceJoin(i.lienUpload)}),c.Tb(2,"mat-icon"),c.Cc(3,"cloud_download"),c.Sb(),c.Sb(),c.Sb()}if(2&t){const t=e.$implicit,i=c.ec();c.Bb(1),c.kc("disabled",i.disable(t.lienUpload))("matTooltip",t.lienUpload)}}function ot(t,e){1&t&&c.Ob(0,"th",32)}function st(t,e){if(1&t){const t=c.Ub();c.Tb(0,"button",37),c.ac("click",function(){c.sc(t);const e=c.ec(2).$implicit;return c.ec().edit(e)}),c.Tb(1,"mat-icon"),c.Cc(2,"create"),c.Sb(),c.Sb()}}function ct(t,e){if(1&t){const t=c.Ub();c.Tb(0,"button",41),c.ac("click",function(){c.sc(t);const e=c.ec(2).$implicit;return c.ec().archive(e)}),c.Tb(1,"mat-icon"),c.Cc(2,"unarchive"),c.Sb(),c.Sb()}}function rt(t,e){if(1&t){const t=c.Ub();c.Tb(0,"button",42),c.ac("click",function(){c.sc(t);const e=c.ec(2).$implicit;return c.ec().delete(e)}),c.Tb(1,"mat-icon"),c.Cc(2,"delete_sweep"),c.Sb(),c.Sb()}}function lt(t,e){if(1&t){const t=c.Ub();c.Tb(0,"div",36),c.Tb(1,"button",37),c.ac("click",function(){c.sc(t);const e=c.ec().$implicit;return c.ec().openDialogDetail(e)}),c.Tb(2,"mat-icon"),c.Cc(3,"visibility"),c.Sb(),c.Sb(),c.Bc(4,st,3,0,"button",38),c.Bc(5,ct,3,0,"button",39),c.Bc(6,rt,3,0,"button",40),c.Sb()}if(2&t){const t=c.ec(2);c.Bb(4),c.kc("ngIf",!t.session.isPointFocal&&!t.session.isSuperViseur),c.Bb(1),c.kc("ngIf",!t.session.isPointFocal&&!t.session.isSuperViseur),c.Bb(1),c.kc("ngIf",!t.session.isPointFocal&&!t.session.isSuperViseur)}}function dt(t,e){if(1&t&&(c.Tb(0,"td",31),c.Bc(1,lt,7,3,"div",35),c.Sb()),2&t){const t=c.ec();c.Bb(1),c.kc("ngIf",!t.session.isPublic)}}function bt(t,e){1&t&&c.Ob(0,"tr",43)}function mt(t,e){1&t&&c.Ob(0,"tr",44)}const ut=function(){return[10,25,50,100,250]},pt=[{path:"",redirectTo:"list",pathMatch:"full"},{path:"list",component:(()=>{class t{constructor(t,e,i,n,a,o,s,r){this.uow=t,this.dialog=e,this.mydialog=i,this.bottomSheet=n,this.url=a,this.route=o,this.session=s,this.mytranslate=r,this.update=new c.o,this.isLoadingResults=!0,this.resultsLength=0,this.isRateLimitReached=!1,this.dataSource=[],this.columnDefs=[{columnDef:"mandat",headName:"MANDAT"},{columnDef:"date",headName:"Date de la visite"},{columnDef:"lienUpload",headName:"RAPPORT NATIONAL DE LA VISITE"},{columnDef:"discours",headName:"RAPPORT DE LA PROCEDURE/REACTION NATIONALE"},{columnDef:"miseOeuvrePiece",headName:"PLAN DE MISE EN OEUVRE"},{columnDef:"option",headName:"OPTION"}].map(t=>(t.headName=""===t.headName?t.columnDef.toUpperCase():t.headName.toUpperCase(),t)),this.displayedColumns=this.columnDefs.filter(t=>"discours"!==t.columnDef&&"miseOeuvrePiece"!==t.columnDef).map(t=>t.columnDef),this.progress=0,this.formData=new FormData,this.text="",this.text2=this.text.substring(0,600),this.countRec=new d.a,this.mecanismeState=new d.a,this.stateByMecanisme=new d.a,this.stateDetailByMecanisme=new d.a}ngOnInit(){setTimeout(()=>this.getPage(0,10,"id","desc"),300),Object(b.a)(this.sort.sortChange,this.paginator.page,this.update).subscribe(t=>{!0===t?this.paginator.pageIndex=0:t=t,this.paginator.pageSize?t=t:this.paginator.pageSize=10;const e=this.paginator.pageIndex*this.paginator.pageSize;this.isLoadingResults=!0,this.getPage(e,this.paginator.pageSize,this.sort.active?this.sort.active:"id",this.sort.direction?this.sort.direction:"desc")}),this.route.queryParams.subscribe(t=>{const e=t.data;e&&this.uow.visites.getOne(e).subscribe(t=>{this.openDialogDetail(t)})}),this.getMecanismeState(),this.getStateByMecanisme(),this.getStateDetailByMecanisme()}disable(t){return!t||""===t}openDialogDetail(t){return this.dialog.open(y,{width:"7100px",disableClose:!0,data:{model:t,title:"Visite"}}).afterClosed()}moreInfo(){this.text2=600===this.text2.length?this.text:this.text.substring(0,600)}getPage(t,e,i,n){this.uow.visites.getList(t,e,i,n).subscribe(t=>{console.log(t.list),this.dataSource=t.list,this.resultsLength=t.count,this.isLoadingResults=!1})}openDialog(t,e){return this.dialog.open(P,{width:"7100px",disableClose:!0,data:{model:t,title:e}}).afterClosed()}add(){this.openDialog(new s.q,this.mytranslate.get("admin.ps.list.Ajouter_Proc\xe9dure_sp\xe9ciale")).subscribe(t=>{t&&this.update.next(!0)})}archive(t){this.dialog.open(M,{width:"80vw",disableClose:!0,data:{model:t,title:t.mandat}})}edit(t){this.openDialog(t,this.mytranslate.get("admin.ps.list.Modifier_Proc\xe9dure_sp\xe9ciale")).subscribe(t=>{t&&this.update.next(!0)})}delete(t){return Object(o.a)(this,void 0,void 0,function*(){if("ok"===(yield this.mydialog.openDialog("Proc\xe9dure sp\xe9ciale").toPromise())){let e=[];""!==t.lienUpload?e.push(...this.uow.decoupe(t.lienUpload)):e=e,""!==t.discours?e.push(...this.uow.decoupe(t.discours)):e=e,this.uow.files.deleteFiles(e,"visite").subscribe(e=>{this.uow.examens.delete(t.id).subscribe(()=>this.update.next(!0))})}})}showPieceJoin(t){this.bottomSheet.open(k.a,{data:{fileName:t,folder:"visite"}})}getMecanismeState(){this.uow.visites.mecanismeState().subscribe(t=>{const e=[];e.push(this.mytranslate.get("NonR\xe9alis\xe9")),e.push(this.mytranslate.get("EnCours")),e.push(this.mytranslate.get("Recommendation_continue")),e.push(this.mytranslate.get("R\xe9alis\xe9"));const i=[],n=[];i.push(100*t.one/t.total),i.push(100*t.two/t.total),i.push(100*t.three/t.total),i.push(100*t.four/t.total),n.push(t.one,t.two,t.three,t.four),this.countRec.next(t.one+t.two+t.three+t.four),this.mecanismeState.next({chartLabels:e,chartData:i,chartColors:["#db0707","#f7801e","#2d71a1","#2b960b","#ffffff"],dataToShowInTable:n,title:this.mytranslate.get("admin.header.OrganesdeTrait\xe9s")})})}getStateByMecanisme(){this.uow.visites.stateByMecanisme().subscribe(t=>{const e=t.map(t=>t.name),i=t.map(t=>+t.one.toFixed(0));this.stateByMecanisme.next({chartLabels:e,chartData:i,chartColors:[],dataToShowInTable:[],title:this.mytranslate.get("admin.organe.OrganesdeTrait\xe9s")})})}getStateDetailByMecanisme(){this.uow.visites.stateDetailByMecanisme().subscribe(t=>{const e=(t=t.filter(t=>null!==t.name)).map(t=>t.name),i=[{data:[],label:this.mytranslate.get("NonR\xe9alis\xe9")},{data:[],label:this.mytranslate.get("EnCours")},{data:[],label:this.mytranslate.get("Recommendation_continue")},{data:[],label:this.mytranslate.get("R\xe9alis\xe9")}];t.forEach(t=>{i[0].data.push((100*t.one/t.total).toFixed(0)),i[1].data.push((100*t.two/t.total).toFixed(0)),i[2].data.push((100*t.three/t.total).toFixed(0)),i[3].data.push((100*t.four/t.total).toFixed(0))}),this.stateDetailByMecanisme.next({barChartLabels:e,barChartData:i,title:this.mytranslate.get("admin.organe.list.Miseen\u0153uvredesrecommandationsparOrganesdeTrait\xe9s")})})}}return t.\u0275fac=function(e){return new(e||t)(c.Nb(p.a),c.Nb(m.b),c.Nb(R.a),c.Nb(N.b),c.Nb("BASE_URL"),c.Nb(I.a),c.Nb(E.a),c.Nb(F.a))},t.\u0275cmp=c.Hb({type:t,selectors:[["app-visite"]],viewQuery:function(t,e){if(1&t&&(c.xc(r.a,!0),c.xc(l.a,!0)),2&t){let t;c.pc(t=c.bc())&&(e.paginator=t.first),c.pc(t=c.bc())&&(e.sort=t.first)}},decls:42,vars:23,consts:[[1,"host"],[3,"title"],["class","right",4,"ngIf"],["mecanisme","ps"],[1,"row","mb-4","justify-content-center"],[1,"col-md-5"],[3,"obs"],[1,"col-md-2","p-0"],["ifEpu","true",3,"count","height"],[1,"col-md-12"],[1,"chart-size"],[3,"col","height","dataSubject"],[1,"example-container","mat-elevation-z8"],["class","example-loading-shade",4,"ngIf"],[1,"example-table-container"],["mat-table","","multiTemplateDataRows","","aria-label","Elements","matSort","",3,"dataSource"],["table",""],[3,"matColumnDef"],["mat-header-cell","","mat-sort-header","",4,"matHeaderCellDef"],["mat-cell","",4,"matCellDef"],["mat-header-cell","",4,"matHeaderCellDef"],["matColumnDef","option",2,"flex-direction","row-reverse"],["mat-header-row","",4,"matHeaderRowDef"],["mat-row","",4,"matRowDef","matRowDefColumns"],["pageIndex","0","pageSize","10","showFirstLastButtons","",3,"length","pageSizeOptions"],["paginator",""],[1,"right"],["mat-raised-button","","color","primary",1,"mt-3",3,"click"],[1,"example-loading-shade"],[4,"ngIf"],["mat-header-cell","","mat-sort-header",""],["mat-cell",""],["mat-header-cell",""],["mat-icon-button","","color","accent",3,"disabled","matTooltip","click"],["mat-icon-button","","color","accent",1,"center",3,"disabled","matTooltip","click"],["class","button-row",4,"ngIf"],[1,"button-row"],["mat-icon-button","","color","primary",3,"click"],["mat-icon-button","","color","primary",3,"click",4,"ngIf"],["mat-icon-button","","color","accent",3,"click",4,"ngIf"],["mat-icon-button","","color","warn",3,"click",4,"ngIf"],["mat-icon-button","","color","accent",3,"click"],["mat-icon-button","","color","warn",3,"click"],["mat-header-row",""],["mat-row",""]],template:function(t,e){1&t&&(c.Tb(0,"div",0),c.Ob(1,"app-title",1),c.fc(2,"translate"),c.Bc(3,G,6,3,"div",2),c.Ob(4,"app-intros",3),c.Tb(5,"div",4),c.Tb(6,"div",5),c.Ob(7,"app-pie",6),c.Sb(),c.Tb(8,"div",7),c.Ob(9,"app-count",8),c.Sb(),c.Tb(10,"div",5),c.Ob(11,"app-pie",6),c.Sb(),c.Tb(12,"div",9),c.Tb(13,"div",10),c.Ob(14,"app-bar",11),c.Sb(),c.Sb(),c.Sb(),c.Tb(15,"div",12),c.Bc(16,J,2,1,"div",13),c.Tb(17,"div",14),c.Tb(18,"table",15,16),c.Rb(20,17),c.Bc(21,K,3,3,"th",18),c.Bc(22,X,2,1,"td",19),c.Qb(),c.Rb(23,17),c.Bc(24,Y,3,3,"th",18),c.Bc(25,Z,3,4,"td",19),c.Qb(),c.Rb(26,17),c.Bc(27,W,3,3,"th",20),c.Bc(28,tt,4,2,"td",19),c.Qb(),c.Rb(29,17),c.Bc(30,et,3,3,"th",20),c.Bc(31,it,4,2,"td",19),c.Qb(),c.Rb(32,17),c.Bc(33,nt,3,3,"th",20),c.Bc(34,at,4,2,"td",19),c.Qb(),c.Rb(35,21),c.Bc(36,ot,1,0,"th",20),c.Bc(37,dt,2,1,"td",19),c.Qb(),c.Bc(38,bt,1,0,"tr",22),c.Bc(39,mt,1,0,"tr",23),c.Sb(),c.Sb(),c.Ob(40,"mat-paginator",24,25),c.Sb(),c.Sb()),2&t&&(c.Bb(1),c.lc("title",c.gc(2,20,"admin.ps.Proc\xe9dure_sp\xe9ciales")),c.Bb(2),c.kc("ngIf",e.session.isAdmin),c.Bb(4),c.kc("obs",e.mecanismeState),c.Bb(2),c.kc("count",e.countRec)("height","55vh"),c.Bb(2),c.kc("obs",e.stateByMecanisme),c.Bb(3),c.kc("col",12)("height","70vh")("dataSubject",e.stateDetailByMecanisme),c.Bb(2),c.kc("ngIf",e.isLoadingResults),c.Bb(2),c.kc("dataSource",e.dataSource),c.Bb(2),c.kc("matColumnDef",e.columnDefs[0].columnDef),c.Bb(3),c.kc("matColumnDef",e.columnDefs[1].columnDef),c.Bb(3),c.kc("matColumnDef",e.columnDefs[2].columnDef),c.Bb(3),c.kc("matColumnDef",e.columnDefs[3].columnDef),c.Bb(3),c.kc("matColumnDef",e.columnDefs[4].columnDef),c.Bb(6),c.kc("matHeaderRowDef",e.displayedColumns),c.Bb(1),c.kc("matRowDefColumns",e.displayedColumns),c.Bb(1),c.kc("length",e.resultsLength)("pageSizeOptions",c.mc(22,ut)))},directives:[A.a,a.m,L.a,U.a,$.a,V.a,z.j,l.a,z.c,z.e,z.b,z.g,z.i,r.a,C.a,j.a,q.b,z.d,l.b,z.a,H.a,z.f,z.h],pipes:[v.c,a.e],styles:['section[_ngcontent-%COMP%]{display:flex!important;justify-content:space-between!important;align-items:center!important}  h3{margin:0!important}.mat-cell[_ngcontent-%COMP%]:last-child,   .mat-header-cell:last-child{width:180px!important}.border-left[_ngcontent-%COMP%]{border-left:10px solid #a19b9e}.border-right[_ngcontent-%COMP%]{border-right:10px solid #a19b9e}.super-title[_ngcontent-%COMP%]{height:45px}.super-title[_ngcontent-%COMP%], .super-title[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]{display:flex;align-items:center}.super-title[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]{background-color:#d17c36;height:35px}.super-title[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]   h3[_ngcontent-%COMP%]{color:#fff;margin:0;padding:0 5px}.super-title2[_ngcontent-%COMP%]{height:45px;display:flex;align-items:center}.super-title2[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]{height:35px;display:flex;align-items:center}.super-title2[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]   h3[_ngcontent-%COMP%]{color:#a19b9e;margin:0;padding:0 5px;font-size:1.8em}.host[_ngcontent-%COMP%]{margin:1em!important}  .mat-progress-spinner circle{fill:rgba(0,0,0,.03137254901960784)!important}h3[_ngcontent-%COMP%]{margin:20px 0 10px;color:var(--primary);text-align:center;font-size:medium}.axes[_ngcontent-%COMP%]{display:flex;flex-direction:column;box-shadow:1px 1px 5px #ddd;padding:5px;margin-bottom:5px}.axes[_ngcontent-%COMP%]   p[_ngcontent-%COMP%]{margin:0;font-size:.8em}.axes[_ngcontent-%COMP%]   .title[_ngcontent-%COMP%]{font-weight:700;margin-bottom:10px;font-size:.9em}@font-face{font-family:Satisfy;font-style:normal;font-weight:400;font-display:swap;src:local("Satisfy Regular"),local("Satisfy-Regular"),url(https://fonts.gstatic.com/s/satisfy/v11/rP2Hp2yn6lkG50LoCZOIHQ.woff2) format("woff2");unicode-range:u+00??,u+0131,u+0152-0153,u+02bb-02bc,u+02c6,u+02da,u+02dc,u+2000-206f,u+2074,u+20ac,u+2122,u+2191,u+2193,u+2212,u+2215,u+feff,u+fffd}.textAlign-left[_ngcontent-%COMP%]{text-align:left}.textAlign-right[_ngcontent-%COMP%], .textSouTitre[_ngcontent-%COMP%]{text-align:right}.textSouTitre[_ngcontent-%COMP%]{margin-bottom:2%;font-size:.9em;color:rgba(0,0,0,.4392156862745098)}']}),t})()}];let ht=(()=>{class t{}return t.\u0275mod=c.Lb({type:t}),t.\u0275inj=c.Kb({factory:function(e){return new(e||t)},imports:[[I.h.forChild(pt)],I.h]}),t})();var ft=i("tk/3"),gt=i("2thQ"),St=i("Fr4G"),Tt=i("Ry++"),Ot=i("gct3");let Ct=(()=>{class t{}return t.\u0275mod=c.Lb({type:t}),t.\u0275inj=c.Kb({factory:function(e){return new(e||t)},providers:[],imports:[[a.c,ht,ft.c,gt.a,u.i,u.q,n.a,St.a,Tt.a,v.b,Ot.a]]}),t})()}}]);