(window.webpackJsonp=window.webpackJsonp||[]).push([[0],{"2HI4":function(t,e,i){"use strict";i.d(e,"a",function(){return c});var n=i("fXoL"),s=i("J3i2"),o=i("tk/3"),r=i("ofXK");let c=(()=>{class t{constructor(t,e){this.mytranslate=t,this.http=e,this.text="",this.text2="",this.length=400,this.mecanisme=""}ngOnInit(){this.mytranslate.lang.subscribe(t=>{this.http.get(`assets/htmls/${"fr"===t?this.mecanisme+"_fr":this.mecanisme+"_ar"}.html`,{responseType:"text"}).subscribe(t=>{this.text=t,this.text2=this.text.substring(0,this.length)})})}moreInfo(){this.text2=this.text2.length===this.length?this.text:this.text.substring(0,this.length)}}return t.\u0275fac=function(e){return new(e||t)(n.Nb(s.a),n.Nb(o.b))},t.\u0275cmp=n.Hb({type:t,selectors:[["app-intros"]],inputs:{mecanisme:"mecanisme"},decls:6,vars:4,consts:[[2,"color","#737473","margin","20px 5px"],[2,"font-size","1.5em",3,"innerHTML"],[2,"color","#286293","cursor","pointer","font-size","1.5em",3,"click"]],template:function(t,e){1&t&&(n.Tb(0,"section"),n.Tb(1,"h5",0),n.Ob(2,"span",1),n.Tb(3,"b",2),n.ac("click",function(){return e.moreInfo()}),n.Dc(4),n.fc(5,"async"),n.Sb(),n.Sb(),n.Sb()),2&t&&(n.Bb(2),n.kc("innerHTML",e.text2,n.tc),n.Bb(2),n.Fc(" ","fr"===n.gc(5,2,e.mytranslate.lang)?e.text2.length===e.length?"Lire la suite":"R\xe9duire":e.text2.length===e.length?"\u0627\u0642\u0631\u0623 \u0627\u0644\u0645\u0632\u064a\u062f":"\u062a\u0642\u0644\u064a\u0635"," "))},pipes:[r.b],styles:[""]}),t})()},"3IEU":function(t,e,i){"use strict";i.d(e,"a",function(){return f});var n=i("mrSG"),s=i("XNiG"),o=i("fXoL"),r=i("WTxg"),c=i("0kbX"),a=i("bTqV"),l=i("NFeN"),h=i("ofXK"),p=i("bSwM");function b(t,e){if(1&t){const t=o.Ub();o.Tb(0,"p",7),o.Ob(1,"img",8),o.Dc(2),o.Tb(3,"span"),o.Tb(4,"mat-checkbox",9,10),o.ac("change",function(){o.sc(t);const i=e.$implicit,n=o.qc(5);return o.ec().active(n.checked,i)}),o.Sb(),o.Tb(6,"button",11),o.ac("click",function(){o.sc(t);const i=e.$implicit;return o.ec().remove(i)}),o.Tb(7,"mat-icon",12),o.Dc(8,"delete_sweep"),o.Sb(),o.Sb(),o.Sb(),o.Sb()}if(2&t){const t=e.$implicit,i=o.ec();o.Bb(1),o.kc("src",i.setIcon(t),o.uc),o.Bb(1),o.Fc(" - ",t.substring(14,t.length-1)," "),o.Bb(2),o.kc("checked","1"===t.substring(t.length-1,t.length))}}let f=(()=>{class t{constructor(t,e){this.filesService=t,this.snackBar=e,this.listOfNames=[],this.listToDelete=[],this.files=[],this.nameBtn="",this.folderToSaveInServer="folder",this.propertyOfParent=new s.a,this.eventSubmitToParent=new s.a,this.eventSubmitFromParent=new s.a}ngOnInit(){this.propertyOfParent.subscribe(t=>{if(!t)return;const e=t.split(";");e.pop(),this.listOfNames=e,this.listToDelete=[]}),this.eventSubmitFromParent.subscribe(t=>Object(n.a)(this,void 0,void 0,function*(){yield this.submit()}))}upload(t){for(let e=0;e<t.length;e++){const i=t.item(e);this.listOfNames.push(this.setFileName(i)+"0"),this.sendPropertyOfParent(),this.files.push(i)}}setIcon(t){const e=t.lastIndexOf("."),i=t.substring(e+1);return"pdf"===i||"pdf;"===i?"assets/svg/pdf.svg":"assets/svg/word.svg"}active(t,e){this.listOfNames.forEach((i,n)=>{if(e.includes(i.substring(0,i.length-2))){let e=this.listOfNames[n];e=e.substring(0,e.length-1),this.listOfNames[n]=`${e}${t?"1":"0"}`}}),this.sendPropertyOfParent()}remove(t){const e=this.listOfNames.findIndex(e=>e===t);-1!==e&&(this.listOfNames.splice(e,1),this.sendPropertyOfParent()),this.listToDelete.push(t);const i=t.indexOf("_"),n=t.substring(i);-1!==this.files.findIndex(t=>t.name===n)&&this.files.splice(e,1)}openInput(t){t.click()}sendPropertyOfParent(){let t="";this.listOfNames.forEach(e=>{t+=e+";"}),this.eventSubmitToParent.next(t)}submit(){return Object(n.a)(this,void 0,void 0,function*(){if(this.files.length>0){const t=new FormData;this.files.forEach(e=>{const i=this.setFileName(e);t.append(i,e,i)}),yield this.filesService.uploadFiles(t,this.folderToSaveInServer).toPromise(),this.snackBar.notifyOk(200,"fichier(s) uploade avec succ\xe8s")}this.listToDelete.length>0&&(yield this.filesService.deleteFiles(this.listToDelete,this.folderToSaveInServer).toPromise(),this.snackBar.notifyOk(200,"fichier(s) Supprimer avec succ\xe8s"))})}setFileName(t){return`${t.lastModified}_${t.name}`}}return t.\u0275fac=function(e){return new(e||t)(o.Nb(r.a),o.Nb(c.a))},t.\u0275cmp=o.Hb({type:t,selectors:[["app-upload-select"]],inputs:{nameBtn:"nameBtn",folderToSaveInServer:"folderToSaveInServer",propertyOfParent:"propertyOfParent",eventSubmitToParent:"eventSubmitToParent",eventSubmitFromParent:"eventSubmitFromParent"},decls:12,vars:2,consts:[[1,"row"],[1,"col-md-12","mb-3"],[1,"myrow"],["hidden","","accept","application/pdf,.doc,.docx,application/msword,application/vnd.openxmlformats-officedocument.wordprocessingml.document","type","file","multiple","false",2,"display","none",3,"change"],["file1",""],["mat-raised-button","","type","button","color","primary",3,"click"],["style","font-size: .7em;margin: 0;",4,"ngFor","ngForOf"],[2,"font-size",".7em","margin","0"],["alt","pdf/word",3,"src"],[1,"pl-2",3,"checked","change"],["c",""],["mat-icon-button","","color","warn","type","button",3,"click"],[2,"font-size","1.3em !important"]],template:function(t,e){if(1&t){const t=o.Ub();o.Tb(0,"div",0),o.Tb(1,"div",1),o.Tb(2,"div",2),o.Tb(3,"input",3,4),o.ac("change",function(){o.sc(t);const i=o.qc(4);return e.upload(i.files)}),o.Sb(),o.Tb(5,"button",5),o.ac("click",function(){o.sc(t);const i=o.qc(4);return e.openInput(i)}),o.Tb(6,"mat-icon"),o.Dc(7,"add"),o.Sb(),o.Dc(8),o.Sb(),o.Dc(9," \xa0\xa0 "),o.Tb(10,"div",2),o.Bc(11,b,9,3,"p",6),o.Sb(),o.Sb(),o.Sb(),o.Sb()}2&t&&(o.Bb(8),o.Fc(" ",e.nameBtn," "),o.Bb(3),o.kc("ngForOf",e.listOfNames))},directives:[a.a,l.a,h.l,p.a],styles:["img[_ngcontent-%COMP%]{height:20px}"]}),t})()},"5nPQ":function(t,e,i){"use strict";i.d(e,"a",function(){return p});var n=i("mrSG"),s=i("XNiG"),o=i("fXoL"),r=i("WTxg"),c=i("bTqV"),a=i("NFeN"),l=i("ofXK");function h(t,e){if(1&t){const t=o.Ub();o.Tb(0,"p",7),o.Ob(1,"img",8),o.Dc(2),o.Tb(3,"button",9),o.ac("click",function(){o.sc(t);const i=e.$implicit;return o.ec().remove(i)}),o.Tb(4,"mat-icon",10),o.Dc(5,"delete_sweep"),o.Sb(),o.Sb(),o.Sb()}if(2&t){const t=e.$implicit,i=o.ec();o.Bb(1),o.kc("src",i.setIcon(t),o.uc),o.Bb(1),o.Fc(" - ",t.substring(14)," "),o.Bb(1),o.kc("disabled",i.disabled)}}let p=(()=>{class t{constructor(t){this.filesService=t,this.listOfNames=[],this.listToDelete=[],this.files=[],this.nameBtn="",this.disabled=!1,this.folderToSaveInServer="folder",this.propertyOfParent=new s.a,this.eventSubmitToParent=new s.a,this.eventSubmitFromParent=new s.a}ngOnInit(){this.propertyOfParent.subscribe(t=>{if(!t)return;const e=t.split(";");e.pop(),this.listOfNames=e,this.listToDelete=[]}),this.eventSubmitFromParent.subscribe(t=>Object(n.a)(this,void 0,void 0,function*(){yield this.submit()}))}upload(t){for(let e=0;e<t.length;e++){const i=t.item(e);this.listOfNames.push(this.setFileName(i)),this.sendPropertyOfParent(),this.files.push(i)}}setIcon(t){const e=t.lastIndexOf("."),i=t.substring(e+1);return"pdf"===i||"pdf;"===i?"assets/svg/pdf.svg":"assets/svg/word.svg"}remove(t){const e=this.listOfNames.findIndex(e=>e===t);-1!==e&&(this.listOfNames.splice(e,1),this.sendPropertyOfParent()),this.listToDelete.push(t);const i=t.indexOf("_"),n=t.substring(i);-1!==this.files.findIndex(t=>t.name===n)&&this.files.splice(e,1)}openInput(t){t.click()}sendPropertyOfParent(){let t="";this.listOfNames.forEach(e=>{t+=e+";"}),this.eventSubmitToParent.next(t)}submit(){return Object(n.a)(this,void 0,void 0,function*(){const t=new FormData;this.files.forEach(e=>{const i=this.setFileName(e);t.append(i,e,i)}),t&&(yield this.filesService.uploadFiles(t,this.folderToSaveInServer).toPromise(),yield this.filesService.deleteFiles(this.listToDelete,this.folderToSaveInServer).toPromise())})}setFileName(t){return`${t.lastModified}_${t.name}`}}return t.\u0275fac=function(e){return new(e||t)(o.Nb(r.a))},t.\u0275cmp=o.Hb({type:t,selectors:[["app-upload"]],inputs:{nameBtn:"nameBtn",disabled:"disabled",folderToSaveInServer:"folderToSaveInServer",propertyOfParent:"propertyOfParent",eventSubmitToParent:"eventSubmitToParent",eventSubmitFromParent:"eventSubmitFromParent"},decls:12,vars:3,consts:[[1,"row"],[1,"col-md-12","mb-3"],[1,"myrow"],["hidden","","accept","application/pdf,.doc,.docx,application/msword,application/vnd.openxmlformats-officedocument.wordprocessingml.document","type","file","multiple","false",2,"display","none",3,"change"],["file1",""],["mat-raised-button","","type","button","color","accent",3,"disabled","click"],["style","font-size: .7em;margin: 0;",4,"ngFor","ngForOf"],[2,"font-size",".7em","margin","0"],["alt","pdf/word",3,"src"],["mat-icon-button","","color","warn","type","button",3,"disabled","click"],[2,"font-size","1.3em !important"]],template:function(t,e){if(1&t){const t=o.Ub();o.Tb(0,"div",0),o.Tb(1,"div",1),o.Tb(2,"div",2),o.Tb(3,"input",3,4),o.ac("change",function(){o.sc(t);const i=o.qc(4);return e.upload(i.files)}),o.Sb(),o.Tb(5,"button",5),o.ac("click",function(){o.sc(t);const i=o.qc(4);return e.openInput(i)}),o.Tb(6,"mat-icon"),o.Dc(7,"add"),o.Sb(),o.Dc(8),o.Sb(),o.Dc(9," \xa0\xa0 "),o.Tb(10,"div",2),o.Bc(11,h,6,3,"p",6),o.Sb(),o.Sb(),o.Sb(),o.Sb()}2&t&&(o.Bb(5),o.kc("disabled",e.disabled),o.Bb(3),o.Fc(" ",e.nameBtn," "),o.Bb(3),o.kc("ngForOf",e.listOfNames))},directives:[c.a,a.a,l.l],styles:["img[_ngcontent-%COMP%]{height:20px}"]}),t})()},Fr4G:function(t,e,i){"use strict";i.d(e,"a",function(){return c});var n=i("tk/3"),s=i("2thQ"),o=i("ofXK"),r=i("fXoL");let c=(()=>{class t{}return t.\u0275mod=r.Lb({type:t}),t.\u0275inj=r.Kb({factory:function(e){return new(e||t)},imports:[[o.c,s.a,n.c]]}),t})()},gct3:function(t,e,i){"use strict";i.d(e,"a",function(){return r});var n=i("ofXK"),s=i("sYmb"),o=i("fXoL");let r=(()=>{class t{}return t.\u0275mod=o.Lb({type:t}),t.\u0275inj=o.Kb({factory:function(e){return new(e||t)},imports:[[n.c,s.b]]}),t})()},oz3B:function(t,e,i){"use strict";i.d(e,"a",function(){return u});var n=i("LPYB"),s=i("XNiG"),o=i("HDdC"),r=i("DDG+"),c=i("hSFZ"),a=i("fXoL"),l=i("7q3A"),h=i("J3i2"),p=i("0IaG"),b=i("ofXK");function f(t,e){if(1&t&&(a.Tb(0,"div",8),a.Tb(1,"span",9),a.Dc(2),a.Sb(),a.Ob(3,"div",10),a.Sb()),2&t){const t=e.$implicit,i=e.index,n=a.ec();a.Bb(2),a.Ec(t),a.Bb(1),a.yc("background-color",n.pieChartColors[0].backgroundColor[i])}}let u=(()=>{class t{constructor(t,e,i){this.uow=t,this.mytranslate=e,this.dialog=i,this.obs=new s.a,this.showLegend=!0,this.withGraphe="100%",this.positionLegendBottom=!1,this.canvasHeight=400,this.height="45vh",this.title=null,this.pieChartOptions={responsive:!0,maintainAspectRatio:!1,cutoutPercentage:50,title:{text:"",display:!0},tooltips:{enabled:!0},legend:{position:"bottom",display:!1,align:"center",fullWidth:!0,labels:{fontSize:16}},plugins:{labels:{fontColor:["white","white","white","white","white","white","white","white","white","white","white","white"],precision:0,render:"percentage",fontSize:14,fontStyle:"bold"},pieceLabel:{render:t=>t.label+": "+t.value}}},this.pieChartLabels=[],this.pieChartData=[],this.pieChartType="pie",this.pieChartLegend=!0,this.pieChartPlugins=[c],this.pieChartColors=[{backgroundColor:[]}],this.list=[],this.retate=0,Object(n.d)(),Object(n.c)()}ngOnInit(){this.mytranslate.lang.subscribe(t=>{this.retate="fr"===t?0:180}),this.obs.subscribe(t=>{t.title instanceof o.a?t.title.subscribe(t=>this.title=t):this.title=t.title,this.uow.recommendations.genericByRecommendation(t.table,t.type).subscribe(t=>{console.log(t),this.pieChartLabels=t.map(t=>t.table),this.pieChartData=t.map(t=>+t.value.toFixed(0)),this.pieChartColors[0].backgroundColor=this.getColors(this.pieChartLabels.length),this.pieChartLabels.forEach((e,i)=>{0!==this.pieChartData[i]&&this.list.push({name:t[i].table.toString(),value:this.pieChartData[i]})})})})}openDialog(){this.dialog.open(r.a,{width:"7100px",disableClose:!1,data:{model:this.list,type:"pie",title:this.title}}).afterClosed().subscribe(t=>{console.log(t)})}getColors(t){const e=["#d97f2a","#2d71a1","#c2c3c6","#ba6446","#7dc460","#fdb93a","#59b8ce","#5c5c5f","#ef4f42","#a5a6aa"],i=[];for(let n=0;n<t;n++)i.push(e[n%e.length]);return i}}return t.\u0275fac=function(e){return new(e||t)(a.Nb(l.a),a.Nb(h.a),a.Nb(p.b))},t.\u0275cmp=a.Hb({type:t,selectors:[["app-pie-chart"]],inputs:{obs:"obs",showLegend:"showLegend",withGraphe:"withGraphe",positionLegendBottom:"positionLegendBottom",canvasHeight:"canvasHeight",height:"height",pieChartType:"pieChartType"},decls:9,vars:16,consts:[[1,"d-flex","flex-column","align-items-center","justify-content-center","mb-3",2,"cursor","pointer",3,"click"],[2,"display","block"],["baseChart","",1,"chart","chart-pie",3,"data","legend","labels","chartType","options","plugins","colors"],[1,"mt-3"],["style","display: flex;margin-bottom: 7px;max-width: 50vw;width: 100%;",4,"ngFor","ngForOf"],[1,"d-flex","flex-column","justify-content-center","mt-2"],["src","assets/line.png","height","10px","width","280px"],[1,"pie-title",2,"color","#737473","margin","5px 0 10px 5px"],[2,"display","flex","margin-bottom","7px","max-width","50vw","width","100%"],[2,"color","gray","font-size","1em","margin","0 10px"],[2,"width","43px","height","18px","border","1px solid white"]],template:function(t,e){1&t&&(a.Tb(0,"div",0),a.ac("click",function(){return e.openDialog()}),a.Tb(1,"div",1),a.Ob(2,"canvas",2),a.Sb(),a.Tb(3,"div",3),a.Bc(4,f,4,3,"div",4),a.Sb(),a.Tb(5,"div",5),a.Ob(6,"img",6),a.Tb(7,"h5",7),a.Dc(8),a.Sb(),a.Sb(),a.Sb()),2&t&&(a.Bb(1),a.yc("width",e.withGraphe)("height",e.height),a.Bb(1),a.kc("data",e.pieChartData)("legend",!0)("labels",e.pieChartLabels)("chartType",e.pieChartType)("options",e.pieChartOptions)("plugins",e.pieChartPlugins)("colors",e.pieChartColors)("legend",e.pieChartLegend),a.Bb(2),a.kc("ngForOf",e.pieChartLabels),a.Bb(2),a.yc("transform","rotateY("+e.retate+"deg)"),a.Bb(2),a.Fc(" ",e.title," "))},directives:[n.a,b.l],styles:["p[_ngcontent-%COMP%]{font-family:Lato}"]}),t})()},x3GN:function(t,e,i){"use strict";i.d(e,"a",function(){return h});var n=i("XNiG"),s=i("fXoL"),o=i("J3i2"),r=i("ofXK"),c=i("sYmb");function a(t,e){if(1&t&&(s.Tb(0,"div",1),s.Tb(1,"div",2),s.Tb(2,"p",3),s.Dc(3),s.fc(4,"async"),s.Sb(),s.Tb(5,"p",4),s.Dc(6),s.fc(7,"translate"),s.Sb(),s.Tb(8,"p",4),s.Dc(9),s.Sb(),s.Sb(),s.Sb()),2&t){const t=s.ec();s.yc("height",t.height),s.Bb(3),s.Ec(s.gc(4,5,t.count)),s.Bb(3),s.Ec(s.gc(7,7,"admin.recomm")),s.Bb(3),s.Fc(" ","fr"===t.mytranslate.langSync?"En cours de suivi et d'affaires":"\u0641\u064a \u0637\u0648\u0631 \u0627\u0644\u062a\u062a\u0628\u0639 \u0648\u0627\u0644\u0623\u0639\u0645\u0627\u0644"," ")}}function l(t,e){if(1&t&&(s.Tb(0,"div",1),s.Tb(1,"div",2),s.Tb(2,"p",3),s.Dc(3),s.fc(4,"async"),s.Sb(),s.Tb(5,"p",4),s.Dc(6),s.fc(7,"translate"),s.Sb(),s.Tb(8,"p",4),s.Dc(9),s.Sb(),s.Sb(),s.Sb()),2&t){const t=s.ec();s.yc("height",t.height),s.Bb(3),s.Ec(s.gc(4,5,t.count)),s.Bb(3),s.Ec(s.gc(7,7,"admin.recomm")),s.Bb(3),s.Ec("fr"===t.mytranslate.langSync?"\xe0 l\u2019exercice du troisi\xe8me cycle":"\u0628\u0631\u0633\u0645 \u0627\u0644\u062f\u0648\u0631\u0629 \u0627\u0644\u062b\u0627\u0644\u062b\u0629")}}let h=(()=>{class t{constructor(t){this.mytranslate=t,this.year=(new Date).getFullYear(),this.count=new n.a,this.height="62vh",this.ifEpu=!1}ngOnInit(){}}return t.\u0275fac=function(e){return new(e||t)(s.Nb(o.a))},t.\u0275cmp=s.Hb({type:t,selectors:[["app-count"]],inputs:{count:"count",height:"height",ifEpu:"ifEpu"},decls:2,vars:2,consts:[["class","d-flex justify-content-center align-items-center",3,"height",4,"ngIf"],[1,"d-flex","justify-content-center","align-items-center"],[1,"d-flex","flex-column","justify-content-center","align-items-center"],[1,"prg1",2,"color","#00658e"],[1,"prg2",2,"color","gray"]],template:function(t,e){1&t&&(s.Bc(0,a,10,9,"div",0),s.Bc(1,l,10,9,"div",0)),2&t&&(s.kc("ngIf",!e.ifEpu),s.Bb(1),s.kc("ngIf",e.ifEpu))},directives:[r.m],pipes:[r.b,c.c],styles:[".prg1[_ngcontent-%COMP%]{font-size:2.5em}.prg1[_ngcontent-%COMP%], .prg2[_ngcontent-%COMP%]{margin:0;font-weight:700;text-align:center}.prg2[_ngcontent-%COMP%]{font-size:1.5em}"]}),t})()},xjdI:function(t,e,i){"use strict";i.d(e,"a",function(){return r});var n=i("fXoL"),s=i("M0ag"),o=i("tyNb");let r=(()=>{class t{constructor(t,e){this.session=t,this.router=e}canActivate(t,e){return console.log(e),!(e.url.includes("update")&&!this.session.isAdmin&&!this.session.isProprietaire&&(this.router.navigate(["/admin"]),1))}}return t.\u0275fac=function(e){return new(e||t)(n.Xb(s.a),n.Xb(o.e))},t.\u0275prov=n.Jb({token:t,factory:t.\u0275fac,providedIn:"root"}),t})()}}]);