(self.webpackChunkmy_app=self.webpackChunkmy_app||[]).push([[450],{94589:function(t,e,o){"use strict";o.d(e,{b:function(){return l}});var n=o(92935),i=o(35366),a=o(37112),s=o(36278),r=o(84369);let c=(()=>{class t{constructor(t,e){this.dialogRef=t,this.data=e,this.model=""}ngOnInit(){this.model=this.data.model}onNoClick(){this.dialogRef.close()}onOkClick(){this.dialogRef.close("ok")}}return t.\u0275fac=function(e){return new(e||t)(i.Y36(n.so),i.Y36(n.WI))},t.\u0275cmp=i.Xpm({type:t,selectors:[["app-delete"]],decls:15,vars:1,consts:[[1,"dialog"],["mat-dialog-title",""],["role","toolbar",1,"task-header"],[1,"content"],["mat-dialog-content",""],["mat-dialog-actions","",1,"actions"],["mat-button","","type","button",3,"click"],["mat-button","","color","primary","type","button","cdkFocusInitial","",3,"mat-dialog-close","click"]],template:function(t,e){1&t&&(i.TgZ(0,"div",0),i.TgZ(1,"h1",1),i.TgZ(2,"mat-toolbar",2),i.TgZ(3,"span"),i._uU(4),i.qZA(),i.qZA(),i._UZ(5,"mat-divider"),i.qZA(),i.TgZ(6,"div",3),i.TgZ(7,"div",4),i.TgZ(8,"p"),i._uU(9,"Voulez-vous vraiment supprimer?"),i.qZA(),i.qZA(),i.TgZ(10,"div",5),i.TgZ(11,"button",6),i.NdJ("click",function(){return e.onNoClick()}),i._uU(12,"Annuler"),i.qZA(),i.TgZ(13,"button",7),i.NdJ("click",function(){return e.onOkClick()}),i._uU(14,"Ok"),i.qZA(),i.qZA(),i.qZA(),i.qZA()),2&t&&(i.xp6(4),i.hij("Suppression ",e.model," "))},directives:[n.uh,a.Ye,s.d,n.xY,n.H8,r.lW,n.ZT],styles:[".dialog[_ngcontent-%COMP%]{overflow-x:hidden;overflow-y:hidden}.dialog[_ngcontent-%COMP%]   h1[_ngcontent-%COMP%]   span[_ngcontent-%COMP%]{padding:0 5px}.dialog[_ngcontent-%COMP%]   .content[_ngcontent-%COMP%]{padding:0 20px 25px}.dialog[_ngcontent-%COMP%]   .actions[_ngcontent-%COMP%]{display:flex;flex-direction:row-reverse}"]}),t})(),l=(()=>{class t{constructor(t){this.dialog=t}openDialog(t){return this.dialog.open(c,{width:"750px",disableClose:!0,data:{model:t}}).afterClosed()}}return t.\u0275fac=function(e){return new(e||t)(i.LFG(n.uw))},t.\u0275prov=i.Yz7({token:t,factory:t.\u0275fac,providedIn:"root"}),t})()},81450:function(t,e,o){"use strict";o.r(e),o.d(e,{PaysModule:function(){return S}});var n=o(57823),i=o(61116),a=o(64762),s=o(35366),r=o(5609),c=o(59241),l=o(31906),d=o(92935),u=o(31041),m=o(18314),p=o(37112),g=o(36278),h=o(13070),f=o(9550),Z=o(84369);let b=(()=>{class t{constructor(t,e,o){this.dialogRef=t,this.data=e,this.fb=o,this.title=""}ngOnInit(){this.o=this.data.model,this.title=this.data.title,this.createForm()}onNoClick(){this.dialogRef.close()}onOkClick(t){this.dialogRef.close(t)}createForm(){this.myForm=this.fb.group({id:this.o.id,nom:[this.o.nom,u.kI.required],nomAr:[this.o.nomAr,u.kI.required]})}resetForm(){this.o=new m.bU,this.createForm()}}return t.\u0275fac=function(e){return new(e||t)(s.Y36(d.so),s.Y36(d.WI),s.Y36(u.qu))},t.\u0275cmp=s.Xpm({type:t,selectors:[["app-update"]],decls:24,vars:3,consts:[[1,"dialog"],["mat-dialog-title",""],["role","toolbar",1,"task-header"],[1,"content"],["mat-dialog-content",""],[3,"formGroup"],["appearance","fill"],["matInput","","formControlName","nom","required",""],["matInput","","formControlName","nomAr","required",""],["mat-dialog-actions","",1,"actions"],["mat-button","","type","button",3,"click"],["mat-raised-button","","cdkFocusInitial","","color","primary",3,"disabled","click"]],template:function(t,e){1&t&&(s.TgZ(0,"div",0),s.TgZ(1,"h1",1),s.TgZ(2,"mat-toolbar",2),s.TgZ(3,"span"),s._uU(4),s.qZA(),s.qZA(),s._UZ(5,"mat-divider"),s.qZA(),s.TgZ(6,"div",3),s.TgZ(7,"div",4),s.TgZ(8,"form",5),s.TgZ(9,"mat-form-field",6),s.TgZ(10,"mat-label"),s._uU(11,"Nom"),s.qZA(),s._UZ(12,"input",7),s.qZA(),s._uU(13," \xa0 "),s.TgZ(14,"mat-form-field",6),s.TgZ(15,"mat-label"),s._uU(16,"Nom Ar"),s.qZA(),s._UZ(17,"input",8),s.qZA(),s.qZA(),s.qZA(),s.TgZ(18,"div",9),s.TgZ(19,"button",10),s.NdJ("click",function(){return e.onNoClick()}),s._uU(20,"Annuler"),s.qZA(),s._uU(21,"\xa0\xa0 "),s.TgZ(22,"button",11),s.NdJ("click",function(){return e.onOkClick(e.myForm.value)}),s._uU(23,"Enregistre"),s.qZA(),s.qZA(),s.qZA(),s.qZA()),2&t&&(s.xp6(4),s.Oqu(e.title),s.xp6(4),s.Q6J("formGroup",e.myForm),s.xp6(14),s.Q6J("disabled",e.myForm.invalid))},directives:[d.uh,p.Ye,g.d,d.xY,u._Y,u.JL,u.sg,h.KE,h.hX,f.Nt,u.Fj,u.JJ,u.u,u.Q7,d.H8,Z.lW],styles:["mat-form-field[_ngcontent-%COMP%]{width:100%}.dialog[_ngcontent-%COMP%]{overflow-x:hidden;overflow-y:hidden}.dialog[_ngcontent-%COMP%]   h1[_ngcontent-%COMP%]   span[_ngcontent-%COMP%]{padding:0 5px}.dialog[_ngcontent-%COMP%]   .content[_ngcontent-%COMP%]{padding:0 20px 25px}.dialog[_ngcontent-%COMP%]   .actions[_ngcontent-%COMP%]{display:flex;flex-direction:row-reverse}"]}),t})();var x=o(92572),A=o(94589),q=o(77307),w=o(47340),C=o(87672);function _(t,e){1&t&&s._UZ(0,"mat-spinner")}function v(t,e){if(1&t&&(s.TgZ(0,"div",18),s.YNc(1,_,1,0,"mat-spinner",19),s.qZA()),2&t){const t=s.oxw();s.xp6(1),s.Q6J("ngIf",t.isLoadingResults)}}function y(t,e){if(1&t&&(s.TgZ(0,"th",20),s._uU(1),s.qZA()),2&t){const t=s.oxw();s.xp6(1),s.Oqu(t.columnDefs[0].headName)}}function T(t,e){if(1&t&&(s.TgZ(0,"td",21),s._uU(1),s.qZA()),2&t){const t=e.$implicit,o=s.oxw();s.xp6(1),s.Oqu(t[o.columnDefs[0].columnDef])}}function k(t,e){if(1&t&&(s.TgZ(0,"th",20),s._uU(1),s.qZA()),2&t){const t=s.oxw();s.xp6(1),s.Oqu(t.columnDefs[1].headName)}}function O(t,e){if(1&t&&(s.TgZ(0,"td",21),s._uU(1),s.qZA()),2&t){const t=e.$implicit,o=s.oxw();s.xp6(1),s.Oqu(t[o.columnDefs[1].columnDef])}}function D(t,e){1&t&&s._UZ(0,"th",22)}function N(t,e){if(1&t){const t=s.EpF();s.TgZ(0,"td",21),s.TgZ(1,"div",23),s.TgZ(2,"button",24),s.NdJ("click",function(){const e=s.CHM(t).$implicit;return s.oxw().edit(e)}),s.TgZ(3,"mat-icon"),s._uU(4,"create"),s.qZA(),s.qZA(),s.TgZ(5,"button",25),s.NdJ("click",function(){const e=s.CHM(t).$implicit;return s.oxw().delete(e.id)}),s.TgZ(6,"mat-icon"),s._uU(7,"delete_sweep"),s.qZA(),s.qZA(),s.qZA(),s.qZA()}}function U(t,e){1&t&&s._UZ(0,"tr",26)}function M(t,e){1&t&&s._UZ(0,"tr",27)}const P=function(){return[10,25,50,100,250]};let Y=(()=>{class t{constructor(t,e,o){this.uow=t,this.dialog=e,this.mydialog=o,this.update=new s.vpe,this.isLoadingResults=!0,this.resultsLength=0,this.isRateLimitReached=!1,this.dataSource=[],this.columnDefs=[{columnDef:"nom",headName:"NOM"},{columnDef:"nomAr",headName:"NOM Ar"},{columnDef:"option",headName:"OPTION"}],this.displayedColumns=this.columnDefs.map(t=>t.columnDef)}ngOnInit(){this.getPage(0,10,"id","desc"),(0,l.T)(this.sort.sortChange,this.paginator.page,this.update).subscribe(t=>{!0===t?this.paginator.pageIndex=0:t=t,this.paginator.pageSize?t=t:this.paginator.pageSize=10;const e=this.paginator.pageIndex*this.paginator.pageSize;this.isLoadingResults=!0,this.getPage(e,this.paginator.pageSize,this.sort.active?this.sort.active:"id",this.sort.direction?this.sort.direction:"desc")})}getPage(t,e,o,n){this.uow.pays.getList(t,e,o,n).subscribe(t=>{this.dataSource=t.list,this.resultsLength=t.count,this.isLoadingResults=!1})}openDialog(t,e){return this.dialog.open(b,{width:"750px",disableClose:!0,data:{model:t,title:e}}).afterClosed()}add(){this.openDialog(new m.bU,"Ajouter pays").subscribe(t=>{t&&this.uow.pays.post(t).subscribe(t=>{this.update.next(!0)})})}edit(t){this.openDialog(t,"Modifier pays").subscribe(t=>{t&&this.uow.pays.put(t.id,t).subscribe(t=>{this.update.next(!0)})})}delete(t){return(0,a.mG)(this,void 0,void 0,function*(){"ok"===(yield this.mydialog.openDialog("pays").toPromise())&&this.uow.pays.delete(t).subscribe(()=>this.update.next(!0))})}}return t.\u0275fac=function(e){return new(e||t)(s.Y36(x.Z),s.Y36(d.uw),s.Y36(A.b))},t.\u0275cmp=s.Xpm({type:t,selectors:[["app-pays"]],viewQuery:function(t,e){if(1&t&&(s.Gf(r.NW,7),s.Gf(c.YE,7)),2&t){let t;s.iGM(t=s.CRH())&&(e.paginator=t.first),s.iGM(t=s.CRH())&&(e.sort=t.first)}},decls:28,vars:9,consts:[[1,"host"],[2,"margin-bottom","15px"],[1,"right"],["mat-raised-button","","color","primary",1,"mt-3",2,"margin","20px 0",3,"click"],[1,"example-container","mat-elevation-z8"],["class","example-loading-shade",4,"ngIf"],[1,"example-table-container"],["mat-table","","multiTemplateDataRows","","aria-label","Elements","matSort","",3,"dataSource"],["table",""],[3,"matColumnDef"],["mat-header-cell","","mat-sort-header","",4,"matHeaderCellDef"],["mat-cell","",4,"matCellDef"],["matColumnDef","option",2,"flex-direction","row-reverse"],["mat-header-cell","",4,"matHeaderCellDef"],["mat-header-row","",4,"matHeaderRowDef"],["mat-row","",4,"matRowDef","matRowDefColumns"],["pageIndex","0","pageSize","10","showFirstLastButtons","",3,"length","pageSizeOptions"],["paginator",""],[1,"example-loading-shade"],[4,"ngIf"],["mat-header-cell","","mat-sort-header",""],["mat-cell",""],["mat-header-cell",""],[1,"button-row"],["mat-icon-button","","color","primary",3,"click"],["mat-icon-button","","color","warn",3,"click"],["mat-header-row",""],["mat-row",""]],template:function(t,e){1&t&&(s.TgZ(0,"div",0),s.TgZ(1,"section",1),s.TgZ(2,"h3"),s._uU(3,"Pays"),s.qZA(),s.qZA(),s._UZ(4,"mat-divider"),s.TgZ(5,"div",2),s.TgZ(6,"button",3),s.NdJ("click",function(){return e.add()}),s.TgZ(7,"mat-icon"),s._uU(8,"add"),s.qZA(),s._uU(9," Pays "),s.qZA(),s.qZA(),s.TgZ(10,"div",4),s.YNc(11,v,2,1,"div",5),s.TgZ(12,"div",6),s.TgZ(13,"table",7,8),s.ynx(15,9),s.YNc(16,y,2,1,"th",10),s.YNc(17,T,2,1,"td",11),s.BQk(),s.ynx(18,9),s.YNc(19,k,2,1,"th",10),s.YNc(20,O,2,1,"td",11),s.BQk(),s.ynx(21,12),s.YNc(22,D,1,0,"th",13),s.YNc(23,N,8,0,"td",11),s.BQk(),s.YNc(24,U,1,0,"tr",14),s.YNc(25,M,1,0,"tr",15),s.qZA(),s.qZA(),s._UZ(26,"mat-paginator",16,17),s.qZA(),s.qZA()),2&t&&(s.xp6(11),s.Q6J("ngIf",e.isLoadingResults),s.xp6(2),s.Q6J("dataSource",e.dataSource),s.xp6(2),s.Q6J("matColumnDef",e.columnDefs[0].columnDef),s.xp6(3),s.Q6J("matColumnDef",e.columnDefs[1].columnDef),s.xp6(6),s.Q6J("matHeaderRowDef",e.displayedColumns),s.xp6(1),s.Q6J("matRowDefColumns",e.displayedColumns),s.xp6(1),s.Q6J("length",e.resultsLength)("pageSizeOptions",s.DdM(8,P)))},directives:[g.d,Z.lW,q.Hw,i.O5,w.BZ,c.YE,w.w1,w.fO,w.Dz,w.as,w.nj,r.NW,C.$g,w.ge,c.nU,w.ev,w.XQ,w.Gk],styles:["section[_ngcontent-%COMP%]{display:flex!important;justify-content:space-between!important;align-items:center!important}  h3{margin:0!important}.host[_ngcontent-%COMP%]{margin:1em!important}"]}),t})();var J=o(63337);const R=[{path:"pays",redirectTo:"",pathMatch:"full"},{path:"",component:Y}];let I=(()=>{class t{}return t.\u0275fac=function(e){return new(e||t)},t.\u0275mod=s.oAB({type:t}),t.\u0275inj=s.cJS({imports:[[J.Bz.forChild(R)],J.Bz]}),t})();var Q=o(42693);let S=(()=>{class t{}return t.\u0275fac=function(e){return new(e||t)},t.\u0275mod=s.oAB({type:t}),t.\u0275inj=s.cJS({imports:[[i.ez,I,Q.JF,n.R,u.u5,u.UX]]}),t})()}}]);