(window.webpackJsonp=window.webpackJsonp||[]).push([[3],{"5nPQ":function(t,n,l){"use strict";l.d(n,"a",(function(){return s}));var e=l("mrSG"),i=l("XNiG");class s{constructor(t){this.filesService=t,this.listOfNames=[],this.listToDelete=[],this.files=[],this.nameBtn="",this.folderToSaveInServer="folder",this.propertyOfParent=new i.a,this.eventSubmitToParent=new i.a,this.eventSubmitFromParent=new i.a}ngOnInit(){this.propertyOfParent.subscribe(t=>{if(!t)return;const n=t.split(";");n.pop(),this.listOfNames=n,this.listToDelete=[]}),this.eventSubmitFromParent.subscribe(t=>e.a(this,void 0,void 0,(function*(){yield this.submit()})))}upload(t){for(let n=0;n<t.length;n++){const l=t.item(n);this.listOfNames.push(this.setFileName(l)),this.sendPropertyOfParent(),this.files.push(l)}}setIcon(t){const n=t.lastIndexOf("."),l=t.substring(n+1);return"pdf"===l||"pdf;"===l?"assets/svg/pdf.svg":"assets/svg/word.svg"}remove(t){const n=this.listOfNames.findIndex(n=>n===t);-1!==n&&(this.listOfNames.splice(n,1),this.sendPropertyOfParent()),this.listToDelete.push(t);const l=t.indexOf("_"),e=t.substring(l);-1!==this.files.findIndex(t=>t.name===e)&&this.files.splice(n,1)}openInput(t){t.click()}sendPropertyOfParent(){let t="";this.listOfNames.forEach(n=>{t+=`${n};`}),this.eventSubmitToParent.next(t)}submit(){return e.a(this,void 0,void 0,(function*(){const t=new FormData;this.files.forEach(n=>{const l=this.setFileName(n);t.append(l,n,l)}),t&&(yield this.filesService.uploadFiles(t,this.folderToSaveInServer).toPromise(),yield this.filesService.deleteFiles(this.listToDelete,this.folderToSaveInServer).toPromise())}))}setFileName(t){return`${t.lastModified}_${t.name}`}}},"A/Kj":function(t,n,l){"use strict";var e=l("8Y7J"),i=l("bujt"),s=l("Fwaw"),o=l("5GAg"),a=l("omvX"),r=l("Mr+X"),u=l("Gi4r"),c=l("SVse");l("5nPQ"),l("WTxg"),l.d(n,"a",(function(){return h})),l.d(n,"b",(function(){return m}));var h=e.qb({encapsulation:0,styles:[["img[_ngcontent-%COMP%]{height:20px}"]],data:{}});function d(t){return e.Ob(0,[(t()(),e.sb(0,0,null,null,7,"p",[["style","font-size: .7em;margin: 0;"]],null,null,null,null,null)),(t()(),e.sb(1,0,null,null,0,"img",[["alt","pdf/word"]],[[8,"src",4]],null,null,null,null)),(t()(),e.Mb(2,null,[" - "," "])),(t()(),e.sb(3,0,null,null,4,"button",[["color","warn"],["mat-icon-button",""],["type","button"]],[[1,"disabled",0],[2,"_mat-animation-noopable",null]],[[null,"click"]],(function(t,n,l){var e=!0;return"click"===n&&(e=!1!==t.component.remove(t.context.$implicit)&&e),e}),i.b,i.a)),e.rb(4,180224,null,0,s.b,[e.k,o.h,[2,a.a]],{color:[0,"color"]},null),(t()(),e.sb(5,0,null,0,2,"mat-icon",[["class","mat-icon notranslate"],["role","img"],["style","font-size: 1.3em !important;"]],[[2,"mat-icon-inline",null],[2,"mat-icon-no-color",null]],null,null,r.b,r.a)),e.rb(6,9158656,null,0,u.b,[e.k,u.d,[8,null],[2,u.a],[2,e.l]],null,null),(t()(),e.Mb(-1,0,["delete_sweep"]))],(function(t,n){t(n,4,0,"warn"),t(n,6,0)}),(function(t,n){t(n,1,0,n.component.setIcon(n.context.$implicit));var l=n.context.$implicit.substring(14);t(n,2,0,l),t(n,3,0,e.Eb(n,4).disabled||null,"NoopAnimations"===e.Eb(n,4)._animationMode),t(n,5,0,e.Eb(n,6).inline,"primary"!==e.Eb(n,6).color&&"accent"!==e.Eb(n,6).color&&"warn"!==e.Eb(n,6).color)}))}function m(t){return e.Ob(0,[(t()(),e.sb(0,0,null,null,13,"div",[["class","row"]],null,null,null,null,null)),(t()(),e.sb(1,0,null,null,12,"div",[["class","col-md-12 mb-3"]],null,null,null,null,null)),(t()(),e.sb(2,0,null,null,11,"div",[["class","myrow"]],null,null,null,null,null)),(t()(),e.sb(3,0,[["file1",1]],null,0,"input",[["accept","application/pdf,.doc,.docx,application/msword,application/vnd.openxmlformats-officedocument.wordprocessingml.document"],["hidden",""],["multiple","false"],["style","display: none;"],["type","file"]],null,[[null,"change"]],(function(t,n,l){var i=!0;return"change"===n&&(i=!1!==t.component.upload(e.Eb(t,3).files)&&i),i}),null,null)),(t()(),e.sb(4,0,null,null,5,"button",[["color","accent"],["mat-raised-button",""],["type","button"]],[[1,"disabled",0],[2,"_mat-animation-noopable",null]],[[null,"click"]],(function(t,n,l){var i=!0;return"click"===n&&(i=!1!==t.component.openInput(e.Eb(t,3))&&i),i}),i.b,i.a)),e.rb(5,180224,null,0,s.b,[e.k,o.h,[2,a.a]],{color:[0,"color"]},null),(t()(),e.sb(6,0,null,0,2,"mat-icon",[["class","mat-icon notranslate"],["role","img"]],[[2,"mat-icon-inline",null],[2,"mat-icon-no-color",null]],null,null,r.b,r.a)),e.rb(7,9158656,null,0,u.b,[e.k,u.d,[8,null],[2,u.a],[2,e.l]],null,null),(t()(),e.Mb(-1,0,["add"])),(t()(),e.Mb(9,0,[" "," "])),(t()(),e.Mb(-1,null,[" \xa0\xa0 "])),(t()(),e.sb(11,0,null,null,2,"div",[["class","myrow"]],null,null,null,null,null)),(t()(),e.hb(16777216,null,null,1,null,d)),e.rb(13,278528,null,0,c.k,[e.O,e.L,e.r],{ngForOf:[0,"ngForOf"]},null)],(function(t,n){var l=n.component;t(n,5,0,"accent"),t(n,7,0),t(n,13,0,l.listOfNames)}),(function(t,n){var l=n.component;t(n,4,0,e.Eb(n,5).disabled||null,"NoopAnimations"===e.Eb(n,5)._animationMode),t(n,6,0,e.Eb(n,7).inline,"primary"!==e.Eb(n,7).color&&"accent"!==e.Eb(n,7).color&&"warn"!==e.Eb(n,7).color),t(n,9,0,l.nameBtn)}))}},AT23:function(t,n,l){"use strict";var e=l("8Y7J"),i=l("hrfs");l("oz3B"),l("7q3A"),l("J3i2"),l("s6ns"),l.d(n,"a",(function(){return s})),l.d(n,"b",(function(){return o}));var s=e.qb({encapsulation:0,styles:[["p[_ngcontent-%COMP%]{font-family:Lato}"]],data:{}});function o(t){return e.Ob(0,[(t()(),e.sb(0,0,null,null,7,"div",[["class","d-flex flex-column align-items-center justify-content-center mb-3"],["style","cursor: pointer;"]],null,[[null,"click"]],(function(t,n,l){var e=!0;return"click"===n&&(e=!1!==t.component.openDialog()&&e),e}),null,null)),(t()(),e.sb(1,0,null,null,2,"div",[["style","display: block;"]],[[4,"width","px"]],null,null,null,null)),(t()(),e.sb(2,0,null,null,1,"canvas",[["baseChart",""],["class","chart chart-pie"]],null,null,null,null,null)),e.rb(3,999424,null,0,i.a,[e.k,i.c],{data:[0,"data"],labels:[1,"labels"],options:[2,"options"],chartType:[3,"chartType"],colors:[4,"colors"],legend:[5,"legend"],plugins:[6,"plugins"]},null),(t()(),e.sb(4,0,null,null,3,"div",[["class","d-flex flex-column justify-content-center mt-2"]],null,null,null,null,null)),(t()(),e.sb(5,0,null,null,0,"img",[["height","10px"],["src","assets/line.png"],["width","280px"]],[[4,"transform",null]],null,null,null,null)),(t()(),e.sb(6,0,null,null,1,"h5",[["style","color: #737473; margin: 5px 0 10px 5px;"]],null,null,null,null,null)),(t()(),e.Mb(7,null,[" "," "]))],(function(t,n){var l=n.component;t(n,3,0,l.pieChartData,l.pieChartLabels,l.pieChartOptions,l.pieChartType,l.pieChartColors,l.pieChartLegend,l.pieChartPlugins)}),(function(t,n){var l=n.component;t(n,1,0,l.withGraphe),t(n,5,0,"rotateY("+l.retate+"deg)"),t(n,7,0,l.title)}))}},CJ2A:function(t,n,l){"use strict";l.d(n,"a",(function(){return a}));var e=l("mrSG"),i=l("XNiG"),s=l("HDdC"),o=l("DDG+");class a{constructor(t,n){this.mytranslate=t,this.dialog=n,this.width=300,this.fontSize=.93,this.widthText="",this.marginh5Title="",this.marginLegend="",this.marginLeftTitle="",this.diameter=120,this.transform=50,this.showLegend=!1,this.isInForLoop=!1,this.data=new i.a,this.o={name:null,t:0,p:0,r:0},this.retate=0}ngOnInit(){this.mytranslate.lang.subscribe(t=>{this.retate="fr"===t?0:180}),this.data.subscribe(t=>e.a(this,void 0,void 0,(function*(){t.name instanceof s.a?t.name.subscribe(n=>{this.o.name=n,this.o.t=t.t,this.o.p=t.p,this.o.r=t.r,console.log(this.o)}):this.o=t})))}tooltipMsg(t,n,l){return"fr"===this.mytranslate.langSync?"En cours : "+t+"% - R\xe9alis\xe9 : "+n+"% - Taux : "+l.toFixed(0)+"%":`\u0627\u0644\u062a\u0642\u062f\u0645 \u0627\u0644\u0645\u062d\u0631\u0632 : ${t} % - \u0645\u0646\u062c\u0632 : ${n} % - \u0646\u0633\u0628\u0629 ${l.toFixed(0)} %    `}openDialog(){this.dialog.open(o.a,{width:"7100px",disableClose:!1,data:{model:this.o,type:"cercle",title:this.o.name}}).afterClosed().subscribe(t=>{console.log(t)})}}},ExPl:function(t,n,l){"use strict";var e=l("8Y7J"),i=l("SVse"),s=l("hrfs");l("oTHA"),l("J3i2"),l("s6ns"),l.d(n,"a",(function(){return o})),l.d(n,"b",(function(){return a}));var o=e.qb({encapsulation:0,styles:[['p[_ngcontent-%COMP%]{font-family:Lato}.border-left[_ngcontent-%COMP%]{border-left:10px solid #a19b9e}.border-right[_ngcontent-%COMP%]{border-right:10px solid #a19b9e}.super-title[_ngcontent-%COMP%]{height:45px;display:flex;align-items:center}.super-title[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]{background-color:#d17c36;height:35px;display:flex;align-items:center}.super-title[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]   h3[_ngcontent-%COMP%]{color:#fff;margin:0;padding:0 5px}.super-title2[_ngcontent-%COMP%]{height:45px;display:flex;align-items:center}.super-title2[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]{height:35px;display:flex;align-items:center}.super-title2[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]   h3[_ngcontent-%COMP%]{color:#a19b9e;margin:0;padding:0 5px;font-size:1.8em}.host[_ngcontent-%COMP%]{margin:1em!important}  .mat-progress-spinner circle{fill:#00000008!important}h3[_ngcontent-%COMP%]{margin:20px 0 10px;color:var(--primary);text-align:center;font-size:medium}.axes[_ngcontent-%COMP%]{display:flex;flex-direction:column;box-shadow:1px 1px 5px #ddd;padding:5px;margin-bottom:5px}.axes[_ngcontent-%COMP%]   p[_ngcontent-%COMP%]{margin:0;font-size:.8em}.axes[_ngcontent-%COMP%]   .title[_ngcontent-%COMP%]{font-weight:700;margin-bottom:10px;font-size:.9em}@font-face{font-family:Satisfy;font-style:normal;font-weight:400;font-display:swap;src:local("Satisfy Regular"),local("Satisfy-Regular"),url(https://fonts.gstatic.com/s/satisfy/v11/rP2Hp2yn6lkG50LoCZOIHQ.woff2) format("woff2");unicode-range:U+0000-00FF,U+0131,U+0152-0153,U+02BB-02BC,U+02C6,U+02DA,U+02DC,U+2000-206F,U+2074,U+20AC,U+2122,U+2191,U+2193,U+2212,U+2215,U+FEFF,U+FFFD}.textAlign-left[_ngcontent-%COMP%]{text-align:left}.textAlign-right[_ngcontent-%COMP%]{text-align:right}.textSouTitre[_ngcontent-%COMP%]{text-align:right;margin-bottom:2%;font-size:.9em;color:#00000070}']],data:{}});function a(t){return e.Ob(0,[(t()(),e.sb(0,0,null,null,9,"div",[["class","d-flex flex-column align-items-center justify-content-center"],["style","cursor: pointer;"]],null,[[null,"click"]],(function(t,n,l){var e=!0;return"click"===n&&(e=!1!==t.component.openDialog()&&e),e}),null,null)),(t()(),e.sb(1,0,null,null,5,"div",[["class","d-flex justify-content-center w-100"],["style","margin-top: 2%; "]],null,null,null,null,null)),(t()(),e.sb(2,0,null,null,4,"section",[],[[8,"className",0]],null,null,null,null)),e.Gb(131072,i.b,[e.h]),(t()(),e.sb(4,0,null,null,2,"div",[],null,null,null,null,null)),(t()(),e.sb(5,0,null,null,1,"h3",[],null,null,null,null,null)),(t()(),e.Mb(6,null,["",""])),(t()(),e.sb(7,0,null,null,2,"div",[["class","col-md-8"],["style","display: block; width: 80vw;"]],null,null,null,null,null)),(t()(),e.sb(8,0,null,null,1,"canvas",[["baseChart",""]],null,[[null,"chartHover"],[null,"chartClick"]],(function(t,n,l){var e=!0,i=t.component;return"chartHover"===n&&(e=!1!==i.chartHovered(l)&&e),"chartClick"===n&&(e=!1!==i.chartClicked(l)&&e),e}),null,null)),e.rb(9,999424,null,0,s.a,[e.k,s.c],{datasets:[0,"datasets"],labels:[1,"labels"],options:[2,"options"],chartType:[3,"chartType"],colors:[4,"colors"],legend:[5,"legend"]},{chartClick:"chartClick",chartHover:"chartHover"})],(function(t,n){var l=n.component;t(n,9,0,l.barChartData,l.barChartLabels,l.barChartOptions,l.barChartType,l.pieChartColors,l.barChartLegend)}),(function(t,n){var l=n.component;t(n,2,0,"fr"===e.Nb(n,2,0,e.Eb(n,3).transform(l.mytranslate.lang))?"super-title border-left":"super-title border-right"),t(n,6,0,""===l.title?".......":l.title)}))}},F76L:function(t,n,l){"use strict";l.d(n,"a",(function(){return c})),l.d(n,"b",(function(){return h}));var e=l("mrSG"),i=l("m+JQ"),s=l("8Y7J"),o=l("VRyK"),a=(l("ukCm"),l("s7LF")),r=l("eIep"),u=l("ZTdd");class c{constructor(t,n,l,e,i,o,r,u){this.uow=t,this.dialog=n,this.mydialog=l,this.mytranslate=e,this.fb=i,this.session=o,this.route=r,this.bottomSheet=u,this.update=new s.m,this.isLoadingResults=!0,this.resultsLength=0,this.isRateLimitReached=!1,this.dataSource=[],this.columnDefs=[{columnDef:"codeRecommendation",headName:"CODE"},{columnDef:"nom",headName:"INTITULE"},{columnDef:"mecanisme",headName:"mecanisme"},{columnDef:"axe",headName:"Axe"},{columnDef:"sousAxe",headName:"SOUS AXE"},{columnDef:"organismes",headName:"DEPARTEMENT"},{columnDef:"etat",headName:"ETAT DE MISE EN OEUVRE"},{columnDef:"observation",headName:""},{columnDef:"complement",headName:""},{columnDef:"pieceJointe",headName:""},{columnDef:"option",headName:""}].map(t=>(t.headName=""===t.headName?t.columnDef.toUpperCase():t.headName.toUpperCase(),t)),this.panelOpenState=!1,this.organismes=this.uow.organismes.get(),this.axes=this.uow.axes.get(),this.sousAxes=[],this.mecanismes=this.uow.mecanismes,this.visites=this.uow.visites.get(),this.organes=this.uow.organes.get(),this.pays=this.uow.pays.get(),this.cycles=[],this.etats=this.uow.etats,this.displayedColumns=this.columnDefs.map(t=>t.columnDef),this.progress=0,this.formData=new FormData,this.o=new h,this.myAuto=new a.f("")}ngOnInit(){this.createForm(),this.isLoadingResults=!1,Object(o.a)(this.sort.sortChange,this.paginator.page,this.update).subscribe(t=>{!0===t?this.paginator.pageIndex=0:t=t,this.paginator.pageSize?t=t:this.paginator.pageSize=10,this.o.startIndex=this.paginator.pageIndex*this.paginator.pageSize,this.o.pageSize=this.paginator.pageSize,this.o.sortBy=this.sort.active?this.sort.active:"id",this.o.sortDir=this.sort.direction?this.sort.direction:"desc",this.isLoadingResults=!0,this.searchAndGet(this.o)}),this.uow.cycles.get().subscribe(t=>{this.cycles=t,0!==this.cycles.length&&this.myForm.get("idCycle").patchValue(this.cycles[0].id)}),this.route.queryParams.subscribe(t=>{const n=t.data;n&&this.uow.recommendations.getDetail(n).subscribe(t=>{this.openDialog(t)})}),this.autoComplete()}autoComplete(){this.filteredOptions=this.myAuto.valueChanges.pipe(Object(r.a)(t=>t.length>1?this.uow.organismes.autocompletePost("label",t):[]))}selected(t){const n=t.option.value;console.log(n),this.myAuto.setValue(n.label),this.myForm.get("idOrganisme").setValue(n.id)}createForm(){this.myForm=this.fb.group({idOrganisme:this.o.idOrganisme,mecanisme:this.o.mecanisme,idCycle:this.o.idCycle,idOrgane:this.o.idOrgane,idVisite:this.o.idVisite,idAxe:this.o.idAxe,nom:this.o.nom,etat:this.o.etat,idPays:this.o.idPays,idSousAxe:this.o.idSousAxe,startIndex:this.o.startIndex,pageSize:this.o.pageSize,sortBy:this.o.sortBy,sortDir:this.o.sortDir})}get mecanisme(){return this.myForm.get("mecanisme")}get idVisite(){return this.myForm.get("idVisite")}get idCycle(){return this.myForm.get("idCycle")}get idOrgane(){return this.myForm.get("idOrgane")}get cycleActive(){return"Examen p\xe9riodique universal"===this.mecanisme.value}get visiteActive(){return"Proc\xe9dure sp\xe9ciale"===this.mecanisme.value}get organeActive(){return"Organes de trait\xe9s"===this.mecanisme.value}selectChange(t){this.idVisite.setValue(0),this.idCycle.setValue(this.cycles[0].id),this.idOrgane.setValue(0)}reset(){this.o=new h,this.createForm(),this.searchAndGet(this.o)}search(t){this.searchAndGet(t)}detail(t){this.uow.recommendations.getDetail(t.id).subscribe(t=>{this.openDialog(t)})}openDialog(t){return this.dialog.open(i.a,{width:"7100px",disableClose:!0,data:{model:t,title:"Recommdandation"}}).afterClosed()}searchAndGet(t){console.log(t),this.o=t,this.o.idOrganisme=this.session.isPointFocal||this.session.isProprietaire?this.session.user.idOrganisme:this.o.idOrganisme,this.uow.recommendations.searchAndGet(this.o).subscribe(t=>{console.log(t.list),this.dataSource=t.list,this.resultsLength=t.count,this.isLoadingResults=!1},t=>this.isLoadingResults=!1)}delete(t){return e.a(this,void 0,void 0,(function*(){if("ok"===(yield this.mydialog.openDialog("recommandation").toPromise())){let n=[];""!==t.pieceJointe?n.push(...this.uow.decoupe(t.pieceJointe)):n=n,this.uow.files.deleteFiles(n,"recommandation").subscribe(n=>{this.uow.recommendations.delete(t.id).subscribe(()=>this.update.next(!0))})}}))}showPieceJoin(t){this.bottomSheet.open(u.a,{data:{fileName:t,folder:"recommandation"}})}axeChange(t){this.uow.sousAxes.getByIdAxe(t).subscribe(t=>{this.sousAxes=t})}get isAllEmpty(){return"0"===this.myForm.get("idAxe").value.toString()&&"0"===this.myForm.get("idCycle").value.toString()&&"0"===this.myForm.get("idSousAxe").value.toString()&&"0"===this.myForm.get("idOrganisme").value.toString()&&"0"===this.myForm.get("idOrgane").value.toString()&&"0"===this.myForm.get("idPays").value.toString()&&""===this.myForm.get("nom").value.toString()&&""===this.myForm.get("etat").value.toString()&&"0"===this.myForm.get("idVisite").value.toString()&&""===this.myForm.get("mecanisme").value.toString()}}class h{constructor(){this.idAxe=0,this.idSousAxe=0,this.idOrganisme=0,this.mecanisme="",this.idCycle=0,this.idOrgane=0,this.idVisite=0,this.nom="",this.etat="",this.idPays=0,this.startIndex=0,this.pageSize=10,this.sortBy="id",this.sortDir="desc"}}},Rn7m:function(t,n,l){"use strict";l.d(n,"a",(function(){return s})),l.d(n,"b",(function(){return a}));var e=l("8Y7J"),i=(l("/Co4"),l("SVse")),s=(l("QQfA"),l("IP0z"),l("Xd0L"),l("cUpR"),l("/HVE"),l("zMNK"),l("hOhj"),e.qb({encapsulation:2,styles:[".mat-autocomplete-panel{min-width:112px;max-width:280px;overflow:auto;-webkit-overflow-scrolling:touch;visibility:hidden;max-width:none;max-height:256px;position:relative;width:100%;border-bottom-left-radius:4px;border-bottom-right-radius:4px}.mat-autocomplete-panel.mat-autocomplete-visible{visibility:visible}.mat-autocomplete-panel.mat-autocomplete-hidden{visibility:hidden}.mat-autocomplete-panel-above .mat-autocomplete-panel{border-radius:0;border-top-left-radius:4px;border-top-right-radius:4px}.mat-autocomplete-panel .mat-divider-horizontal{margin-top:-1px}@media (-ms-high-contrast:active){.mat-autocomplete-panel{outline:solid 1px}}"],data:{}}));function o(t){return e.Ob(0,[(t()(),e.sb(0,0,[[2,0],["panel",1]],null,3,"div",[["class","mat-autocomplete-panel"],["role","listbox"]],[[8,"id",0]],null,null,null,null)),e.Jb(512,null,i.x,i.y,[e.r,e.s,e.k,e.D]),e.rb(2,278528,null,0,i.j,[i.x],{klass:[0,"klass"],ngClass:[1,"ngClass"]},null),e.Db(null,0)],(function(t,n){t(n,2,0,"mat-autocomplete-panel",n.component._classList)}),(function(t,n){t(n,0,0,n.component.id)}))}function a(t){return e.Ob(2,[e.Kb(402653184,1,{template:0}),e.Kb(671088640,2,{panel:0}),(t()(),e.hb(0,[[1,2]],null,0,null,o))],null,null)}},aQXj:function(t,n,l){"use strict";l.d(n,"a",(function(){return i}));var e=l("DDG+");class i{constructor(t,n){this.mytranslate=t,this.dialog=n,this.widthOne=0,this.widthTwo=0,this.widthThree=0,this.title="",this.rotateY=0}ngOnInit(){this.mytranslate.lang.subscribe(t=>{this.rotateY="fr"===t?0:180})}tooltipMsg(t,n,l){return"fr"===this.mytranslate.langSync?"En cours : "+t+"% - R\xe9alis\xe9 : "+n+"% - Taux : "+l.toFixed(0)+"%":`\u0627\u0644\u062a\u0642\u062f\u0645 \u0627\u0644\u0645\u062d\u0631\u0632 : ${t} % - \u0645\u0646\u062c\u0632 : ${n} % - \u0646\u0633\u0628\u0629 ${l.toFixed(0)} %    `}openDialog(){this.dialog.open(e.a,{width:"7100px",disableClose:!1,data:{model:{name:this.title,t:this.widthTwo,p:this.widthTwo,r:this.widthThree},type:"cercle",title:this.title}}).afterClosed().subscribe(t=>{console.log(t)})}}},cyWb:function(t,n,l){"use strict";var e=l("8Y7J"),i=l("NvT6"),s=l("W5yJ"),o=l("/HVE"),a=l("SVse"),r=l("omvX"),u=l("Mz6y"),c=l("QQfA"),h=l("hOhj"),d=l("5GAg"),m=l("IP0z"),p=l("cUpR");l("CJ2A"),l("J3i2"),l("s6ns"),l.d(n,"a",(function(){return g})),l.d(n,"b",(function(){return y}));var g=e.qb({encapsulation:0,styles:[[".legend[_ngcontent-%COMP%]{list-style:none}.legend[_ngcontent-%COMP%]   li[_ngcontent-%COMP%]{margin-right:10px;font-size:14px;font-weight:100}.legend[_ngcontent-%COMP%]   span[_ngcontent-%COMP%]{border:1px solid #ccc;float:left;width:12px;height:12px;margin:2px}.legend[_ngcontent-%COMP%]   .superawesome[_ngcontent-%COMP%]{background-color:#2b6a97;width:40px;height:22px;font-size:small;padding:2%}.legend[_ngcontent-%COMP%]   .awesome[_ngcontent-%COMP%]{background-color:#ca7834;width:40px;height:22px;font-size:small;padding:2%}.legend[_ngcontent-%COMP%]   .kindaawesome[_ngcontent-%COMP%]{background-color:grey;width:40px;height:22px;font-size:small;padding:2%}.divLegend[_ngcontent-%COMP%]{margin:12px 15px -171px -196px}.h5Title[_ngcontent-%COMP%]{color:#737473}.mat-spinner[_ngcontent-%COMP%]   circle[_ngcontent-%COMP%],   .orange .mat-progress-spinner circle{stroke:#d17c36!important}.mat-spinner[_ngcontent-%COMP%]   circle[_ngcontent-%COMP%],   .blue .mat-progress-spinner circle{stroke:var(--primary)!important}.mat-spinner[_ngcontent-%COMP%]   circle[_ngcontent-%COMP%],   .gray .mat-progress-spinner circle{stroke:gray!important}"]],data:{}});function b(t){return e.Ob(0,[(t()(),e.sb(0,0,null,null,0,"img",[["height","10px"],["src","assets/line.png"],["width","280px"]],[[4,"transform",null]],null,null,null,null))],null,(function(t,n){t(n,0,0,"rotateY("+n.component.retate+"deg)")}))}function f(t){return e.Ob(0,[(t()(),e.sb(0,0,null,null,7,"div",[["class","d-flex flex-column justify-content-center mt-2 "]],[[4,"width",null],[4,"margin",null]],null,null,null,null)),(t()(),e.sb(1,0,null,null,6,"ul",[["class","legend"],["height","10px"],["width","280px"]],null,null,null,null,null)),(t()(),e.sb(2,0,null,null,1,"span",[["class","superawesome"]],null,null,null,null,null)),(t()(),e.Mb(3,null,["","%"])),(t()(),e.sb(4,0,null,null,1,"span",[["class","awesome"]],null,null,null,null,null)),(t()(),e.Mb(5,null,["","%"])),(t()(),e.sb(6,0,null,null,1,"span",[["class","kindaawesome"]],null,null,null,null,null)),(t()(),e.Mb(7,null,["","%"]))],null,(function(t,n){var l=n.component;t(n,0,0,l.widthText,l.marginLegend),t(n,3,0,l.o.t.toFixed(0)),t(n,5,0,l.o.p.toFixed(0)),t(n,7,0,l.o.r.toFixed(0))}))}function y(t){return e.Ob(0,[(t()(),e.sb(0,0,null,null,24,"div",[["class","d-flex justify-content-center"],["style","height: 230px; cursor: pointer;margin-right: 70px;"]],null,[[null,"click"]],(function(t,n,l){var e=!0;return"click"===n&&(e=!1!==t.component.openDialog()&&e),e}),null,null)),(t()(),e.sb(1,0,null,null,13,"div",[["class","d-flex justify-content-center"],["style","height: 300px;"]],null,null,null,null,null)),(t()(),e.sb(2,0,null,null,12,"div",[["style","position: relative;width: 100%;"]],null,null,null,null,null)),(t()(),e.sb(3,0,null,null,3,"div",[["class","blue"]],null,null,null,null,null)),(t()(),e.sb(4,16777216,null,null,2,"mat-progress-spinner",[["class","mat-progress-spinner"],["role","progressbar"],["style","position: absolute;"]],[[4,"transform",null],[2,"_mat-animation-noopable",null],[4,"width","px"],[4,"height","px"],[1,"aria-valuemin",0],[1,"aria-valuemax",0],[1,"aria-valuenow",0],[1,"mode",0]],[[null,"longpress"],[null,"keydown"],[null,"touchend"]],(function(t,n,l){var i=!0;return"longpress"===n&&(i=!1!==e.Eb(t,6).show()&&i),"keydown"===n&&(i=!1!==e.Eb(t,6)._handleKeydown(l)&&i),"touchend"===n&&(i=!1!==e.Eb(t,6)._handleTouchend()&&i),i}),i.c,i.a)),e.rb(5,114688,null,0,s.b,[e.k,o.a,[2,a.d],[2,r.a],s.a],{color:[0,"color"],diameter:[1,"diameter"],mode:[2,"mode"],value:[3,"value"]},null),e.rb(6,212992,null,0,u.d,[c.c,e.k,h.b,e.O,e.y,o.a,d.c,d.h,u.b,[2,m.c],[2,u.a],[2,p.f]],{message:[0,"message"]},null),(t()(),e.sb(7,0,null,null,3,"div",[["class","orange"]],null,null,null,null,null)),(t()(),e.sb(8,16777216,null,null,2,"mat-progress-spinner",[["class","orange mat-progress-spinner"],["role","progressbar"],["style","position: absolute;"]],[[4,"transform",null],[2,"_mat-animation-noopable",null],[4,"width","px"],[4,"height","px"],[1,"aria-valuemin",0],[1,"aria-valuemax",0],[1,"aria-valuenow",0],[1,"mode",0]],[[null,"longpress"],[null,"keydown"],[null,"touchend"]],(function(t,n,l){var i=!0;return"longpress"===n&&(i=!1!==e.Eb(t,10).show()&&i),"keydown"===n&&(i=!1!==e.Eb(t,10)._handleKeydown(l)&&i),"touchend"===n&&(i=!1!==e.Eb(t,10)._handleTouchend()&&i),i}),i.c,i.a)),e.rb(9,114688,null,0,s.b,[e.k,o.a,[2,a.d],[2,r.a],s.a],{color:[0,"color"],diameter:[1,"diameter"],mode:[2,"mode"],value:[3,"value"]},null),e.rb(10,212992,null,0,u.d,[c.c,e.k,h.b,e.O,e.y,o.a,d.c,d.h,u.b,[2,m.c],[2,u.a],[2,p.f]],{message:[0,"message"]},null),(t()(),e.sb(11,0,null,null,3,"div",[["class","gray"]],null,null,null,null,null)),(t()(),e.sb(12,16777216,null,null,2,"mat-progress-spinner",[["class","mat-progress-spinner"],["role","progressbar"],["style","position: absolute;"]],[[4,"transform",null],[2,"_mat-animation-noopable",null],[4,"width","px"],[4,"height","px"],[1,"aria-valuemin",0],[1,"aria-valuemax",0],[1,"aria-valuenow",0],[1,"mode",0]],[[null,"longpress"],[null,"keydown"],[null,"touchend"]],(function(t,n,l){var i=!0;return"longpress"===n&&(i=!1!==e.Eb(t,14).show()&&i),"keydown"===n&&(i=!1!==e.Eb(t,14)._handleKeydown(l)&&i),"touchend"===n&&(i=!1!==e.Eb(t,14)._handleTouchend()&&i),i}),i.c,i.a)),e.rb(13,114688,null,0,s.b,[e.k,o.a,[2,a.d],[2,r.a],s.a],{color:[0,"color"],diameter:[1,"diameter"],mode:[2,"mode"],value:[3,"value"]},null),e.rb(14,212992,null,0,u.d,[c.c,e.k,h.b,e.O,e.y,o.a,d.c,d.h,u.b,[2,m.c],[2,u.a],[2,p.f]],{message:[0,"message"]},null),(t()(),e.sb(15,0,null,null,7,"div",[["class","d-flex flex-column justify-content-center mt-2"],["style","height: 218%;"]],[[4,"margin-left",null],[4,"width",null]],null,null,null,null)),(t()(),e.sb(16,0,null,null,4,"h5",[["class","h5Title"]],[[4,"margin",null],[4,"font-size","em"]],null,null,null,null)),e.Jb(512,null,a.z,a.A,[e.k,e.s,e.D]),e.rb(18,278528,null,0,a.o,[a.z],{ngStyle:[0,"ngStyle"]},null),e.Hb(19,{"text-align":0}),(t()(),e.Mb(20,null,[" "," "])),(t()(),e.hb(16777216,null,null,1,null,b)),e.rb(22,16384,null,0,a.l,[e.O,e.L],{ngIf:[0,"ngIf"]},null),(t()(),e.hb(16777216,null,null,1,null,f)),e.rb(24,16384,null,0,a.l,[e.O,e.L],{ngIf:[0,"ngIf"]},null)],(function(t,n){var l=n.component;t(n,5,0,"primary",l.diameter,"determinate",l.o.t),t(n,6,0,"Taux : "+l.o.t+"%"),t(n,9,0,"warn",l.diameter,"determinate",l.o.p*l.o.t/100),t(n,10,0,l.tooltipMsg(l.o.p,l.o.r,l.o.t)),t(n,13,0,"primary",l.diameter,"determinate",l.o.r*l.o.t/100),t(n,14,0,l.tooltipMsg(l.o.p,l.o.r,l.o.t));var e=t(n,19,0,l.isInForLoop?"center":0===l.retate?"left":"right");t(n,18,0,e),t(n,22,0,!l.isInForLoop),t(n,24,0,l.showLegend)}),(function(t,n){var l=n.component;t(n,4,0,"translateX("+l.transform+"%)",e.Eb(n,5)._noopAnimations,e.Eb(n,5).diameter,e.Eb(n,5).diameter,"determinate"===e.Eb(n,5).mode?0:null,"determinate"===e.Eb(n,5).mode?100:null,"determinate"===e.Eb(n,5).mode?e.Eb(n,5).value:null,e.Eb(n,5).mode),t(n,8,0,"translateX("+l.transform+"%)",e.Eb(n,9)._noopAnimations,e.Eb(n,9).diameter,e.Eb(n,9).diameter,"determinate"===e.Eb(n,9).mode?0:null,"determinate"===e.Eb(n,9).mode?100:null,"determinate"===e.Eb(n,9).mode?e.Eb(n,9).value:null,e.Eb(n,9).mode),t(n,12,0,"translateX("+l.transform+"%)",e.Eb(n,13)._noopAnimations,e.Eb(n,13).diameter,e.Eb(n,13).diameter,"determinate"===e.Eb(n,13).mode?0:null,"determinate"===e.Eb(n,13).mode?100:null,"determinate"===e.Eb(n,13).mode?e.Eb(n,13).value:null,e.Eb(n,13).mode),t(n,15,0,l.marginLeftTitle,l.widthText),t(n,16,0,l.marginh5Title,l.fontSize),t(n,20,0,l.o.name)}))}},loLo:function(t,n,l){"use strict";var e=l("8Y7J"),i=l("SVse"),s=l("Mz6y"),o=l("QQfA"),a=l("hOhj"),r=l("/HVE"),u=l("5GAg"),c=l("IP0z"),h=l("cUpR");l("aQXj"),l("J3i2"),l("s6ns"),l.d(n,"a",(function(){return d})),l.d(n,"b",(function(){return p}));var d=e.qb({encapsulation:0,styles:[".ValeurGraph[_ngcontent-%COMP%]\n  {\n    margin-top: 10%;\n    color: #fff;\n  }",[".miniBarProgress[_ngcontent-%COMP%]{background-color:#8a898a;height:100%;position:absolute;top:0;left:0}.miniBar[_ngcontent-%COMP%]{height:.85rem;position:relative;width:calc(100% - 2rem);margin-right:.5rem}"]],data:{}});function m(t){return e.Ob(0,[(t()(),e.sb(0,0,null,null,0,"img",[["height","10px"],["src","assets/line.png"],["width","280px"]],null,null,null,null,null))],null,null)}function p(t){return e.Ob(0,[(t()(),e.sb(0,0,null,null,13,"div",[["class","mb-3"],["style","cursor: pointer;"]],null,[[null,"click"]],(function(t,n,l){var e=!0;return"click"===n&&(e=!1!==t.component.openDialog()&&e),e}),null,null)),(t()(),e.sb(1,0,null,null,12,"div",[["class","row"]],null,null,null,null,null)),(t()(),e.sb(2,0,null,null,5,"div",[["class","col-md-5"]],null,null,null,null,null)),(t()(),e.sb(3,0,null,null,4,"div",[["class","d-flex flex-column justify-content-center mt-2"]],null,null,null,null,null)),(t()(),e.hb(16777216,null,null,1,null,m)),e.rb(5,16384,null,0,i.l,[e.O,e.L],{ngIf:[0,"ngIf"]},null),(t()(),e.sb(6,0,null,null,1,"h5",[["style","color: #737473; margin: 5px 0 10px 5px;"]],null,null,null,null,null)),(t()(),e.Mb(7,null,[" "," "])),(t()(),e.sb(8,0,null,null,5,"div",[["class","col-md-7"]],null,null,null,null,null)),(t()(),e.sb(9,16777216,null,null,4,"div",[["class","miniBar"],["style","height: 30px; margin-left: 3%;"]],[[4,"transform",null]],[[null,"longpress"],[null,"keydown"],[null,"touchend"]],(function(t,n,l){var i=!0;return"longpress"===n&&(i=!1!==e.Eb(t,10).show()&&i),"keydown"===n&&(i=!1!==e.Eb(t,10)._handleKeydown(l)&&i),"touchend"===n&&(i=!1!==e.Eb(t,10)._handleTouchend()&&i),i}),null,null)),e.rb(10,212992,null,0,s.d,[o.c,e.k,a.b,e.O,e.y,r.a,u.c,u.h,s.b,[2,c.c],[2,s.a],[2,h.f]],{message:[0,"message"]},null),(t()(),e.sb(11,0,null,null,0,"div",[["class","miniBarProgress"],["style","z-index: 1; background-color: var(--primary);"]],[[4,"width","%"]],null,null,null,null)),(t()(),e.sb(12,0,null,null,0,"div",[["class","miniBarProgress"],["style","z-index: 2; background-color: #d17c36;"]],[[4,"width","%"]],null,null,null,null)),(t()(),e.sb(13,0,null,null,0,"div",[["class","miniBarProgress"],["style","z-index: 2; background-color:gray;"]],[[4,"width","%"]],null,null,null,null))],(function(t,n){var l=n.component;t(n,5,0,!1),t(n,10,0,l.tooltipMsg(l.widthOne,l.widthThree,l.widthTwo))}),(function(t,n){var l=n.component;t(n,7,0,l.title),t(n,9,0,"rotateY("+l.rotateY+"deg)"),t(n,11,0,l.widthTwo),t(n,12,0,l.widthOne*l.widthTwo/100),t(n,13,0,l.widthThree*l.widthTwo/100)}))}},"m+JQ":function(t,n,l){"use strict";l.d(n,"a",(function(){return e}));class e{constructor(t,n){this.dialogRef=t,this.data=n,this.title=""}ngOnInit(){this.o=this.data.model,this.title=this.data.title,console.log(this.o)}onNoClick(){this.dialogRef.close()}onOkClick(t){}}},oTHA:function(t,n,l){"use strict";l.d(n,"a",(function(){return s}));var e=l("XNiG"),i=l("DDG+");class s{constructor(t,n){this.mytranslate=t,this.dialog=n,this.title="",this.barChartOptions={responsive:!0,title:{text:"",display:!0},scales:{xAxes:[{}],yAxes:[{ticks:{beginAtZero:!0}}]}},this.barChartLabels=[],this.barChartType="bar",this.barChartLegend=!0,this.barChartData=[{data:[],label:""}],this.pieChartColors=[{backgroundColor:"#d17c36"},{backgroundColor:"#2d71a1"},{backgroundColor:"gray"}],this.dataSubject=new e.a,this.retate=0,this.list=[]}ngOnInit(){this.mytranslate.lang.subscribe(t=>{this.retate="fr"===t?0:180}),this.dataSubject.subscribe(t=>{this.title=t.title,this.barChartLabels=t.barChartLabels,this.barChartData=t.barChartData,this.barChartLabels.forEach((t,n)=>{this.list.push({name:t.toString(),p:this.barChartData.find(t=>"En cours"===t.label).data[n],t:this.barChartData.find(t=>"Taux"===t.label).data[n],r:this.barChartData.find(t=>"R\xe9alis\xe9"===t.label).data[n]})})})}openDialog(){this.dialog.open(i.a,{width:"7100px",disableClose:!1,data:{model:this.list,type:"bar",title:this.title}}).afterClosed().subscribe(t=>{console.log(t)})}chartClicked({}){}chartHovered({}){}randomize(){this.barChartType="bar"===this.barChartType?"line":"bar"}getColors(t){const n=["#0074D9","#FF4136","#2ECC40","#FF851B","#7FDBFF","#B10DC9","#FFDC00","#001f3f","#39CCCC","#01FF70","#85144b","#F012BE","#3D9970","#111111","#AAAAAA"],l=[];for(let e=0;e<t;e++)l.push(n[e%n.length]);return l}}},ondm:function(t,n,l){"use strict";l.d(n,"a",(function(){return s})),l.d(n,"b",(function(){return o}));var e=l("8Y7J"),i=l("zQui"),s=(l("SVse"),l("IP0z"),l("/HVE"),e.qb({encapsulation:2,styles:[],data:{}}));function o(t){return e.Ob(0,[e.Kb(402653184,1,{_rowOutlet:0}),e.Kb(402653184,2,{_headerRowOutlet:0}),e.Kb(402653184,3,{_footerRowOutlet:0}),e.Db(null,0),(t()(),e.sb(4,16777216,null,null,1,null,null,null,null,null,null,null)),e.rb(5,16384,[[2,4]],0,i.t,[e.O,e.k],null,null),(t()(),e.sb(6,16777216,null,null,1,null,null,null,null,null,null,null)),e.rb(7,16384,[[1,4]],0,i.r,[e.O,e.k],null,null),(t()(),e.sb(8,16777216,null,null,1,null,null,null,null,null,null,null)),e.rb(9,16384,[[3,4]],0,i.s,[e.O,e.k],null,null)],null,null)}},oz3B:function(t,n,l){"use strict";l.d(n,"a",(function(){return a}));var e=l("hrfs"),i=l("XNiG"),s=l("HDdC"),o=l("DDG+");class a{constructor(t,n,l){this.uow=t,this.mytranslate=n,this.dialog=l,this.obs=new i.a,this.showLegend=!1,this.withGraphe=0,this.title=null,this.pieChartOptions={responsive:!0,title:{text:"",display:!0},tooltips:{enabled:!0},legend:{position:"top",display:!0,align:"center"}},this.pieChartLabels=[],this.pieChartData=[],this.pieChartType="pie",this.pieChartLegend=!0,this.pieChartPlugins=[],this.pieChartColors=[{backgroundColor:[]}],this.list=[],this.retate=0,Object(e.e)(),Object(e.d)()}ngOnInit(){this.mytranslate.lang.subscribe(t=>{this.retate="fr"===t?0:180}),this.pieChartOptions.legend.display=this.showLegend,this.obs.subscribe(t=>{t.title instanceof s.a?t.title.subscribe(t=>this.title=t):this.title=t.title,this.uow.recommendations.genericByRecommendation(t.table,t.type).subscribe(t=>{this.pieChartLabels=t.map(t=>t.table),this.pieChartData=t.map(t=>+t.value.toFixed(0)),this.pieChartColors[0].backgroundColor=this.getColors(this.pieChartLabels.length),this.pieChartLabels.forEach((t,n)=>{0!==this.pieChartData[n]&&this.list.push({name:t.toString(),value:this.pieChartData[n]})})})})}openDialog(){this.dialog.open(o.a,{width:"7100px",disableClose:!1,data:{model:this.list,type:"pie",title:this.title}}).afterClosed().subscribe(t=>{console.log(t)})}getColors(t){const n=["#d97f2a","#2d71a1","#c2c3c6","#ba6446","#7dc460","#fdb93a","#59b8ce","#5c5c5f","#ef4f42","#a5a6aa"],l=[];for(let e=0;e<t;e++)l.push(n[e%n.length]);return l}}},pRjZ:function(t,n,l){"use strict";l.d(n,"a",(function(){return s}));var e=l("8Y7J"),i=l("dFDH");let s=(()=>{class t{constructor(t){this.snackBar=t,this.afterDismissed=()=>this.snackBarRef.afterDismissed(),this.onAction=()=>this.snackBarRef.onAction(),this.dismiss=()=>this.snackBarRef.dismiss()}openMySnackBar(t,n){this.snackBarRef=this.snackBar.openFromComponent(o,{panelClass:["customClass"],data:t})}openSnackBar(t,n="close"){this.snackBarRef=this.snackBar.open(t,n,{duration:1e4})}}return t.ngInjectableDef=e.Sb({factory:function(){return new t(e.Tb(i.b))},token:t,providedIn:"root"}),t})();class o{constructor(t){this.data=t}}},xjdI:function(t,n,l){"use strict";l.d(n,"a",(function(){return o}));var e=l("8Y7J"),i=l("0hB7"),s=l("iInd");let o=(()=>{class t{constructor(t,n){this.session=t,this.router=n}canActivate(t,n){return console.log(n),!(n.url.includes("update")&&!this.session.isAdmin&&!this.session.isProprietaire&&(this.router.navigate(["/admin"]),1))}}return t.ngInjectableDef=e.Sb({factory:function(){return new t(e.Tb(i.a),e.Tb(s.m))},token:t,providedIn:"root"}),t})()}}]);