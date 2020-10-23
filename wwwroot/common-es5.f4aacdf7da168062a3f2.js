var __generator=this&&this.__generator||function(t,e){var n,i,o,r,s={label:0,sent:function(){if(1&o[0])throw o[1];return o[1]},trys:[],ops:[]};return r={next:a(0),throw:a(1),return:a(2)},"function"==typeof Symbol&&(r[Symbol.iterator]=function(){return this}),r;function a(r){return function(a){return function(r){if(n)throw new TypeError("Generator is already executing.");for(;s;)try{if(n=1,i&&(o=2&r[0]?i.return:r[0]?i.throw||((o=i.return)&&o.call(i),0):i.next)&&!(o=o.call(i,r[1])).done)return o;switch(i=0,o&&(r=[2&r[0],o.value]),r[0]){case 0:case 1:o=r;break;case 4:return s.label++,{value:r[1],done:!1};case 5:s.label++,i=r[1],r=[0];continue;case 7:r=s.ops.pop(),s.trys.pop();continue;default:if(!(o=(o=s.trys).length>0&&o[o.length-1])&&(6===r[0]||2===r[0])){s=0;continue}if(3===r[0]&&(!o||r[1]>o[0]&&r[1]<o[3])){s.label=r[1];break}if(6===r[0]&&s.label<o[1]){s.label=o[1],o=r;break}if(o&&s.label<o[2]){s.label=o[2],s.ops.push(r);break}o[2]&&s.ops.pop(),s.trys.pop();continue}r=e.call(t,s)}catch(a){r=[6,a],i=0}finally{n=o=0}if(5&r[0])throw r[1];return{value:r[0]?r[1]:void 0,done:!0}}([r,a])}}};(window.webpackJsonp=window.webpackJsonp||[]).push([[4],{"5nPQ":function(t,e,n){"use strict";n.d(e,"a",(function(){return r}));var i=n("mrSG"),o=n("XNiG"),r=function(){function t(t){this.filesService=t,this.listOfNames=[],this.listToDelete=[],this.files=[],this.nameBtn="",this.folderToSaveInServer="folder",this.propertyOfParent=new o.a,this.eventSubmitToParent=new o.a,this.eventSubmitFromParent=new o.a}return t.prototype.ngOnInit=function(){var t=this;this.propertyOfParent.subscribe((function(e){if(e){var n=e.split(";");n.pop(),t.listOfNames=n,t.listToDelete=[]}})),this.eventSubmitFromParent.subscribe((function(e){return i.a(t,void 0,void 0,(function(){return __generator(this,(function(t){switch(t.label){case 0:return[4,this.submit()];case 1:return t.sent(),[2]}}))}))}))},t.prototype.upload=function(t){for(var e=0;e<t.length;e++){var n=t.item(e);this.listOfNames.push(this.setFileName(n)),this.sendPropertyOfParent(),this.files.push(n)}},t.prototype.setIcon=function(t){var e=t.lastIndexOf("."),n=t.substring(e+1);return"pdf"===n||"pdf;"===n?"assets/svg/pdf.svg":"assets/svg/word.svg"},t.prototype.remove=function(t){var e=this.listOfNames.findIndex((function(e){return e===t}));-1!==e&&(this.listOfNames.splice(e,1),this.sendPropertyOfParent()),this.listToDelete.push(t);var n=t.indexOf("_"),i=t.substring(n);-1!==this.files.findIndex((function(t){return t.name===i}))&&this.files.splice(e,1)},t.prototype.openInput=function(t){t.click()},t.prototype.sendPropertyOfParent=function(){var t="";this.listOfNames.forEach((function(e){t+=e+";"})),this.eventSubmitToParent.next(t)},t.prototype.submit=function(){return i.a(this,void 0,void 0,(function(){var t,e=this;return __generator(this,(function(n){switch(n.label){case 0:return t=new FormData,this.files.forEach((function(n){var i=e.setFileName(n);t.append(i,n,i)})),t?[4,this.filesService.uploadFiles(t,this.folderToSaveInServer).toPromise()]:[3,3];case 1:return n.sent(),[4,this.filesService.deleteFiles(this.listToDelete,this.folderToSaveInServer).toPromise()];case 2:n.sent(),n.label=3;case 3:return[2]}}))}))},t.prototype.setFileName=function(t){return t.lastModified+"_"+t.name},t}()},"A/Kj":function(t,e,n){"use strict";var i=n("8Y7J"),o=n("bujt"),r=n("Fwaw"),s=n("5GAg"),a=n("omvX"),l=n("Mr+X"),u=n("Gi4r"),c=n("SVse");n("5nPQ"),n("WTxg"),n.d(e,"a",(function(){return p})),n.d(e,"b",(function(){return m}));var p=i.qb({encapsulation:0,styles:[["img[_ngcontent-%COMP%]{height:20px}"]],data:{}});function d(t){return i.Ob(0,[(t()(),i.sb(0,0,null,null,7,"p",[["style","font-size: .7em;margin: 0;"]],null,null,null,null,null)),(t()(),i.sb(1,0,null,null,0,"img",[["alt","pdf/word"]],[[8,"src",4]],null,null,null,null)),(t()(),i.Mb(2,null,[" - "," "])),(t()(),i.sb(3,0,null,null,4,"button",[["color","warn"],["mat-icon-button",""],["type","button"]],[[1,"disabled",0],[2,"_mat-animation-noopable",null]],[[null,"click"]],(function(t,e,n){var i=!0;return"click"===e&&(i=!1!==t.component.remove(t.context.$implicit)&&i),i}),o.b,o.a)),i.rb(4,180224,null,0,r.b,[i.k,s.h,[2,a.a]],{color:[0,"color"]},null),(t()(),i.sb(5,0,null,0,2,"mat-icon",[["class","mat-icon notranslate"],["role","img"],["style","font-size: 1.3em !important;"]],[[2,"mat-icon-inline",null],[2,"mat-icon-no-color",null]],null,null,l.b,l.a)),i.rb(6,9158656,null,0,u.b,[i.k,u.d,[8,null],[2,u.a],[2,i.l]],null,null),(t()(),i.Mb(-1,0,["delete_sweep"]))],(function(t,e){t(e,4,0,"warn"),t(e,6,0)}),(function(t,e){t(e,1,0,e.component.setIcon(e.context.$implicit));var n=e.context.$implicit.substring(14);t(e,2,0,n),t(e,3,0,i.Eb(e,4).disabled||null,"NoopAnimations"===i.Eb(e,4)._animationMode),t(e,5,0,i.Eb(e,6).inline,"primary"!==i.Eb(e,6).color&&"accent"!==i.Eb(e,6).color&&"warn"!==i.Eb(e,6).color)}))}function m(t){return i.Ob(0,[(t()(),i.sb(0,0,null,null,13,"div",[["class","row"]],null,null,null,null,null)),(t()(),i.sb(1,0,null,null,12,"div",[["class","col-md-12 mb-3"]],null,null,null,null,null)),(t()(),i.sb(2,0,null,null,11,"div",[["class","myrow"]],null,null,null,null,null)),(t()(),i.sb(3,0,[["file1",1]],null,0,"input",[["accept","application/pdf,.doc,.docx,application/msword,application/vnd.openxmlformats-officedocument.wordprocessingml.document"],["hidden",""],["multiple","false"],["style","display: none;"],["type","file"]],null,[[null,"change"]],(function(t,e,n){var o=!0;return"change"===e&&(o=!1!==t.component.upload(i.Eb(t,3).files)&&o),o}),null,null)),(t()(),i.sb(4,0,null,null,5,"button",[["color","accent"],["mat-raised-button",""],["type","button"]],[[1,"disabled",0],[2,"_mat-animation-noopable",null]],[[null,"click"]],(function(t,e,n){var o=!0;return"click"===e&&(o=!1!==t.component.openInput(i.Eb(t,3))&&o),o}),o.b,o.a)),i.rb(5,180224,null,0,r.b,[i.k,s.h,[2,a.a]],{color:[0,"color"]},null),(t()(),i.sb(6,0,null,0,2,"mat-icon",[["class","mat-icon notranslate"],["role","img"]],[[2,"mat-icon-inline",null],[2,"mat-icon-no-color",null]],null,null,l.b,l.a)),i.rb(7,9158656,null,0,u.b,[i.k,u.d,[8,null],[2,u.a],[2,i.l]],null,null),(t()(),i.Mb(-1,0,["add"])),(t()(),i.Mb(9,0,[" "," "])),(t()(),i.Mb(-1,null,[" \xa0\xa0 "])),(t()(),i.sb(11,0,null,null,2,"div",[["class","myrow"]],null,null,null,null,null)),(t()(),i.hb(16777216,null,null,1,null,d)),i.rb(13,278528,null,0,c.k,[i.O,i.L,i.r],{ngForOf:[0,"ngForOf"]},null)],(function(t,e){var n=e.component;t(e,5,0,"accent"),t(e,7,0),t(e,13,0,n.listOfNames)}),(function(t,e){var n=e.component;t(e,4,0,i.Eb(e,5).disabled||null,"NoopAnimations"===i.Eb(e,5)._animationMode),t(e,6,0,i.Eb(e,7).inline,"primary"!==i.Eb(e,7).color&&"accent"!==i.Eb(e,7).color&&"warn"!==i.Eb(e,7).color),t(e,9,0,n.nameBtn)}))}},F76L:function(t,e,n){"use strict";n.d(e,"a",(function(){return c})),n.d(e,"b",(function(){return p}));var i=n("mrSG"),o=n("m+JQ"),r=n("8Y7J"),s=n("VRyK"),a=(n("ukCm"),n("s7LF")),l=n("eIep"),u=n("ZTdd"),c=function(){function t(t,e,n,i,o,s,l,u){this.uow=t,this.dialog=e,this.mydialog=n,this.mytranslate=i,this.fb=o,this.session=s,this.route=l,this.bottomSheet=u,this.update=new r.m,this.isLoadingResults=!0,this.resultsLength=0,this.isRateLimitReached=!1,this.dataSource=[],this.columnDefs=[{columnDef:"codeRecommendation",headName:"CODE"},{columnDef:"nom",headName:"INTITULE"},{columnDef:"mecanisme",headName:"mecanisme"},{columnDef:"axe",headName:"Axe"},{columnDef:"sousAxe",headName:"SOUS AXE"},{columnDef:"organismes",headName:"DEPARTEMENT"},{columnDef:"etat",headName:"ETAT DE MISE EN OEUVRE"},{columnDef:"complement",headName:""},{columnDef:"pieceJointe",headName:""},{columnDef:"option",headName:""}].map((function(t){return t.headName=""===t.headName?t.columnDef.toUpperCase():t.headName.toUpperCase(),t})),this.panelOpenState=!1,this.organismes=this.uow.organismes.get(),this.axes=this.uow.axes.get(),this.sousAxes=[],this.mecanismes=this.uow.mecanismes,this.visites=this.uow.visites.get(),this.organes=this.uow.organes.get(),this.pays=this.uow.pays.get(),this.cycles=this.uow.cycles.get(),this.etats=this.uow.etats,this.departementList=[],this.displayedColumns=this.columnDefs.map((function(t){return t.columnDef})),this.progress=0,this.formData=new FormData,this.o=new p,this.myAuto=new a.f("")}return t.prototype.ngOnInit=function(){var t=this;this.createForm(),this.isLoadingResults=!1,Object(s.a)(this.sort.sortChange,this.paginator.page,this.update).subscribe((function(e){!0===e?t.paginator.pageIndex=0:e=e,t.paginator.pageSize?e=e:t.paginator.pageSize=10,t.o.startIndex=t.paginator.pageIndex*t.paginator.pageSize,t.o.pageSize=t.paginator.pageSize,t.o.sortBy=t.sort.active?t.sort.active:"id",t.o.sortDir=t.sort.direction?t.sort.direction:"desc",t.isLoadingResults=!0,t.searchAndGet(t.o)})),this.route.queryParams.subscribe((function(e){var n=e.data;n&&t.uow.recommendations.getDetail(n).subscribe((function(e){t.openDialog(e)}))})),this.autoComplete()},t.prototype.displayFrIfArNull=function(t,e){return e&&0!==e.length?e:t},t.prototype.displayMulti=function(t,e){return"fr"===this.mytranslate.langSync?{m:t,e:e}:{m:[{fr:"Examen p\xe9riodique universal",ar:"\u0627\u0644\u0627\u0633\u062a\u0639\u0631\u0627\u0636 \u0627\u0644\u062f\u0648\u0631\u064a \u0627\u0644\u0634\u0627\u0645\u0644"},{fr:"Organes de Trait\xe9s",ar:"\u0647\u064a\u0626\u0627\u062a \u0627\u0644\u0645\u0639\u0627\u0647\u062f\u0627\u062a"},{fr:"Proc\xe9dures sp\xe9ciales",ar:"\u0627\u0644\u0627\u062c\u0631\u0627\u0621\u0627\u062a \u0627\u0644\u062e\u0627\u0635\u0629"}].find((function(e){return t.toLowerCase().includes(e.fr.toLowerCase().substring(0,6))})).ar,e:[{fr:"R\xe9alis\xe9",ar:"\u0645\u0646\u062c\u0632"},{fr:"Non R\xe9alis\xe9",ar:"\u063a\u064a\u0631 \u0645\u0646\u062c\u0632"},{fr:"En cours",ar:"\u0641\u064a \u0637\u0648\u0631 \u0627\u0644\u0625\u0646\u062c\u0627\u0632"}].find((function(t){return t.fr.toLowerCase()===e.toLowerCase()})).ar}},t.prototype.autoComplete=function(){var t=this;this.filteredOptions=this.myAuto.valueChanges.pipe(Object(l.a)((function(e){return e.length>1?t.uow.organismes.autocompletePost("label",e):[]})))},t.prototype.selected=function(t){var e=t.option.value;console.log(e),this.myAuto.setValue(e.label),this.myForm.get("idOrganisme").setValue(e.id)},t.prototype.createForm=function(){this.myForm=this.fb.group({idOrganisme:this.o.idOrganisme,mecanisme:this.o.mecanisme,idCycle:this.o.idCycle,idOrgane:this.o.idOrgane,idVisite:this.o.idVisite,idAxe:this.o.idAxe,nom:this.o.nom,etat:this.o.etat,idPays:this.o.idPays,idSousAxe:this.o.idSousAxe,startIndex:this.o.startIndex,pageSize:this.o.pageSize,sortBy:this.o.sortBy,sortDir:this.o.sortDir})},Object.defineProperty(t.prototype,"mecanisme",{get:function(){return this.myForm.get("mecanisme")},enumerable:!0,configurable:!0}),Object.defineProperty(t.prototype,"idVisite",{get:function(){return this.myForm.get("idVisite")},enumerable:!0,configurable:!0}),Object.defineProperty(t.prototype,"idCycle",{get:function(){return this.myForm.get("idCycle")},enumerable:!0,configurable:!0}),Object.defineProperty(t.prototype,"idOrgane",{get:function(){return this.myForm.get("idOrgane")},enumerable:!0,configurable:!0}),Object.defineProperty(t.prototype,"cycleActive",{get:function(){return"Examen p\xe9riodique universal"===this.mecanisme.value},enumerable:!0,configurable:!0}),Object.defineProperty(t.prototype,"visiteActive",{get:function(){return"Proc\xe9dure sp\xe9ciale"===this.mecanisme.value},enumerable:!0,configurable:!0}),Object.defineProperty(t.prototype,"organeActive",{get:function(){return"Organes de trait\xe9s"===this.mecanisme.value},enumerable:!0,configurable:!0}),t.prototype.selectChange=function(t){this.idVisite.setValue(0),this.idCycle.setValue(0),this.idOrgane.setValue(0)},t.prototype.reset=function(){this.o=new p,this.createForm(),this.searchAndGet(this.o)},t.prototype.search=function(t){this.searchAndGet(t)},t.prototype.detail=function(t){var e=this;this.uow.recommendations.getDetail(t.id).subscribe((function(t){e.openDialog(t)}))},t.prototype.openDialog=function(t){return this.dialog.open(o.a,{width:"7100px",disableClose:!0,data:{model:t,title:"Recommdandation"}}).afterClosed()},t.prototype.stateDepartement=function(t){console.log(t),(t=t.filter((function(t){return null!==t.name}))).filter((function(t){return"PE"===t.type})).map((function(t){return t.name})),t.filter((function(t){return"IN"===t.type})).map((function(t){return t.name})),t.filter((function(t){return"PG"===t.type})).map((function(t){return t.name})),t.filter((function(t){return"Autre"===t.type})).map((function(t){return t.name}));var e=[{data:[],label:this.mytranslate.get("admin.organe.list.Etatavancement")},{data:[],label:this.mytranslate.get("admin.organe.list.R\xe9alis\xe9")},{data:[],label:"Non r\xe9alis\xe9"}],n=e,i=e,o=e;t.forEach((function(t){"PE"===t.type?(e[0].data.push((t.p*t.t/100).toFixed(0)),e[1].data.push((t.r*t.t/100).toFixed(0)),e[2].data.push((t.t-t.p*t.t/100-t.r*t.t/100).toFixed(0))):"Autre"===t.type?(o[0].data.push((t.p*t.t/100).toFixed(0)),o[1].data.push((t.r*t.t/100).toFixed(0)),o[2].data.push((t.t-t.p*t.t/100-t.r*t.t/100).toFixed(0))):"IN"===t.type?(n[0].data.push((t.p*t.t/100).toFixed(0)),n[1].data.push((t.r*t.t/100).toFixed(0)),n[2].data.push((t.t-t.p*t.t/100-t.r*t.t/100).toFixed(0))):"PJ"===t.type&&(i[0].data.push((t.p*t.t/100).toFixed(0)),i[1].data.push((t.r*t.t/100).toFixed(0)),i[2].data.push((t.t-t.p*t.t/100-t.r*t.t/100).toFixed(0)))}))},t.prototype.searchAndGet=function(t){var e=this;console.log(t),this.o=t,this.o.idOrganisme=this.session.isPointFocal||this.session.isProprietaire?this.session.user.idOrganisme:this.o.idOrganisme,this.uow.recommendations.searchAndGet(this.o).subscribe((function(t){console.log(t.list),e.dataSource=t.list,e.resultsLength=t.count,e.isLoadingResults=!1,e.stateDepartement(e.departementList)}),(function(t){return e.isLoadingResults=!1}))},t.prototype.delete=function(t){return i.a(this,void 0,void 0,(function(){var e,n,i=this;return __generator(this,(function(o){switch(o.label){case 0:return e="ok",[4,this.mydialog.openDialog("recommandation").toPromise()];case 1:return e===o.sent()&&(n=[],""!==t.pieceJointe?n.push.apply(n,this.uow.decoupe(t.pieceJointe)):n=n,this.uow.files.deleteFiles(n,"recommandation").subscribe((function(e){i.uow.recommendations.delete(t.id).subscribe((function(){return i.update.next(!0)}))}))),[2]}}))}))},t.prototype.showPieceJoin=function(t){this.bottomSheet.open(u.a,{data:{fileName:t,folder:"recommandation"}})},t.prototype.axeChange=function(t){var e=this;this.uow.sousAxes.getByIdAxe(t).subscribe((function(t){e.sousAxes=t}))},Object.defineProperty(t.prototype,"isAllEmpty",{get:function(){return"0"===this.myForm.get("idAxe").value.toString()&&"0"===this.myForm.get("idCycle").value.toString()&&"0"===this.myForm.get("idSousAxe").value.toString()&&"0"===this.myForm.get("idOrganisme").value.toString()&&"0"===this.myForm.get("idOrgane").value.toString()&&"0"===this.myForm.get("idPays").value.toString()&&""===this.myForm.get("nom").value.toString()&&""===this.myForm.get("etat").value.toString()&&"0"===this.myForm.get("idVisite").value.toString()&&""===this.myForm.get("mecanisme").value.toString()},enumerable:!0,configurable:!0}),t}(),p=function(){this.idAxe=0,this.idSousAxe=0,this.idOrganisme=0,this.mecanisme="",this.idCycle=0,this.idOrgane=0,this.idVisite=0,this.nom="",this.etat="",this.idPays=0,this.startIndex=0,this.pageSize=10,this.sortBy="id",this.sortDir="desc"}},Rn7m:function(t,e,n){"use strict";n.d(e,"a",(function(){return r})),n.d(e,"b",(function(){return a}));var i=n("8Y7J"),o=(n("/Co4"),n("SVse")),r=(n("QQfA"),n("IP0z"),n("Xd0L"),n("cUpR"),n("/HVE"),n("zMNK"),n("hOhj"),i.qb({encapsulation:2,styles:[".mat-autocomplete-panel{min-width:112px;max-width:280px;overflow:auto;-webkit-overflow-scrolling:touch;visibility:hidden;max-width:none;max-height:256px;position:relative;width:100%;border-bottom-left-radius:4px;border-bottom-right-radius:4px}.mat-autocomplete-panel.mat-autocomplete-visible{visibility:visible}.mat-autocomplete-panel.mat-autocomplete-hidden{visibility:hidden}.mat-autocomplete-panel-above .mat-autocomplete-panel{border-radius:0;border-top-left-radius:4px;border-top-right-radius:4px}.mat-autocomplete-panel .mat-divider-horizontal{margin-top:-1px}@media (-ms-high-contrast:active){.mat-autocomplete-panel{outline:solid 1px}}"],data:{}}));function s(t){return i.Ob(0,[(t()(),i.sb(0,0,[[2,0],["panel",1]],null,3,"div",[["class","mat-autocomplete-panel"],["role","listbox"]],[[8,"id",0]],null,null,null,null)),i.Jb(512,null,o.x,o.y,[i.r,i.s,i.k,i.D]),i.rb(2,278528,null,0,o.j,[o.x],{klass:[0,"klass"],ngClass:[1,"ngClass"]},null),i.Db(null,0)],(function(t,e){t(e,2,0,"mat-autocomplete-panel",e.component._classList)}),(function(t,e){t(e,0,0,e.component.id)}))}function a(t){return i.Ob(2,[i.Kb(402653184,1,{template:0}),i.Kb(671088640,2,{panel:0}),(t()(),i.hb(0,[[1,2]],null,0,null,s))],null,null)}},"m+JQ":function(t,e,n){"use strict";n.d(e,"a",(function(){return i}));var i=function(){function t(t,e){this.dialogRef=t,this.data=e,this.title=""}return t.prototype.ngOnInit=function(){this.o=this.data.model,this.title=this.data.title,console.log(this.o)},t.prototype.onNoClick=function(){this.dialogRef.close()},t.prototype.onOkClick=function(t){},t}()},ondm:function(t,e,n){"use strict";n.d(e,"a",(function(){return r})),n.d(e,"b",(function(){return s}));var i=n("8Y7J"),o=n("zQui"),r=(n("SVse"),n("IP0z"),n("/HVE"),i.qb({encapsulation:2,styles:[],data:{}}));function s(t){return i.Ob(0,[i.Kb(402653184,1,{_rowOutlet:0}),i.Kb(402653184,2,{_headerRowOutlet:0}),i.Kb(402653184,3,{_footerRowOutlet:0}),i.Db(null,0),(t()(),i.sb(4,16777216,null,null,1,null,null,null,null,null,null,null)),i.rb(5,16384,[[2,4]],0,o.t,[i.O,i.k],null,null),(t()(),i.sb(6,16777216,null,null,1,null,null,null,null,null,null,null)),i.rb(7,16384,[[1,4]],0,o.r,[i.O,i.k],null,null),(t()(),i.sb(8,16777216,null,null,1,null,null,null,null,null,null,null)),i.rb(9,16384,[[3,4]],0,o.s,[i.O,i.k],null,null)],null,null)}},pRjZ:function(t,e,n){"use strict";n.d(e,"a",(function(){return r}));var i=n("8Y7J"),o=n("dFDH"),r=function(){var t=function(){function t(t){var e=this;this.snackBar=t,this.afterDismissed=function(){return e.snackBarRef.afterDismissed()},this.onAction=function(){return e.snackBarRef.onAction()},this.dismiss=function(){return e.snackBarRef.dismiss()}}return t.prototype.openMySnackBar=function(t,e){this.snackBarRef=this.snackBar.openFromComponent(s,{panelClass:["customClass"],data:t})},t.prototype.openSnackBar=function(t,e){void 0===e&&(e="close"),this.snackBarRef=this.snackBar.open(t,e,{duration:1e4})},t}();return t.ngInjectableDef=i.Sb({factory:function(){return new t(i.Tb(o.b))},token:t,providedIn:"root"}),t}(),s=function(t){this.data=t}},xjdI:function(t,e,n){"use strict";n.d(e,"a",(function(){return s}));var i=n("8Y7J"),o=n("0hB7"),r=n("iInd"),s=function(){var t=function(){function t(t,e){this.session=t,this.router=e}return t.prototype.canActivate=function(t,e){return console.log(e),!(e.url.includes("update")&&!this.session.isAdmin&&!this.session.isProprietaire&&(this.router.navigate(["/admin"]),1))},t}();return t.ngInjectableDef=i.Sb({factory:function(){return new t(i.Tb(o.a),i.Tb(r.m))},token:t,providedIn:"root"}),t}()}}]);