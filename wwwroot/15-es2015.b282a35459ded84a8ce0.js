(window.webpackJsonp=window.webpackJsonp||[]).push([[15],{Dgsr:function(t,e,i){"use strict";i.d(e,"a",function(){return c});var a=i("2thQ"),n=i("ofXK"),o=i("tk/3"),s=i("fXoL");let c=(()=>{class t{}return t.\u0275mod=s.Lb({type:t}),t.\u0275inj=s.Kb({factory:function(e){return new(e||t)},imports:[[n.c,a.a,o.c]]}),t})()},Fr4G:function(t,e,i){"use strict";i.d(e,"a",function(){return c});var a=i("tk/3"),n=i("2thQ"),o=i("ofXK"),s=i("fXoL");let c=(()=>{class t{}return t.\u0275mod=s.Lb({type:t}),t.\u0275inj=s.Kb({factory:function(e){return new(e||t)},imports:[[o.c,n.a,a.c]]}),t})()},KCpK:function(t,e,i){"use strict";i.r(e),i.d(e,"RecommendationModule",function(){return pt});var a=i("ofXK"),n=i("fXoL"),o=i("ukCm"),s=i("XNiG"),c=i("tyNb"),r=i("7q3A"),m=i("3Pt+"),l=i("0hB7"),b=i("J3i2"),d=i("/ysL"),u=i("Wp6s"),f=i("kmnG"),h=i("qFsG"),p=i("d3UM"),g=i("FKr1"),S=i("5nPQ"),v=i("VRyK"),y=i("0EQZ"),C=i("eIep"),T=i("M9IT"),B=i("Dh3D"),O=i("M0ag"),A=i("f0Cb"),k=i("/1cH"),w=i("bTqV"),x=i("NFeN"),D=i("+0xr"),F=i("Xa2L"),P=i("bSwM"),N=i("sYmb");function I(t,e){if(1&t&&(n.Tb(0,"mat-option",21),n.Cc(1),n.Sb()),2&t){const t=e.$implicit;n.kc("value",t),n.Bb(1),n.Ec("",t.label," ")}}function L(t,e){1&t&&n.Ob(0,"mat-spinner")}function R(t,e){if(1&t&&(n.Tb(0,"div",22),n.Bc(1,L,1,0,"mat-spinner",23),n.Sb()),2&t){const t=n.ec();n.Bb(1),n.kc("ngIf",t.isLoadingResults)}}function E(t,e){1&t&&n.Ob(0,"th",24)}function M(t,e){if(1&t){const t=n.Ub();n.Tb(0,"td",25),n.Tb(1,"mat-checkbox",26),n.ac("change",function(i){n.sc(t);const a=e.$implicit,o=n.ec();return i?o.check(a):null})("click",function(t){return t.stopPropagation()}),n.Sb(),n.Sb()}if(2&t){const t=e.$implicit,i=n.ec();n.Bb(1),n.kc("checked",i.isSelected(t))("aria-label",i.checkboxLabel(t))("disabled",!i.isAdmin)}}function V(t,e){1&t&&(n.Tb(0,"th",27),n.Cc(1),n.fc(2,"translate"),n.Sb()),2&t&&(n.Bb(1),n.Dc(n.gc(2,1,"admin.recommandation.update.ORGANISMES")))}function J(t,e){if(1&t&&(n.Tb(0,"td",25),n.Cc(1),n.Sb()),2&t){const t=e.$implicit,i=n.ec();n.Bb(1),n.Dc(t[i.columnDefs[1].columnDef])}}function $(t,e){1&t&&n.Ob(0,"th",27)}function q(t,e){1&t&&n.Ob(0,"td",25)}function K(t,e){1&t&&n.Ob(0,"tr",28)}function _(t,e){1&t&&n.Ob(0,"tr",29)}const z=function(){return[2,5,25,50,100,250]};let G=(()=>{class t{constructor(t,e){this.uow=t,this.session=e,this.eventToParent=new n.o,this.selectedList=[],this.listFromParent=new n.o,this.update=new n.o,this.isLoadingResults=!0,this.resultsLength=0,this.isRateLimitReached=!1,this.dataSource=[],this.columnDefs=[{columnDef:"select",headName:"select"},{columnDef:"label",headName:"ORGANISMES"},{columnDef:"adresse",headName:"ADRESSE"}],this.displayedColumns=this.columnDefs.map(t=>t.columnDef),this.selection=new y.c(!0,[]),this.myAuto=new m.e(""),this.idOrganisme=0}ngOnInit(){this.listFromParent.subscribe(t=>{this.selectedList=t,this.selectedList.forEach(t=>{this.selection.select(t)})}),this.getPage(0,10,"id","desc",this.idOrganisme),Object(v.a)(this.sort.sortChange,this.paginator.page,this.update).subscribe(t=>{!0===t?this.paginator.pageIndex=0:t=t,this.paginator.pageSize?t=t:this.paginator.pageSize=10;const e=this.paginator.pageIndex*this.paginator.pageSize;this.isLoadingResults=!0,this.getPage(e,this.paginator.pageSize,this.sort.active?this.sort.active:"id",this.sort.direction?this.sort.direction:"desc",this.idOrganisme)}),this.autoComplete()}get isAdmin(){return this.session.isAdmin}autoComplete(){this.filteredOptions=this.myAuto.valueChanges.pipe(Object(C.a)(t=>t.length>1?this.uow.organismes.autocompletePost("label",t):[]))}selected(t){const e=t.option.value;console.log(e),this.idOrganisme=e.id,this.update.next(!0)}clear(){this.myAuto.setValue({label:""}),this.idOrganisme=0,this.update.next(!0)}getPage(t,e,i,a,n){this.uow.organismes.getAll(t,e,i,a,n).subscribe(t=>{this.dataSource=t.list,this.resultsLength=t.count,this.isLoadingResults=!1})}isSelected(t){return!!this.selectedList.find(e=>e.id===t.id)}check(t){const e=this.selectedList.findIndex(e=>t.id===e.id);-1!==e?this.selectedList.splice(e,1):this.selectedList.push(t),this.eventToParent.next(this.selectedList)}isAllSelected(){return this.selection.selected.length===this.paginator.pageSize}masterToggle(){this.isAllSelected()?this.selection.clear():this.dataSource.forEach(t=>this.selection.select(t))}checkboxLabel(t){return t?`${this.selectedList.find(e=>e.id===t.id)?"deselect":"select"} row ${t.id}`:(this.isAllSelected()?"select":"deselect")+" all"}}return t.\u0275fac=function(e){return new(e||t)(n.Nb(r.a),n.Nb(O.a))},t.\u0275cmp=n.Hb({type:t,selectors:[["app-organismes"]],viewQuery:function(t,e){if(1&t&&(n.xc(T.a,!0),n.xc(B.a,!0)),2&t){let t;n.pc(t=n.bc())&&(e.paginator=t.first),n.pc(t=n.bc())&&(e.sort=t.first)}},inputs:{selectedList:"selectedList",listFromParent:"listFromParent"},outputs:{eventToParent:"eventToParent"},decls:32,vars:18,consts:[[1,"filter"],["appearance","fill",1,"col-md-6","mt-3"],["matInput","","placeholder","auto compl\xe9tion",3,"formControl","value","matAutocomplete"],[3,"optionSelected"],["auto","matAutocomplete"],[3,"value",4,"ngFor","ngForOf"],["mat-icon-button","","matSuffix","",3,"click"],[1,"example-container","mat-elevation-z8"],["class","example-loading-shade",4,"ngIf"],[1,"example-table-container"],["mat-table","","multiTemplateDataRows","","aria-label","Elements","matSort","",3,"dataSource"],["table",""],["matColumnDef","select",2,"width","10px"],["mat-header-cell","",4,"matHeaderCellDef"],["mat-cell","",4,"matCellDef"],[3,"matColumnDef"],["mat-header-cell","","mat-sort-header","",4,"matHeaderCellDef"],["mat-header-row","",4,"matHeaderRowDef"],["mat-row","",4,"matRowDef","matRowDefColumns"],["pageIndex","0","pageSize","10","showFirstLastButtons","",3,"length","pageSizeOptions"],["paginator",""],[3,"value"],[1,"example-loading-shade"],[4,"ngIf"],["mat-header-cell",""],["mat-cell",""],[3,"checked","aria-label","disabled","change","click"],["mat-header-cell","","mat-sort-header",""],["mat-header-row",""],["mat-row",""]],template:function(t,e){if(1&t&&(n.Ob(0,"mat-divider"),n.Tb(1,"div",0),n.Tb(2,"mat-form-field",1),n.Tb(3,"mat-label"),n.Cc(4),n.fc(5,"translate"),n.Sb(),n.Ob(6,"input",2),n.Tb(7,"mat-autocomplete",3,4),n.ac("optionSelected",function(t){return e.selected(t)}),n.Bc(9,I,2,2,"mat-option",5),n.fc(10,"async"),n.Sb(),n.Tb(11,"button",6),n.ac("click",function(){return e.clear()}),n.Tb(12,"mat-icon"),n.Cc(13,"clear"),n.Sb(),n.Sb(),n.Sb(),n.Sb(),n.Tb(14,"div",7),n.Bc(15,R,2,1,"div",8),n.Tb(16,"div",9),n.Tb(17,"table",10,11),n.Rb(19,12),n.Bc(20,E,1,0,"th",13),n.Bc(21,M,2,3,"td",14),n.Qb(),n.Rb(22,15),n.Bc(23,V,3,3,"th",16),n.Bc(24,J,2,1,"td",14),n.Qb(),n.Rb(25,15),n.Bc(26,$,1,0,"th",16),n.Bc(27,q,1,0,"td",14),n.Qb(),n.Bc(28,K,1,0,"tr",17),n.Bc(29,_,1,0,"tr",18),n.Sb(),n.Sb(),n.Ob(30,"mat-paginator",19,20),n.Sb()),2&t){const t=n.qc(8);n.Bb(4),n.Dc(n.gc(5,13,"admin.recommandation.update.Organisme")),n.Bb(2),n.kc("formControl",e.myAuto)("value",e.myAuto.value.label)("matAutocomplete",t),n.Bb(3),n.kc("ngForOf",n.gc(10,15,e.filteredOptions)),n.Bb(6),n.kc("ngIf",e.isLoadingResults),n.Bb(2),n.kc("dataSource",e.dataSource),n.Bb(5),n.kc("matColumnDef",e.columnDefs[1].columnDef),n.Bb(3),n.kc("matColumnDef",e.columnDefs[2].columnDef),n.Bb(3),n.kc("matHeaderRowDef",e.displayedColumns),n.Bb(1),n.kc("matRowDefColumns",e.displayedColumns),n.Bb(1),n.kc("length",e.resultsLength)("pageSizeOptions",n.mc(17,z))}},directives:[A.a,f.c,f.f,h.b,m.c,k.c,m.m,m.f,k.a,a.l,w.a,f.g,x.a,a.m,D.j,B.a,D.c,D.e,D.b,D.g,D.i,T.a,g.o,F.b,D.d,D.a,P.a,B.b,D.f,D.h],pipes:[N.c,a.b],styles:["h3{margin:0!important}.host[_ngcontent-%COMP%]{margin:1em!important}  mat-checkbox label{margin-top:7px}tr[_ngcontent-%COMP%]:hover{cursor:pointer}.filter[_ngcontent-%COMP%]{display:flex;flex-direction:row-reverse;width:100%}"]}),t})();function Q(t,e){if(1&t&&(n.Tb(0,"mat-option",35),n.Cc(1),n.Sb()),2&t){const t=e.$implicit,i=n.ec();n.kc("value",t.name),n.Bb(1),n.Dc("fr"===i.mytranslate.langSync?t.name:t.nameAr)}}function j(t,e){if(1&t&&(n.Tb(0,"mat-option",35),n.Cc(1),n.Sb()),2&t){const t=e.$implicit,i=n.ec(2);n.kc("value",t.id),n.Bb(1),n.Dc("fr"===i.mytranslate.langSync?t.label:t.labelAr)}}function H(t,e){if(1&t&&(n.Tb(0,"mat-form-field",14),n.Tb(1,"mat-label"),n.Cc(2),n.fc(3,"translate"),n.Sb(),n.Tb(4,"mat-select",36),n.Tb(5,"mat-option",16),n.Cc(6,"..."),n.Sb(),n.Bc(7,j,2,2,"mat-option",17),n.fc(8,"async"),n.Sb(),n.Sb()),2&t){const t=n.ec();n.Bb(2),n.Dc(n.gc(3,3,"admin.recommandation.update.Cycle")),n.Bb(2),n.kc("disabled",!t.isAdmin),n.Bb(3),n.kc("ngForOf",n.gc(8,5,t.cycles))}}function X(t,e){if(1&t&&(n.Tb(0,"mat-option",35),n.Cc(1),n.Sb()),2&t){const t=e.$implicit,i=n.ec(2);n.kc("value",t.id),n.Bb(1),n.Dc("fr"===i.mytranslate.langSync?t.mandat:t.mandatAr)}}function U(t,e){if(1&t&&(n.Tb(0,"mat-form-field",14),n.Tb(1,"mat-label"),n.Cc(2),n.fc(3,"translate"),n.Sb(),n.Tb(4,"mat-select",37),n.Tb(5,"mat-option",16),n.Cc(6,"..."),n.Sb(),n.Bc(7,X,2,2,"mat-option",17),n.fc(8,"async"),n.Sb(),n.Sb()),2&t){const t=n.ec();n.Bb(2),n.Dc(n.gc(3,3,"admin.recommandation.update.Visite")),n.Bb(2),n.kc("disabled",!t.isAdmin),n.Bb(3),n.kc("ngForOf",n.gc(8,5,t.visites))}}function W(t,e){if(1&t&&(n.Tb(0,"mat-option",35),n.Cc(1),n.Sb()),2&t){const t=e.$implicit,i=n.ec(2);n.kc("value",t.id),n.Bb(1),n.Dc("fr"===i.mytranslate.langSync?t.label:t.labelAr)}}function Y(t,e){if(1&t&&(n.Tb(0,"mat-form-field",14),n.Tb(1,"mat-label"),n.Cc(2),n.fc(3,"translate"),n.Sb(),n.Tb(4,"mat-select",38),n.Tb(5,"mat-option",16),n.Cc(6,"..."),n.Sb(),n.Bc(7,W,2,2,"mat-option",17),n.fc(8,"async"),n.Sb(),n.Sb()),2&t){const t=n.ec();n.Bb(2),n.Dc(n.gc(3,3,"admin.recommandation.update.Organe")),n.Bb(2),n.kc("disabled",!t.isAdmin),n.Bb(3),n.kc("ngForOf",n.gc(8,5,t.organes))}}function Z(t,e){if(1&t&&(n.Tb(0,"mat-option",35),n.Cc(1),n.Sb()),2&t){const t=e.$implicit,i=n.ec();n.kc("value",t.id),n.Bb(1),n.Ec("","fr"===i.mytranslate.langSync?t.label:t.labelAr," ")}}function tt(t,e){if(1&t&&(n.Tb(0,"mat-option",35),n.Cc(1),n.Sb()),2&t){const t=e.$implicit,i=n.ec(2);n.kc("value",t.id),n.Bb(1),n.Ec(" ","fr"===i.mytranslate.langSync?t.label:t.labelAr," ")}}function et(t,e){if(1&t&&(n.Tb(0,"mat-optgroup",39),n.Bc(1,tt,2,2,"mat-option",17),n.Sb()),2&t){const t=e.$implicit,i=n.ec();n.kc("label","fr"===i.mytranslate.langSync?t.label:t.labelAr),n.Bb(1),n.kc("ngForOf",t.sousAxes)}}function it(t,e){if(1&t&&(n.Tb(0,"mat-option",35),n.Cc(1),n.Sb()),2&t){const t=e.$implicit,i=n.ec();n.kc("value",t.id),n.Bb(1),n.Dc("fr"===i.mytranslate.langSync?t.nom:t.nomAr)}}function at(t,e){if(1&t&&(n.Tb(0,"mat-option",35),n.Cc(1),n.Sb()),2&t){const t=e.$implicit,i=n.ec();n.kc("value",t.name),n.Bb(1),n.Dc("fr"===i.mytranslate.langSync?t.name:t.nameAr)}}function nt(t,e){if(1&t&&(n.Tb(0,"mat-form-field",28),n.Tb(1,"mat-label"),n.Cc(2),n.fc(3,"translate"),n.Sb(),n.Ob(4,"textarea",40),n.Sb()),2&t){const t=n.ec();n.Bb(2),n.Dc(n.gc(3,2,"admin.recommandation.update.Etatdavancement")),n.Bb(2),n.kc("readonly",!t.isAdmin)}}const ot=function(){return["/admin/recommendation/list"]};let st=(()=>{class t{constructor(t,e,i,a,c,r){this.route=t,this.router=e,this.uow=i,this.fb=a,this.session=c,this.mytranslate=r,this.eventToChild=new n.o,this.organismes=this.uow.organismes.get(),this.axes=this.uow.axes.get(),this.mecanismes=this.uow.mecanismes,this.etats=this.uow.etats,this.cycles=this.uow.cycles.get(),this.visites=this.uow.visites.get(),this.organes=this.uow.organes.get(),this.pays=this.uow.pays.get(),this.sousAxes=[],this.folderToSaveInServer="recommandation",this.pieceJointeTo=new s.a,this.pieceJointeFrom=new s.a,this.eventSubmitFromParent=new s.a,this.o=new o.k,this.id=0,this.title="Nouveau utilisateur",this.listOrganisme=[]}ngOnInit(){this.createForm(),this.stringArray(),this.pieceJointeFrom.subscribe(t=>this.myForm.get("pieceJointe").setValue(t)),setTimeout(()=>this.pieceJointeTo.next(this.o.pieceJointe),100),this.id=+this.route.snapshot.paramMap.get("id"),0!==this.id&&this.uow.recommendations.getOne(this.id).subscribe(t=>{this.o=t,this.handleEtatAvancementChiffre(this.o.etat),this.o.recomOrgs.forEach(t=>{this.listOrganisme.push({id:t.idOrganisme})}),this.eventToChild.emit(this.listOrganisme),this.createForm(),this.stringArray()})}stringArray(){this.myForm.get("axes").setValue(this.check(this.o.axes)),this.myForm.get("sousAxes").setValue(this.check(this.o.sousAxes))}check(t){return t&&""!==t?t.includes("[")?JSON.parse(t):[+t]:[]}get isAdmin(){return this.session.isAdmin}get showEtatDavancement(){return!(!this.myForm.get("etat").value.includes("cour")&&!this.myForm.get("etat").value.includes("continue"))}createForm(){this.myForm=this.fb.group({id:this.o.id,codeRecommendation:[this.o.codeRecommendation],nom:[this.o.nom],codeRecommendationAr:[this.o.codeRecommendationAr],nomAr:[this.o.nomAr],mecanisme:[this.o.mecanisme],idVisite:[this.o.idVisite],idOrgane:[this.o.idOrgane],idCycle:[this.o.idCycle],axes:[this.o.axes],sousAxes:[this.o.sousAxes],etat:[this.o.etat],etatAvancement:[this.o.etatAvancement],etatAvancementChiffre:[this.o.etatAvancementChiffre],observation:[this.o.observation],complement:[this.o.complement],pieceJointe:[this.o.pieceJointe],idPays:[this.o.idPays],annee:[this.o.annee]})}get mecanisme(){return this.myForm.get("mecanisme")}get idVisite(){return this.myForm.get("idVisite")}get idCycle(){return this.myForm.get("idCycle")}get idOrgane(){return this.myForm.get("idOrgane")}get cycleActive(){return"Examen p\xe9riodique universal"===this.mecanisme.value}get visiteActive(){return"Proc\xe9dure sp\xe9ciale"===this.mecanisme.value}get organeActive(){return"Organes de trait\xe9s"===this.mecanisme.value}submit(t){t.axes=JSON.stringify(t.axes),t.sousAxes=JSON.stringify(t.sousAxes),console.log(t),0===this.id?this.uow.recommendations.post(t).subscribe(t=>{const e=[];this.listOrganisme.map(i=>{e.push({idOrganisme:i.id,idRecommendation:t.id,date:new Date})}),this.uow.recomOrgs.postRange(e).subscribe(t=>{console.log(t),this.router.navigateByUrl("/admin/recommendation/list"),this.eventSubmitFromParent.next(!0)})}):this.uow.recommendations.put(t.id,t).subscribe(t=>{const e=[];this.listOrganisme.map(t=>{e.push({idOrganisme:t.id,idRecommendation:this.o.id,date:new Date})}),this.uow.recomOrgs.putRange(this.o.recomOrgs,e).subscribe(t=>{this.router.navigateByUrl("/admin/recommendation/list"),this.eventSubmitFromParent.next(!0)})})}axeChange(t){this.uow.sousAxes.getByIdAxe(t).subscribe(t=>{this.sousAxes=t})}etat(t){console.log(t),this.handleEtatAvancementChiffre(t)}handleEtatAvancementChiffre(t){let e=this.myForm.get("etatAvancementChiffre").value;t.includes("R\xe9alis\xe9")?e=100:t.includes("Non")?e=0:t.includes("cours")?(e=e>5?e:5,this.myForm.get("etatAvancementChiffre").enable()):this.myForm.get("etatAvancementChiffre").enable(),this.myForm.get("etatAvancementChiffre").setValue(e)}selectChange(t){this.idVisite.setValue(null),this.idCycle.setValue(null),this.idOrgane.setValue(null)}updateListOrganisme(t){this.listOrganisme=t;let e=0,i=!0;this.listOrganisme=this.listOrganisme.filter(t=>(t.id===e&&(i=!1),e=t.id,i))}reset(){this.o=new o.k,this.createForm()}}return t.\u0275fac=function(e){return new(e||t)(n.Nb(c.a),n.Nb(c.e),n.Nb(r.a),n.Nb(m.d),n.Nb(l.a),n.Nb(b.a))},t.\u0275cmp=n.Hb({type:t,selectors:[["app-update"]],decls:107,vars:86,consts:[[1,"host"],[3,"title"],[1,""],[3,"formGroup"],[2,"margin-top","15px"],[1,"input"],["appearance","fill",2,"width","20%"],["matInput","","formControlName","codeRecommendation","required","",3,"readonly"],[2,"margin","0 1%"],["appearance","fill",2,"width","78%"],["matInput","","formControlName","nom","required","",3,"readonly"],["matInput","","formControlName","codeRecommendationAr","required","",3,"readonly"],["matInput","","formControlName","nomAr","required","",3,"readonly"],[1,"inputs2"],["appearance","fill"],["formControlName","mecanisme",3,"disabled","selectionChange"],["value","0"],[3,"value",4,"ngFor","ngForOf"],["appearance","fill",4,"ngIf"],["formControlName","axes","multiple",""],["formControlName","sousAxes","multiple",""],["value",""],[3,"label",4,"ngFor","ngForOf"],["formControlName","idPays",3,"disabled"],["type","number","min","0","matInput","","formControlName","annee",3,"readonly"],["formControlName","etat",3,"disabled","selectionChange"],["matInput","","formControlName","etatAvancementChiffre","type","number","min","0","max","100","required",""],["appearance","fill","style","width: 100%;",4,"ngIf"],["appearance","fill",2,"width","100%"],["matInput","","rows","0","formControlName","complement",3,"readonly"],[3,"disabled","nameBtn","folderToSaveInServer","propertyOfParent","eventSubmitToParent","eventSubmitFromParent"],[3,"listFromParent","eventToParent"],[1,"actions"],["mat-button","","type","button",3,"routerLink"],["mat-raised-button","","cdkFocusInitial","","color","primary",3,"disabled","click"],[3,"value"],["formControlName","idCycle",3,"disabled"],["formControlName","idVisite",3,"disabled"],["formControlName","idOrgane",3,"disabled"],[3,"label"],["matInput","","rows","0","formControlName","etatAvancement",3,"readonly"]],template:function(t,e){1&t&&(n.Tb(0,"div",0),n.Ob(1,"app-title",1),n.fc(2,"translate"),n.Tb(3,"div",2),n.Tb(4,"form",3),n.Tb(5,"mat-card",4),n.Tb(6,"div",5),n.Tb(7,"mat-form-field",6),n.Tb(8,"mat-label"),n.Cc(9),n.fc(10,"translate"),n.Sb(),n.Ob(11,"input",7),n.Sb(),n.Ob(12,"span",8),n.Tb(13,"mat-form-field",9),n.Tb(14,"mat-label"),n.Cc(15),n.fc(16,"translate"),n.Sb(),n.Ob(17,"input",10),n.Sb(),n.Sb(),n.Tb(18,"div",5),n.Tb(19,"mat-form-field",6),n.Tb(20,"mat-label"),n.Cc(21),n.fc(22,"translate"),n.Sb(),n.Ob(23,"input",11),n.Sb(),n.Ob(24,"span",8),n.Tb(25,"mat-form-field",9),n.Tb(26,"mat-label"),n.Cc(27),n.fc(28,"translate"),n.Sb(),n.Ob(29,"input",12),n.Sb(),n.Sb(),n.Tb(30,"div",13),n.Tb(31,"mat-form-field",14),n.Tb(32,"mat-label"),n.Cc(33),n.fc(34,"translate"),n.Sb(),n.Tb(35,"mat-select",15),n.ac("selectionChange",function(t){return e.selectChange(t.value)}),n.Tb(36,"mat-option",16),n.Cc(37,"..."),n.Sb(),n.Bc(38,Q,2,2,"mat-option",17),n.fc(39,"async"),n.Sb(),n.Sb(),n.Bc(40,H,9,7,"mat-form-field",18),n.Bc(41,U,9,7,"mat-form-field",18),n.Bc(42,Y,9,7,"mat-form-field",18),n.Sb(),n.Tb(43,"div",13),n.Tb(44,"mat-form-field",14),n.Tb(45,"mat-label"),n.Cc(46),n.fc(47,"translate"),n.Sb(),n.Tb(48,"mat-select",19),n.Bc(49,Z,2,2,"mat-option",17),n.fc(50,"async"),n.Sb(),n.Sb(),n.Tb(51,"mat-form-field",14),n.Tb(52,"mat-label"),n.Cc(53),n.fc(54,"translate"),n.Sb(),n.Tb(55,"mat-select",20),n.Tb(56,"mat-option",21),n.Cc(57,"-- ... --"),n.Sb(),n.Bc(58,et,2,2,"mat-optgroup",22),n.fc(59,"async"),n.Sb(),n.Sb(),n.Sb(),n.Tb(60,"mat-form-field",9),n.Tb(61,"mat-label"),n.Cc(62),n.fc(63,"translate"),n.Sb(),n.Tb(64,"mat-select",23),n.Tb(65,"mat-option",16),n.Cc(66,"..."),n.Sb(),n.Bc(67,it,2,2,"mat-option",17),n.fc(68,"async"),n.Sb(),n.Sb(),n.Ob(69,"span",8),n.Tb(70,"mat-form-field",6),n.Tb(71,"mat-label"),n.Cc(72),n.fc(73,"translate"),n.Sb(),n.Ob(74,"input",24),n.Sb(),n.Tb(75,"mat-form-field",9),n.Tb(76,"mat-label"),n.Cc(77),n.fc(78,"translate"),n.Sb(),n.Tb(79,"mat-select",25),n.ac("selectionChange",function(t){return e.etat(t.value)}),n.Tb(80,"mat-option",21),n.Cc(81,"..."),n.Sb(),n.Bc(82,at,2,2,"mat-option",17),n.fc(83,"async"),n.Sb(),n.Sb(),n.Ob(84,"span",8),n.Tb(85,"mat-form-field",6),n.Tb(86,"mat-label"),n.Cc(87),n.fc(88,"translate"),n.Sb(),n.Ob(89,"input",26),n.Sb(),n.Bc(90,nt,5,4,"mat-form-field",27),n.Tb(91,"mat-form-field",28),n.Tb(92,"mat-label"),n.Cc(93),n.fc(94,"translate"),n.Sb(),n.Ob(95,"textarea",29),n.Sb(),n.Ob(96,"app-upload",30),n.fc(97,"translate"),n.Sb(),n.Sb(),n.Tb(98,"app-organismes",31),n.ac("eventToParent",function(t){return e.updateListOrganisme(t)}),n.Sb(),n.Tb(99,"div",32),n.Tb(100,"button",33),n.Cc(101),n.fc(102,"translate"),n.Sb(),n.Cc(103,"\xa0\xa0 "),n.Tb(104,"button",34),n.ac("click",function(){return e.submit(e.myForm.value)}),n.Cc(105),n.fc(106,"translate"),n.Sb(),n.Sb(),n.Sb(),n.Sb()),2&t&&(n.Bb(1),n.lc("title",n.gc(2,43,"admin.recommandation.list.Recommandation")),n.Bb(3),n.kc("formGroup",e.myForm),n.Bb(5),n.Dc(n.gc(10,45,"admin.recommandation.list.code")),n.Bb(2),n.kc("readonly",!e.isAdmin),n.Bb(4),n.Dc(n.gc(16,47,"admin.recommandation.list.nom")),n.Bb(2),n.kc("readonly",!e.isAdmin),n.Bb(4),n.Dc(n.gc(22,49,"admin.recommandation.list.codeAr")),n.Bb(2),n.kc("readonly",!e.isAdmin),n.Bb(4),n.Dc(n.gc(28,51,"admin.recommandation.list.nomAr")),n.Bb(2),n.kc("readonly",!e.isAdmin),n.Bb(4),n.Dc(n.gc(34,53,"admin.recommandation.list.mecanisme")),n.Bb(2),n.kc("disabled",!e.isAdmin),n.Bb(3),n.kc("ngForOf",n.gc(39,55,e.mecanismes)),n.Bb(2),n.kc("ngIf",e.cycleActive),n.Bb(1),n.kc("ngIf",e.visiteActive),n.Bb(1),n.kc("ngIf",e.organeActive),n.Bb(4),n.Dc(n.gc(47,57,"admin.recommandation.list.Axe")),n.Bb(3),n.kc("ngForOf",n.gc(50,59,e.axes)),n.Bb(4),n.Dc(n.gc(54,61,"admin.recommandation.list.Sousaxe")),n.Bb(5),n.kc("ngForOf",n.gc(59,63,e.axes)),n.Bb(4),n.Dc(n.gc(63,65,"admin.recommandation.update.Pays")),n.Bb(2),n.kc("disabled",!e.isAdmin),n.Bb(3),n.kc("ngForOf",n.gc(68,67,e.pays)),n.Bb(5),n.Dc(n.gc(73,69,"admin.recommandation.update.Annee")),n.Bb(2),n.kc("readonly",!e.isAdmin),n.Bb(3),n.Dc(n.gc(78,71,"admin.recommandation.list.Etatdemisenoeuvre")),n.Bb(2),n.kc("disabled",!e.isAdmin),n.Bb(3),n.kc("ngForOf",n.gc(83,73,e.etats)),n.Bb(5),n.Dc(n.gc(88,75,"admin.recommandation.update.Etaten")),n.Bb(3),n.kc("ngIf",e.showEtatDavancement),n.Bb(3),n.Dc(n.gc(94,77,"admin.recommandation.list.complement")),n.Bb(2),n.kc("readonly",!e.isAdmin),n.Bb(1),n.lc("nameBtn",n.gc(97,79,"admin.recommandation.list.OBSERVATIONS")),n.kc("disabled",!e.isAdmin)("folderToSaveInServer",e.folderToSaveInServer)("propertyOfParent",e.pieceJointeTo)("eventSubmitToParent",e.pieceJointeFrom)("eventSubmitFromParent",e.eventSubmitFromParent),n.Bb(2),n.kc("listFromParent",e.eventToChild),n.Bb(2),n.kc("routerLink",n.mc(85,ot)),n.Bb(1),n.Dc(n.gc(102,81,"admin.Retour")),n.Bb(3),n.kc("disabled",e.myForm.invalid||!e.isAdmin),n.Bb(1),n.Dc(n.gc(106,83,"admin.Enregistre")))},directives:[d.a,m.t,m.n,m.h,u.a,f.c,f.f,h.b,m.c,m.m,m.g,m.r,p.a,g.o,a.l,a.m,m.p,S.a,G,w.a,c.f,g.n],pipes:[N.c,a.b],styles:["mat-card[_ngcontent-%COMP%]{margin:0 15px}mat-card[_ngcontent-%COMP%]   .inputs2[_ngcontent-%COMP%]{display:grid;grid-template-columns:repeat(auto-fit,minmax(25vw,1fr));grid-column-gap:6px;grid-row-gap:6px;align-items:center}.actions[_ngcontent-%COMP%], mat-card[_ngcontent-%COMP%]   .input[_ngcontent-%COMP%]{display:flex}.actions[_ngcontent-%COMP%]{flex-direction:row-reverse;margin:30px 0}.host[_ngcontent-%COMP%]{margin:1em!important}"]}),t})();var ct=i("F76L");let rt=(()=>{class t{constructor(){}ngOnInit(){}}return t.\u0275fac=function(e){return new(e||t)},t.\u0275cmp=n.Hb({type:t,selectors:[["app-recommendation"]],decls:1,vars:0,template:function(t,e){1&t&&n.Ob(0,"router-outlet")},directives:[c.i],styles:[""]}),t})();var mt=i("xjdI");const lt=[{path:"",redirectTo:"",pathMatch:"full"},{path:"",component:rt,children:[{path:"",redirectTo:"list",pathMatch:"full"},{path:"list",component:ct.a},{path:"update/:id",component:st}],canActivate:[mt.a]}];let bt=(()=>{class t{}return t.\u0275mod=n.Lb({type:t}),t.\u0275inj=n.Kb({factory:function(e){return new(e||t)},imports:[[c.h.forChild(lt)],c.h]}),t})();var dt=i("tk/3"),ut=i("2thQ"),ft=i("Dgsr"),ht=i("Fr4G");let pt=(()=>{class t{}return t.\u0275mod=n.Lb({type:t}),t.\u0275inj=n.Kb({factory:function(e){return new(e||t)},imports:[[N.b,a.c,bt,dt.c,ut.a,m.i,m.q,ft.a,ht.a]]}),t})()}}]);