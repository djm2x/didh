!function(){function t(t){return function(t){if(Array.isArray(t))return e(t)}(t)||function(t){if("undefined"!=typeof Symbol&&Symbol.iterator in Object(t))return Array.from(t)}(t)||function(t,n){if(!t)return;if("string"==typeof t)return e(t,n);var i=Object.prototype.toString.call(t).slice(8,-1);"Object"===i&&t.constructor&&(i=t.constructor.name);if("Map"===i||"Set"===i)return Array.from(t);if("Arguments"===i||/^(?:Ui|I)nt(?:8|16|32)(?:Clamped)?Array$/.test(i))return e(t,n)}(t)||function(){throw new TypeError("Invalid attempt to spread non-iterable instance.\nIn order to be iterable, non-array objects must have a [Symbol.iterator]() method.")}()}function e(t,e){(null==e||e>t.length)&&(e=t.length);for(var n=0,i=new Array(e);n<e;n++)i[n]=t[n];return i}function n(t,e,n){return e in t?Object.defineProperty(t,e,{value:n,enumerable:!0,configurable:!0,writable:!0}):t[e]=n,t}function i(t,e){if(!(t instanceof e))throw new TypeError("Cannot call a class as a function")}function a(t,e){for(var n=0;n<e.length;n++){var i=e[n];i.enumerable=i.enumerable||!1,i.configurable=!0,"value"in i&&(i.writable=!0),Object.defineProperty(t,i.key,i)}}function o(t,e,n){return e&&a(t.prototype,e),n&&a(t,n),t}(window.webpackJsonp=window.webpackJsonp||[]).push([[5],{F76L:function(e,a,c){"use strict";c.d(a,"a",function(){return Lt}),c.d(a,"b",function(){return _t});var r=c("mrSG"),s=c("0IaG"),m=c("fXoL"),l=c("/t3+"),b=c("f0Cb"),u=c("ofXK"),d=c("bTqV");function f(t,e){if(1&t&&(m.Tb(0,"li"),m.Cc(1),m.Sb()),2&t){var n=m.ec();m.Bb(1),m.Ec("Cylce: ",n.o.cycle.label,"")}}function g(t,e){if(1&t&&(m.Tb(0,"li"),m.Cc(1),m.Sb()),2&t){var n=m.ec();m.Bb(1),m.Ec("Visite: ",n.o.visite.mandat,"")}}function h(t,e){if(1&t&&(m.Tb(0,"li"),m.Cc(1),m.Sb()),2&t){var n=m.ec();m.Bb(1),m.Ec("Organe de trait\xe9: ",n.o.organe.label,"")}}var p,y=((p=function(){function t(e,n){i(this,t),this.dialogRef=e,this.data=n,this.title=""}return o(t,[{key:"ngOnInit",value:function(){this.o=this.data.model,this.title=this.data.title,// console.log(this.o)}},{key:"onNoClick",value:function(){this.dialogRef.close()}},{key:"onOkClick",value:function(t){}}]),t}()).\u0275fac=function(t){return new(t||p)(m.Nb(s.g),m.Nb(s.a))},p.\u0275cmp=m.Hb({type:p,selectors:[["app-update"]],decls:23,vars:8,consts:[[1,"dialog"],["mat-dialog-title",""],["role","toolbar",1,"task-header"],[1,"content"],["mat-dialog-content",""],[4,"ngIf"],["mat-dialog-actions","",1,"actions"],["mat-button","","type","button",3,"click"]],template:function(t,e){1&t&&(m.Tb(0,"div",0),m.Tb(1,"h1",1),m.Tb(2,"mat-toolbar",2),m.Tb(3,"span"),m.Cc(4),m.Sb(),m.Sb(),m.Ob(5,"mat-divider"),m.Sb(),m.Tb(6,"div",3),m.Tb(7,"div",4),m.Tb(8,"ul"),m.Tb(9,"li"),m.Cc(10),m.Sb(),m.Tb(11,"li"),m.Cc(12),m.Sb(),m.Tb(13,"li"),m.Cc(14),m.Sb(),m.Tb(15,"li"),m.Cc(16),m.Sb(),m.Bc(17,f,2,1,"li",5),m.Bc(18,g,2,1,"li",5),m.Bc(19,h,2,1,"li",5),m.Sb(),m.Sb(),m.Tb(20,"div",6),m.Tb(21,"button",7),m.ac("click",function(){return e.onNoClick()}),m.Cc(22,"Retour"),m.Sb(),m.Sb(),m.Sb(),m.Sb()),2&t&&(m.Bb(4),m.Dc(e.o.nom),m.Bb(6),m.Dc(e.o.etat),m.Bb(2),m.Dc(e.o.mecanisme),m.Bb(2),m.Ec("Axe: ",e.o.axes,""),m.Bb(2),m.Ec("Sous axe: ",e.o.sousAxes,""),m.Bb(1),m.kc("ngIf",e.o.cycle),m.Bb(1),m.kc("ngIf",e.o.visite),m.Bb(1),m.kc("ngIf",e.o.organe))},directives:[s.h,l.a,b.a,s.e,u.m,s.c,d.a],styles:["mat-form-field[_ngcontent-%COMP%]{width:100%}.dialog[_ngcontent-%COMP%]{overflow-x:hidden;overflow-y:hidden}.dialog[_ngcontent-%COMP%]   h1[_ngcontent-%COMP%]   span[_ngcontent-%COMP%]{padding:0 5px}.dialog[_ngcontent-%COMP%]   .content[_ngcontent-%COMP%]{padding:0 20px 25px}.dialog[_ngcontent-%COMP%]   .actions[_ngcontent-%COMP%]{display:flex;flex-direction:row-reverse}.myrow[_ngcontent-%COMP%]{display:flex;align-items:center}"]}),p),S=c("M9IT"),v=c("Dh3D"),C=c("VRyK"),B=c("3Pt+"),T=c("eIep"),k=c("ZTdd"),D=c("7q3A"),w=c("5F3i"),x=c("J3i2"),O=c("M0ag"),A=c("tyNb"),F=c("2ChS"),N=c("qQ+2"),R=c("/ysL"),P=c("NFeN"),I=c("7EHt"),E=c("kmnG"),M=c("qFsG"),L=c("d3UM"),_=c("FKr1"),V=c("+0xr"),$=c("Xa2L"),j=c("Qu3c"),Q=c("sYmb"),z=["mytable"],G=function(){return["/admin/recommendation/update",0]};function J(t,e){1&t&&(m.Tb(0,"button",37),m.Tb(1,"mat-icon"),m.Cc(2,"add"),m.Sb(),m.Cc(3),m.fc(4,"translate"),m.Sb()),2&t&&(m.kc("routerLink",m.mc(4,G)),m.Bb(3),m.Ec(" ",m.gc(4,2,"admin.recommandation.list.Recommandation")," "))}function q(t,e){if(1&t&&(m.Tb(0,"mat-option",38),m.Cc(1),m.Sb()),2&t){var n=e.$implicit,i=m.ec();m.kc("value",n.id),m.Bb(1),m.Dc("fr"===i.mytranslate.langSync?n.nom:n.nomAr)}}function H(t,e){if(1&t&&(m.Tb(0,"mat-option",38),m.Cc(1),m.Sb()),2&t){var n=e.$implicit,i=m.ec(2);m.kc("value",n.annee),m.Bb(1),m.Dc("fr"===i.mytranslate.langSync?n.anneeDisplay:n.anneeDisplayAr)}}function U(t,e){if(1&t&&(m.Tb(0,"mat-form-field",10),m.Tb(1,"mat-label"),m.Cc(2),m.fc(3,"translate"),m.Sb(),m.Tb(4,"mat-select",39),m.Tb(5,"mat-option",13),m.Cc(6,"..."),m.Sb(),m.Bc(7,H,2,2,"mat-option",14),m.Sb(),m.Sb()),2&t){var n=m.ec();m.Bb(2),m.Dc(m.gc(3,2,"admin.questionnaire.list.ann\xe9e")),m.Bb(5),m.kc("ngForOf",n.annees)}}function K(t,e){if(1&t&&(m.Tb(0,"mat-option",38),m.Cc(1),m.Sb()),2&t){var n=e.$implicit,i=m.ec();m.kc("value",n.name),m.Bb(1),m.Dc("fr"===i.mytranslate.langSync?n.name:n.nameAr)}}function X(t,e){if(1&t&&(m.Tb(0,"mat-option",38),m.Cc(1),m.Sb()),2&t){var n=e.$implicit,i=m.ec(2);m.kc("value",n.id),m.Bb(1),m.Dc("fr"===i.mytranslate.langSync?n.label:n.labelAr)}}function Y(t,e){if(1&t&&(m.Tb(0,"mat-form-field",10),m.Tb(1,"mat-label"),m.Cc(2),m.fc(3,"translate"),m.Sb(),m.Tb(4,"mat-select",40),m.Tb(5,"mat-option",13),m.Cc(6,"..."),m.Sb(),m.Bc(7,X,2,2,"mat-option",14),m.fc(8,"async"),m.Sb(),m.Sb()),2&t){var n=m.ec();m.Bb(2),m.Dc(m.gc(3,2,"admin.recommandation.list.Cycle")),m.Bb(5),m.kc("ngForOf",m.gc(8,4,n.cycles))}}function Z(t,e){if(1&t&&(m.Tb(0,"mat-option",38),m.Cc(1),m.Sb()),2&t){var n=e.$implicit,i=m.ec(2);m.kc("value",n.id),m.Bb(1),m.Dc("fr"===i.mytranslate.langSync?n.mandat:n.mandatAr)}}function W(t,e){if(1&t&&(m.Tb(0,"mat-form-field",10),m.Tb(1,"mat-label"),m.Cc(2),m.fc(3,"translate"),m.Sb(),m.Tb(4,"mat-select",41),m.Tb(5,"mat-option",13),m.Cc(6,"..."),m.Sb(),m.Bc(7,Z,2,2,"mat-option",14),m.fc(8,"async"),m.Sb(),m.Sb()),2&t){var n=m.ec();m.Bb(2),m.Dc(m.gc(3,2,"admin.recommandation.list.Visite")),m.Bb(5),m.kc("ngForOf",m.gc(8,4,n.visites))}}function tt(t,e){if(1&t&&(m.Tb(0,"mat-option",38),m.Cc(1),m.Sb()),2&t){var n=e.$implicit,i=m.ec(2);m.kc("value",n.id),m.Bb(1),m.Dc("fr"===i.mytranslate.langSync?n.label:n.labelAr)}}function et(t,e){if(1&t&&(m.Tb(0,"mat-form-field",10),m.Tb(1,"mat-label"),m.Cc(2),m.fc(3,"translate"),m.Sb(),m.Tb(4,"mat-select",42),m.Tb(5,"mat-option",13),m.Cc(6,"..."),m.Sb(),m.Bc(7,tt,2,2,"mat-option",14),m.fc(8,"async"),m.Sb(),m.Sb()),2&t){var n=m.ec();m.Bb(2),m.Dc(m.gc(3,2,"admin.recommandation.list.Organe")),m.Bb(5),m.kc("ngForOf",m.gc(8,4,n.organes))}}function nt(t,e){if(1&t&&(m.Tb(0,"mat-option",38),m.Cc(1),m.Sb()),2&t){var n=e.$implicit,i=m.ec();m.kc("value",n.name),m.Bb(1),m.Dc("fr"===i.mytranslate.langSync?n.name:n.nameAr)}}function it(t,e){if(1&t&&(m.Tb(0,"mat-option",38),m.Cc(1),m.Sb()),2&t){var n=e.$implicit,i=m.ec();m.kc("value",n.id),m.Bb(1),m.Dc("fr"===i.mytranslate.langSync?n.label:n.labelAr)}}function at(t,e){if(1&t&&(m.Tb(0,"mat-option",38),m.Cc(1),m.Sb()),2&t){var n=e.$implicit,i=m.ec();m.kc("value",n.id),m.Bb(1),m.Dc("fr"===i.mytranslate.langSync?n.label:n.labelAr)}}function ot(t,e){if(1&t&&(m.Tb(0,"mat-option",38),m.Cc(1),m.Sb()),2&t){var n=e.$implicit,i=m.ec();m.kc("value",n.id),m.Bb(1),m.Ec(" ","fr"===i.mytranslate.langSync?n.label:n.labelAr,"")}}function ct(t,e){1&t&&m.Ob(0,"mat-spinner")}function rt(t,e){if(1&t&&(m.Tb(0,"div",43),m.Bc(1,ct,1,0,"mat-spinner",44),m.Sb()),2&t){var n=m.ec();m.Bb(1),m.kc("ngIf",n.isLoadingResults)}}function st(t,e){1&t&&(m.Tb(0,"th",45),m.Cc(1),m.fc(2,"translate"),m.Sb()),2&t&&(m.Bb(1),m.Dc(m.gc(2,1,"admin.recommandation.list.code")))}function mt(t,e){if(1&t&&(m.Tb(0,"td",46),m.Cc(1),m.Sb()),2&t){var n=e.$implicit,i=m.ec();m.Bb(1),m.Ec(" ","fr"===i.mytranslate.langSync?n.codeRecommendation:i.displayFrIfArNull(n.codeRecommendation,n.codeRecommendationAr)," ")}}function lt(t,e){1&t&&(m.Tb(0,"th",45),m.Cc(1),m.fc(2,"translate"),m.Sb()),2&t&&(m.Bb(1),m.Dc(m.gc(2,1,"admin.recommandation.list.nom")))}function bt(t,e){if(1&t&&(m.Tb(0,"td",46),m.Cc(1),m.Sb()),2&t){var n=e.$implicit,i=m.ec();m.Bb(1),m.Dc("fr"===i.mytranslate.langSync?n.nom:i.displayFrIfArNull(n.nom,n.nomAr))}}function ut(t,e){1&t&&(m.Tb(0,"th",45),m.Cc(1),m.fc(2,"translate"),m.Sb()),2&t&&(m.Bb(1),m.Dc(m.gc(2,1,"admin.recommandation.list.mecanisme")))}function dt(t,e){if(1&t&&(m.Tb(0,"td",46),m.Cc(1),m.Sb()),2&t){var n=e.$implicit;m.Bb(1),m.Gc(" ",n.organe," ",n.cycle," ",n.visite," ")}}function ft(t,e){1&t&&(m.Tb(0,"th",45),m.Cc(1),m.fc(2,"translate"),m.Sb()),2&t&&(m.Bb(1),m.Dc(m.gc(2,1,"admin.recommandation.list.Axe")))}function gt(t,e){if(1&t&&(m.Tb(0,"td",46),m.Cc(1),m.Sb()),2&t){var n=e.$implicit,i=m.ec();m.Bb(1),m.Dc(n[i.columnDefs[3].columnDef])}}function ht(t,e){if(1&t&&(m.Tb(0,"th",45),m.Cc(1),m.fc(2,"translate"),m.Sb()),2&t){var n=m.ec();m.Bb(1),m.Dc(m.gc(2,1,n.columnDefs[4].headName))}}function pt(t,e){if(1&t&&(m.Tb(0,"td",46),m.Cc(1),m.Sb()),2&t){var n=e.$implicit,i=m.ec();m.Bb(1),m.Dc(n[i.columnDefs[4].columnDef])}}function yt(t,e){if(1&t&&(m.Tb(0,"th",45),m.Cc(1),m.fc(2,"translate"),m.Sb()),2&t){var n=m.ec();m.Bb(1),m.Dc(m.gc(2,1,n.columnDefs[5].headName))}}function St(t,e){if(1&t&&(m.Tb(0,"td",46),m.Cc(1),m.Sb()),2&t){var n=e.$implicit;m.Bb(1),m.Dc(n.organismes)}}function vt(t,e){if(1&t&&(m.Tb(0,"th",45),m.Cc(1),m.fc(2,"translate"),m.Sb()),2&t){var n=m.ec();m.Bb(1),m.Dc(m.gc(2,1,n.columnDefs[6].headName))}}function Ct(t,e){if(1&t&&(m.Tb(0,"td",46),m.Cc(1),m.Sb()),2&t){var n=e.$implicit,i=m.ec();m.Bb(1),m.Dc(i.displayMulti(n.mecanisme,n.etat).e)}}function Bt(t,e){if(1&t&&(m.Tb(0,"th",47),m.Cc(1),m.fc(2,"translate"),m.Sb()),2&t){var n=m.ec();m.Bb(1),m.Dc(m.gc(2,1,n.columnDefs[7].headName))}}function Tt(t,e){if(1&t){var n=m.Ub();m.Tb(0,"button",49),m.ac("click",function(){m.sc(n);var t=m.ec().$implicit;return m.ec().showPieceJoin(t.pieceJointe)}),m.Tb(1,"mat-icon"),m.Cc(2,"cloud_download"),m.Sb(),m.Sb()}if(2&t){var i=m.ec().$implicit;m.kc("disabled",""===i.pieceJointe)("matTooltip",i.pieceJointe)}}function kt(t,e){if(1&t&&(m.Tb(0,"td",46),m.Bc(1,Tt,3,2,"button",48),m.Sb()),2&t){var n=e.$implicit,i=m.ec();m.Bb(1),m.kc("ngIf",i.showDownload(n.idsOrganisme))}}function Dt(t,e){if(1&t&&(m.Tb(0,"th",45),m.Cc(1),m.fc(2,"translate"),m.Sb()),2&t){var n=m.ec();m.Bb(1),m.Dc(m.gc(2,1,n.columnDefs[8].headName))}}function wt(t,e){if(1&t&&(m.Tb(0,"td",46),m.Cc(1),m.Sb()),2&t){var n=e.$implicit;m.Bb(1),m.Dc(n.complement)}}function xt(t,e){1&t&&m.Ob(0,"th",47)}var Ot=function(t){return["/admin/recommendation/update",t]};function At(t,e){if(1&t&&(m.Tb(0,"button",54),m.Tb(1,"mat-icon"),m.Cc(2,"create"),m.Sb(),m.Sb()),2&t){var n=m.ec(2).$implicit;m.kc("routerLink",m.nc(1,Ot,n.id))}}function Ft(t,e){if(1&t){var n=m.Ub();m.Tb(0,"button",55),m.ac("click",function(){m.sc(n);var t=m.ec(2).$implicit;return m.ec().delete(t)}),m.Tb(1,"mat-icon"),m.Cc(2,"delete_sweep"),m.Sb(),m.Sb()}}function Nt(t,e){if(1&t&&(m.Tb(0,"div",51),m.Bc(1,At,3,3,"button",52),m.Bc(2,Ft,3,0,"button",53),m.Sb()),2&t){var n=m.ec(2);m.Bb(1),m.kc("ngIf",!n.session.isSuperViseur),m.Bb(1),m.kc("ngIf",!n.session.isPointFocal&&!n.session.isSuperViseur)}}function Rt(t,e){if(1&t&&(m.Tb(0,"td",46),m.Bc(1,Nt,3,2,"div",50),m.Sb()),2&t){var n=m.ec();m.Bb(1),m.kc("ngIf",!n.session.isPublic)}}function Pt(t,e){1&t&&m.Ob(0,"tr",56)}function It(t,e){1&t&&m.Ob(0,"tr",57)}var Et,Mt=function(t){return[10,25,50,100,250,t]},Lt=((Et=function(){function e(t,n,a,o,c,r,s,l,b){i(this,e),this.uow=t,this.dialog=n,this.mydialog=a,this.mytranslate=o,this.fb=c,this.session=r,this.route=s,this.bottomSheet=l,this.excel=b,this.update=new m.o,this.isLoadingResults=!0,this.resultsLength=0,this.isRateLimitReached=!1,this.dataSource=[],this.columnDefs=[{columnDef:"codeRecommendation",headName:"admin.recommandation.list.code",show:!0},{columnDef:"nom",headName:"admin.recommandation.list.nom",show:!0},{columnDef:"mecanisme",headName:"admin.recommandation.list.mecanisme",show:!0},{columnDef:"axe",headName:"admin.recommandation.list.Axe",show:!0},{columnDef:"sousAxe",headName:"admin.recommandation.list.Sousaxe",show:!0},{columnDef:"organismes",headName:"admin.recommandation.list.DEPARTEMENT",show:!1},{columnDef:"etat",headName:"admin.recommandation.list.Etatdemisenoeuvre",show:!1},{columnDef:"pieceJointe",headName:"admin.recommandation.list.OBSERVATIONS",show:!1},{columnDef:"complement",headName:"admin.recommandation.list.complement",show:!1},{columnDef:"option",headName:"",show:!0}],this.panelOpenState=!1,this.organismes=this.uow.organismes.get(),this.axes=this.uow.axes.get(),this.sousAxes=[],this.annees=[],this.mecanismes=this.uow.mecanismes,this.visites=this.uow.visites.get(),this.organes=this.uow.organes.get(),this.pays=this.uow.pays.get(),this.cycles=this.uow.cycles.get(),this.etats=this.uow.etats,this.departementList=[],this.displayedColumns=this.columnDefs.map(function(t){return t.columnDef}),this.progress=0,this.formData=new FormData,this.o=new _t,this.myAuto=new B.e(""),this.session.isPublic&&(this.columnDefs=this.columnDefs.filter(function(t){return t.show}),this.displayedColumns=this.columnDefs.map(function(t){return t.columnDef}))}return o(e,[{key:"ngOnInit",value:function(){var t=this;this.createForm(),this.isLoadingResults=!1,this.uow.recommendations.annee().subscribe(function(e){t.annees=e,t.myForm.get("annee").setValue(t.annees[0].annee),// console.log(e)}),this.o.idOrganisme=this.session.isPointFocal?this.session.user.idOrganisme:0,this.myForm.get("idOrganisme").setValue(this.o.idOrganisme),Object(C.a)(this.sort.sortChange,this.paginator.page,this.update).subscribe(function(e){!0===e?t.paginator.pageIndex=0:e=e,t.paginator.pageSize?e=e:t.paginator.pageSize=10,t.o.startIndex=t.paginator.pageIndex*t.paginator.pageSize,t.o.pageSize=t.paginator.pageSize,t.o.sortBy=t.sort.active?t.sort.active:"id",t.o.sortDir=t.sort.direction?t.sort.direction:"desc",t.isLoadingResults=!0,t.searchAndGet(t.o)}),this.route.queryParams.subscribe(function(e){var n=e.data;n&&t.uow.recommendations.getDetail(n).subscribe(function(e){t.openDialog(e)})}),this.autoComplete()}},{key:"showDownload",value:function(t){return!t||!1===this.session.isPointFocal||t.includes(this.session.user.idOrganisme)}},{key:"generateExcel",value:function(){var t=this,e=this.dataSource.map(function(e,i){var a,o,c,r,s,m;return n(a={},t.mytranslate.get("admin.recommandation.list.code"),"fr"===t.mytranslate.langSync?e.codeRecommendation:e.codeRecommendationAr),n(a,t.mytranslate.get("admin.recommandation.list.nom"),"fr"===t.mytranslate.langSync?e.nom:e.nomAr),n(a,t.mytranslate.get("admin.recommandation.list.mecanisme"),"".concat(null!==(o=e.organe)&&void 0!==o?o:"").concat(null!==(c=e.cycle)&&void 0!==c?c:"").concat(null!==(r=e.visite)&&void 0!==r?r:"")),n(a,t.mytranslate.get("admin.recommandation.list.Axe"),null===(s=e.axe)||void 0===s?void 0:s.join("; ")),n(a,t.mytranslate.get("admin.recommandation.list.Sousaxe"),null===(m=e.sousAxe)||void 0===m?void 0:m.join("; ")),n(a,t.mytranslate.get("admin.recommandation.list.DEPARTEMENT"),e.organismes),n(a,t.mytranslate.get("admin.recommandation.list.Etatdemisenoeuvre"),t.displayMulti(e.mecanisme,e.etat).e),n(a,t.mytranslate.get("admin.recommandation.list.complement"),e.complement),a});this.excel.json_to_sheet(e)}},{key:"displayFrIfArNull",value:function(t,e){return null==e||""===e||"null"===e?t:e}},{key:"displayMulti",value:function(t,e){if("fr"===this.mytranslate.langSync)return{m:t,e:e};var n=[{fr:"Examen p\xe9riodique universal",ar:"\u0627\u0644\u0627\u0633\u062a\u0639\u0631\u0627\u0636 \u0627\u0644\u062f\u0648\u0631\u064a \u0627\u0644\u0634\u0627\u0645\u0644"},{fr:"Organes de Trait\xe9s",ar:"\u0647\u064a\u0626\u0627\u062a \u0627\u0644\u0645\u0639\u0627\u0647\u062f\u0627\u062a"},{fr:"Proc\xe9dures sp\xe9ciales",ar:"\u0627\u0644\u0627\u062c\u0631\u0627\u0621\u0627\u062a \u0627\u0644\u062e\u0627\u0635\u0629"}].find(function(e){return t.toLowerCase().includes(e.fr.toLowerCase().substring(0,6))}),i=[{fr:"Non R\xe9alis\xe9",ar:"\u063a\u064a\u0631 \u0645\u0646\u062c\u0632"},{fr:"En cours",ar:"\u0641\u064a \u0637\u0648\u0631 \u0627\u0644\u0625\u0646\u062c\u0627\u0632"},{fr:"Recommendation continue",ar:"\u062a\u0648\u0635\u064a\u0629 \u0645\u0633\u062a\u0645\u0631\u0629"},{fr:"R\xe9alis\xe9",ar:"\u0645\u0646\u062c\u0632"}].find(function(t){return t.fr.toLowerCase()===e.toLowerCase()});return{m:n?n.ar:t,e:i?i.ar:e}}},{key:"autoComplete",value:function(){var t=this;this.filteredOptions=this.myAuto.valueChanges.pipe(Object(T.a)(function(e){return e.length>1?t.uow.organismes.autocompletePost("label",e):[]}))}},{key:"selected",value:function(t){var e=t.option.value;// console.log(e),this.myAuto.setValue(e.label),this.myForm.get("idOrganisme").setValue(e.id)}},{key:"createForm",value:function(){this.myForm=this.fb.group({idOrganisme:this.o.idOrganisme,mecanisme:this.o.mecanisme,idCycle:this.o.idCycle,idOrgane:this.o.idOrgane,idVisite:this.o.idVisite,idAxe:this.o.idAxe,nom:this.o.nom,etat:this.o.etat,idPays:this.o.idPays,idSousAxe:this.o.idSousAxe,annee:this.o.annee,startIndex:this.o.startIndex,pageSize:this.o.pageSize,sortBy:this.o.sortBy,sortDir:this.o.sortDir})}},{key:"selectChange",value:function(t){this.idVisite.setValue(0),this.idCycle.setValue(0),this.idOrgane.setValue(0)}},{key:"reset",value:function(){this.o=new _t,this.createForm(),this.myForm.get("annee").setValue(this.annees[0].annee),this.searchAndGet(this.o)}},{key:"search",value:function(t){this.searchAndGet(t)}},{key:"detail",value:function(t){var e=this;this.uow.recommendations.getDetail(t.id).subscribe(function(t){e.openDialog(t)})}},{key:"openDialog",value:function(t){return this.dialog.open(y,{width:"7100px",disableClose:!0,data:{model:t,title:"Recommdandation"}}).afterClosed()}},{key:"searchAndGet",value:function(t){var e=this;// console.log(t),this.o=t,this.uow.recommendations.searchAndGet(this.o).subscribe(function(t){// console.log(t.list),e.dataSource=t.list,e.resultsLength=t.count,e.isLoadingResults=!1,// console.log(e.table)},function(t){return e.isLoadingResults=!1})}},{key:"delete",value:function(e){return Object(r.a)(this,void 0,void 0,regeneratorRuntime.mark(function n(){var i,a,o=this;return regeneratorRuntime.wrap(function(n){for(;;)switch(n.prev=n.next){case 0:return n.next=2,this.mydialog.openDialog("recommandation").toPromise();case 2:if(n.t0=n.sent,"ok"!==n.t0){n.next=6;break}a=[],""!==e.pieceJointe?(i=a).push.apply(i,t(this.uow.decoupe(e.pieceJointe))):a=a,this.uow.files.deleteFiles(a,"recommandation").subscribe(function(t){o.uow.recommendations.delete(e.id).subscribe(function(){return o.update.next(!0)})});case 6:case"end":return n.stop()}},n,this)}))}},{key:"showPieceJoin",value:function(t){this.bottomSheet.open(k.a,{data:{fileName:t,folder:"recommandation"}})}},{key:"axeChange",value:function(t){var e=this;this.uow.sousAxes.getByIdAxe(t).subscribe(function(t){e.sousAxes=t})}},{key:"mecanisme",get:function(){return this.myForm.get("mecanisme")}},{key:"idVisite",get:function(){return this.myForm.get("idVisite")}},{key:"idCycle",get:function(){return this.myForm.get("idCycle")}},{key:"idOrgane",get:function(){return this.myForm.get("idOrgane")}},{key:"cycleActive",get:function(){return"Examen p\xe9riodique universal"===this.mecanisme.value}},{key:"visiteActive",get:function(){return"Proc\xe9dure sp\xe9ciale"===this.mecanisme.value}},{key:"organeActive",get:function(){return"Organes de trait\xe9s"===this.mecanisme.value}},{key:"isAllEmpty",get:function(){var t;return"0"===this.myForm.get("idAxe").value.toString()&&"0"===this.myForm.get("idCycle").value.toString()&&"0"===this.myForm.get("idSousAxe").value.toString()&&"0"===this.myForm.get("idOrganisme").value.toString()&&"0"===this.myForm.get("idOrgane").value.toString()&&"0"===this.myForm.get("idPays").value.toString()&&""===this.myForm.get("nom").value.toString()&&""===this.myForm.get("etat").value.toString()&&"0"===this.myForm.get("idVisite").value.toString()&&"0"===(null===(t=this.myForm.get("annee").value)||void 0===t?void 0:t.toString())&&""===this.myForm.get("mecanisme").value.toString()}}]),e}()).\u0275fac=function(t){return new(t||Et)(m.Nb(D.a),m.Nb(s.b),m.Nb(w.a),m.Nb(x.a),m.Nb(B.d),m.Nb(O.a),m.Nb(A.a),m.Nb(F.b),m.Nb(N.a))},Et.\u0275cmp=m.Hb({type:Et,selectors:[["app-list"]],viewQuery:function(t,e){var n;1&t&&(m.xc(S.a,!0),m.xc(v.a,!0),m.xc(z,!0)),2&t&&(m.pc(n=m.bc())&&(e.paginator=n.first),m.pc(n=m.bc())&&(e.sort=n.first),m.pc(n=m.bc())&&(e.table=n.first))},decls:139,vars:74,consts:[[1,"host"],[3,"title"],[1,"right"],[1,"d-flex","flex-row-reverse","pt-3","mb-3"],["mat-raised-button","","color","primary",3,"routerLink",4,"ngIf"],["mat-raised-button","","color","warn",3,"disabled","click"],[1,"expension"],["expanded","",3,"opened","closed"],[3,"formGroup"],[1,"inputs2"],["appearance","fill"],["matInput","","formControlName","nom","required",""],["formControlName","idPays"],["value","0"],[3,"value",4,"ngFor","ngForOf"],["appearance","fill",4,"ngIf"],["formControlName","mecanisme",3,"selectionChange"],["formControlName","etat"],["formControlName","idAxe",3,"selectionChange"],["formControlName","idSousAxe"],["formControlName","idOrganisme"],["mat-raised-button","","color","primary",3,"disabled","click"],["mat-raised-button","",3,"click"],[1,"example-container","mat-elevation-z8"],["class","example-loading-shade",4,"ngIf"],[1,"example-table-container"],["mat-table","","multiTemplateDataRows","","aria-label","Elements","matSort","",3,"dataSource"],["mytable",""],[3,"matColumnDef"],["mat-header-cell","","mat-sort-header","",4,"matHeaderCellDef"],["mat-cell","",4,"matCellDef"],["mat-header-cell","",4,"matHeaderCellDef"],["matColumnDef","option",2,"flex-direction","row-reverse"],["mat-header-row","",4,"matHeaderRowDef"],["mat-row","",4,"matRowDef","matRowDefColumns"],["pageIndex","0","pageSize","10","showFirstLastButtons","",3,"length","pageSizeOptions"],["paginator",""],["mat-raised-button","","color","primary",3,"routerLink"],[3,"value"],["formControlName","annee"],["formControlName","idCycle"],["formControlName","idVisite"],["formControlName","idOrgane"],[1,"example-loading-shade"],[4,"ngIf"],["mat-header-cell","","mat-sort-header",""],["mat-cell",""],["mat-header-cell",""],["mat-icon-button","","color","accent",3,"disabled","matTooltip","click",4,"ngIf"],["mat-icon-button","","color","accent",3,"disabled","matTooltip","click"],["class","button-row",4,"ngIf"],[1,"button-row"],["mat-icon-button","","color","primary",3,"routerLink",4,"ngIf"],["mat-icon-button","","color","warn",3,"click",4,"ngIf"],["mat-icon-button","","color","primary",3,"routerLink"],["mat-icon-button","","color","warn",3,"click"],["mat-header-row",""],["mat-row",""]],template:function(t,e){1&t&&(m.Tb(0,"div",0),m.Ob(1,"app-title",1),m.fc(2,"translate"),m.Tb(3,"div",2),m.Tb(4,"div",3),m.Bc(5,J,5,5,"button",4),m.Cc(6," \xa0 "),m.Tb(7,"button",5),m.ac("click",function(){return e.generateExcel()}),m.Tb(8,"mat-icon"),m.Cc(9,"cloud_download"),m.Sb(),m.Cc(10," Excel "),m.Sb(),m.Sb(),m.Sb(),m.Tb(11,"div",6),m.Tb(12,"mat-accordion"),m.Tb(13,"mat-expansion-panel",7),m.ac("opened",function(){return e.panelOpenState=!0})("closed",function(){return e.panelOpenState=!1}),m.Tb(14,"mat-expansion-panel-header"),m.Tb(15,"mat-panel-title"),m.Tb(16,"mat-icon"),m.Cc(17,"search"),m.Sb(),m.Tb(18,"p"),m.Cc(19),m.fc(20,"translate"),m.Sb(),m.Sb(),m.Ob(21,"mat-panel-description"),m.Sb(),m.Ob(22,"mat-divider"),m.Tb(23,"form",8),m.Tb(24,"div",9),m.Tb(25,"mat-form-field",10),m.Tb(26,"mat-label"),m.Cc(27),m.fc(28,"translate"),m.Sb(),m.Ob(29,"input",11),m.Sb(),m.Sb(),m.Tb(30,"div",9),m.Tb(31,"mat-form-field",10),m.Tb(32,"mat-label"),m.Cc(33),m.fc(34,"translate"),m.Sb(),m.Tb(35,"mat-select",12),m.Tb(36,"mat-option",13),m.Cc(37,"..."),m.Sb(),m.Bc(38,q,2,2,"mat-option",14),m.fc(39,"async"),m.Sb(),m.Sb(),m.Bc(40,U,8,4,"mat-form-field",15),m.Sb(),m.Tb(41,"div",9),m.Tb(42,"mat-form-field",10),m.Tb(43,"mat-label"),m.Cc(44),m.fc(45,"translate"),m.Sb(),m.Tb(46,"mat-select",16),m.ac("selectionChange",function(t){return e.selectChange(t.value)}),m.Tb(47,"mat-option",13),m.Cc(48,"..."),m.Sb(),m.Bc(49,K,2,2,"mat-option",14),m.fc(50,"async"),m.Sb(),m.Sb(),m.Bc(51,Y,9,6,"mat-form-field",15),m.Bc(52,W,9,6,"mat-form-field",15),m.Bc(53,et,9,6,"mat-form-field",15),m.Tb(54,"mat-form-field",10),m.Tb(55,"mat-label"),m.Cc(56),m.fc(57,"translate"),m.Sb(),m.Tb(58,"mat-select",17),m.Bc(59,nt,2,2,"mat-option",14),m.fc(60,"async"),m.Sb(),m.Sb(),m.Sb(),m.Tb(61,"div",9),m.Tb(62,"mat-form-field",10),m.Tb(63,"mat-label"),m.Cc(64),m.fc(65,"translate"),m.Sb(),m.Tb(66,"mat-select",18),m.ac("selectionChange",function(t){return e.axeChange(t.value)}),m.Tb(67,"mat-option",13),m.Cc(68,"..."),m.Sb(),m.Bc(69,it,2,2,"mat-option",14),m.fc(70,"async"),m.Sb(),m.Sb(),m.Tb(71,"mat-form-field",10),m.Tb(72,"mat-label"),m.Cc(73),m.fc(74,"translate"),m.Sb(),m.Tb(75,"mat-select",19),m.Tb(76,"mat-option",13),m.Cc(77,"..."),m.Sb(),m.Bc(78,at,2,2,"mat-option",14),m.Sb(),m.Sb(),m.Tb(79,"mat-form-field",10),m.Tb(80,"mat-label"),m.Cc(81),m.fc(82,"translate"),m.Sb(),m.Tb(83,"mat-select",20),m.Tb(84,"mat-option",13),m.Cc(85,"..."),m.Sb(),m.Bc(86,ot,2,2,"mat-option",14),m.fc(87,"async"),m.Sb(),m.Sb(),m.Sb(),m.Sb(),m.Tb(88,"div",2),m.Tb(89,"button",21),m.ac("click",function(){return e.search(e.myForm.value)}),m.Tb(90,"mat-icon"),m.Cc(91,"search"),m.Sb(),m.Cc(92),m.fc(93,"translate"),m.Sb(),m.Cc(94," \xa0 "),m.Tb(95,"button",22),m.ac("click",function(){return e.reset()}),m.Tb(96,"mat-icon"),m.Cc(97,"refresh"),m.Sb(),m.Cc(98),m.fc(99,"translate"),m.Sb(),m.Sb(),m.Sb(),m.Sb(),m.Sb(),m.Tb(100,"div",23),m.Bc(101,rt,2,1,"div",24),m.Tb(102,"div",25),m.Tb(103,"table",26,27),m.Rb(105,28),m.Bc(106,st,3,3,"th",29),m.Bc(107,mt,2,1,"td",30),m.Qb(),m.Rb(108,28),m.Bc(109,lt,3,3,"th",29),m.Bc(110,bt,2,1,"td",30),m.Qb(),m.Rb(111,28),m.Bc(112,ut,3,3,"th",29),m.Bc(113,dt,2,3,"td",30),m.Qb(),m.Rb(114,28),m.Bc(115,ft,3,3,"th",29),m.Bc(116,gt,2,1,"td",30),m.Qb(),m.Rb(117,28),m.Bc(118,ht,3,3,"th",29),m.Bc(119,pt,2,1,"td",30),m.Qb(),m.Rb(120,28),m.Bc(121,yt,3,3,"th",29),m.Bc(122,St,2,1,"td",30),m.Qb(),m.Rb(123,28),m.Bc(124,vt,3,3,"th",29),m.Bc(125,Ct,2,1,"td",30),m.Qb(),m.Rb(126,28),m.Bc(127,Bt,3,3,"th",31),m.Bc(128,kt,2,1,"td",30),m.Qb(),m.Rb(129,28),m.Bc(130,Dt,3,3,"th",29),m.Bc(131,wt,2,1,"td",30),m.Qb(),m.Rb(132,32),m.Bc(133,xt,1,0,"th",31),m.Bc(134,Rt,2,1,"td",30),m.Qb(),m.Bc(135,Pt,1,0,"tr",33),m.Bc(136,It,1,0,"tr",34),m.Sb(),m.Sb(),m.Ob(137,"mat-paginator",35,36),m.Sb(),m.Sb()),2&t&&(m.Bb(1),m.lc("title",m.gc(2,40,"admin.recommandation.list.Recommandations")),m.Bb(4),m.kc("ngIf",!e.session.isPointFocal&&!e.session.isSuperViseur&&!e.session.isPublic),m.Bb(2),m.kc("disabled",0===e.dataSource.length),m.Bb(12),m.Dc(m.gc(20,42,"admin.recommandation.list.Recherche")),m.Bb(4),m.kc("formGroup",e.myForm),m.Bb(4),m.Dc(m.gc(28,44,"admin.recommandation.list.nom")),m.Bb(6),m.Dc(m.gc(34,46,"admin.recommandation.list.Pays")),m.Bb(5),m.kc("ngForOf",m.gc(39,48,e.pays)),m.Bb(2),m.kc("ngIf",!e.session.isPublic),m.Bb(4),m.Dc(m.gc(45,50,"admin.recommandation.list.mecanisme")),m.Bb(5),m.kc("ngForOf",m.gc(50,52,e.mecanismes)),m.Bb(2),m.kc("ngIf",e.cycleActive),m.Bb(1),m.kc("ngIf",e.visiteActive),m.Bb(1),m.kc("ngIf",e.organeActive),m.Bb(3),m.Dc(m.gc(57,54,"admin.recommandation.list.Etatdemisenoeuvre")),m.Bb(3),m.kc("ngForOf",m.gc(60,56,e.etats)),m.Bb(5),m.Dc(m.gc(65,58,"admin.recommandation.list.Axe")),m.Bb(5),m.kc("ngForOf",m.gc(70,60,e.axes)),m.Bb(4),m.Dc(m.gc(74,62,"admin.recommandation.list.Sousaxe")),m.Bb(5),m.kc("ngForOf",e.sousAxes),m.Bb(3),m.Dc(m.gc(82,64,"admin.recommandation.list.DEPARTEMENT")),m.Bb(5),m.kc("ngForOf",m.gc(87,66,e.organismes)),m.Bb(3),m.kc("disabled",e.isAllEmpty),m.Bb(3),m.Ec(" ",m.gc(93,68,"admin.recommandation.list.Rechercher")," "),m.Bb(6),m.Ec(" ",m.gc(99,70,"admin.recommandation.list.R\xe9initialiser")," "),m.Bb(3),m.kc("ngIf",e.isLoadingResults),m.Bb(2),m.kc("dataSource",e.dataSource),m.Bb(2),m.kc("matColumnDef","codeRecommendation"),m.Bb(3),m.kc("matColumnDef","nom"),m.Bb(3),m.kc("matColumnDef","mecanisme"),m.Bb(3),m.kc("matColumnDef","axe"),m.Bb(3),m.kc("matColumnDef","sousAxe"),m.Bb(3),m.kc("matColumnDef","organismes"),m.Bb(3),m.kc("matColumnDef","etat"),m.Bb(3),m.kc("matColumnDef","pieceJointe"),m.Bb(3),m.kc("matColumnDef","complement"),m.Bb(6),m.kc("matHeaderRowDef",e.displayedColumns),m.Bb(1),m.kc("matRowDefColumns",e.displayedColumns),m.Bb(1),m.kc("length",e.resultsLength)("pageSizeOptions",m.nc(72,Mt,e.resultsLength)))},directives:[R.a,u.m,d.a,P.a,I.a,I.c,I.e,I.f,I.d,b.a,B.t,B.n,B.h,E.c,E.f,M.b,B.c,B.m,B.g,B.r,L.a,_.o,u.l,V.j,v.a,V.c,V.e,V.b,V.g,V.i,S.a,A.f,$.b,V.d,v.b,V.a,j.a,V.f,V.h],pipes:[Q.c,u.b],styles:["section[_ngcontent-%COMP%]{display:flex!important;justify-content:space-between!important;align-items:center!important}  h3{margin:0!important}.host[_ngcontent-%COMP%]{margin:1em!important}.inputs2[_ngcontent-%COMP%]{display:grid;grid-template-columns:repeat(auto-fit,minmax(25vw,1fr));grid-column-gap:6px;grid-row-gap:6px;align-items:center}form[_ngcontent-%COMP%]{padding:20px}.expension[_ngcontent-%COMP%]{margin:20px 0}.right[_ngcontent-%COMP%]{margin:0 20px 20px}mat-panel-title[_ngcontent-%COMP%]{display:flex;align-items:center}mat-panel-title[_ngcontent-%COMP%]   p[_ngcontent-%COMP%]{margin:0 0 0 10px}mat-panel-title[_ngcontent-%COMP%]   mat-icon[_ngcontent-%COMP%]{margin-top:5px}"]}),Et),_t=function t(){i(this,t),this.idAxe=0,this.idSousAxe=0,this.idOrganisme=0,this.mecanisme="",this.idCycle=0,this.idOrgane=0,this.idVisite=0,this.nom="",this.etat="",this.idPays=0,this.startIndex=0,this.pageSize=10,this.sortBy="id",this.sortDir="desc",this.annee=0}}}])}();