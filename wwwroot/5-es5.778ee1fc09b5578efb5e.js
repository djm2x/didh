!function(){function t(t){return function(t){if(Array.isArray(t))return e(t)}(t)||function(t){if("undefined"!=typeof Symbol&&Symbol.iterator in Object(t))return Array.from(t)}(t)||function(t,n){if(!t)return;if("string"==typeof t)return e(t,n);var i=Object.prototype.toString.call(t).slice(8,-1);"Object"===i&&t.constructor&&(i=t.constructor.name);if("Map"===i||"Set"===i)return Array.from(t);if("Arguments"===i||/^(?:Ui|I)nt(?:8|16|32)(?:Clamped)?Array$/.test(i))return e(t,n)}(t)||function(){throw new TypeError("Invalid attempt to spread non-iterable instance.\nIn order to be iterable, non-array objects must have a [Symbol.iterator]() method.")}()}function e(t,e){(null==e||e>t.length)&&(e=t.length);for(var n=0,i=new Array(e);n<e;n++)i[n]=t[n];return i}function n(t,e){if(!(t instanceof e))throw new TypeError("Cannot call a class as a function")}function i(t,e){for(var n=0;n<e.length;n++){var i=e[n];i.enumerable=i.enumerable||!1,i.configurable=!0,"value"in i&&(i.writable=!0),Object.defineProperty(t,i.key,i)}}function a(t,e,n){return e&&i(t.prototype,e),n&&i(t,n),t}(window.webpackJsonp=window.webpackJsonp||[]).push([[5],{F76L:function(e,i,o){"use strict";o.d(i,"a",function(){return It}),o.d(i,"b",function(){return Et});var c=o("mrSG"),r=o("0IaG"),s=o("fXoL"),m=o("/t3+"),l=o("f0Cb"),b=o("ofXK"),u=o("bTqV");function d(t,e){if(1&t&&(s.Tb(0,"li"),s.Cc(1),s.Sb()),2&t){var n=s.ec();s.Bb(1),s.Ec("Cylce: ",n.o.cycle.label,"")}}function f(t,e){if(1&t&&(s.Tb(0,"li"),s.Cc(1),s.Sb()),2&t){var n=s.ec();s.Bb(1),s.Ec("Visite: ",n.o.visite.mandat,"")}}function p(t,e){if(1&t&&(s.Tb(0,"li"),s.Cc(1),s.Sb()),2&t){var n=s.ec();s.Bb(1),s.Ec("Organe de trait\xe9: ",n.o.organe.label,"")}}var g,h=((g=function(){function t(e,i){n(this,t),this.dialogRef=e,this.data=i,this.title=""}return a(t,[{key:"ngOnInit",value:function(){this.o=this.data.model,this.title=this.data.title,console.log(this.o)}},{key:"onNoClick",value:function(){this.dialogRef.close()}},{key:"onOkClick",value:function(t){}}]),t}()).\u0275fac=function(t){return new(t||g)(s.Nb(r.g),s.Nb(r.a))},g.\u0275cmp=s.Hb({type:g,selectors:[["app-update"]],decls:23,vars:8,consts:[[1,"dialog"],["mat-dialog-title",""],["role","toolbar",1,"task-header"],[1,"content"],["mat-dialog-content",""],[4,"ngIf"],["mat-dialog-actions","",1,"actions"],["mat-button","","type","button",3,"click"]],template:function(t,e){1&t&&(s.Tb(0,"div",0),s.Tb(1,"h1",1),s.Tb(2,"mat-toolbar",2),s.Tb(3,"span"),s.Cc(4),s.Sb(),s.Sb(),s.Ob(5,"mat-divider"),s.Sb(),s.Tb(6,"div",3),s.Tb(7,"div",4),s.Tb(8,"ul"),s.Tb(9,"li"),s.Cc(10),s.Sb(),s.Tb(11,"li"),s.Cc(12),s.Sb(),s.Tb(13,"li"),s.Cc(14),s.Sb(),s.Tb(15,"li"),s.Cc(16),s.Sb(),s.Bc(17,d,2,1,"li",5),s.Bc(18,f,2,1,"li",5),s.Bc(19,p,2,1,"li",5),s.Sb(),s.Sb(),s.Tb(20,"div",6),s.Tb(21,"button",7),s.ac("click",function(){return e.onNoClick()}),s.Cc(22,"Retour"),s.Sb(),s.Sb(),s.Sb(),s.Sb()),2&t&&(s.Bb(4),s.Dc(e.o.nom),s.Bb(6),s.Dc(e.o.etat),s.Bb(2),s.Dc(e.o.mecanisme),s.Bb(2),s.Ec("Axe: ",e.o.axes,""),s.Bb(2),s.Ec("Sous axe: ",e.o.sousAxes,""),s.Bb(1),s.kc("ngIf",e.o.cycle),s.Bb(1),s.kc("ngIf",e.o.visite),s.Bb(1),s.kc("ngIf",e.o.organe))},directives:[r.h,m.a,l.a,r.e,b.m,r.c,u.a],styles:["mat-form-field[_ngcontent-%COMP%]{width:100%}.dialog[_ngcontent-%COMP%]{overflow-x:hidden;overflow-y:hidden}.dialog[_ngcontent-%COMP%]   h1[_ngcontent-%COMP%]   span[_ngcontent-%COMP%]{padding:0 5px}.dialog[_ngcontent-%COMP%]   .content[_ngcontent-%COMP%]{padding:0 20px 25px}.dialog[_ngcontent-%COMP%]   .actions[_ngcontent-%COMP%]{display:flex;flex-direction:row-reverse}.myrow[_ngcontent-%COMP%]{display:flex;align-items:center}"]}),g),y=o("M9IT"),S=o("Dh3D"),v=o("VRyK"),C=o("3Pt+"),B=o("eIep"),T=o("ZTdd"),D=o("7q3A"),k=o("5F3i"),x=o("J3i2"),w=o("M0ag"),O=o("tyNb"),A=o("2ChS"),F=o("/ysL"),N=o("7EHt"),P=o("NFeN"),R=o("kmnG"),I=o("qFsG"),E=o("d3UM"),M=o("FKr1"),L=o("+0xr"),V=o("Xa2L"),_=o("Qu3c"),$=o("sYmb"),J=function(){return["/admin/recommendation/update",0]};function z(t,e){1&t&&(s.Tb(0,"button",34),s.Tb(1,"mat-icon"),s.Cc(2,"add"),s.Sb(),s.Cc(3),s.fc(4,"translate"),s.Sb()),2&t&&(s.kc("routerLink",s.mc(4,J)),s.Bb(3),s.Ec(" ",s.gc(4,2,"admin.recommandation.list.Recommandation")," "))}function G(t,e){if(1&t&&(s.Tb(0,"mat-option",35),s.Cc(1),s.Sb()),2&t){var n=e.$implicit,i=s.ec();s.kc("value",n.id),s.Bb(1),s.Dc("fr"===i.mytranslate.langSync?n.nom:n.nomAr)}}function Q(t,e){if(1&t&&(s.Tb(0,"mat-option",35),s.Cc(1),s.Sb()),2&t){var n=e.$implicit;s.kc("value",n),s.Bb(1),s.Dc(n)}}function j(t,e){if(1&t&&(s.Tb(0,"mat-form-field",8),s.Tb(1,"mat-label"),s.Cc(2),s.fc(3,"translate"),s.Sb(),s.Tb(4,"mat-select",36),s.Bc(5,Q,2,2,"mat-option",12),s.Sb(),s.Sb()),2&t){var n=s.ec();s.Bb(2),s.Dc(s.gc(3,2,"admin.questionnaire.list.ann\xe9e")),s.Bb(3),s.kc("ngForOf",n.annee)}}function U(t,e){if(1&t&&(s.Tb(0,"mat-option",35),s.Cc(1),s.Sb()),2&t){var n=e.$implicit,i=s.ec();s.kc("value",n.name),s.Bb(1),s.Dc("fr"===i.mytranslate.langSync?n.name:n.nameAr)}}function q(t,e){if(1&t&&(s.Tb(0,"mat-option",35),s.Cc(1),s.Sb()),2&t){var n=e.$implicit,i=s.ec(2);s.kc("value",n.id),s.Bb(1),s.Dc("fr"===i.mytranslate.langSync?n.label:n.labelAr)}}function H(t,e){if(1&t&&(s.Tb(0,"mat-form-field",8),s.Tb(1,"mat-label"),s.Cc(2),s.fc(3,"translate"),s.Sb(),s.Tb(4,"mat-select",37),s.Tb(5,"mat-option",11),s.Cc(6,"..."),s.Sb(),s.Bc(7,q,2,2,"mat-option",12),s.fc(8,"async"),s.Sb(),s.Sb()),2&t){var n=s.ec();s.Bb(2),s.Dc(s.gc(3,2,"admin.recommandation.list.Cycle")),s.Bb(5),s.kc("ngForOf",s.gc(8,4,n.cycles))}}function X(t,e){if(1&t&&(s.Tb(0,"mat-option",35),s.Cc(1),s.Sb()),2&t){var n=e.$implicit,i=s.ec(2);s.kc("value",n.id),s.Bb(1),s.Dc("fr"===i.mytranslate.langSync?n.mandat:n.mandatAr)}}function K(t,e){if(1&t&&(s.Tb(0,"mat-form-field",8),s.Tb(1,"mat-label"),s.Cc(2),s.fc(3,"translate"),s.Sb(),s.Tb(4,"mat-select",38),s.Tb(5,"mat-option",11),s.Cc(6,"..."),s.Sb(),s.Bc(7,X,2,2,"mat-option",12),s.fc(8,"async"),s.Sb(),s.Sb()),2&t){var n=s.ec();s.Bb(2),s.Dc(s.gc(3,2,"admin.recommandation.list.Visite")),s.Bb(5),s.kc("ngForOf",s.gc(8,4,n.visites))}}function Y(t,e){if(1&t&&(s.Tb(0,"mat-option",35),s.Cc(1),s.Sb()),2&t){var n=e.$implicit,i=s.ec(2);s.kc("value",n.id),s.Bb(1),s.Dc("fr"===i.mytranslate.langSync?n.label:n.labelAr)}}function Z(t,e){if(1&t&&(s.Tb(0,"mat-form-field",8),s.Tb(1,"mat-label"),s.Cc(2),s.fc(3,"translate"),s.Sb(),s.Tb(4,"mat-select",39),s.Tb(5,"mat-option",11),s.Cc(6,"..."),s.Sb(),s.Bc(7,Y,2,2,"mat-option",12),s.fc(8,"async"),s.Sb(),s.Sb()),2&t){var n=s.ec();s.Bb(2),s.Dc(s.gc(3,2,"admin.recommandation.list.Organe")),s.Bb(5),s.kc("ngForOf",s.gc(8,4,n.organes))}}function W(t,e){if(1&t&&(s.Tb(0,"mat-option",35),s.Cc(1),s.Sb()),2&t){var n=e.$implicit,i=s.ec();s.kc("value",n.name),s.Bb(1),s.Dc("fr"===i.mytranslate.langSync?n.name:n.nameAr)}}function tt(t,e){if(1&t&&(s.Tb(0,"mat-option",35),s.Cc(1),s.Sb()),2&t){var n=e.$implicit,i=s.ec();s.kc("value",n.id),s.Bb(1),s.Dc("fr"===i.mytranslate.langSync?n.label:n.labelAr)}}function et(t,e){if(1&t&&(s.Tb(0,"mat-option",35),s.Cc(1),s.Sb()),2&t){var n=e.$implicit,i=s.ec();s.kc("value",n.id),s.Bb(1),s.Dc("fr"===i.mytranslate.langSync?n.label:n.labelAr)}}function nt(t,e){if(1&t&&(s.Tb(0,"mat-option",35),s.Cc(1),s.Sb()),2&t){var n=e.$implicit,i=s.ec(2);s.kc("value",n.id),s.Bb(1),s.Ec(" ","fr"===i.mytranslate.langSync?n.label:n.labelAr,"")}}function it(t,e){if(1&t&&(s.Tb(0,"mat-form-field",8),s.Tb(1,"mat-label"),s.Cc(2),s.fc(3,"translate"),s.Sb(),s.Tb(4,"mat-select",40),s.Tb(5,"mat-option",11),s.Cc(6,"..."),s.Sb(),s.Bc(7,nt,2,2,"mat-option",12),s.fc(8,"async"),s.Sb(),s.Sb()),2&t){var n=s.ec();s.Bb(2),s.Dc(s.gc(3,2,"admin.recommandation.list.DEPARTEMENT")),s.Bb(5),s.kc("ngForOf",s.gc(8,4,n.organismes))}}function at(t,e){1&t&&s.Ob(0,"mat-spinner")}function ot(t,e){if(1&t&&(s.Tb(0,"div",41),s.Bc(1,at,1,0,"mat-spinner",42),s.Sb()),2&t){var n=s.ec();s.Bb(1),s.kc("ngIf",n.isLoadingResults)}}function ct(t,e){1&t&&(s.Tb(0,"th",43),s.Cc(1),s.fc(2,"translate"),s.Sb()),2&t&&(s.Bb(1),s.Dc(s.gc(2,1,"admin.recommandation.list.code")))}function rt(t,e){if(1&t&&(s.Tb(0,"td",44),s.Cc(1),s.Sb()),2&t){var n=e.$implicit,i=s.ec();s.Bb(1),s.Ec(" ","fr"===i.mytranslate.langSync?n.codeRecommendation:i.displayFrIfArNull(n.codeRecommendation,n.codeRecommendationAr)," ")}}function st(t,e){1&t&&(s.Tb(0,"th",43),s.Cc(1),s.fc(2,"translate"),s.Sb()),2&t&&(s.Bb(1),s.Dc(s.gc(2,1,"admin.recommandation.list.nom")))}function mt(t,e){if(1&t&&(s.Tb(0,"td",44),s.Cc(1),s.Sb()),2&t){var n=e.$implicit,i=s.ec();s.Bb(1),s.Dc("fr"===i.mytranslate.langSync?n.nom:i.displayFrIfArNull(n.nom,n.nomAr))}}function lt(t,e){1&t&&(s.Tb(0,"th",43),s.Cc(1),s.fc(2,"translate"),s.Sb()),2&t&&(s.Bb(1),s.Dc(s.gc(2,1,"admin.recommandation.list.mecanisme")))}function bt(t,e){if(1&t&&(s.Tb(0,"td",44),s.Cc(1),s.Sb()),2&t){var n=e.$implicit,i=s.ec();s.Bb(1),s.Dc(i.displayMulti(n.mecanisme,n.etat).m)}}function ut(t,e){1&t&&(s.Tb(0,"th",43),s.Cc(1),s.fc(2,"translate"),s.Sb()),2&t&&(s.Bb(1),s.Dc(s.gc(2,1,"admin.recommandation.list.Axe")))}function dt(t,e){if(1&t&&(s.Tb(0,"td",44),s.Cc(1),s.Sb()),2&t){var n=e.$implicit,i=s.ec();s.Bb(1),s.Dc(n[i.columnDefs[3].columnDef])}}function ft(t,e){1&t&&(s.Tb(0,"th",43),s.Cc(1),s.fc(2,"translate"),s.Sb()),2&t&&(s.Bb(1),s.Dc(s.gc(2,1,"admin.recommandation.list.Sousaxe")))}function pt(t,e){if(1&t&&(s.Tb(0,"td",44),s.Cc(1),s.Sb()),2&t){var n=e.$implicit,i=s.ec();s.Bb(1),s.Dc(n[i.columnDefs[4].columnDef])}}function gt(t,e){1&t&&(s.Tb(0,"th",43),s.Cc(1),s.fc(2,"translate"),s.Sb()),2&t&&(s.Bb(1),s.Dc(s.gc(2,1,"admin.recommandation.list.DEPARTEMENT")))}function ht(t,e){if(1&t&&(s.Tb(0,"td",44),s.Cc(1),s.Sb()),2&t){var n=e.$implicit;s.Bb(1),s.Dc(n.organismes)}}function yt(t,e){1&t&&(s.Tb(0,"th",43),s.Cc(1),s.fc(2,"translate"),s.Sb()),2&t&&(s.Bb(1),s.Dc(s.gc(2,1,"admin.recommandation.list.Etatdemisenoeuvre")))}function St(t,e){if(1&t&&(s.Tb(0,"td",44),s.Cc(1),s.Sb()),2&t){var n=e.$implicit,i=s.ec();s.Bb(1),s.Dc(i.displayMulti(n.mecanisme,n.etat).e)}}function vt(t,e){1&t&&(s.Tb(0,"th",45),s.Cc(1),s.fc(2,"translate"),s.Sb()),2&t&&(s.Bb(1),s.Dc(s.gc(2,1,"admin.recommandation.list.OBSERVATIONS")))}function Ct(t,e){if(1&t){var n=s.Ub();s.Tb(0,"td",44),s.Tb(1,"button",46),s.ac("click",function(){s.sc(n);var t=e.$implicit;return s.ec().showPieceJoin(t.pieceJointe)}),s.Tb(2,"mat-icon"),s.Cc(3,"cloud_download"),s.Sb(),s.Sb(),s.Sb()}if(2&t){var i=e.$implicit;s.Bb(1),s.kc("disabled",""===i.pieceJointe)("matTooltip",i.pieceJointe)}}function Bt(t,e){1&t&&(s.Tb(0,"th",43),s.Cc(1),s.fc(2,"translate"),s.Sb()),2&t&&(s.Bb(1),s.Dc(s.gc(2,1,"admin.recommandation.list.complement")))}function Tt(t,e){if(1&t&&(s.Tb(0,"td",44),s.Cc(1),s.Sb()),2&t){var n=e.$implicit;s.Bb(1),s.Dc(n.complement)}}function Dt(t,e){1&t&&s.Ob(0,"th",45)}var kt=function(t){return["/admin/recommendation/update",t]};function xt(t,e){if(1&t&&(s.Tb(0,"button",52),s.Tb(1,"mat-icon"),s.Cc(2,"create"),s.Sb(),s.Sb()),2&t){var n=s.ec(2).$implicit;s.kc("routerLink",s.nc(1,kt,n.id))}}function wt(t,e){if(1&t){var n=s.Ub();s.Tb(0,"button",53),s.ac("click",function(){s.sc(n);var t=s.ec(2).$implicit;return s.ec().delete(t)}),s.Tb(1,"mat-icon"),s.Cc(2,"delete_sweep"),s.Sb(),s.Sb()}}function Ot(t,e){if(1&t){var n=s.Ub();s.Tb(0,"div",48),s.Tb(1,"button",49),s.ac("click",function(){s.sc(n);var t=s.ec().$implicit;return s.ec().detail(t)}),s.Tb(2,"mat-icon"),s.Cc(3,"visibility"),s.Sb(),s.Sb(),s.Bc(4,xt,3,3,"button",50),s.Bc(5,wt,3,0,"button",51),s.Sb()}if(2&t){var i=s.ec(2);s.Bb(4),s.kc("ngIf",!i.session.isSuperViseur),s.Bb(1),s.kc("ngIf",!i.session.isPointFocal&&!i.session.isSuperViseur)}}function At(t,e){if(1&t&&(s.Tb(0,"td",44),s.Bc(1,Ot,6,2,"div",47),s.Sb()),2&t){var n=s.ec();s.Bb(1),s.kc("ngIf",!n.session.isPublic)}}function Ft(t,e){1&t&&s.Ob(0,"tr",54)}function Nt(t,e){1&t&&s.Ob(0,"tr",55)}var Pt,Rt=function(){return[10,25,50,100,250]},It=((Pt=function(){function e(t,i,a,o,c,r,m,l){n(this,e),this.uow=t,this.dialog=i,this.mydialog=a,this.mytranslate=o,this.fb=c,this.session=r,this.route=m,this.bottomSheet=l,this.update=new s.o,this.isLoadingResults=!0,this.resultsLength=0,this.isRateLimitReached=!1,this.dataSource=[],this.columnDefs=[{columnDef:"codeRecommendation",headName:"CODE",show:!0},{columnDef:"nom",headName:"INTITULE",show:!0},{columnDef:"mecanisme",headName:"mecanisme",show:!0},{columnDef:"axe",headName:"Axe",show:!0},{columnDef:"sousAxe",headName:"SOUS AXE",show:!0},{columnDef:"organismes",headName:"DEPARTEMENT",show:!1},{columnDef:"etat",headName:"ETAT DE MISE EN OEUVRE",show:!1},{columnDef:"pieceJointe",headName:"",show:!1},{columnDef:"complement",headName:"",show:!1},{columnDef:"option",headName:"",show:!0}].map(function(t){return t.headName=""===t.headName?t.columnDef.toUpperCase():t.headName.toUpperCase(),t}),this.panelOpenState=!1,this.organismes=this.uow.organismes.get(),this.axes=this.uow.axes.get(),this.sousAxes=[],this.annee=[],this.mecanismes=this.uow.mecanismes,this.visites=this.uow.visites.get(),this.organes=this.uow.organes.get(),this.pays=this.uow.pays.get(),this.cycles=this.uow.cycles.get(),this.etats=this.uow.etats,this.departementList=[],this.displayedColumns=this.columnDefs.map(function(t){return t.columnDef}),this.progress=0,this.formData=new FormData,this.o=new Et,this.myAuto=new C.e(""),this.session.isPublic&&(this.columnDefs=this.columnDefs.filter(function(t){return t.show}),this.displayedColumns=this.columnDefs.map(function(t){return t.columnDef}))}return a(e,[{key:"ngOnInit",value:function(){var t=this;this.createForm(),this.isLoadingResults=!1,this.uow.recommendations.annee().subscribe(function(e){t.annee=e,t.myForm.get("annee").setValue(t.annee[0])}),Object(v.a)(this.sort.sortChange,this.paginator.page,this.update).subscribe(function(e){!0===e?t.paginator.pageIndex=0:e=e,t.paginator.pageSize?e=e:t.paginator.pageSize=10,t.o.startIndex=t.paginator.pageIndex*t.paginator.pageSize,t.o.pageSize=t.paginator.pageSize,t.o.sortBy=t.sort.active?t.sort.active:"id",t.o.sortDir=t.sort.direction?t.sort.direction:"desc",t.isLoadingResults=!0,console.log(t.o),t.searchAndGet(t.o)}),this.route.queryParams.subscribe(function(e){var n=e.data;n&&t.uow.recommendations.getDetail(n).subscribe(function(e){t.openDialog(e)})}),this.autoComplete()}},{key:"displayFrIfArNull",value:function(t,e){return null==e||""===e||"null"===e?t:e}},{key:"displayMulti",value:function(t,e){if("fr"===this.mytranslate.langSync)return{m:t,e:e};var n=[{fr:"Examen p\xe9riodique universal",ar:"\u0627\u0644\u0627\u0633\u062a\u0639\u0631\u0627\u0636 \u0627\u0644\u062f\u0648\u0631\u064a \u0627\u0644\u0634\u0627\u0645\u0644"},{fr:"Organes de Trait\xe9s",ar:"\u0647\u064a\u0626\u0627\u062a \u0627\u0644\u0645\u0639\u0627\u0647\u062f\u0627\u062a"},{fr:"Proc\xe9dures sp\xe9ciales",ar:"\u0627\u0644\u0627\u062c\u0631\u0627\u0621\u0627\u062a \u0627\u0644\u062e\u0627\u0635\u0629"}].find(function(e){return t.toLowerCase().includes(e.fr.toLowerCase().substring(0,6))}),i=[{fr:"Non R\xe9alis\xe9",ar:"\u063a\u064a\u0631 \u0645\u0646\u062c\u0632"},{fr:"En cours",ar:"\u0641\u064a \u0637\u0648\u0631 \u0627\u0644\u0625\u0646\u062c\u0627\u0632"},{fr:"Recommendation continue",ar:"\u062a\u0648\u0635\u064a\u0629 \u0645\u0633\u062a\u0645\u0631\u0629"},{fr:"R\xe9alis\xe9",ar:"\u0645\u0646\u062c\u0632"}].find(function(t){return t.fr.toLowerCase()===e.toLowerCase()});return{m:n?n.ar:t,e:i?i.ar:e}}},{key:"autoComplete",value:function(){var t=this;this.filteredOptions=this.myAuto.valueChanges.pipe(Object(B.a)(function(e){return e.length>1?t.uow.organismes.autocompletePost("label",e):[]}))}},{key:"selected",value:function(t){var e=t.option.value;console.log(e),this.myAuto.setValue(e.label),this.myForm.get("idOrganisme").setValue(e.id)}},{key:"createForm",value:function(){this.myForm=this.fb.group({idOrganisme:this.o.idOrganisme,mecanisme:this.o.mecanisme,idCycle:this.o.idCycle,idOrgane:this.o.idOrgane,idVisite:this.o.idVisite,idAxe:this.o.idAxe,nom:this.o.nom,etat:this.o.etat,idPays:this.o.idPays,idSousAxe:this.o.idSousAxe,annee:this.o.annee,startIndex:this.o.startIndex,pageSize:this.o.pageSize,sortBy:this.o.sortBy,sortDir:this.o.sortDir})}},{key:"selectChange",value:function(t){this.idVisite.setValue(0),this.idCycle.setValue(0),this.idOrgane.setValue(0)}},{key:"reset",value:function(){this.o=new Et,this.createForm(),this.myForm.get("annee").setValue(this.annee[0]),this.searchAndGet(this.o)}},{key:"search",value:function(t){this.searchAndGet(t)}},{key:"detail",value:function(t){var e=this;this.uow.recommendations.getDetail(t.id).subscribe(function(t){e.openDialog(t)})}},{key:"openDialog",value:function(t){return this.dialog.open(h,{width:"7100px",disableClose:!0,data:{model:t,title:"Recommdandation"}}).afterClosed()}},{key:"stateDepartement",value:function(t){console.log(t),(t=t.filter(function(t){return null!==t.name})).filter(function(t){return"PE"===t.type}).map(function(t){return t.name}),t.filter(function(t){return"IN"===t.type}).map(function(t){return t.name}),t.filter(function(t){return"PG"===t.type}).map(function(t){return t.name}),t.filter(function(t){return"Autre"===t.type}).map(function(t){return t.name});var e=[{data:[],label:this.mytranslate.get("admin.organe.list.Etatavancement")},{data:[],label:this.mytranslate.get("admin.organe.list.R\xe9alis\xe9")},{data:[],label:"Non r\xe9alis\xe9"}],n=e,i=e,a=e;t.forEach(function(t){"PE"===t.type?(e[0].data.push(+(t.p*t.t/100).toFixed(0)),e[1].data.push(+(t.r*t.t/100).toFixed(0)),e[2].data.push(+(t.t-t.p*t.t/100-t.r*t.t/100).toFixed(0))):"Autre"===t.type?(a[0].data.push(+(t.p*t.t/100).toFixed(0)),a[1].data.push(+(t.r*t.t/100).toFixed(0)),a[2].data.push(+(t.t-t.p*t.t/100-t.r*t.t/100).toFixed(0))):"IN"===t.type?(n[0].data.push(+(t.p*t.t/100).toFixed(0)),n[1].data.push(+(t.r*t.t/100).toFixed(0)),n[2].data.push(+(t.t-t.p*t.t/100-t.r*t.t/100).toFixed(0))):"PJ"===t.type&&(i[0].data.push(+(t.p*t.t/100).toFixed(0)),i[1].data.push(+(t.r*t.t/100).toFixed(0)),i[2].data.push(+(t.t-t.p*t.t/100-t.r*t.t/100).toFixed(0)))})}},{key:"searchAndGet",value:function(t){var e=this;console.log(t),this.o=t,this.o.idOrganisme=this.session.isPointFocal||this.session.isProprietaire?this.session.user.idOrganisme:this.o.idOrganisme,this.uow.recommendations.searchAndGet(this.o).subscribe(function(t){console.log(t.list),e.dataSource=t.list,e.resultsLength=t.count,e.isLoadingResults=!1,e.stateDepartement(e.departementList)},function(t){return e.isLoadingResults=!1})}},{key:"delete",value:function(e){return Object(c.a)(this,void 0,void 0,regeneratorRuntime.mark(function n(){var i,a,o=this;return regeneratorRuntime.wrap(function(n){for(;;)switch(n.prev=n.next){case 0:return n.next=2,this.mydialog.openDialog("recommandation").toPromise();case 2:if(n.t0=n.sent,"ok"!==n.t0){n.next=6;break}a=[],""!==e.pieceJointe?(i=a).push.apply(i,t(this.uow.decoupe(e.pieceJointe))):a=a,this.uow.files.deleteFiles(a,"recommandation").subscribe(function(t){o.uow.recommendations.delete(e.id).subscribe(function(){return o.update.next(!0)})});case 6:case"end":return n.stop()}},n,this)}))}},{key:"showPieceJoin",value:function(t){this.bottomSheet.open(T.a,{data:{fileName:t,folder:"recommandation"}})}},{key:"axeChange",value:function(t){var e=this;this.uow.sousAxes.getByIdAxe(t).subscribe(function(t){e.sousAxes=t})}},{key:"mecanisme",get:function(){return this.myForm.get("mecanisme")}},{key:"idVisite",get:function(){return this.myForm.get("idVisite")}},{key:"idCycle",get:function(){return this.myForm.get("idCycle")}},{key:"idOrgane",get:function(){return this.myForm.get("idOrgane")}},{key:"cycleActive",get:function(){return"Examen p\xe9riodique universal"===this.mecanisme.value}},{key:"visiteActive",get:function(){return"Proc\xe9dure sp\xe9ciale"===this.mecanisme.value}},{key:"organeActive",get:function(){return"Organes de trait\xe9s"===this.mecanisme.value}},{key:"isAllEmpty",get:function(){var t;return"0"===this.myForm.get("idAxe").value.toString()&&"0"===this.myForm.get("idCycle").value.toString()&&"0"===this.myForm.get("idSousAxe").value.toString()&&"0"===this.myForm.get("idOrganisme").value.toString()&&"0"===this.myForm.get("idOrgane").value.toString()&&"0"===this.myForm.get("idPays").value.toString()&&""===this.myForm.get("nom").value.toString()&&""===this.myForm.get("etat").value.toString()&&"0"===this.myForm.get("idVisite").value.toString()&&"0"===(null===(t=this.myForm.get("annee").value)||void 0===t?void 0:t.toString())&&""===this.myForm.get("mecanisme").value.toString()}}]),e}()).\u0275fac=function(t){return new(t||Pt)(s.Nb(D.a),s.Nb(r.b),s.Nb(k.a),s.Nb(x.a),s.Nb(C.d),s.Nb(w.a),s.Nb(O.a),s.Nb(A.b))},Pt.\u0275cmp=s.Hb({type:Pt,selectors:[["app-list"]],viewQuery:function(t,e){var n;1&t&&(s.xc(y.a,!0),s.xc(S.a,!0)),2&t&&(s.pc(n=s.bc())&&(e.paginator=n.first),s.pc(n=s.bc())&&(e.sort=n.first))},decls:125,vars:75,consts:[[1,"host"],[3,"title"],[1,"right"],["class","mt-3","style","margin: 20px 0 0","mat-raised-button","","color","primary",3,"routerLink",4,"ngIf"],[1,"expension"],["expanded","",3,"opened","closed"],[3,"formGroup"],[1,"inputs2"],["appearance","fill"],["matInput","","formControlName","nom","required",""],["formControlName","idPays"],["value","0"],[3,"value",4,"ngFor","ngForOf"],["appearance","fill",4,"ngIf"],["formControlName","mecanisme",3,"selectionChange"],["formControlName","etat"],["formControlName","idAxe",3,"selectionChange"],["formControlName","idSousAxe"],["mat-raised-button","","color","primary",3,"disabled","click"],["mat-raised-button","",3,"click"],[1,"example-container","mat-elevation-z8"],["class","example-loading-shade",4,"ngIf"],[1,"example-table-container"],["mat-table","","multiTemplateDataRows","","aria-label","Elements","matSort","",3,"dataSource"],["table",""],[3,"matColumnDef"],["mat-header-cell","","mat-sort-header","",4,"matHeaderCellDef"],["mat-cell","",4,"matCellDef"],["mat-header-cell","",4,"matHeaderCellDef"],["matColumnDef","option",2,"flex-direction","row-reverse"],["mat-header-row","",4,"matHeaderRowDef"],["mat-row","",4,"matRowDef","matRowDefColumns"],["pageIndex","0","pageSize","10","showFirstLastButtons","",3,"length","pageSizeOptions"],["paginator",""],["mat-raised-button","","color","primary",1,"mt-3",2,"margin","20px 0 0",3,"routerLink"],[3,"value"],["formControlName","annee"],["formControlName","idCycle"],["formControlName","idVisite"],["formControlName","idOrgane"],["formControlName","idOrganisme"],[1,"example-loading-shade"],[4,"ngIf"],["mat-header-cell","","mat-sort-header",""],["mat-cell",""],["mat-header-cell",""],["mat-icon-button","","color","accent",3,"disabled","matTooltip","click"],["class","button-row",4,"ngIf"],[1,"button-row"],["mat-icon-button","","color","primary",3,"click"],["mat-icon-button","","color","primary",3,"routerLink",4,"ngIf"],["mat-icon-button","","color","warn",3,"click",4,"ngIf"],["mat-icon-button","","color","primary",3,"routerLink"],["mat-icon-button","","color","warn",3,"click"],["mat-header-row",""],["mat-row",""]],template:function(t,e){1&t&&(s.Tb(0,"div",0),s.Ob(1,"app-title",1),s.fc(2,"translate"),s.Tb(3,"div",2),s.Bc(4,z,5,5,"button",3),s.Sb(),s.Tb(5,"div",4),s.Tb(6,"mat-accordion"),s.Tb(7,"mat-expansion-panel",5),s.ac("opened",function(){return e.panelOpenState=!0})("closed",function(){return e.panelOpenState=!1}),s.Tb(8,"mat-expansion-panel-header"),s.Tb(9,"mat-panel-title"),s.Tb(10,"mat-icon"),s.Cc(11,"search"),s.Sb(),s.Tb(12,"p"),s.Cc(13),s.fc(14,"translate"),s.Sb(),s.Sb(),s.Ob(15,"mat-panel-description"),s.Sb(),s.Ob(16,"mat-divider"),s.Tb(17,"form",6),s.Tb(18,"div",7),s.Tb(19,"mat-form-field",8),s.Tb(20,"mat-label"),s.Cc(21),s.fc(22,"translate"),s.Sb(),s.Ob(23,"input",9),s.Sb(),s.Sb(),s.Tb(24,"div",7),s.Tb(25,"mat-form-field",8),s.Tb(26,"mat-label"),s.Cc(27),s.fc(28,"translate"),s.Sb(),s.Tb(29,"mat-select",10),s.Tb(30,"mat-option",11),s.Cc(31,"..."),s.Sb(),s.Bc(32,G,2,2,"mat-option",12),s.fc(33,"async"),s.Sb(),s.Sb(),s.Bc(34,j,6,4,"mat-form-field",13),s.Sb(),s.Tb(35,"div",7),s.Tb(36,"mat-form-field",8),s.Tb(37,"mat-label"),s.Cc(38),s.fc(39,"translate"),s.Sb(),s.Tb(40,"mat-select",14),s.ac("selectionChange",function(t){return e.selectChange(t.value)}),s.Tb(41,"mat-option",11),s.Cc(42,"..."),s.Sb(),s.Bc(43,U,2,2,"mat-option",12),s.fc(44,"async"),s.Sb(),s.Sb(),s.Bc(45,H,9,6,"mat-form-field",13),s.Bc(46,K,9,6,"mat-form-field",13),s.Bc(47,Z,9,6,"mat-form-field",13),s.Tb(48,"mat-form-field",8),s.Tb(49,"mat-label"),s.Cc(50),s.fc(51,"translate"),s.Sb(),s.Tb(52,"mat-select",15),s.Bc(53,W,2,2,"mat-option",12),s.fc(54,"async"),s.Sb(),s.Sb(),s.Sb(),s.Tb(55,"div",7),s.Tb(56,"mat-form-field",8),s.Tb(57,"mat-label"),s.Cc(58),s.fc(59,"translate"),s.Sb(),s.Tb(60,"mat-select",16),s.ac("selectionChange",function(t){return e.axeChange(t.value)}),s.Tb(61,"mat-option",11),s.Cc(62,"..."),s.Sb(),s.Bc(63,tt,2,2,"mat-option",12),s.fc(64,"async"),s.Sb(),s.Sb(),s.Tb(65,"mat-form-field",8),s.Tb(66,"mat-label"),s.Cc(67),s.fc(68,"translate"),s.Sb(),s.Tb(69,"mat-select",17),s.Tb(70,"mat-option",11),s.Cc(71,"..."),s.Sb(),s.Bc(72,et,2,2,"mat-option",12),s.Sb(),s.Sb(),s.Bc(73,it,9,6,"mat-form-field",13),s.Sb(),s.Sb(),s.Tb(74,"div",2),s.Tb(75,"button",18),s.ac("click",function(){return e.search(e.myForm.value)}),s.Tb(76,"mat-icon"),s.Cc(77,"search"),s.Sb(),s.Cc(78),s.fc(79,"translate"),s.Sb(),s.Cc(80," \xa0 "),s.Tb(81,"button",19),s.ac("click",function(){return e.reset()}),s.Tb(82,"mat-icon"),s.Cc(83,"refresh"),s.Sb(),s.Cc(84),s.fc(85,"translate"),s.Sb(),s.Sb(),s.Sb(),s.Sb(),s.Sb(),s.Tb(86,"div",20),s.Bc(87,ot,2,1,"div",21),s.Tb(88,"div",22),s.Tb(89,"table",23,24),s.Rb(91,25),s.Bc(92,ct,3,3,"th",26),s.Bc(93,rt,2,1,"td",27),s.Qb(),s.Rb(94,25),s.Bc(95,st,3,3,"th",26),s.Bc(96,mt,2,1,"td",27),s.Qb(),s.Rb(97,25),s.Bc(98,lt,3,3,"th",26),s.Bc(99,bt,2,1,"td",27),s.Qb(),s.Rb(100,25),s.Bc(101,ut,3,3,"th",26),s.Bc(102,dt,2,1,"td",27),s.Qb(),s.Rb(103,25),s.Bc(104,ft,3,3,"th",26),s.Bc(105,pt,2,1,"td",27),s.Qb(),s.Rb(106,25),s.Bc(107,gt,3,3,"th",26),s.Bc(108,ht,2,1,"td",27),s.Qb(),s.Rb(109,25),s.Bc(110,yt,3,3,"th",26),s.Bc(111,St,2,1,"td",27),s.Qb(),s.Rb(112,25),s.Bc(113,vt,3,3,"th",28),s.Bc(114,Ct,4,2,"td",27),s.Qb(),s.Rb(115,25),s.Bc(116,Bt,3,3,"th",26),s.Bc(117,Tt,2,1,"td",27),s.Qb(),s.Rb(118,29),s.Bc(119,Dt,1,0,"th",28),s.Bc(120,At,2,1,"td",27),s.Qb(),s.Bc(121,Ft,1,0,"tr",30),s.Bc(122,Nt,1,0,"tr",31),s.Sb(),s.Sb(),s.Ob(123,"mat-paginator",32,33),s.Sb(),s.Sb()),2&t&&(s.Bb(1),s.lc("title",s.gc(2,46,"admin.recommandation.list.Recommandations")),s.Bb(3),s.kc("ngIf",!e.session.isPointFocal&&!e.session.isSuperViseur&&!e.session.isPublic),s.Bb(9),s.Dc(s.gc(14,48,"admin.recommandation.list.Recherche")),s.Bb(4),s.kc("formGroup",e.myForm),s.Bb(4),s.Dc(s.gc(22,50,"admin.recommandation.list.nom")),s.Bb(6),s.Dc(s.gc(28,52,"admin.recommandation.list.Pays")),s.Bb(5),s.kc("ngForOf",s.gc(33,54,e.pays)),s.Bb(2),s.kc("ngIf",!e.session.isPublic),s.Bb(4),s.Dc(s.gc(39,56,"admin.recommandation.list.mecanisme")),s.Bb(5),s.kc("ngForOf",s.gc(44,58,e.mecanismes)),s.Bb(2),s.kc("ngIf",e.cycleActive),s.Bb(1),s.kc("ngIf",e.visiteActive),s.Bb(1),s.kc("ngIf",e.organeActive),s.Bb(3),s.Dc(s.gc(51,60,"admin.recommandation.list.Etatdemisenoeuvre")),s.Bb(3),s.kc("ngForOf",s.gc(54,62,e.etats)),s.Bb(5),s.Dc(s.gc(59,64,"admin.recommandation.list.Axe")),s.Bb(5),s.kc("ngForOf",s.gc(64,66,e.axes)),s.Bb(4),s.Dc(s.gc(68,68,"admin.recommandation.list.Sousaxe")),s.Bb(5),s.kc("ngForOf",e.sousAxes),s.Bb(1),s.kc("ngIf",e.session.isAdmin||e.session.isSuperViseur),s.Bb(2),s.kc("disabled",e.isAllEmpty),s.Bb(3),s.Ec(" ",s.gc(79,70,"admin.recommandation.list.Rechercher")," "),s.Bb(6),s.Ec(" ",s.gc(85,72,"admin.recommandation.list.R\xe9initialiser")," "),s.Bb(3),s.kc("ngIf",e.isLoadingResults),s.Bb(2),s.kc("dataSource",e.dataSource),s.Bb(2),s.kc("matColumnDef",e.columnDefs[0].columnDef),s.Bb(3),s.kc("matColumnDef",e.columnDefs[1].columnDef),s.Bb(3),s.kc("matColumnDef",e.columnDefs[2].columnDef),s.Bb(3),s.kc("matColumnDef",e.columnDefs[3].columnDef),s.Bb(3),s.kc("matColumnDef",e.columnDefs[4].columnDef),s.Bb(3),s.yc("display","none"),s.kc("matColumnDef","organismes"),s.Bb(3),s.yc("display","none"),s.kc("matColumnDef","etat"),s.Bb(3),s.yc("display","none"),s.kc("matColumnDef","pieceJointe"),s.Bb(3),s.yc("display","none"),s.kc("matColumnDef","complement"),s.Bb(6),s.kc("matHeaderRowDef",e.displayedColumns),s.Bb(1),s.kc("matRowDefColumns",e.displayedColumns),s.Bb(1),s.kc("length",e.resultsLength)("pageSizeOptions",s.mc(74,Rt)))},directives:[F.a,b.m,N.a,N.c,N.e,N.f,P.a,N.d,l.a,C.t,C.n,C.h,R.c,R.f,I.b,C.c,C.m,C.g,C.r,E.a,M.o,b.l,u.a,L.j,S.a,L.c,L.e,L.b,L.g,L.i,y.a,O.f,V.b,L.d,S.b,L.a,_.a,L.f,L.h],pipes:[$.c,b.b],styles:["section[_ngcontent-%COMP%]{display:flex!important;justify-content:space-between!important;align-items:center!important}  h3{margin:0!important}.host[_ngcontent-%COMP%]{margin:1em!important}.inputs2[_ngcontent-%COMP%]{display:grid;grid-template-columns:repeat(auto-fit,minmax(25vw,1fr));grid-column-gap:6px;grid-row-gap:6px;align-items:center}form[_ngcontent-%COMP%]{padding:20px}.expension[_ngcontent-%COMP%]{margin:20px 0}.right[_ngcontent-%COMP%]{margin:0 20px 20px}mat-panel-title[_ngcontent-%COMP%]{display:flex;align-items:center}mat-panel-title[_ngcontent-%COMP%]   p[_ngcontent-%COMP%]{margin:0 0 0 10px}mat-panel-title[_ngcontent-%COMP%]   mat-icon[_ngcontent-%COMP%]{margin-top:5px}.mat-cell[_ngcontent-%COMP%]:nth-child(2), .mat-header-cell[_ngcontent-%COMP%]:nth-child(2){width:30vw!important;min-width:30vw;padding-right:0!important}"]}),Pt),Et=function t(){n(this,t),this.idAxe=0,this.idSousAxe=0,this.idOrganisme=0,this.mecanisme="",this.idCycle=0,this.idOrgane=0,this.idVisite=0,this.nom="",this.etat="",this.idPays=0,this.startIndex=0,this.pageSize=10,this.sortBy="id",this.sortDir="desc",this.annee=0}}}])}();