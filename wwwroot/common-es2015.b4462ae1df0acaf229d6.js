(window.webpackJsonp=window.webpackJsonp||[]).push([[4],{"2HI4":function(t,e,l){"use strict";l.d(e,"a",(function(){return n}));class n{constructor(t,e){this.mytranslate=t,this.http=e,this.text="",this.text2="",this.length=400,this.mecanisme=""}ngOnInit(){this.mytranslate.lang.subscribe(t=>{this.http.get(`assets/htmls/${"fr"===t?this.mecanisme+"_fr":this.mecanisme+"_ar"}.html`,{responseType:"text"}).subscribe(t=>{this.text=t,this.text2=this.text.substring(0,this.length)})})}moreInfo(){this.text2=this.text2.length===this.length?this.text:this.text.substring(0,this.length)}}},"4AjB":function(t,e,l){"use strict";var n=l("8Y7J"),i=l("SVse"),s=l("TSSN");l("x3GN"),l("J3i2"),l.d(e,"a",(function(){return o})),l.d(e,"b",(function(){return r}));var o=n.qb({encapsulation:0,styles:[[".prg1[_ngcontent-%COMP%]{font-size:2.5em;margin:0;font-weight:700;text-align:center}.prg2[_ngcontent-%COMP%]{font-size:1.5em;margin:0;font-weight:700;text-align:center}"]],data:{}});function a(t){return n.Ob(0,[(t()(),n.sb(0,0,null,null,11,"div",[["class","d-flex justify-content-center align-items-center"]],[[4,"height",null]],null,null,null,null)),(t()(),n.sb(1,0,null,null,10,"div",[["class","d-flex flex-column justify-content-center align-items-center"]],null,null,null,null,null)),(t()(),n.sb(2,0,null,null,2,"p",[["class","prg1"],["style","color: #00658e;"]],null,null,null,null,null)),(t()(),n.Mb(3,null,["",""])),n.Gb(131072,i.b,[n.h]),(t()(),n.sb(5,0,null,null,2,"p",[["class","prg2"],["style","color: gray;"]],null,null,null,null,null)),(t()(),n.Mb(6,null,["",""])),n.Gb(131072,s.i,[s.j,n.h]),(t()(),n.sb(8,0,null,null,3,"p",[["class","prg2"],["style","color: gray;"]],null,null,null,null,null)),(t()(),n.Mb(9,null,[""," 2011 "," ",""])),n.Gb(131072,s.i,[s.j,n.h]),n.Gb(131072,s.i,[s.j,n.h])],null,(function(t,e){var l=e.component;t(e,0,0,l.height),t(e,3,0,n.Nb(e,3,0,n.Eb(e,4).transform(l.count))),t(e,6,0,n.Nb(e,6,0,n.Eb(e,7).transform("admin.recomm"))),t(e,9,0,n.Nb(e,9,0,n.Eb(e,10).transform("admin.du")),n.Nb(e,9,1,n.Eb(e,11).transform("admin.au")),l.year)}))}function u(t){return n.Ob(0,[(t()(),n.sb(0,0,null,null,9,"div",[["class","d-flex justify-content-center align-items-center"]],[[4,"height",null]],null,null,null,null)),(t()(),n.sb(1,0,null,null,8,"div",[["class","d-flex flex-column justify-content-center align-items-center"]],null,null,null,null,null)),(t()(),n.sb(2,0,null,null,2,"p",[["class","prg1"],["style","color: #00658e;"]],null,null,null,null,null)),(t()(),n.Mb(3,null,["",""])),n.Gb(131072,i.b,[n.h]),(t()(),n.sb(5,0,null,null,2,"p",[["class","prg2"],["style","color: gray;"]],null,null,null,null,null)),(t()(),n.Mb(6,null,["",""])),n.Gb(131072,s.i,[s.j,n.h]),(t()(),n.sb(8,0,null,null,1,"p",[["class","prg2"],["style","color: gray;"]],null,null,null,null,null)),(t()(),n.Mb(9,null,["",""]))],null,(function(t,e){var l=e.component;t(e,0,0,l.height),t(e,3,0,n.Nb(e,3,0,n.Eb(e,4).transform(l.count))),t(e,6,0,n.Nb(e,6,0,n.Eb(e,7).transform("admin.recomm"))),t(e,9,0,"fr"===l.mytranslate.langSync?"\xe0 l\u2019exercice du troisi\xe8me cycle":"\u0628\u0631\u0633\u0645 \u0627\u0644\u062f\u0648\u0631\u0629 \u0627\u0644\u062b\u0627\u0644\u062b\u0629")}))}function r(t){return n.Ob(0,[(t()(),n.hb(16777216,null,null,1,null,a)),n.rb(1,16384,null,0,i.l,[n.O,n.L],{ngIf:[0,"ngIf"]},null),(t()(),n.hb(16777216,null,null,1,null,u)),n.rb(3,16384,null,0,i.l,[n.O,n.L],{ngIf:[0,"ngIf"]},null)],(function(t,e){var l=e.component;t(e,1,0,!l.ifEpu),t(e,3,0,l.ifEpu)}),null)}},"5nPQ":function(t,e,l){"use strict";l.d(e,"a",(function(){return s}));var n=l("mrSG"),i=l("XNiG");class s{constructor(t){this.filesService=t,this.listOfNames=[],this.listToDelete=[],this.files=[],this.nameBtn="",this.disabled=!1,this.folderToSaveInServer="folder",this.propertyOfParent=new i.a,this.eventSubmitToParent=new i.a,this.eventSubmitFromParent=new i.a}ngOnInit(){this.propertyOfParent.subscribe(t=>{if(!t)return;const e=t.split(";");e.pop(),this.listOfNames=e,this.listToDelete=[]}),this.eventSubmitFromParent.subscribe(t=>n.a(this,void 0,void 0,(function*(){yield this.submit()})))}upload(t){for(let e=0;e<t.length;e++){const l=t.item(e);this.listOfNames.push(this.setFileName(l)),this.sendPropertyOfParent(),this.files.push(l)}}setIcon(t){const e=t.lastIndexOf("."),l=t.substring(e+1);return"pdf"===l||"pdf;"===l?"assets/svg/pdf.svg":"assets/svg/word.svg"}remove(t){const e=this.listOfNames.findIndex(e=>e===t);-1!==e&&(this.listOfNames.splice(e,1),this.sendPropertyOfParent()),this.listToDelete.push(t);const l=t.indexOf("_"),n=t.substring(l);-1!==this.files.findIndex(t=>t.name===n)&&this.files.splice(e,1)}openInput(t){t.click()}sendPropertyOfParent(){let t="";this.listOfNames.forEach(e=>{t+=`${e};`}),this.eventSubmitToParent.next(t)}submit(){return n.a(this,void 0,void 0,(function*(){const t=new FormData;this.files.forEach(e=>{const l=this.setFileName(e);t.append(l,e,l)}),t&&(yield this.filesService.uploadFiles(t,this.folderToSaveInServer).toPromise(),yield this.filesService.deleteFiles(this.listToDelete,this.folderToSaveInServer).toPromise())}))}setFileName(t){return`${t.lastModified}_${t.name}`}}},"A/Kj":function(t,e,l){"use strict";var n=l("8Y7J"),i=l("bujt"),s=l("Fwaw"),o=l("5GAg"),a=l("omvX"),u=l("Mr+X"),r=l("Gi4r"),c=l("SVse");l("5nPQ"),l("WTxg"),l.d(e,"a",(function(){return h})),l.d(e,"b",(function(){return m}));var h=n.qb({encapsulation:0,styles:[["img[_ngcontent-%COMP%]{height:20px}"]],data:{}});function d(t){return n.Ob(0,[(t()(),n.sb(0,0,null,null,7,"p",[["style","font-size: .7em;margin: 0;"]],null,null,null,null,null)),(t()(),n.sb(1,0,null,null,0,"img",[["alt","pdf/word"]],[[8,"src",4]],null,null,null,null)),(t()(),n.Mb(2,null,[" - "," "])),(t()(),n.sb(3,0,null,null,4,"button",[["color","warn"],["mat-icon-button",""],["type","button"]],[[1,"disabled",0],[2,"_mat-animation-noopable",null]],[[null,"click"]],(function(t,e,l){var n=!0;return"click"===e&&(n=!1!==t.component.remove(t.context.$implicit)&&n),n}),i.b,i.a)),n.rb(4,180224,null,0,s.b,[n.k,o.h,[2,a.a]],{disabled:[0,"disabled"],color:[1,"color"]},null),(t()(),n.sb(5,0,null,0,2,"mat-icon",[["class","mat-icon notranslate"],["role","img"],["style","font-size: 1.3em !important;"]],[[2,"mat-icon-inline",null],[2,"mat-icon-no-color",null]],null,null,u.b,u.a)),n.rb(6,9158656,null,0,r.b,[n.k,r.d,[8,null],[2,r.a],[2,n.l]],null,null),(t()(),n.Mb(-1,0,["delete_sweep"]))],(function(t,e){t(e,4,0,e.component.disabled,"warn"),t(e,6,0)}),(function(t,e){t(e,1,0,e.component.setIcon(e.context.$implicit));var l=e.context.$implicit.substring(14);t(e,2,0,l),t(e,3,0,n.Eb(e,4).disabled||null,"NoopAnimations"===n.Eb(e,4)._animationMode),t(e,5,0,n.Eb(e,6).inline,"primary"!==n.Eb(e,6).color&&"accent"!==n.Eb(e,6).color&&"warn"!==n.Eb(e,6).color)}))}function m(t){return n.Ob(0,[(t()(),n.sb(0,0,null,null,13,"div",[["class","row"]],null,null,null,null,null)),(t()(),n.sb(1,0,null,null,12,"div",[["class","col-md-12 mb-3"]],null,null,null,null,null)),(t()(),n.sb(2,0,null,null,11,"div",[["class","myrow"]],null,null,null,null,null)),(t()(),n.sb(3,0,[["file1",1]],null,0,"input",[["accept","application/pdf,.doc,.docx,application/msword,application/vnd.openxmlformats-officedocument.wordprocessingml.document"],["hidden",""],["multiple","false"],["style","display: none;"],["type","file"]],null,[[null,"change"]],(function(t,e,l){var i=!0;return"change"===e&&(i=!1!==t.component.upload(n.Eb(t,3).files)&&i),i}),null,null)),(t()(),n.sb(4,0,null,null,5,"button",[["color","accent"],["mat-raised-button",""],["type","button"]],[[1,"disabled",0],[2,"_mat-animation-noopable",null]],[[null,"click"]],(function(t,e,l){var i=!0;return"click"===e&&(i=!1!==t.component.openInput(n.Eb(t,3))&&i),i}),i.b,i.a)),n.rb(5,180224,null,0,s.b,[n.k,o.h,[2,a.a]],{disabled:[0,"disabled"],color:[1,"color"]},null),(t()(),n.sb(6,0,null,0,2,"mat-icon",[["class","mat-icon notranslate"],["role","img"]],[[2,"mat-icon-inline",null],[2,"mat-icon-no-color",null]],null,null,u.b,u.a)),n.rb(7,9158656,null,0,r.b,[n.k,r.d,[8,null],[2,r.a],[2,n.l]],null,null),(t()(),n.Mb(-1,0,["add"])),(t()(),n.Mb(9,0,[" "," "])),(t()(),n.Mb(-1,null,[" \xa0\xa0 "])),(t()(),n.sb(11,0,null,null,2,"div",[["class","myrow"]],null,null,null,null,null)),(t()(),n.hb(16777216,null,null,1,null,d)),n.rb(13,278528,null,0,c.k,[n.O,n.L,n.r],{ngForOf:[0,"ngForOf"]},null)],(function(t,e){var l=e.component;t(e,5,0,l.disabled,"accent"),t(e,7,0),t(e,13,0,l.listOfNames)}),(function(t,e){var l=e.component;t(e,4,0,n.Eb(e,5).disabled||null,"NoopAnimations"===n.Eb(e,5)._animationMode),t(e,6,0,n.Eb(e,7).inline,"primary"!==n.Eb(e,7).color&&"accent"!==n.Eb(e,7).color&&"warn"!==n.Eb(e,7).color),t(e,9,0,l.nameBtn)}))}},AT23:function(t,e,l){"use strict";var n=l("8Y7J"),i=l("hrfs"),s=l("SVse");l("oz3B"),l("7q3A"),l("J3i2"),l("s6ns"),l.d(e,"a",(function(){return o})),l.d(e,"b",(function(){return u}));var o=n.qb({encapsulation:0,styles:[["p[_ngcontent-%COMP%]{font-family:Lato}"]],data:{}});function a(t){return n.Ob(0,[(t()(),n.sb(0,0,null,null,3,"div",[["style","display: flex;margin-bottom: 7px;max-width: 50vw;width: 100%;"]],null,null,null,null,null)),(t()(),n.sb(1,0,null,null,1,"span",[["style","color: gray; font-size: 1em; margin: 0 10px;"]],null,null,null,null,null)),(t()(),n.Mb(2,null,["",""])),(t()(),n.sb(3,0,null,null,0,"div",[["style","width: 43px; height: 18px; border: 1px solid white;"]],[[4,"backgroundColor",null]],null,null,null,null))],null,(function(t,e){var l=e.component;t(e,2,0,e.context.$implicit),t(e,3,0,l.pieChartColors[0].backgroundColor[e.context.index])}))}function u(t){return n.Ob(0,[(t()(),n.sb(0,0,null,null,10,"div",[["class","d-flex flex-column align-items-center justify-content-center mb-3"],["style","cursor: pointer;"]],null,[[null,"click"]],(function(t,e,l){var n=!0;return"click"===e&&(n=!1!==t.component.openDialog()&&n),n}),null,null)),(t()(),n.sb(1,0,null,null,2,"div",[["style","display: block;"]],[[4,"width",null],[4,"height",null]],null,null,null,null)),(t()(),n.sb(2,0,null,null,1,"canvas",[["baseChart",""],["class","chart chart-pie"]],null,null,null,null,null)),n.rb(3,999424,null,0,i.a,[n.k,i.c],{data:[0,"data"],labels:[1,"labels"],options:[2,"options"],chartType:[3,"chartType"],colors:[4,"colors"],legend:[5,"legend"],plugins:[6,"plugins"]},null),(t()(),n.sb(4,0,null,null,2,"div",[["class","mt-3"]],null,null,null,null,null)),(t()(),n.hb(16777216,null,null,1,null,a)),n.rb(6,278528,null,0,s.k,[n.O,n.L,n.r],{ngForOf:[0,"ngForOf"]},null),(t()(),n.sb(7,0,null,null,3,"div",[["class","d-flex flex-column justify-content-center mt-2"]],null,null,null,null,null)),(t()(),n.sb(8,0,null,null,0,"img",[["height","10px"],["src","assets/line.png"],["width","280px"]],[[4,"transform",null]],null,null,null,null)),(t()(),n.sb(9,0,null,null,1,"h5",[["class","pie-title"],["style","color: #737473; margin: 5px 0 10px 5px;"]],null,null,null,null,null)),(t()(),n.Mb(10,null,[" "," "]))],(function(t,e){var l=e.component;t(e,3,0,l.pieChartData,l.pieChartLabels,l.pieChartOptions,l.pieChartType,l.pieChartColors,!0,l.pieChartPlugins),t(e,6,0,l.pieChartLabels)}),(function(t,e){var l=e.component;t(e,1,0,l.withGraphe,l.height),t(e,8,0,"rotateY("+l.retate+"deg)"),t(e,10,0,l.title)}))}},F76L:function(t,e,l){"use strict";l.d(e,"a",(function(){return c})),l.d(e,"b",(function(){return h}));var n=l("mrSG"),i=l("m+JQ"),s=l("8Y7J"),o=l("VRyK"),a=(l("ukCm"),l("s7LF")),u=l("eIep"),r=l("ZTdd");class c{constructor(t,e,l,n,i,o,u,r){this.uow=t,this.dialog=e,this.mydialog=l,this.mytranslate=n,this.fb=i,this.session=o,this.route=u,this.bottomSheet=r,this.update=new s.m,this.isLoadingResults=!0,this.resultsLength=0,this.isRateLimitReached=!1,this.dataSource=[],this.columnDefs=[{columnDef:"codeRecommendation",headName:"CODE"},{columnDef:"nom",headName:"INTITULE"},{columnDef:"mecanisme",headName:"mecanisme"},{columnDef:"axe",headName:"Axe"},{columnDef:"sousAxe",headName:"SOUS AXE"},{columnDef:"organismes",headName:"DEPARTEMENT"},{columnDef:"etat",headName:"ETAT DE MISE EN OEUVRE"},{columnDef:"pieceJointe",headName:""},{columnDef:"complement",headName:""},{columnDef:"option",headName:""}].map(t=>(t.headName=""===t.headName?t.columnDef.toUpperCase():t.headName.toUpperCase(),t)),this.panelOpenState=!1,this.organismes=this.uow.organismes.get(),this.axes=this.uow.axes.get(),this.sousAxes=[],this.annee=this.uow.recommendations.annee(),this.mecanismes=this.uow.mecanismes,this.visites=this.uow.visites.get(),this.organes=this.uow.organes.get(),this.pays=this.uow.pays.get(),this.cycles=this.uow.cycles.get(),this.etats=this.uow.etats,this.departementList=[],this.displayedColumns=this.columnDefs.map(t=>t.columnDef),this.progress=0,this.formData=new FormData,this.o=new h,this.myAuto=new a.f("")}ngOnInit(){this.createForm(),this.isLoadingResults=!1,Object(o.a)(this.sort.sortChange,this.paginator.page,this.update).subscribe(t=>{!0===t?this.paginator.pageIndex=0:t=t,this.paginator.pageSize?t=t:this.paginator.pageSize=10,this.o.startIndex=this.paginator.pageIndex*this.paginator.pageSize,this.o.pageSize=this.paginator.pageSize,this.o.sortBy=this.sort.active?this.sort.active:"id",this.o.sortDir=this.sort.direction?this.sort.direction:"desc",this.isLoadingResults=!0,this.searchAndGet(this.o)}),this.route.queryParams.subscribe(t=>{const e=t.data;e&&this.uow.recommendations.getDetail(e).subscribe(t=>{this.openDialog(t)})}),this.autoComplete()}displayFrIfArNull(t,e){return null==e||""===e||"null"===e?t:e}displayMulti(t,e){const l=[{fr:"R\xe9alis\xe9",ar:"\u0645\u0646\u062c\u0632"},{fr:"Non R\xe9alis\xe9",ar:"\u063a\u064a\u0631 \u0645\u0646\u062c\u0632"},{fr:"En cours",ar:"\u0641\u064a \u0637\u0648\u0631 \u0627\u0644\u0625\u0646\u062c\u0627\u0632"}];if("fr"===this.mytranslate.langSync)return{m:t,e};{const n=[{fr:"Examen p\xe9riodique universal",ar:"\u0627\u0644\u0627\u0633\u062a\u0639\u0631\u0627\u0636 \u0627\u0644\u062f\u0648\u0631\u064a \u0627\u0644\u0634\u0627\u0645\u0644"},{fr:"Organes de Trait\xe9s",ar:"\u0647\u064a\u0626\u0627\u062a \u0627\u0644\u0645\u0639\u0627\u0647\u062f\u0627\u062a"},{fr:"Proc\xe9dures sp\xe9ciales",ar:"\u0627\u0644\u0627\u062c\u0631\u0627\u0621\u0627\u062a \u0627\u0644\u062e\u0627\u0635\u0629"}].find(e=>t.toLowerCase().includes(e.fr.toLowerCase().substring(0,6))),i=l.find(t=>t.fr.toLowerCase()===e.toLowerCase());return{m:n?n.ar:t,e:i?i.ar:e}}}autoComplete(){this.filteredOptions=this.myAuto.valueChanges.pipe(Object(u.a)(t=>t.length>1?this.uow.organismes.autocompletePost("label",t):[]))}selected(t){const e=t.option.value;console.log(e),this.myAuto.setValue(e.label),this.myForm.get("idOrganisme").setValue(e.id)}createForm(){this.myForm=this.fb.group({idOrganisme:this.o.idOrganisme,mecanisme:this.o.mecanisme,idCycle:this.o.idCycle,idOrgane:this.o.idOrgane,idVisite:this.o.idVisite,idAxe:this.o.idAxe,nom:this.o.nom,etat:this.o.etat,idPays:this.o.idPays,idSousAxe:this.o.idSousAxe,annee:this.o.annee,startIndex:this.o.startIndex,pageSize:this.o.pageSize,sortBy:this.o.sortBy,sortDir:this.o.sortDir})}get mecanisme(){return this.myForm.get("mecanisme")}get idVisite(){return this.myForm.get("idVisite")}get idCycle(){return this.myForm.get("idCycle")}get idOrgane(){return this.myForm.get("idOrgane")}get cycleActive(){return"Examen p\xe9riodique universal"===this.mecanisme.value}get visiteActive(){return"Proc\xe9dure sp\xe9ciale"===this.mecanisme.value}get organeActive(){return"Organes de trait\xe9s"===this.mecanisme.value}selectChange(t){this.idVisite.setValue(0),this.idCycle.setValue(0),this.idOrgane.setValue(0)}reset(){this.o=new h,this.createForm(),this.searchAndGet(this.o)}search(t){this.searchAndGet(t)}detail(t){this.uow.recommendations.getDetail(t.id).subscribe(t=>{this.openDialog(t)})}openDialog(t){return this.dialog.open(i.a,{width:"7100px",disableClose:!0,data:{model:t,title:"Recommdandation"}}).afterClosed()}stateDepartement(t){console.log(t),(t=t.filter(t=>null!==t.name)).filter(t=>"PE"===t.type).map(t=>t.name),t.filter(t=>"IN"===t.type).map(t=>t.name),t.filter(t=>"PG"===t.type).map(t=>t.name),t.filter(t=>"Autre"===t.type).map(t=>t.name);const e=[{data:[],label:this.mytranslate.get("admin.organe.list.Etatavancement")},{data:[],label:this.mytranslate.get("admin.organe.list.R\xe9alis\xe9")},{data:[],label:"Non r\xe9alis\xe9"}],l=e,n=e,i=e;t.forEach(t=>{"PE"===t.type?(e[0].data.push((t.p*t.t/100).toFixed(0)),e[1].data.push((t.r*t.t/100).toFixed(0)),e[2].data.push((t.t-t.p*t.t/100-t.r*t.t/100).toFixed(0))):"Autre"===t.type?(i[0].data.push((t.p*t.t/100).toFixed(0)),i[1].data.push((t.r*t.t/100).toFixed(0)),i[2].data.push((t.t-t.p*t.t/100-t.r*t.t/100).toFixed(0))):"IN"===t.type?(l[0].data.push((t.p*t.t/100).toFixed(0)),l[1].data.push((t.r*t.t/100).toFixed(0)),l[2].data.push((t.t-t.p*t.t/100-t.r*t.t/100).toFixed(0))):"PJ"===t.type&&(n[0].data.push((t.p*t.t/100).toFixed(0)),n[1].data.push((t.r*t.t/100).toFixed(0)),n[2].data.push((t.t-t.p*t.t/100-t.r*t.t/100).toFixed(0)))})}searchAndGet(t){console.log(t),this.o=t,this.o.idOrganisme=this.session.isPointFocal||this.session.isProprietaire?this.session.user.idOrganisme:this.o.idOrganisme,this.uow.recommendations.searchAndGet(this.o).subscribe(t=>{console.log(t.list),this.dataSource=t.list,this.resultsLength=t.count,this.isLoadingResults=!1,this.stateDepartement(this.departementList)},t=>this.isLoadingResults=!1)}delete(t){return n.a(this,void 0,void 0,(function*(){if("ok"===(yield this.mydialog.openDialog("recommandation").toPromise())){let e=[];""!==t.pieceJointe?e.push(...this.uow.decoupe(t.pieceJointe)):e=e,this.uow.files.deleteFiles(e,"recommandation").subscribe(e=>{this.uow.recommendations.delete(t.id).subscribe(()=>this.update.next(!0))})}}))}showPieceJoin(t){this.bottomSheet.open(r.a,{data:{fileName:t,folder:"recommandation"}})}axeChange(t){this.uow.sousAxes.getByIdAxe(t).subscribe(t=>{this.sousAxes=t})}get isAllEmpty(){return"0"===this.myForm.get("idAxe").value.toString()&&"0"===this.myForm.get("idCycle").value.toString()&&"0"===this.myForm.get("idSousAxe").value.toString()&&"0"===this.myForm.get("idOrganisme").value.toString()&&"0"===this.myForm.get("idOrgane").value.toString()&&"0"===this.myForm.get("idPays").value.toString()&&""===this.myForm.get("nom").value.toString()&&""===this.myForm.get("etat").value.toString()&&"0"===this.myForm.get("idVisite").value.toString()&&"0"===this.myForm.get("annee").value.toString()&&""===this.myForm.get("mecanisme").value.toString()}}class h{constructor(){this.idAxe=0,this.idSousAxe=0,this.idOrganisme=0,this.mecanisme="",this.idCycle=0,this.idOrgane=0,this.idVisite=0,this.nom="",this.etat="",this.idPays=0,this.startIndex=0,this.pageSize=10,this.sortBy="id",this.sortDir="desc",this.annee=(new Date).getFullYear()}}},Rn7m:function(t,e,l){"use strict";l.d(e,"a",(function(){return s})),l.d(e,"b",(function(){return a}));var n=l("8Y7J"),i=(l("/Co4"),l("SVse")),s=(l("QQfA"),l("IP0z"),l("Xd0L"),l("cUpR"),l("/HVE"),l("zMNK"),l("hOhj"),n.qb({encapsulation:2,styles:[".mat-autocomplete-panel{min-width:112px;max-width:280px;overflow:auto;-webkit-overflow-scrolling:touch;visibility:hidden;max-width:none;max-height:256px;position:relative;width:100%;border-bottom-left-radius:4px;border-bottom-right-radius:4px}.mat-autocomplete-panel.mat-autocomplete-visible{visibility:visible}.mat-autocomplete-panel.mat-autocomplete-hidden{visibility:hidden}.mat-autocomplete-panel-above .mat-autocomplete-panel{border-radius:0;border-top-left-radius:4px;border-top-right-radius:4px}.mat-autocomplete-panel .mat-divider-horizontal{margin-top:-1px}@media (-ms-high-contrast:active){.mat-autocomplete-panel{outline:solid 1px}}"],data:{}}));function o(t){return n.Ob(0,[(t()(),n.sb(0,0,[[2,0],["panel",1]],null,3,"div",[["class","mat-autocomplete-panel"],["role","listbox"]],[[8,"id",0]],null,null,null,null)),n.Jb(512,null,i.x,i.y,[n.r,n.s,n.k,n.D]),n.rb(2,278528,null,0,i.j,[i.x],{klass:[0,"klass"],ngClass:[1,"ngClass"]},null),n.Db(null,0)],(function(t,e){t(e,2,0,"mat-autocomplete-panel",e.component._classList)}),(function(t,e){t(e,0,0,e.component.id)}))}function a(t){return n.Ob(2,[n.Kb(402653184,1,{template:0}),n.Kb(671088640,2,{panel:0}),(t()(),n.hb(0,[[1,2]],null,0,null,o))],null,null)}},gct3:function(t,e,l){"use strict";l.d(e,"a",(function(){return n}));class n{}},"m+JQ":function(t,e,l){"use strict";l.d(e,"a",(function(){return n}));class n{constructor(t,e){this.dialogRef=t,this.data=e,this.title=""}ngOnInit(){this.o=this.data.model,this.title=this.data.title,console.log(this.o)}onNoClick(){this.dialogRef.close()}onOkClick(t){}}},nRMC:function(t,e,l){"use strict";var n=l("8Y7J"),i=l("SVse");l("2HI4"),l("J3i2"),l("IheW"),l.d(e,"a",(function(){return s})),l.d(e,"b",(function(){return o}));var s=n.qb({encapsulation:0,styles:[[""]],data:{}});function o(t){return n.Ob(0,[(t()(),n.sb(0,0,null,null,5,"section",[],null,null,null,null,null)),(t()(),n.sb(1,0,null,null,4,"h5",[["style","color: #737473; margin: 20px 5px;"]],null,null,null,null,null)),(t()(),n.sb(2,0,null,null,0,"span",[["style","font-size: 1.5em;"]],[[8,"innerHTML",1]],null,null,null,null)),(t()(),n.sb(3,0,null,null,2,"b",[["style","color: #286293; cursor: pointer;font-size: 1.5em;"]],null,[[null,"click"]],(function(t,e,l){var n=!0;return"click"===e&&(n=!1!==t.component.moreInfo()&&n),n}),null,null)),(t()(),n.Mb(4,null,[" "," "])),n.Gb(131072,i.b,[n.h])],null,(function(t,e){var l=e.component;t(e,2,0,l.text2),t(e,4,0,"fr"===n.Nb(e,4,0,n.Eb(e,5).transform(l.mytranslate.lang))?l.text2.length===l.length?"Lire la suite":"R\xe9duire":l.text2.length===l.length?"\u0627\u0642\u0631\u0623 \u0627\u0644\u0645\u0632\u064a\u062f":"\u062a\u0642\u0644\u064a\u0635")}))}},ondm:function(t,e,l){"use strict";l.d(e,"a",(function(){return s})),l.d(e,"b",(function(){return o}));var n=l("8Y7J"),i=l("zQui"),s=(l("SVse"),l("IP0z"),l("/HVE"),n.qb({encapsulation:2,styles:[],data:{}}));function o(t){return n.Ob(0,[n.Kb(402653184,1,{_rowOutlet:0}),n.Kb(402653184,2,{_headerRowOutlet:0}),n.Kb(402653184,3,{_footerRowOutlet:0}),n.Db(null,0),(t()(),n.sb(4,16777216,null,null,1,null,null,null,null,null,null,null)),n.rb(5,16384,[[2,4]],0,i.t,[n.O,n.k],null,null),(t()(),n.sb(6,16777216,null,null,1,null,null,null,null,null,null,null)),n.rb(7,16384,[[1,4]],0,i.r,[n.O,n.k],null,null),(t()(),n.sb(8,16777216,null,null,1,null,null,null,null,null,null,null)),n.rb(9,16384,[[3,4]],0,i.s,[n.O,n.k],null,null)],null,null)}},oz3B:function(t,e,l){"use strict";l.d(e,"a",(function(){return u}));var n=l("hrfs"),i=l("XNiG"),s=l("HDdC"),o=l("DDG+"),a=l("hSFZ");class u{constructor(t,e,l){this.uow=t,this.mytranslate=e,this.dialog=l,this.obs=new i.a,this.showLegend=!0,this.withGraphe="100%",this.positionLegendBottom=!1,this.canvasHeight=400,this.height="45vh",this.title=null,this.pieChartOptions={responsive:!0,maintainAspectRatio:!1,cutoutPercentage:50,title:{text:"",display:!0},tooltips:{enabled:!0},legend:{position:"bottom",display:!1,align:"center",fullWidth:!0,labels:{fontSize:16}},plugins:{labels:{fontColor:["white","white","white","white","white","white","white","white","white","white","white","white"],precision:0,render:"percentage",fontSize:14,fontStyle:"bold"},pieceLabel:{render:t=>t.label+": "+t.value}}},this.pieChartLabels=[],this.pieChartData=[],this.pieChartType="pie",this.pieChartLegend=!0,this.pieChartPlugins=[a],this.pieChartColors=[{backgroundColor:[]}],this.list=[],this.retate=0,Object(n.e)(),Object(n.d)()}ngOnInit(){this.mytranslate.lang.subscribe(t=>{this.retate="fr"===t?0:180}),this.obs.subscribe(t=>{t.title instanceof s.a?t.title.subscribe(t=>this.title=t):this.title=t.title,this.uow.recommendations.genericByRecommendation(t.table,t.type).subscribe(t=>{console.log(t),this.pieChartLabels=t.map(t=>t.table),this.pieChartData=t.map(t=>+t.value.toFixed(0)),this.pieChartColors[0].backgroundColor=this.getColors(this.pieChartLabels.length),this.pieChartLabels.forEach((e,l)=>{0!==this.pieChartData[l]&&this.list.push({name:t[l].table.toString(),value:this.pieChartData[l]})})})})}openDialog(){this.dialog.open(o.a,{width:"7100px",disableClose:!1,data:{model:this.list,type:"pie",title:this.title}}).afterClosed().subscribe(t=>{console.log(t)})}getColors(t){const e=["#d97f2a","#2d71a1","#c2c3c6","#ba6446","#7dc460","#fdb93a","#59b8ce","#5c5c5f","#ef4f42","#a5a6aa"],l=[];for(let n=0;n<t;n++)l.push(e[n%e.length]);return l}}},x3GN:function(t,e,l){"use strict";l.d(e,"a",(function(){return i}));var n=l("XNiG");class i{constructor(t){this.mytranslate=t,this.year=(new Date).getFullYear(),this.count=new n.a,this.height="62vh",this.ifEpu=!1}ngOnInit(){}}},xjdI:function(t,e,l){"use strict";l.d(e,"a",(function(){return o}));var n=l("8Y7J"),i=l("0hB7"),s=l("iInd");let o=(()=>{class t{constructor(t,e){this.session=t,this.router=e}canActivate(t,e){return console.log(e),!(e.url.includes("update")&&!this.session.isAdmin&&!this.session.isProprietaire&&(this.router.navigate(["/admin"]),1))}}return t.ngInjectableDef=n.Sb({factory:function(){return new t(n.Tb(i.a),n.Tb(s.m))},token:t,providedIn:"root"}),t})()}}]);