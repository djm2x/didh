var __generator=this&&this.__generator||function(n,e){var t,l,i,a,o={label:0,sent:function(){if(1&i[0])throw i[1];return i[1]},trys:[],ops:[]};return a={next:c(0),throw:c(1),return:c(2)},"function"==typeof Symbol&&(a[Symbol.iterator]=function(){return this}),a;function c(a){return function(c){return function(a){if(t)throw new TypeError("Generator is already executing.");for(;o;)try{if(t=1,l&&(i=2&a[0]?l.return:a[0]?l.throw||((i=l.return)&&i.call(l),0):l.next)&&!(i=i.call(l,a[1])).done)return i;switch(l=0,i&&(a=[2&a[0],i.value]),a[0]){case 0:case 1:i=a;break;case 4:return o.label++,{value:a[1],done:!1};case 5:o.label++,l=a[1],a=[0];continue;case 7:a=o.ops.pop(),o.trys.pop();continue;default:if(!(i=(i=o.trys).length>0&&i[i.length-1])&&(6===a[0]||2===a[0])){o=0;continue}if(3===a[0]&&(!i||a[1]>i[0]&&a[1]<i[3])){o.label=a[1];break}if(6===a[0]&&o.label<i[1]){o.label=i[1],i=a;break}if(i&&o.label<i[2]){o.label=i[2],o.ops.push(a);break}i[2]&&o.ops.pop(),o.trys.pop();continue}a=e.call(n,o)}catch(c){a=[6,c],l=0}finally{t=i=0}if(5&a[0])throw a[1];return{value:a[0]?a[1]:void 0,done:!0}}([a,c])}}};(window.webpackJsonp=window.webpackJsonp||[]).push([[8],{"2HI4":function(n,e,t){"use strict";t.d(e,"a",(function(){return l}));var l=function(){function n(n,e){this.mytranslate=n,this.http=e,this.text="",this.text2="",this.length=400,this.mecanisme=""}return n.prototype.ngOnInit=function(){var n=this;this.mytranslate.lang.subscribe((function(e){n.http.get("assets/htmls/"+("fr"===e?n.mecanisme+"_fr":n.mecanisme+"_ar")+".html",{responseType:"text"}).subscribe((function(e){n.text=e,n.text2=n.text.substring(0,n.length)}))}))},n.prototype.moreInfo=function(){this.text2=this.text2.length===this.length?this.text:this.text.substring(0,this.length)},n}()},"3IEU":function(n,e,t){"use strict";t.d(e,"a",(function(){return a}));var l=t("mrSG"),i=t("XNiG"),a=function(){function n(n,e){this.filesService=n,this.snackBar=e,this.listOfNames=[],this.listToDelete=[],this.files=[],this.nameBtn="",this.folderToSaveInServer="folder",this.propertyOfParent=new i.a,this.eventSubmitToParent=new i.a,this.eventSubmitFromParent=new i.a}return n.prototype.ngOnInit=function(){var n=this;this.propertyOfParent.subscribe((function(e){if(e){var t=e.split(";");t.pop(),n.listOfNames=t,n.listToDelete=[]}})),this.eventSubmitFromParent.subscribe((function(e){return l.a(n,void 0,void 0,(function(){return __generator(this,(function(n){switch(n.label){case 0:return[4,this.submit()];case 1:return n.sent(),[2]}}))}))}))},n.prototype.upload=function(n){for(var e=0;e<n.length;e++){var t=n.item(e);this.listOfNames.push(this.setFileName(t)+"0"),this.sendPropertyOfParent(),this.files.push(t)}},n.prototype.setIcon=function(n){var e=n.lastIndexOf("."),t=n.substring(e+1);return"pdf"===t||"pdf;"===t?"assets/svg/pdf.svg":"assets/svg/word.svg"},n.prototype.active=function(n,e){var t=this;this.listOfNames.forEach((function(l,i){if(e.includes(l.substring(0,l.length-2))){var a=t.listOfNames[i];a=a.substring(0,a.length-1),t.listOfNames[i]=a+(n?"1":"0")}})),this.sendPropertyOfParent()},n.prototype.remove=function(n){var e=this.listOfNames.findIndex((function(e){return e===n}));-1!==e&&(this.listOfNames.splice(e,1),this.sendPropertyOfParent()),this.listToDelete.push(n);var t=n.indexOf("_"),l=n.substring(t);-1!==this.files.findIndex((function(n){return n.name===l}))&&this.files.splice(e,1)},n.prototype.openInput=function(n){n.click()},n.prototype.sendPropertyOfParent=function(){var n="";this.listOfNames.forEach((function(e){n+=e+";"})),this.eventSubmitToParent.next(n)},n.prototype.submit=function(){return l.a(this,void 0,void 0,(function(){var n,e=this;return __generator(this,(function(t){switch(t.label){case 0:return this.files.length>0?(n=new FormData,this.files.forEach((function(t){var l=e.setFileName(t);n.append(l,t,l)})),[4,this.filesService.uploadFiles(n,this.folderToSaveInServer).toPromise()]):[3,2];case 1:t.sent(),this.snackBar.notifyOk(200,"fichier(s) uploade avec succ\xe8s"),t.label=2;case 2:return this.listToDelete.length>0?[4,this.filesService.deleteFiles(this.listToDelete,this.folderToSaveInServer).toPromise()]:[3,4];case 3:t.sent(),this.snackBar.notifyOk(200,"fichier(s) Supprimer avec succ\xe8s"),t.label=4;case 4:return[2]}}))}))},n.prototype.setFileName=function(n){return n.lastModified+"_"+n.name},n}()},"3VwI":function(n,e,t){"use strict";var l=t("8Y7J"),i=t("6UMx"),a=t("Q+lL"),o=t("Xd0L"),c=t("SVse"),r=t("ZTdd"),u=t("lwm9");t.d(e,"a",(function(){return d}));var s=l.qb({encapsulation:0,styles:[[""]],data:{}});function m(n){return l.Ob(0,[(n()(),l.sb(0,0,null,null,7,"a",[["class","mat-list-item"],["mat-list-item",""]],[[2,"mat-list-item-avatar",null],[2,"mat-list-item-with-avatar",null]],[[null,"click"]],(function(n,e,t){var l=!0;return"click"===e&&(l=!1!==n.component.openLink(n.parent.context.$implicit)&&l),l}),i.d,i.b)),l.rb(1,1228800,null,3,a.b,[l.k,l.h,[2,a.e],[2,a.a]],null,null),l.Kb(603979776,1,{_lines:1}),l.Kb(603979776,2,{_avatar:0}),l.Kb(603979776,3,{_icon:0}),(n()(),l.sb(5,0,null,1,2,"span",[["class","mat-line"],["mat-line",""]],null,null,null,null,null)),l.rb(6,16384,[[1,4]],0,o.o,[],null,null),(n()(),l.Mb(7,null,["- ",""]))],null,(function(n,e){n(e,0,0,l.Eb(e,1)._avatar||l.Eb(e,1)._icon,l.Eb(e,1)._avatar||l.Eb(e,1)._icon);var t=e.parent.context.$implicit.substring(14,e.parent.context.$implicit.length-1);n(e,7,0,t)}))}function b(n){return l.Ob(0,[(n()(),l.sb(0,0,null,null,2,"div",[],null,null,null,null,null)),(n()(),l.hb(16777216,null,null,1,null,m)),l.rb(2,16384,null,0,c.l,[l.O,l.L],{ngIf:[0,"ngIf"]},null)],(function(n,e){n(e,2,0,e.component.show(e.context.$implicit))}),null)}function h(n){return l.Ob(0,[(n()(),l.sb(0,0,null,null,3,"mat-nav-list",[["class","mat-nav-list mat-list-base"],["role","navigation"]],null,null,null,i.f,i.c)),l.rb(1,704512,null,0,a.e,[],null,null),(n()(),l.hb(16777216,null,0,1,null,b)),l.rb(3,278528,null,0,c.k,[l.O,l.L,l.r],{ngForOf:[0,"ngForOf"]},null)],(function(n,e){n(e,3,0,e.component.list)}),null)}var d=l.ob("app-download-sheet",r.a,(function(n){return l.Ob(0,[(n()(),l.sb(0,0,null,null,1,"app-download-sheet",[],null,null,null,h,s)),l.rb(1,114688,null,0,r.a,[u.f,u.a,"BASE_URL"],null,null)],(function(n,e){n(e,1,0)}),null)}),{},{},[])},"4AjB":function(n,e,t){"use strict";var l=t("8Y7J"),i=t("SVse"),a=t("TSSN");t("x3GN"),t("J3i2"),t.d(e,"a",(function(){return o})),t.d(e,"b",(function(){return u}));var o=l.qb({encapsulation:0,styles:[[".prg1[_ngcontent-%COMP%]{font-size:2.5em;margin:0;font-weight:700;text-align:center}.prg2[_ngcontent-%COMP%]{font-size:1.5em;margin:0;font-weight:700;text-align:center}"]],data:{}});function c(n){return l.Ob(0,[(n()(),l.sb(0,0,null,null,11,"div",[["class","d-flex justify-content-center align-items-center"]],[[4,"height",null]],null,null,null,null)),(n()(),l.sb(1,0,null,null,10,"div",[["class","d-flex flex-column justify-content-center align-items-center"]],null,null,null,null,null)),(n()(),l.sb(2,0,null,null,2,"p",[["class","prg1"],["style","color: #00658e;"]],null,null,null,null,null)),(n()(),l.Mb(3,null,["",""])),l.Gb(131072,i.b,[l.h]),(n()(),l.sb(5,0,null,null,2,"p",[["class","prg2"],["style","color: gray;"]],null,null,null,null,null)),(n()(),l.Mb(6,null,["",""])),l.Gb(131072,a.i,[a.j,l.h]),(n()(),l.sb(8,0,null,null,3,"p",[["class","prg2"],["style","color: gray;"]],null,null,null,null,null)),(n()(),l.Mb(9,null,[""," 2011 "," ",""])),l.Gb(131072,a.i,[a.j,l.h]),l.Gb(131072,a.i,[a.j,l.h])],null,(function(n,e){var t=e.component;n(e,0,0,t.height),n(e,3,0,l.Nb(e,3,0,l.Eb(e,4).transform(t.count))),n(e,6,0,l.Nb(e,6,0,l.Eb(e,7).transform("admin.recomm"))),n(e,9,0,l.Nb(e,9,0,l.Eb(e,10).transform("admin.du")),l.Nb(e,9,1,l.Eb(e,11).transform("admin.au")),t.year)}))}function r(n){return l.Ob(0,[(n()(),l.sb(0,0,null,null,9,"div",[["class","d-flex justify-content-center align-items-center"]],[[4,"height",null]],null,null,null,null)),(n()(),l.sb(1,0,null,null,8,"div",[["class","d-flex flex-column justify-content-center align-items-center"]],null,null,null,null,null)),(n()(),l.sb(2,0,null,null,2,"p",[["class","prg1"],["style","color: #00658e;"]],null,null,null,null,null)),(n()(),l.Mb(3,null,["",""])),l.Gb(131072,i.b,[l.h]),(n()(),l.sb(5,0,null,null,2,"p",[["class","prg2"],["style","color: gray;"]],null,null,null,null,null)),(n()(),l.Mb(6,null,["",""])),l.Gb(131072,a.i,[a.j,l.h]),(n()(),l.sb(8,0,null,null,1,"p",[["class","prg2"],["style","color: gray;"]],null,null,null,null,null)),(n()(),l.Mb(9,null,["",""]))],null,(function(n,e){var t=e.component;n(e,0,0,t.height),n(e,3,0,l.Nb(e,3,0,l.Eb(e,4).transform(t.count))),n(e,6,0,l.Nb(e,6,0,l.Eb(e,7).transform("admin.recomm"))),n(e,9,0,"fr"===t.mytranslate.langSync?"\xe0 l\u2019exercice du troisi\xe8me cycle":"\u0628\u0631\u0633\u0645 \u0627\u0644\u062f\u0648\u0631\u0629 \u0627\u0644\u062b\u0627\u0644\u062b\u0629")}))}function u(n){return l.Ob(0,[(n()(),l.hb(16777216,null,null,1,null,c)),l.rb(1,16384,null,0,i.l,[l.O,l.L],{ngIf:[0,"ngIf"]},null),(n()(),l.hb(16777216,null,null,1,null,r)),l.rb(3,16384,null,0,i.l,[l.O,l.L],{ngIf:[0,"ngIf"]},null)],(function(n,e){var t=e.component;n(e,1,0,!t.ifEpu),n(e,3,0,t.ifEpu)}),null)}},"5F3i":function(n,e,t){"use strict";t.d(e,"a",(function(){return o}));var l=t("1KGb"),i=t("8Y7J"),a=t("s6ns"),o=function(){var n=function(){function n(n){this.dialog=n}return n.prototype.openDialog=function(n){return this.dialog.open(l.a,{width:"750px",disableClose:!0,data:{model:n}}).afterClosed()},n}();return n.ngInjectableDef=i.Sb({factory:function(){return new n(i.Tb(a.e))},token:n,providedIn:"root"}),n}()},AT23:function(n,e,t){"use strict";var l=t("8Y7J"),i=t("hrfs"),a=t("SVse");t("oz3B"),t("7q3A"),t("J3i2"),t("s6ns"),t.d(e,"a",(function(){return o})),t.d(e,"b",(function(){return r}));var o=l.qb({encapsulation:0,styles:[["p[_ngcontent-%COMP%]{font-family:Lato}"]],data:{}});function c(n){return l.Ob(0,[(n()(),l.sb(0,0,null,null,3,"div",[["style","display: flex;margin-bottom: 7px;max-width: 50vw;width: 100%;"]],null,null,null,null,null)),(n()(),l.sb(1,0,null,null,1,"span",[["style","color: gray; font-size: 1em; margin: 0 10px;"]],null,null,null,null,null)),(n()(),l.Mb(2,null,["",""])),(n()(),l.sb(3,0,null,null,0,"div",[["style","width: 43px; height: 18px; border: 1px solid white;"]],[[4,"backgroundColor",null]],null,null,null,null))],null,(function(n,e){var t=e.component;n(e,2,0,e.context.$implicit),n(e,3,0,t.pieChartColors[0].backgroundColor[e.context.index])}))}function r(n){return l.Ob(0,[(n()(),l.sb(0,0,null,null,10,"div",[["class","d-flex flex-column align-items-center justify-content-center mb-3"],["style","cursor: pointer;"]],null,[[null,"click"]],(function(n,e,t){var l=!0;return"click"===e&&(l=!1!==n.component.openDialog()&&l),l}),null,null)),(n()(),l.sb(1,0,null,null,2,"div",[["style","display: block;"]],[[4,"width",null],[4,"height",null]],null,null,null,null)),(n()(),l.sb(2,0,null,null,1,"canvas",[["baseChart",""],["class","chart chart-pie"]],null,null,null,null,null)),l.rb(3,999424,null,0,i.a,[l.k,i.c],{data:[0,"data"],labels:[1,"labels"],options:[2,"options"],chartType:[3,"chartType"],colors:[4,"colors"],legend:[5,"legend"],plugins:[6,"plugins"]},null),(n()(),l.sb(4,0,null,null,2,"div",[["class","mt-3"]],null,null,null,null,null)),(n()(),l.hb(16777216,null,null,1,null,c)),l.rb(6,278528,null,0,a.k,[l.O,l.L,l.r],{ngForOf:[0,"ngForOf"]},null),(n()(),l.sb(7,0,null,null,3,"div",[["class","d-flex flex-column justify-content-center mt-2"]],null,null,null,null,null)),(n()(),l.sb(8,0,null,null,0,"img",[["height","10px"],["src","assets/line.png"],["width","280px"]],[[4,"transform",null]],null,null,null,null)),(n()(),l.sb(9,0,null,null,1,"h5",[["class","pie-title"],["style","color: #737473; margin: 5px 0 10px 5px;"]],null,null,null,null,null)),(n()(),l.Mb(10,null,[" "," "]))],(function(n,e){var t=e.component;n(e,3,0,t.pieChartData,t.pieChartLabels,t.pieChartOptions,t.pieChartType,t.pieChartColors,!0,t.pieChartPlugins),n(e,6,0,t.pieChartLabels)}),(function(n,e){var t=e.component;n(e,1,0,t.withGraphe,t.height),n(e,8,0,"rotateY("+t.retate+"deg)"),n(e,10,0,t.title)}))}},EFDD:function(n,e,t){"use strict";var l=t("8Y7J"),i=t("Z5h4"),a=t("s7LF"),o=t("r0V8"),c=t("5GAg"),r=t("omvX"),u=t("bujt"),s=t("Fwaw"),m=t("Mr+X"),b=t("Gi4r"),h=t("SVse");t("3IEU"),t("WTxg"),t("0kbX"),t.d(e,"a",(function(){return d})),t.d(e,"b",(function(){return f}));var d=l.qb({encapsulation:0,styles:[["img[_ngcontent-%COMP%]{height:20px}"]],data:{}});function p(n){return l.Ob(0,[(n()(),l.sb(0,0,null,null,11,"p",[["style","font-size: .7em;margin: 0;"]],null,null,null,null,null)),(n()(),l.sb(1,0,null,null,0,"img",[["alt","pdf/word"]],[[8,"src",4]],null,null,null,null)),(n()(),l.Mb(2,null,[" - "," "])),(n()(),l.sb(3,0,null,null,8,"span",[],null,null,null,null,null)),(n()(),l.sb(4,0,null,null,2,"mat-checkbox",[["class","pl-2 mat-checkbox"]],[[8,"id",0],[1,"tabindex",0],[2,"mat-checkbox-indeterminate",null],[2,"mat-checkbox-checked",null],[2,"mat-checkbox-disabled",null],[2,"mat-checkbox-label-before",null],[2,"_mat-animation-noopable",null]],[[null,"change"]],(function(n,e,t){var i=!0;return"change"===e&&(i=!1!==n.component.active(l.Eb(n,6).checked,n.context.$implicit)&&i),i}),i.b,i.a)),l.Jb(5120,null,a.l,(function(n){return[n]}),[o.b]),l.rb(6,8568832,[["c",4]],0,o.b,[l.k,l.h,c.h,l.y,[8,null],[2,o.a],[2,r.a]],{checked:[0,"checked"]},{change:"change"}),(n()(),l.sb(7,0,null,null,4,"button",[["color","warn"],["mat-icon-button",""],["type","button"]],[[1,"disabled",0],[2,"_mat-animation-noopable",null]],[[null,"click"]],(function(n,e,t){var l=!0;return"click"===e&&(l=!1!==n.component.remove(n.context.$implicit)&&l),l}),u.b,u.a)),l.rb(8,180224,null,0,s.b,[l.k,c.h,[2,r.a]],{color:[0,"color"]},null),(n()(),l.sb(9,0,null,0,2,"mat-icon",[["class","mat-icon notranslate"],["role","img"],["style","font-size: 1.3em !important;"]],[[2,"mat-icon-inline",null],[2,"mat-icon-no-color",null]],null,null,m.b,m.a)),l.rb(10,9158656,null,0,b.b,[l.k,b.d,[8,null],[2,b.a],[2,l.l]],null,null),(n()(),l.Mb(-1,0,["delete_sweep"]))],(function(n,e){var t="1"===e.context.$implicit.substring(e.context.$implicit.length-1,e.context.$implicit.length);n(e,6,0,t),n(e,8,0,"warn"),n(e,10,0)}),(function(n,e){n(e,1,0,e.component.setIcon(e.context.$implicit));var t=e.context.$implicit.substring(14,e.context.$implicit.length-1);n(e,2,0,t),n(e,4,0,l.Eb(e,6).id,null,l.Eb(e,6).indeterminate,l.Eb(e,6).checked,l.Eb(e,6).disabled,"before"==l.Eb(e,6).labelPosition,"NoopAnimations"===l.Eb(e,6)._animationMode),n(e,7,0,l.Eb(e,8).disabled||null,"NoopAnimations"===l.Eb(e,8)._animationMode),n(e,9,0,l.Eb(e,10).inline,"primary"!==l.Eb(e,10).color&&"accent"!==l.Eb(e,10).color&&"warn"!==l.Eb(e,10).color)}))}function f(n){return l.Ob(0,[(n()(),l.sb(0,0,null,null,13,"div",[["class","row"]],null,null,null,null,null)),(n()(),l.sb(1,0,null,null,12,"div",[["class","col-md-12 mb-3"]],null,null,null,null,null)),(n()(),l.sb(2,0,null,null,11,"div",[["class","myrow"]],null,null,null,null,null)),(n()(),l.sb(3,0,[["file1",1]],null,0,"input",[["accept","application/pdf,.doc,.docx,application/msword,application/vnd.openxmlformats-officedocument.wordprocessingml.document"],["hidden",""],["multiple","false"],["style","display: none;"],["type","file"]],null,[[null,"change"]],(function(n,e,t){var i=!0;return"change"===e&&(i=!1!==n.component.upload(l.Eb(n,3).files)&&i),i}),null,null)),(n()(),l.sb(4,0,null,null,5,"button",[["color","primary"],["mat-raised-button",""],["type","button"]],[[1,"disabled",0],[2,"_mat-animation-noopable",null]],[[null,"click"]],(function(n,e,t){var i=!0;return"click"===e&&(i=!1!==n.component.openInput(l.Eb(n,3))&&i),i}),u.b,u.a)),l.rb(5,180224,null,0,s.b,[l.k,c.h,[2,r.a]],{color:[0,"color"]},null),(n()(),l.sb(6,0,null,0,2,"mat-icon",[["class","mat-icon notranslate"],["role","img"]],[[2,"mat-icon-inline",null],[2,"mat-icon-no-color",null]],null,null,m.b,m.a)),l.rb(7,9158656,null,0,b.b,[l.k,b.d,[8,null],[2,b.a],[2,l.l]],null,null),(n()(),l.Mb(-1,0,["add"])),(n()(),l.Mb(9,0,[" "," "])),(n()(),l.Mb(-1,null,[" \xa0\xa0 "])),(n()(),l.sb(11,0,null,null,2,"div",[["class","myrow"]],null,null,null,null,null)),(n()(),l.hb(16777216,null,null,1,null,p)),l.rb(13,278528,null,0,h.k,[l.O,l.L,l.r],{ngForOf:[0,"ngForOf"]},null)],(function(n,e){var t=e.component;n(e,5,0,"primary"),n(e,7,0),n(e,13,0,t.listOfNames)}),(function(n,e){var t=e.component;n(e,4,0,l.Eb(e,5).disabled||null,"NoopAnimations"===l.Eb(e,5)._animationMode),n(e,6,0,l.Eb(e,7).inline,"primary"!==l.Eb(e,7).color&&"accent"!==l.Eb(e,7).color&&"warn"!==l.Eb(e,7).color),n(e,9,0,t.nameBtn)}))}},Fr4G:function(n,e,t){"use strict";t.d(e,"a",(function(){return l}));var l=function(){}},Z5h4:function(n,e,t){"use strict";t.d(e,"a",(function(){return r})),t.d(e,"b",(function(){return u}));var l=t("8Y7J"),i=(t("r0V8"),t("SVse"),t("POq0")),a=(t("IP0z"),t("Xd0L")),o=(t("cUpR"),t("/HVE")),c=t("omvX"),r=(t("s7LF"),t("5GAg"),l.qb({encapsulation:2,styles:["@keyframes mat-checkbox-fade-in-background{0%{opacity:0}50%{opacity:1}}@keyframes mat-checkbox-fade-out-background{0%,50%{opacity:1}100%{opacity:0}}@keyframes mat-checkbox-unchecked-checked-checkmark-path{0%,50%{stroke-dashoffset:22.91026}50%{animation-timing-function:cubic-bezier(0,0,.2,.1)}100%{stroke-dashoffset:0}}@keyframes mat-checkbox-unchecked-indeterminate-mixedmark{0%,68.2%{transform:scaleX(0)}68.2%{animation-timing-function:cubic-bezier(0,0,0,1)}100%{transform:scaleX(1)}}@keyframes mat-checkbox-checked-unchecked-checkmark-path{from{animation-timing-function:cubic-bezier(.4,0,1,1);stroke-dashoffset:0}to{stroke-dashoffset:-22.91026}}@keyframes mat-checkbox-checked-indeterminate-checkmark{from{animation-timing-function:cubic-bezier(0,0,.2,.1);opacity:1;transform:rotate(0)}to{opacity:0;transform:rotate(45deg)}}@keyframes mat-checkbox-indeterminate-checked-checkmark{from{animation-timing-function:cubic-bezier(.14,0,0,1);opacity:0;transform:rotate(45deg)}to{opacity:1;transform:rotate(360deg)}}@keyframes mat-checkbox-checked-indeterminate-mixedmark{from{animation-timing-function:cubic-bezier(0,0,.2,.1);opacity:0;transform:rotate(-45deg)}to{opacity:1;transform:rotate(0)}}@keyframes mat-checkbox-indeterminate-checked-mixedmark{from{animation-timing-function:cubic-bezier(.14,0,0,1);opacity:1;transform:rotate(0)}to{opacity:0;transform:rotate(315deg)}}@keyframes mat-checkbox-indeterminate-unchecked-mixedmark{0%{animation-timing-function:linear;opacity:1;transform:scaleX(1)}100%,32.8%{opacity:0;transform:scaleX(0)}}.mat-checkbox-background,.mat-checkbox-frame{top:0;left:0;right:0;bottom:0;position:absolute;border-radius:2px;box-sizing:border-box;pointer-events:none}.mat-checkbox{transition:background .4s cubic-bezier(.25,.8,.25,1),box-shadow 280ms cubic-bezier(.4,0,.2,1);cursor:pointer;-webkit-tap-highlight-color:transparent}._mat-animation-noopable.mat-checkbox{transition:none;animation:none}.mat-checkbox .mat-ripple-element:not(.mat-checkbox-persistent-ripple){opacity:.16}.mat-checkbox-layout{-webkit-user-select:none;-moz-user-select:none;-ms-user-select:none;user-select:none;cursor:inherit;align-items:baseline;vertical-align:middle;display:inline-flex;white-space:nowrap}.mat-checkbox-label{-webkit-user-select:auto;-moz-user-select:auto;-ms-user-select:auto;user-select:auto}.mat-checkbox-inner-container{display:inline-block;height:16px;line-height:0;margin:auto;margin-right:8px;order:0;position:relative;vertical-align:middle;white-space:nowrap;width:16px;flex-shrink:0}[dir=rtl] .mat-checkbox-inner-container{margin-left:8px;margin-right:auto}.mat-checkbox-inner-container-no-side-margin{margin-left:0;margin-right:0}.mat-checkbox-frame{background-color:transparent;transition:border-color 90ms cubic-bezier(0,0,.2,.1);border-width:2px;border-style:solid}._mat-animation-noopable .mat-checkbox-frame{transition:none}@media (-ms-high-contrast:active){.mat-checkbox.cdk-keyboard-focused .mat-checkbox-frame{border-style:dotted}}.mat-checkbox-background{align-items:center;display:inline-flex;justify-content:center;transition:background-color 90ms cubic-bezier(0,0,.2,.1),opacity 90ms cubic-bezier(0,0,.2,.1)}._mat-animation-noopable .mat-checkbox-background{transition:none}.mat-checkbox-persistent-ripple{width:100%;height:100%;transform:none}.mat-checkbox-inner-container:hover .mat-checkbox-persistent-ripple{opacity:.04}.mat-checkbox.cdk-keyboard-focused .mat-checkbox-persistent-ripple{opacity:.12}.mat-checkbox-persistent-ripple,.mat-checkbox.mat-checkbox-disabled .mat-checkbox-inner-container:hover .mat-checkbox-persistent-ripple{opacity:0}@media (hover:none){.mat-checkbox-inner-container:hover .mat-checkbox-persistent-ripple{display:none}}.mat-checkbox-checkmark{top:0;left:0;right:0;bottom:0;position:absolute;width:100%}.mat-checkbox-checkmark-path{stroke-dashoffset:22.91026;stroke-dasharray:22.91026;stroke-width:2.13333px}.mat-checkbox-mixedmark{width:calc(100% - 6px);height:2px;opacity:0;transform:scaleX(0) rotate(0);border-radius:2px}@media (-ms-high-contrast:active){.mat-checkbox-mixedmark{height:0;border-top:solid 2px;margin-top:2px}}.mat-checkbox-label-before .mat-checkbox-inner-container{order:1;margin-left:8px;margin-right:auto}[dir=rtl] .mat-checkbox-label-before .mat-checkbox-inner-container{margin-left:auto;margin-right:8px}.mat-checkbox-checked .mat-checkbox-checkmark{opacity:1}.mat-checkbox-checked .mat-checkbox-checkmark-path{stroke-dashoffset:0}.mat-checkbox-checked .mat-checkbox-mixedmark{transform:scaleX(1) rotate(-45deg)}.mat-checkbox-indeterminate .mat-checkbox-checkmark{opacity:0;transform:rotate(45deg)}.mat-checkbox-indeterminate .mat-checkbox-checkmark-path{stroke-dashoffset:0}.mat-checkbox-indeterminate .mat-checkbox-mixedmark{opacity:1;transform:scaleX(1) rotate(0)}.mat-checkbox-unchecked .mat-checkbox-background{background-color:transparent}.mat-checkbox-disabled{cursor:default}.mat-checkbox-anim-unchecked-checked .mat-checkbox-background{animation:180ms linear 0s mat-checkbox-fade-in-background}.mat-checkbox-anim-unchecked-checked .mat-checkbox-checkmark-path{animation:180ms linear 0s mat-checkbox-unchecked-checked-checkmark-path}.mat-checkbox-anim-unchecked-indeterminate .mat-checkbox-background{animation:180ms linear 0s mat-checkbox-fade-in-background}.mat-checkbox-anim-unchecked-indeterminate .mat-checkbox-mixedmark{animation:90ms linear 0s mat-checkbox-unchecked-indeterminate-mixedmark}.mat-checkbox-anim-checked-unchecked .mat-checkbox-background{animation:180ms linear 0s mat-checkbox-fade-out-background}.mat-checkbox-anim-checked-unchecked .mat-checkbox-checkmark-path{animation:90ms linear 0s mat-checkbox-checked-unchecked-checkmark-path}.mat-checkbox-anim-checked-indeterminate .mat-checkbox-checkmark{animation:90ms linear 0s mat-checkbox-checked-indeterminate-checkmark}.mat-checkbox-anim-checked-indeterminate .mat-checkbox-mixedmark{animation:90ms linear 0s mat-checkbox-checked-indeterminate-mixedmark}.mat-checkbox-anim-indeterminate-checked .mat-checkbox-checkmark{animation:.5s linear 0s mat-checkbox-indeterminate-checked-checkmark}.mat-checkbox-anim-indeterminate-checked .mat-checkbox-mixedmark{animation:.5s linear 0s mat-checkbox-indeterminate-checked-mixedmark}.mat-checkbox-anim-indeterminate-unchecked .mat-checkbox-background{animation:180ms linear 0s mat-checkbox-fade-out-background}.mat-checkbox-anim-indeterminate-unchecked .mat-checkbox-mixedmark{animation:.3s linear 0s mat-checkbox-indeterminate-unchecked-mixedmark}.mat-checkbox-input{bottom:0;left:50%}.mat-checkbox .mat-checkbox-ripple{position:absolute;left:calc(50% - 20px);top:calc(50% - 20px);height:40px;width:40px;z-index:1;pointer-events:none}"],data:{}}));function u(n){return l.Ob(2,[l.Kb(671088640,1,{_inputElement:0}),l.Kb(671088640,2,{ripple:0}),(n()(),l.sb(2,0,[["label",1]],null,16,"label",[["class","mat-checkbox-layout"]],[[1,"for",0]],null,null,null,null)),(n()(),l.sb(3,0,null,null,10,"div",[["class","mat-checkbox-inner-container"]],[[2,"mat-checkbox-inner-container-no-side-margin",null]],null,null,null,null)),(n()(),l.sb(4,0,[[1,0],["input",1]],null,0,"input",[["class","mat-checkbox-input cdk-visually-hidden"],["type","checkbox"]],[[8,"id",0],[8,"required",0],[8,"checked",0],[1,"value",0],[8,"disabled",0],[1,"name",0],[8,"tabIndex",0],[8,"indeterminate",0],[1,"aria-label",0],[1,"aria-labelledby",0],[1,"aria-checked",0]],[[null,"change"],[null,"click"]],(function(n,e,t){var l=!0,i=n.component;return"change"===e&&(l=!1!==i._onInteractionEvent(t)&&l),"click"===e&&(l=!1!==i._onInputClick(t)&&l),l}),null,null)),(n()(),l.sb(5,0,null,null,3,"div",[["class","mat-checkbox-ripple mat-ripple"],["matRipple",""]],[[2,"mat-ripple-unbounded",null]],null,null,null,null)),l.rb(6,212992,[[2,4]],0,a.x,[l.k,l.y,o.a,[2,a.m],[2,c.a]],{centered:[0,"centered"],radius:[1,"radius"],animation:[2,"animation"],disabled:[3,"disabled"],trigger:[4,"trigger"]},null),l.Hb(7,{enterDuration:0}),(n()(),l.sb(8,0,null,null,0,"div",[["class","mat-ripple-element mat-checkbox-persistent-ripple"]],null,null,null,null,null)),(n()(),l.sb(9,0,null,null,0,"div",[["class","mat-checkbox-frame"]],null,null,null,null,null)),(n()(),l.sb(10,0,null,null,3,"div",[["class","mat-checkbox-background"]],null,null,null,null,null)),(n()(),l.sb(11,0,null,null,1,":svg:svg",[[":xml:space","preserve"],["class","mat-checkbox-checkmark"],["focusable","false"],["version","1.1"],["viewBox","0 0 24 24"]],null,null,null,null,null)),(n()(),l.sb(12,0,null,null,0,":svg:path",[["class","mat-checkbox-checkmark-path"],["d","M4.1,12.7 9,17.6 20.3,6.3"],["fill","none"],["stroke","white"]],null,null,null,null,null)),(n()(),l.sb(13,0,null,null,0,"div",[["class","mat-checkbox-mixedmark"]],null,null,null,null,null)),(n()(),l.sb(14,0,[["checkboxLabel",1]],null,4,"span",[["class","mat-checkbox-label"]],null,[[null,"cdkObserveContent"]],(function(n,e,t){var l=!0;return"cdkObserveContent"===e&&(l=!1!==n.component._onLabelTextChange()&&l),l}),null,null)),l.rb(15,1196032,null,0,i.a,[i.b,l.k,l.y],null,{event:"cdkObserveContent"}),(n()(),l.sb(16,0,null,null,1,"span",[["style","display:none"]],null,null,null,null,null)),(n()(),l.Mb(-1,null,["\xa0"])),l.Db(null,0)],(function(n,e){var t=e.component,i=n(e,7,0,150);n(e,6,0,!0,20,i,t._isRippleDisabled(),l.Eb(e,2))}),(function(n,e){var t=e.component;n(e,2,0,t.inputId),n(e,3,0,!l.Eb(e,14).textContent||!l.Eb(e,14).textContent.trim()),n(e,4,1,[t.inputId,t.required,t.checked,t.value,t.disabled,t.name,t.tabIndex,t.indeterminate,t.ariaLabel||null,t.ariaLabelledby,t._getAriaChecked()]),n(e,5,0,l.Eb(e,6).unbounded)}))}},gct3:function(n,e,t){"use strict";t.d(e,"a",(function(){return l}));var l=function(){}},nRMC:function(n,e,t){"use strict";var l=t("8Y7J"),i=t("SVse");t("2HI4"),t("J3i2"),t("IheW"),t.d(e,"a",(function(){return a})),t.d(e,"b",(function(){return o}));var a=l.qb({encapsulation:0,styles:[[""]],data:{}});function o(n){return l.Ob(0,[(n()(),l.sb(0,0,null,null,5,"section",[],null,null,null,null,null)),(n()(),l.sb(1,0,null,null,4,"h5",[["style","color: #737473; margin: 20px 5px;"]],null,null,null,null,null)),(n()(),l.sb(2,0,null,null,0,"span",[["style","font-size: 1.5em;"]],[[8,"innerHTML",1]],null,null,null,null)),(n()(),l.sb(3,0,null,null,2,"b",[["style","color: #286293; cursor: pointer;font-size: 1.5em;"]],null,[[null,"click"]],(function(n,e,t){var l=!0;return"click"===e&&(l=!1!==n.component.moreInfo()&&l),l}),null,null)),(n()(),l.Mb(4,null,[" "," "])),l.Gb(131072,i.b,[l.h])],null,(function(n,e){var t=e.component;n(e,2,0,t.text2),n(e,4,0,"fr"===l.Nb(e,4,0,l.Eb(e,5).transform(t.mytranslate.lang))?t.text2.length===t.length?"Lire la suite":"R\xe9duire":t.text2.length===t.length?"\u0627\u0642\u0631\u0623 \u0627\u0644\u0645\u0632\u064a\u062f":"\u062a\u0642\u0644\u064a\u0635")}))}},oz3B:function(n,e,t){"use strict";t.d(e,"a",(function(){return r}));var l=t("hrfs"),i=t("XNiG"),a=t("HDdC"),o=t("DDG+"),c=t("hSFZ"),r=function(){function n(n,e,t){this.uow=n,this.mytranslate=e,this.dialog=t,this.obs=new i.a,this.showLegend=!0,this.withGraphe="100%",this.positionLegendBottom=!1,this.canvasHeight=400,this.height="45vh",this.title=null,this.pieChartOptions={responsive:!0,maintainAspectRatio:!1,cutoutPercentage:50,title:{text:"",display:!0},tooltips:{enabled:!0},legend:{position:"bottom",display:!1,align:"center",fullWidth:!0,labels:{fontSize:16}},plugins:{labels:{fontColor:["white","white","white","white","white","white","white","white","white","white","white","white"],precision:0,render:"percentage",fontSize:14,fontStyle:"bold"},pieceLabel:{render:function(n){return n.label+": "+n.value}}}},this.pieChartLabels=[],this.pieChartData=[],this.pieChartType="pie",this.pieChartLegend=!0,this.pieChartPlugins=[c],this.pieChartColors=[{backgroundColor:[]}],this.list=[],this.retate=0,Object(l.e)(),Object(l.d)()}return n.prototype.ngOnInit=function(){var n=this;this.mytranslate.lang.subscribe((function(e){n.retate="fr"===e?0:180})),this.obs.subscribe((function(e){e.title instanceof a.a?e.title.subscribe((function(e){return n.title=e})):n.title=e.title,n.uow.recommendations.genericByRecommendation(e.table,e.type).subscribe((function(e){console.log(e),n.pieChartLabels=e.map((function(n){return n.table})),n.pieChartData=e.map((function(n){return+n.value.toFixed(0)})),n.pieChartColors[0].backgroundColor=n.getColors(n.pieChartLabels.length),n.pieChartLabels.forEach((function(t,l){0!==n.pieChartData[l]&&n.list.push({name:e[l].table.toString(),value:n.pieChartData[l]})}))}))}))},n.prototype.openDialog=function(){this.dialog.open(o.a,{width:"7100px",disableClose:!1,data:{model:this.list,type:"pie",title:this.title}}).afterClosed().subscribe((function(n){console.log(n)}))},n.prototype.getColors=function(n){for(var e=["#d97f2a","#2d71a1","#c2c3c6","#ba6446","#7dc460","#fdb93a","#59b8ce","#5c5c5f","#ef4f42","#a5a6aa"],t=[],l=0;l<n;l++)t.push(e[l%e.length]);return t},n}()},x3GN:function(n,e,t){"use strict";t.d(e,"a",(function(){return i}));var l=t("XNiG"),i=function(){function n(n){this.mytranslate=n,this.year=(new Date).getFullYear(),this.count=new l.a,this.height="62vh",this.ifEpu=!1}return n.prototype.ngOnInit=function(){},n}()}}]);