(window.webpackJsonp=window.webpackJsonp||[]).push([[5],{F76L:function(t,e,i){"use strict";i.d(e,"a",function(){return Rt}),i.d(e,"b",function(){return Pt});var n=i("mrSG"),a=i("0IaG"),o=i("fXoL"),c=i("/t3+"),s=i("f0Cb"),m=i("ofXK"),l=i("bTqV");function r(t,e){if(1&t&&(o.Tb(0,"li"),o.Cc(1),o.Sb()),2&t){const t=o.ec();o.Bb(1),o.Ec("Cylce: ",t.o.cycle.label,"")}}function b(t,e){if(1&t&&(o.Tb(0,"li"),o.Cc(1),o.Sb()),2&t){const t=o.ec();o.Bb(1),o.Ec("Visite: ",t.o.visite.mandat,"")}}function d(t,e){if(1&t&&(o.Tb(0,"li"),o.Cc(1),o.Sb()),2&t){const t=o.ec();o.Bb(1),o.Ec("Organe de trait\xe9: ",t.o.organe.label,"")}}let u=(()=>{class t{constructor(t,e){this.dialogRef=t,this.data=e,this.title=""}ngOnInit(){this.o=this.data.model,this.title=this.data.title,console.log(this.o)}onNoClick(){this.dialogRef.close()}onOkClick(t){}}return t.\u0275fac=function(e){return new(e||t)(o.Nb(a.g),o.Nb(a.a))},t.\u0275cmp=o.Hb({type:t,selectors:[["app-update"]],decls:23,vars:8,consts:[[1,"dialog"],["mat-dialog-title",""],["role","toolbar",1,"task-header"],[1,"content"],["mat-dialog-content",""],[4,"ngIf"],["mat-dialog-actions","",1,"actions"],["mat-button","","type","button",3,"click"]],template:function(t,e){1&t&&(o.Tb(0,"div",0),o.Tb(1,"h1",1),o.Tb(2,"mat-toolbar",2),o.Tb(3,"span"),o.Cc(4),o.Sb(),o.Sb(),o.Ob(5,"mat-divider"),o.Sb(),o.Tb(6,"div",3),o.Tb(7,"div",4),o.Tb(8,"ul"),o.Tb(9,"li"),o.Cc(10),o.Sb(),o.Tb(11,"li"),o.Cc(12),o.Sb(),o.Tb(13,"li"),o.Cc(14),o.Sb(),o.Tb(15,"li"),o.Cc(16),o.Sb(),o.Bc(17,r,2,1,"li",5),o.Bc(18,b,2,1,"li",5),o.Bc(19,d,2,1,"li",5),o.Sb(),o.Sb(),o.Tb(20,"div",6),o.Tb(21,"button",7),o.ac("click",function(){return e.onNoClick()}),o.Cc(22,"Retour"),o.Sb(),o.Sb(),o.Sb(),o.Sb()),2&t&&(o.Bb(4),o.Dc(e.o.nom),o.Bb(6),o.Dc(e.o.etat),o.Bb(2),o.Dc(e.o.mecanisme),o.Bb(2),o.Ec("Axe: ",e.o.axes,""),o.Bb(2),o.Ec("Sous axe: ",e.o.sousAxes,""),o.Bb(1),o.kc("ngIf",e.o.cycle),o.Bb(1),o.kc("ngIf",e.o.visite),o.Bb(1),o.kc("ngIf",e.o.organe))},directives:[a.h,c.a,s.a,a.e,m.m,a.c,l.a],styles:["mat-form-field[_ngcontent-%COMP%]{width:100%}.dialog[_ngcontent-%COMP%]{overflow-x:hidden;overflow-y:hidden}.dialog[_ngcontent-%COMP%]   h1[_ngcontent-%COMP%]   span[_ngcontent-%COMP%]{padding:0 5px}.dialog[_ngcontent-%COMP%]   .content[_ngcontent-%COMP%]{padding:0 20px 25px}.dialog[_ngcontent-%COMP%]   .actions[_ngcontent-%COMP%]{display:flex;flex-direction:row-reverse}.myrow[_ngcontent-%COMP%]{display:flex;align-items:center}"]}),t})();var f=i("M9IT"),h=i("Dh3D"),g=i("VRyK"),p=i("3Pt+"),S=i("eIep"),C=i("ZTdd"),y=i("7q3A"),B=i("5F3i"),T=i("J3i2"),D=i("M0ag"),v=i("tyNb"),w=i("2ChS"),x=i("qQ+2"),k=i("/ysL"),O=i("7EHt"),A=i("NFeN"),N=i("kmnG"),F=i("qFsG"),R=i("d3UM"),P=i("FKr1"),I=i("+0xr"),E=i("Xa2L"),M=i("Qu3c"),L=i("sYmb");const _=["mytable"],V=function(){return["/admin/recommendation/update",0]};function $(t,e){1&t&&(o.Tb(0,"button",37),o.Tb(1,"mat-icon"),o.Cc(2,"add"),o.Sb(),o.Cc(3),o.fc(4,"translate"),o.Sb()),2&t&&(o.kc("routerLink",o.mc(4,V)),o.Bb(3),o.Ec(" ",o.gc(4,2,"admin.recommandation.list.Recommandation")," "))}function Q(t,e){if(1&t){const t=o.Ub();o.Tb(0,"button",38),o.ac("click",function(){return o.sc(t),o.ec().generateExcel()}),o.Tb(1,"mat-icon"),o.Cc(2,"cloud_download"),o.Sb(),o.Cc(3," Excel "),o.Sb()}}function z(t,e){if(1&t&&(o.Tb(0,"mat-option",39),o.Cc(1),o.Sb()),2&t){const t=e.$implicit,i=o.ec();o.kc("value",t.id),o.Bb(1),o.Dc("fr"===i.mytranslate.langSync?t.nom:t.nomAr)}}function G(t,e){if(1&t&&(o.Tb(0,"mat-option",39),o.Cc(1),o.Sb()),2&t){const t=e.$implicit,i=o.ec(2);o.kc("value",t.annee),o.Bb(1),o.Dc("fr"===i.mytranslate.langSync?t.anneeDisplay:t.anneeDisplayAr)}}function J(t,e){if(1&t&&(o.Tb(0,"mat-form-field",10),o.Tb(1,"mat-label"),o.Cc(2),o.fc(3,"translate"),o.Sb(),o.Tb(4,"mat-select",40),o.Tb(5,"mat-option",13),o.Cc(6,"..."),o.Sb(),o.Bc(7,G,2,2,"mat-option",14),o.Sb(),o.Sb()),2&t){const t=o.ec();o.Bb(2),o.Dc(o.gc(3,2,"admin.questionnaire.list.ann\xe9e")),o.Bb(5),o.kc("ngForOf",t.annees)}}function q(t,e){if(1&t&&(o.Tb(0,"mat-option",39),o.Cc(1),o.Sb()),2&t){const t=e.$implicit,i=o.ec();o.kc("value",t.name),o.Bb(1),o.Dc("fr"===i.mytranslate.langSync?t.name:t.nameAr)}}function j(t,e){if(1&t&&(o.Tb(0,"mat-option",39),o.Cc(1),o.Sb()),2&t){const t=e.$implicit,i=o.ec(2);o.kc("value",t.id),o.Bb(1),o.Dc("fr"===i.mytranslate.langSync?t.label:t.labelAr)}}function H(t,e){if(1&t&&(o.Tb(0,"mat-form-field",10),o.Tb(1,"mat-label"),o.Cc(2),o.fc(3,"translate"),o.Sb(),o.Tb(4,"mat-select",41),o.Tb(5,"mat-option",13),o.Cc(6,"..."),o.Sb(),o.Bc(7,j,2,2,"mat-option",14),o.fc(8,"async"),o.Sb(),o.Sb()),2&t){const t=o.ec();o.Bb(2),o.Dc(o.gc(3,2,"admin.recommandation.list.Cycle")),o.Bb(5),o.kc("ngForOf",o.gc(8,4,t.cycles))}}function U(t,e){if(1&t&&(o.Tb(0,"mat-option",39),o.Cc(1),o.Sb()),2&t){const t=e.$implicit,i=o.ec(2);o.kc("value",t.id),o.Bb(1),o.Dc("fr"===i.mytranslate.langSync?t.mandat:t.mandatAr)}}function K(t,e){if(1&t&&(o.Tb(0,"mat-form-field",10),o.Tb(1,"mat-label"),o.Cc(2),o.fc(3,"translate"),o.Sb(),o.Tb(4,"mat-select",42),o.Tb(5,"mat-option",13),o.Cc(6,"..."),o.Sb(),o.Bc(7,U,2,2,"mat-option",14),o.fc(8,"async"),o.Sb(),o.Sb()),2&t){const t=o.ec();o.Bb(2),o.Dc(o.gc(3,2,"admin.recommandation.list.Visite")),o.Bb(5),o.kc("ngForOf",o.gc(8,4,t.visites))}}function X(t,e){if(1&t&&(o.Tb(0,"mat-option",39),o.Cc(1),o.Sb()),2&t){const t=e.$implicit,i=o.ec(2);o.kc("value",t.id),o.Bb(1),o.Dc("fr"===i.mytranslate.langSync?t.label:t.labelAr)}}function Y(t,e){if(1&t&&(o.Tb(0,"mat-form-field",10),o.Tb(1,"mat-label"),o.Cc(2),o.fc(3,"translate"),o.Sb(),o.Tb(4,"mat-select",43),o.Tb(5,"mat-option",13),o.Cc(6,"..."),o.Sb(),o.Bc(7,X,2,2,"mat-option",14),o.fc(8,"async"),o.Sb(),o.Sb()),2&t){const t=o.ec();o.Bb(2),o.Dc(o.gc(3,2,"admin.recommandation.list.Organe")),o.Bb(5),o.kc("ngForOf",o.gc(8,4,t.organes))}}function Z(t,e){if(1&t&&(o.Tb(0,"mat-option",39),o.Cc(1),o.Sb()),2&t){const t=e.$implicit,i=o.ec();o.kc("value",t.name),o.Bb(1),o.Dc("fr"===i.mytranslate.langSync?t.name:t.nameAr)}}function W(t,e){if(1&t&&(o.Tb(0,"mat-option",39),o.Cc(1),o.Sb()),2&t){const t=e.$implicit,i=o.ec();o.kc("value",t.id),o.Bb(1),o.Dc("fr"===i.mytranslate.langSync?t.label:t.labelAr)}}function tt(t,e){if(1&t&&(o.Tb(0,"mat-option",39),o.Cc(1),o.Sb()),2&t){const t=e.$implicit,i=o.ec();o.kc("value",t.id),o.Bb(1),o.Dc("fr"===i.mytranslate.langSync?t.label:t.labelAr)}}function et(t,e){if(1&t&&(o.Tb(0,"mat-option",39),o.Cc(1),o.Sb()),2&t){const t=e.$implicit,i=o.ec();o.kc("value",t.id),o.Bb(1),o.Ec(" ","fr"===i.mytranslate.langSync?t.label:t.labelAr,"")}}function it(t,e){1&t&&o.Ob(0,"mat-spinner")}function nt(t,e){if(1&t&&(o.Tb(0,"div",44),o.Bc(1,it,1,0,"mat-spinner",45),o.Sb()),2&t){const t=o.ec();o.Bb(1),o.kc("ngIf",t.isLoadingResults)}}function at(t,e){if(1&t&&(o.Tb(0,"th",46),o.Cc(1),o.fc(2,"translate"),o.Sb()),2&t){const t=o.ec();o.Bb(1),o.Dc(o.gc(2,1,t.columnDefs[0].headName))}}function ot(t,e){if(1&t&&(o.Tb(0,"td",47),o.Cc(1),o.Sb()),2&t){const t=e.$implicit,i=o.ec();o.Bb(1),o.Ec(" ","fr"===i.mytranslate.langSync?t.codeRecommendation:i.displayFrIfArNull(t.codeRecommendation,t.codeRecommendationAr)," ")}}function ct(t,e){if(1&t&&(o.Tb(0,"th",46),o.Cc(1),o.fc(2,"translate"),o.Sb()),2&t){const t=o.ec();o.Bb(1),o.Dc(o.gc(2,1,t.columnDefs[1].headName))}}function st(t,e){if(1&t&&(o.Tb(0,"td",47),o.Cc(1),o.Sb()),2&t){const t=e.$implicit,i=o.ec();o.Bb(1),o.Dc("fr"===i.mytranslate.langSync?t.nom:i.displayFrIfArNull(t.nom,t.nomAr))}}function mt(t,e){if(1&t&&(o.Tb(0,"th",46),o.Cc(1),o.fc(2,"translate"),o.Sb()),2&t){const t=o.ec();o.Bb(1),o.Dc(o.gc(2,1,t.columnDefs[2].headName))}}function lt(t,e){if(1&t&&(o.Tb(0,"td",47),o.Cc(1),o.Sb()),2&t){const t=e.$implicit;o.Bb(1),o.Gc(" ",t.organe," ",t.cycle," ",t.visite," ")}}function rt(t,e){if(1&t&&(o.Tb(0,"th",46),o.Cc(1),o.fc(2,"translate"),o.Sb()),2&t){const t=o.ec();o.Bb(1),o.Dc(o.gc(2,1,t.columnDefs[3].headName))}}function bt(t,e){if(1&t&&(o.Tb(0,"td",47),o.Cc(1),o.Sb()),2&t){const t=e.$implicit,i=o.ec();o.Bb(1),o.Dc(t[i.columnDefs[3].columnDef])}}function dt(t,e){if(1&t&&(o.Tb(0,"th",46),o.Cc(1),o.fc(2,"translate"),o.Sb()),2&t){const t=o.ec();o.Bb(1),o.Dc(o.gc(2,1,t.columnDefs[4].headName))}}function ut(t,e){if(1&t&&(o.Tb(0,"td",47),o.Cc(1),o.Sb()),2&t){const t=e.$implicit,i=o.ec();o.Bb(1),o.Dc(t[i.columnDefs[4].columnDef])}}function ft(t,e){if(1&t&&(o.Tb(0,"th",46),o.Cc(1),o.fc(2,"translate"),o.Sb()),2&t){const t=o.ec();o.Bb(1),o.Dc(o.gc(2,1,t.columnDefs[5].headName))}}function ht(t,e){if(1&t&&(o.Tb(0,"td",47),o.Cc(1),o.Sb()),2&t){const t=e.$implicit;o.Bb(1),o.Dc(t.organismes)}}function gt(t,e){if(1&t&&(o.Tb(0,"th",46),o.Cc(1),o.fc(2,"translate"),o.Sb()),2&t){const t=o.ec();o.Bb(1),o.Dc(o.gc(2,1,t.columnDefs[6].headName))}}function pt(t,e){if(1&t&&(o.Tb(0,"td",47),o.Cc(1),o.Sb()),2&t){const t=e.$implicit,i=o.ec();o.Bb(1),o.Dc(i.displayMulti(t.mecanisme,t.etat).e)}}function St(t,e){if(1&t&&(o.Tb(0,"th",48),o.Cc(1),o.fc(2,"translate"),o.Sb()),2&t){const t=o.ec();o.Bb(1),o.Dc(o.gc(2,1,t.columnDefs[7].headName))}}function Ct(t,e){if(1&t){const t=o.Ub();o.Tb(0,"button",50),o.ac("click",function(){o.sc(t);const e=o.ec().$implicit;return o.ec().showPieceJoin(e.pieceJointe)}),o.Tb(1,"mat-icon"),o.Cc(2,"cloud_download"),o.Sb(),o.Sb()}if(2&t){const t=o.ec().$implicit;o.kc("disabled",""===t.pieceJointe)("matTooltip",t.pieceJointe)}}function yt(t,e){if(1&t&&(o.Tb(0,"td",47),o.Bc(1,Ct,3,2,"button",49),o.Sb()),2&t){const t=e.$implicit,i=o.ec();o.Bb(1),o.kc("ngIf",i.showDownload(t.idsOrganisme))}}function Bt(t,e){if(1&t&&(o.Tb(0,"th",46),o.Cc(1),o.fc(2,"translate"),o.Sb()),2&t){const t=o.ec();o.Bb(1),o.Dc(o.gc(2,1,t.columnDefs[8].headName))}}function Tt(t,e){if(1&t&&(o.Tb(0,"td",47),o.Cc(1),o.Sb()),2&t){const t=e.$implicit;o.Bb(1),o.Dc(t.complement)}}function Dt(t,e){1&t&&o.Ob(0,"th",48)}const vt=function(t){return["/admin/recommendation/update",t]};function wt(t,e){if(1&t&&(o.Tb(0,"button",55),o.Tb(1,"mat-icon"),o.Cc(2,"create"),o.Sb(),o.Sb()),2&t){const t=o.ec(2).$implicit;o.kc("routerLink",o.nc(1,vt,t.id))}}function xt(t,e){if(1&t){const t=o.Ub();o.Tb(0,"button",56),o.ac("click",function(){o.sc(t);const e=o.ec(2).$implicit;return o.ec().delete(e)}),o.Tb(1,"mat-icon"),o.Cc(2,"delete_sweep"),o.Sb(),o.Sb()}}function kt(t,e){if(1&t&&(o.Tb(0,"div",52),o.Bc(1,wt,3,3,"button",53),o.Bc(2,xt,3,0,"button",54),o.Sb()),2&t){const t=o.ec(2);o.Bb(1),o.kc("ngIf",!t.session.isSuperViseur),o.Bb(1),o.kc("ngIf",!t.session.isPointFocal&&!t.session.isSuperViseur)}}function Ot(t,e){if(1&t&&(o.Tb(0,"td",47),o.Bc(1,kt,3,2,"div",51),o.Sb()),2&t){const t=o.ec();o.Bb(1),o.kc("ngIf",!t.session.isPublic)}}function At(t,e){1&t&&o.Ob(0,"tr",57)}function Nt(t,e){1&t&&o.Ob(0,"tr",58)}const Ft=function(){return[10,25,50,100,250]};let Rt=(()=>{class t{constructor(t,e,i,n,a,c,s,m,l){this.uow=t,this.dialog=e,this.mydialog=i,this.mytranslate=n,this.fb=a,this.session=c,this.route=s,this.bottomSheet=m,this.excel=l,this.update=new o.o,this.isLoadingResults=!0,this.resultsLength=0,this.isRateLimitReached=!1,this.dataSource=[],this.columnDefs=[{columnDef:"codeRecommendation",headName:"admin.recommandation.list.code",show:!0},{columnDef:"nom",headName:"admin.recommandation.list.nom",show:!0},{columnDef:"mecanisme",headName:"admin.recommandation.list.mecanisme",show:!0},{columnDef:"axe",headName:"admin.recommandation.list.Axe",show:!0},{columnDef:"sousAxe",headName:"admin.recommandation.list.Sousaxe",show:!0},{columnDef:"organismes",headName:"admin.recommandation.list.DEPARTEMENT",show:!1},{columnDef:"etat",headName:"admin.recommandation.list.Etatdemisenoeuvre",show:!1},{columnDef:"pieceJointe",headName:"admin.recommandation.list.OBSERVATIONS",show:!1},{columnDef:"complement",headName:"admin.recommandation.list.complement",show:!1},{columnDef:"option",headName:"",show:!0}],this.panelOpenState=!1,this.organismes=this.uow.organismes.get(),this.axes=this.uow.axes.get(),this.sousAxes=[],this.annees=[],this.mecanismes=this.uow.mecanismes,this.visites=this.uow.visites.get(),this.organes=this.uow.organes.get(),this.pays=this.uow.pays.get(),this.cycles=this.uow.cycles.get(),this.etats=this.uow.etats,this.departementList=[],this.displayedColumns=this.columnDefs.map(t=>t.columnDef),this.progress=0,this.formData=new FormData,this.o=new Pt,this.myAuto=new p.e(""),this.session.isPublic&&(this.columnDefs=this.columnDefs.filter(t=>t.show),this.displayedColumns=this.columnDefs.map(t=>t.columnDef))}ngOnInit(){this.createForm(),this.isLoadingResults=!1,this.uow.recommendations.annee().subscribe(t=>{this.annees=t,this.myForm.get("annee").setValue(this.annees[0].annee),console.log(t)}),this.o.idOrganisme=this.session.isPointFocal?this.session.user.idOrganisme:0,this.myForm.get("idOrganisme").setValue(this.o.idOrganisme),Object(g.a)(this.sort.sortChange,this.paginator.page,this.update).subscribe(t=>{!0===t?this.paginator.pageIndex=0:t=t,this.paginator.pageSize?t=t:this.paginator.pageSize=10,this.o.startIndex=this.paginator.pageIndex*this.paginator.pageSize,this.o.pageSize=this.paginator.pageSize,this.o.sortBy=this.sort.active?this.sort.active:"id",this.o.sortDir=this.sort.direction?this.sort.direction:"desc",this.isLoadingResults=!0,this.searchAndGet(this.o)}),this.route.queryParams.subscribe(t=>{const e=t.data;e&&this.uow.recommendations.getDetail(e).subscribe(t=>{this.openDialog(t)})}),this.autoComplete()}showDownload(t){return!t||!1===this.session.isPointFocal||t.includes(this.session.user.idOrganisme)}generateExcel(){const t=this.dataSource.map((t,e)=>{var i,n;return{[this.mytranslate.get("admin.recommandation.list.code")]:"fr"===this.mytranslate.langSync?t.codeRecommendation:t.codeRecommendationAr,[this.mytranslate.get("admin.recommandation.list.nom")]:"fr"===this.mytranslate.langSync?t.nom:t.nomAr,[this.mytranslate.get("admin.recommandation.list.mecanisme")]:this.displayMulti(t.mecanisme,t.etat).m,[this.mytranslate.get("admin.recommandation.list.Axe")]:null===(i=t.axe)||void 0===i?void 0:i.join("; "),[this.mytranslate.get("admin.recommandation.list.Sousaxe")]:null===(n=t.sousAxe)||void 0===n?void 0:n.join("; "),[this.mytranslate.get("admin.recommandation.list.DEPARTEMENT")]:t.organismes,[this.mytranslate.get("admin.recommandation.list.Etatdemisenoeuvre")]:this.displayMulti(t.mecanisme,t.etat).e,[this.mytranslate.get("admin.recommandation.list.complement")]:t.complement}});this.excel.json_to_sheet(t)}displayFrIfArNull(t,e){return null==e||""===e||"null"===e?t:e}displayMulti(t,e){const i=[{fr:"Non R\xe9alis\xe9",ar:"\u063a\u064a\u0631 \u0645\u0646\u062c\u0632"},{fr:"En cours",ar:"\u0641\u064a \u0637\u0648\u0631 \u0627\u0644\u0625\u0646\u062c\u0627\u0632"},{fr:"Recommendation continue",ar:"\u062a\u0648\u0635\u064a\u0629 \u0645\u0633\u062a\u0645\u0631\u0629"},{fr:"R\xe9alis\xe9",ar:"\u0645\u0646\u062c\u0632"}];if("fr"===this.mytranslate.langSync)return{m:t,e};{const n=[{fr:"Examen p\xe9riodique universal",ar:"\u0627\u0644\u0627\u0633\u062a\u0639\u0631\u0627\u0636 \u0627\u0644\u062f\u0648\u0631\u064a \u0627\u0644\u0634\u0627\u0645\u0644"},{fr:"Organes de Trait\xe9s",ar:"\u0647\u064a\u0626\u0627\u062a \u0627\u0644\u0645\u0639\u0627\u0647\u062f\u0627\u062a"},{fr:"Proc\xe9dures sp\xe9ciales",ar:"\u0627\u0644\u0627\u062c\u0631\u0627\u0621\u0627\u062a \u0627\u0644\u062e\u0627\u0635\u0629"}].find(e=>t.toLowerCase().includes(e.fr.toLowerCase().substring(0,6))),a=i.find(t=>t.fr.toLowerCase()===e.toLowerCase());return{m:n?n.ar:t,e:a?a.ar:e}}}autoComplete(){this.filteredOptions=this.myAuto.valueChanges.pipe(Object(S.a)(t=>t.length>1?this.uow.organismes.autocompletePost("label",t):[]))}selected(t){const e=t.option.value;console.log(e),this.myAuto.setValue(e.label),this.myForm.get("idOrganisme").setValue(e.id)}createForm(){this.myForm=this.fb.group({idOrganisme:this.o.idOrganisme,mecanisme:this.o.mecanisme,idCycle:this.o.idCycle,idOrgane:this.o.idOrgane,idVisite:this.o.idVisite,idAxe:this.o.idAxe,nom:this.o.nom,etat:this.o.etat,idPays:this.o.idPays,idSousAxe:this.o.idSousAxe,annee:this.o.annee,startIndex:this.o.startIndex,pageSize:this.o.pageSize,sortBy:this.o.sortBy,sortDir:this.o.sortDir})}get mecanisme(){return this.myForm.get("mecanisme")}get idVisite(){return this.myForm.get("idVisite")}get idCycle(){return this.myForm.get("idCycle")}get idOrgane(){return this.myForm.get("idOrgane")}get cycleActive(){return"Examen p\xe9riodique universal"===this.mecanisme.value}get visiteActive(){return"Proc\xe9dure sp\xe9ciale"===this.mecanisme.value}get organeActive(){return"Organes de trait\xe9s"===this.mecanisme.value}selectChange(t){this.idVisite.setValue(0),this.idCycle.setValue(0),this.idOrgane.setValue(0)}reset(){this.o=new Pt,this.createForm(),this.myForm.get("annee").setValue(this.annees[0].annee),this.searchAndGet(this.o)}search(t){this.searchAndGet(t)}detail(t){this.uow.recommendations.getDetail(t.id).subscribe(t=>{this.openDialog(t)})}openDialog(t){return this.dialog.open(u,{width:"7100px",disableClose:!0,data:{model:t,title:"Recommdandation"}}).afterClosed()}searchAndGet(t){console.log(t),this.o=t,this.uow.recommendations.searchAndGet(this.o).subscribe(t=>{console.log(t.list),this.dataSource=t.list,this.resultsLength=t.count,this.isLoadingResults=!1,console.log(this.table)},t=>this.isLoadingResults=!1)}delete(t){return Object(n.a)(this,void 0,void 0,function*(){if("ok"===(yield this.mydialog.openDialog("recommandation").toPromise())){let e=[];""!==t.pieceJointe?e.push(...this.uow.decoupe(t.pieceJointe)):e=e,this.uow.files.deleteFiles(e,"recommandation").subscribe(e=>{this.uow.recommendations.delete(t.id).subscribe(()=>this.update.next(!0))})}})}showPieceJoin(t){this.bottomSheet.open(C.a,{data:{fileName:t,folder:"recommandation"}})}axeChange(t){this.uow.sousAxes.getByIdAxe(t).subscribe(t=>{this.sousAxes=t})}get isAllEmpty(){var t;return"0"===this.myForm.get("idAxe").value.toString()&&"0"===this.myForm.get("idCycle").value.toString()&&"0"===this.myForm.get("idSousAxe").value.toString()&&"0"===this.myForm.get("idOrganisme").value.toString()&&"0"===this.myForm.get("idOrgane").value.toString()&&"0"===this.myForm.get("idPays").value.toString()&&""===this.myForm.get("nom").value.toString()&&""===this.myForm.get("etat").value.toString()&&"0"===this.myForm.get("idVisite").value.toString()&&"0"===(null===(t=this.myForm.get("annee").value)||void 0===t?void 0:t.toString())&&""===this.myForm.get("mecanisme").value.toString()}}return t.\u0275fac=function(e){return new(e||t)(o.Nb(y.a),o.Nb(a.b),o.Nb(B.a),o.Nb(T.a),o.Nb(p.d),o.Nb(D.a),o.Nb(v.a),o.Nb(w.b),o.Nb(x.a))},t.\u0275cmp=o.Hb({type:t,selectors:[["app-list"]],viewQuery:function(t,e){if(1&t&&(o.xc(f.a,!0),o.xc(h.a,!0),o.xc(_,!0)),2&t){let t;o.pc(t=o.bc())&&(e.paginator=t.first),o.pc(t=o.bc())&&(e.sort=t.first),o.pc(t=o.bc())&&(e.table=t.first)}},decls:136,vars:73,consts:[[1,"host"],[3,"title"],[1,"right"],[1,"d-flex","flex-row-reverse","pt-3","mb-3"],["mat-raised-button","","color","primary",3,"routerLink",4,"ngIf"],["mat-raised-button","","color","warn",3,"click",4,"ngIf"],[1,"expension"],["expanded","",3,"opened","closed"],[3,"formGroup"],[1,"inputs2"],["appearance","fill"],["matInput","","formControlName","nom","required",""],["formControlName","idPays"],["value","0"],[3,"value",4,"ngFor","ngForOf"],["appearance","fill",4,"ngIf"],["formControlName","mecanisme",3,"selectionChange"],["formControlName","etat"],["formControlName","idAxe",3,"selectionChange"],["formControlName","idSousAxe"],["formControlName","idOrganisme"],["mat-raised-button","","color","primary",3,"disabled","click"],["mat-raised-button","",3,"click"],[1,"example-container","mat-elevation-z8"],["class","example-loading-shade",4,"ngIf"],[1,"example-table-container"],["mat-table","","multiTemplateDataRows","","aria-label","Elements","matSort","",3,"dataSource"],["mytable",""],[3,"matColumnDef"],["mat-header-cell","","mat-sort-header","",4,"matHeaderCellDef"],["mat-cell","",4,"matCellDef"],["mat-header-cell","",4,"matHeaderCellDef"],["matColumnDef","option",2,"flex-direction","row-reverse"],["mat-header-row","",4,"matHeaderRowDef"],["mat-row","",4,"matRowDef","matRowDefColumns"],["pageIndex","0","pageSize","10","showFirstLastButtons","",3,"length","pageSizeOptions"],["paginator",""],["mat-raised-button","","color","primary",3,"routerLink"],["mat-raised-button","","color","warn",3,"click"],[3,"value"],["formControlName","annee"],["formControlName","idCycle"],["formControlName","idVisite"],["formControlName","idOrgane"],[1,"example-loading-shade"],[4,"ngIf"],["mat-header-cell","","mat-sort-header",""],["mat-cell",""],["mat-header-cell",""],["mat-icon-button","","color","accent",3,"disabled","matTooltip","click",4,"ngIf"],["mat-icon-button","","color","accent",3,"disabled","matTooltip","click"],["class","button-row",4,"ngIf"],[1,"button-row"],["mat-icon-button","","color","primary",3,"routerLink",4,"ngIf"],["mat-icon-button","","color","warn",3,"click",4,"ngIf"],["mat-icon-button","","color","primary",3,"routerLink"],["mat-icon-button","","color","warn",3,"click"],["mat-header-row",""],["mat-row",""]],template:function(t,e){1&t&&(o.Tb(0,"div",0),o.Ob(1,"app-title",1),o.fc(2,"translate"),o.Tb(3,"div",2),o.Tb(4,"div",3),o.Bc(5,$,5,5,"button",4),o.Cc(6," \xa0 "),o.Bc(7,Q,4,0,"button",5),o.Sb(),o.Sb(),o.Tb(8,"div",6),o.Tb(9,"mat-accordion"),o.Tb(10,"mat-expansion-panel",7),o.ac("opened",function(){return e.panelOpenState=!0})("closed",function(){return e.panelOpenState=!1}),o.Tb(11,"mat-expansion-panel-header"),o.Tb(12,"mat-panel-title"),o.Tb(13,"mat-icon"),o.Cc(14,"search"),o.Sb(),o.Tb(15,"p"),o.Cc(16),o.fc(17,"translate"),o.Sb(),o.Sb(),o.Ob(18,"mat-panel-description"),o.Sb(),o.Ob(19,"mat-divider"),o.Tb(20,"form",8),o.Tb(21,"div",9),o.Tb(22,"mat-form-field",10),o.Tb(23,"mat-label"),o.Cc(24),o.fc(25,"translate"),o.Sb(),o.Ob(26,"input",11),o.Sb(),o.Sb(),o.Tb(27,"div",9),o.Tb(28,"mat-form-field",10),o.Tb(29,"mat-label"),o.Cc(30),o.fc(31,"translate"),o.Sb(),o.Tb(32,"mat-select",12),o.Tb(33,"mat-option",13),o.Cc(34,"..."),o.Sb(),o.Bc(35,z,2,2,"mat-option",14),o.fc(36,"async"),o.Sb(),o.Sb(),o.Bc(37,J,8,4,"mat-form-field",15),o.Sb(),o.Tb(38,"div",9),o.Tb(39,"mat-form-field",10),o.Tb(40,"mat-label"),o.Cc(41),o.fc(42,"translate"),o.Sb(),o.Tb(43,"mat-select",16),o.ac("selectionChange",function(t){return e.selectChange(t.value)}),o.Tb(44,"mat-option",13),o.Cc(45,"..."),o.Sb(),o.Bc(46,q,2,2,"mat-option",14),o.fc(47,"async"),o.Sb(),o.Sb(),o.Bc(48,H,9,6,"mat-form-field",15),o.Bc(49,K,9,6,"mat-form-field",15),o.Bc(50,Y,9,6,"mat-form-field",15),o.Tb(51,"mat-form-field",10),o.Tb(52,"mat-label"),o.Cc(53),o.fc(54,"translate"),o.Sb(),o.Tb(55,"mat-select",17),o.Bc(56,Z,2,2,"mat-option",14),o.fc(57,"async"),o.Sb(),o.Sb(),o.Sb(),o.Tb(58,"div",9),o.Tb(59,"mat-form-field",10),o.Tb(60,"mat-label"),o.Cc(61),o.fc(62,"translate"),o.Sb(),o.Tb(63,"mat-select",18),o.ac("selectionChange",function(t){return e.axeChange(t.value)}),o.Tb(64,"mat-option",13),o.Cc(65,"..."),o.Sb(),o.Bc(66,W,2,2,"mat-option",14),o.fc(67,"async"),o.Sb(),o.Sb(),o.Tb(68,"mat-form-field",10),o.Tb(69,"mat-label"),o.Cc(70),o.fc(71,"translate"),o.Sb(),o.Tb(72,"mat-select",19),o.Tb(73,"mat-option",13),o.Cc(74,"..."),o.Sb(),o.Bc(75,tt,2,2,"mat-option",14),o.Sb(),o.Sb(),o.Tb(76,"mat-form-field",10),o.Tb(77,"mat-label"),o.Cc(78),o.fc(79,"translate"),o.Sb(),o.Tb(80,"mat-select",20),o.Tb(81,"mat-option",13),o.Cc(82,"..."),o.Sb(),o.Bc(83,et,2,2,"mat-option",14),o.fc(84,"async"),o.Sb(),o.Sb(),o.Sb(),o.Sb(),o.Tb(85,"div",2),o.Tb(86,"button",21),o.ac("click",function(){return e.search(e.myForm.value)}),o.Tb(87,"mat-icon"),o.Cc(88,"search"),o.Sb(),o.Cc(89),o.fc(90,"translate"),o.Sb(),o.Cc(91," \xa0 "),o.Tb(92,"button",22),o.ac("click",function(){return e.reset()}),o.Tb(93,"mat-icon"),o.Cc(94,"refresh"),o.Sb(),o.Cc(95),o.fc(96,"translate"),o.Sb(),o.Sb(),o.Sb(),o.Sb(),o.Sb(),o.Tb(97,"div",23),o.Bc(98,nt,2,1,"div",24),o.Tb(99,"div",25),o.Tb(100,"table",26,27),o.Rb(102,28),o.Bc(103,at,3,3,"th",29),o.Bc(104,ot,2,1,"td",30),o.Qb(),o.Rb(105,28),o.Bc(106,ct,3,3,"th",29),o.Bc(107,st,2,1,"td",30),o.Qb(),o.Rb(108,28),o.Bc(109,mt,3,3,"th",29),o.Bc(110,lt,2,3,"td",30),o.Qb(),o.Rb(111,28),o.Bc(112,rt,3,3,"th",29),o.Bc(113,bt,2,1,"td",30),o.Qb(),o.Rb(114,28),o.Bc(115,dt,3,3,"th",29),o.Bc(116,ut,2,1,"td",30),o.Qb(),o.Rb(117,28),o.Bc(118,ft,3,3,"th",29),o.Bc(119,ht,2,1,"td",30),o.Qb(),o.Rb(120,28),o.Bc(121,gt,3,3,"th",29),o.Bc(122,pt,2,1,"td",30),o.Qb(),o.Rb(123,28),o.Bc(124,St,3,3,"th",31),o.Bc(125,yt,2,1,"td",30),o.Qb(),o.Rb(126,28),o.Bc(127,Bt,3,3,"th",29),o.Bc(128,Tt,2,1,"td",30),o.Qb(),o.Rb(129,32),o.Bc(130,Dt,1,0,"th",31),o.Bc(131,Ot,2,1,"td",30),o.Qb(),o.Bc(132,At,1,0,"tr",33),o.Bc(133,Nt,1,0,"tr",34),o.Sb(),o.Sb(),o.Ob(134,"mat-paginator",35,36),o.Sb(),o.Sb()),2&t&&(o.Bb(1),o.lc("title",o.gc(2,40,"admin.recommandation.list.Recommandations")),o.Bb(4),o.kc("ngIf",!e.session.isPointFocal&&!e.session.isSuperViseur&&!e.session.isPublic),o.Bb(2),o.kc("ngIf",!1),o.Bb(9),o.Dc(o.gc(17,42,"admin.recommandation.list.Recherche")),o.Bb(4),o.kc("formGroup",e.myForm),o.Bb(4),o.Dc(o.gc(25,44,"admin.recommandation.list.nom")),o.Bb(6),o.Dc(o.gc(31,46,"admin.recommandation.list.Pays")),o.Bb(5),o.kc("ngForOf",o.gc(36,48,e.pays)),o.Bb(2),o.kc("ngIf",!e.session.isPublic),o.Bb(4),o.Dc(o.gc(42,50,"admin.recommandation.list.mecanisme")),o.Bb(5),o.kc("ngForOf",o.gc(47,52,e.mecanismes)),o.Bb(2),o.kc("ngIf",e.cycleActive),o.Bb(1),o.kc("ngIf",e.visiteActive),o.Bb(1),o.kc("ngIf",e.organeActive),o.Bb(3),o.Dc(o.gc(54,54,"admin.recommandation.list.Etatdemisenoeuvre")),o.Bb(3),o.kc("ngForOf",o.gc(57,56,e.etats)),o.Bb(5),o.Dc(o.gc(62,58,"admin.recommandation.list.Axe")),o.Bb(5),o.kc("ngForOf",o.gc(67,60,e.axes)),o.Bb(4),o.Dc(o.gc(71,62,"admin.recommandation.list.Sousaxe")),o.Bb(5),o.kc("ngForOf",e.sousAxes),o.Bb(3),o.Dc(o.gc(79,64,"admin.recommandation.list.DEPARTEMENT")),o.Bb(5),o.kc("ngForOf",o.gc(84,66,e.organismes)),o.Bb(3),o.kc("disabled",e.isAllEmpty),o.Bb(3),o.Ec(" ",o.gc(90,68,"admin.recommandation.list.Rechercher")," "),o.Bb(6),o.Ec(" ",o.gc(96,70,"admin.recommandation.list.R\xe9initialiser")," "),o.Bb(3),o.kc("ngIf",e.isLoadingResults),o.Bb(2),o.kc("dataSource",e.dataSource),o.Bb(2),o.kc("matColumnDef",e.columnDefs[0].columnDef),o.Bb(3),o.kc("matColumnDef",e.columnDefs[1].columnDef),o.Bb(3),o.kc("matColumnDef",e.columnDefs[2].columnDef),o.Bb(3),o.kc("matColumnDef",e.columnDefs[3].columnDef),o.Bb(3),o.kc("matColumnDef",e.columnDefs[4].columnDef),o.Bb(3),o.kc("matColumnDef","organismes"),o.Bb(3),o.kc("matColumnDef","etat"),o.Bb(3),o.kc("matColumnDef","pieceJointe"),o.Bb(3),o.kc("matColumnDef","complement"),o.Bb(6),o.kc("matHeaderRowDef",e.displayedColumns),o.Bb(1),o.kc("matRowDefColumns",e.displayedColumns),o.Bb(1),o.kc("length",e.resultsLength)("pageSizeOptions",o.mc(72,Ft)))},directives:[k.a,m.m,O.a,O.c,O.e,O.f,A.a,O.d,s.a,p.t,p.n,p.h,N.c,N.f,F.b,p.c,p.m,p.g,p.r,R.a,P.o,m.l,l.a,I.j,h.a,I.c,I.e,I.b,I.g,I.i,f.a,v.f,E.b,I.d,h.b,I.a,M.a,I.f,I.h],pipes:[L.c,m.b],styles:["section[_ngcontent-%COMP%]{display:flex!important;justify-content:space-between!important;align-items:center!important}  h3{margin:0!important}.host[_ngcontent-%COMP%]{margin:1em!important}.inputs2[_ngcontent-%COMP%]{display:grid;grid-template-columns:repeat(auto-fit,minmax(25vw,1fr));grid-column-gap:6px;grid-row-gap:6px;align-items:center}form[_ngcontent-%COMP%]{padding:20px}.expension[_ngcontent-%COMP%]{margin:20px 0}.right[_ngcontent-%COMP%]{margin:0 20px 20px}mat-panel-title[_ngcontent-%COMP%]{display:flex;align-items:center}mat-panel-title[_ngcontent-%COMP%]   p[_ngcontent-%COMP%]{margin:0 0 0 10px}mat-panel-title[_ngcontent-%COMP%]   mat-icon[_ngcontent-%COMP%]{margin-top:5px}"]}),t})();class Pt{constructor(){this.idAxe=0,this.idSousAxe=0,this.idOrganisme=0,this.mecanisme="",this.idCycle=0,this.idOrgane=0,this.idVisite=0,this.nom="",this.etat="",this.idPays=0,this.startIndex=0,this.pageSize=10,this.sortBy="id",this.sortDir="desc",this.annee=0}}}}]);