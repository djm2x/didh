(window.webpackJsonp=window.webpackJsonp||[]).push([[2],{"5nPQ":function(l,n,t){"use strict";t.d(n,"a",(function(){return o}));var e=t("mrSG"),i=t("XNiG");class o{constructor(l){this.filesService=l,this.listOfNames=[],this.listToDelete=[],this.files=[],this.nameBtn="",this.folderToSaveInServer="folder",this.propertyOfParent=new i.a,this.eventSubmitToParent=new i.a,this.eventSubmitFromParent=new i.a}ngOnInit(){this.propertyOfParent.subscribe(l=>{if(!l)return;const n=l.split(";");n.pop(),this.listOfNames=n,this.listToDelete=[]}),this.eventSubmitFromParent.subscribe(l=>e.a(this,void 0,void 0,(function*(){yield this.submit()})))}upload(l){for(let n=0;n<l.length;n++){const t=l.item(n);this.listOfNames.push(this.setFileName(t)),this.sendPropertyOfParent(),this.files.push(t)}}setIcon(l){const n=l.lastIndexOf("."),t=l.substring(n+1);return"pdf"===t||"pdf;"===t?"assets/svg/pdf.svg":"assets/svg/word.svg"}remove(l){const n=this.listOfNames.findIndex(n=>n===l);-1!==n&&(this.listOfNames.splice(n,1),this.sendPropertyOfParent()),this.listToDelete.push(l);const t=l.indexOf("_"),e=l.substring(t);-1!==this.files.findIndex(l=>l.name===e)&&this.files.splice(n,1)}openInput(l){l.click()}sendPropertyOfParent(){let l="";this.listOfNames.forEach(n=>{l+=`${n};`}),this.eventSubmitToParent.next(l)}submit(){return e.a(this,void 0,void 0,(function*(){const l=new FormData;this.files.forEach(n=>{const t=this.setFileName(n);l.append(t,n,t)}),l&&(yield this.filesService.uploadFiles(l,this.folderToSaveInServer).toPromise(),yield this.filesService.deleteFiles(this.listToDelete,this.folderToSaveInServer).toPromise())}))}setFileName(l){return`${l.lastModified}_${l.name}`}}},"A/Kj":function(l,n,t){"use strict";var e=t("8Y7J"),i=t("bujt"),o=t("Fwaw"),s=t("5GAg"),a=t("omvX"),u=t("Mr+X"),r=t("Gi4r"),c=t("SVse");t("5nPQ"),t("WTxg"),t.d(n,"a",(function(){return m})),t.d(n,"b",(function(){return b}));var m=e.qb({encapsulation:0,styles:[["img[_ngcontent-%COMP%]{height:20px}"]],data:{}});function p(l){return e.Ob(0,[(l()(),e.sb(0,0,null,null,7,"p",[["style","font-size: .7em;margin: 0;"]],null,null,null,null,null)),(l()(),e.sb(1,0,null,null,0,"img",[["alt","pdf/word"]],[[8,"src",4]],null,null,null,null)),(l()(),e.Mb(2,null,[" - "," "])),(l()(),e.sb(3,0,null,null,4,"button",[["color","warn"],["mat-icon-button",""],["type","button"]],[[1,"disabled",0],[2,"_mat-animation-noopable",null]],[[null,"click"]],(function(l,n,t){var e=!0;return"click"===n&&(e=!1!==l.component.remove(l.context.$implicit)&&e),e}),i.b,i.a)),e.rb(4,180224,null,0,o.b,[e.k,s.h,[2,a.a]],{color:[0,"color"]},null),(l()(),e.sb(5,0,null,0,2,"mat-icon",[["class","mat-icon notranslate"],["role","img"],["style","font-size: 1.3em !important;"]],[[2,"mat-icon-inline",null],[2,"mat-icon-no-color",null]],null,null,u.b,u.a)),e.rb(6,9158656,null,0,r.b,[e.k,r.d,[8,null],[2,r.a],[2,e.l]],null,null),(l()(),e.Mb(-1,0,["delete_sweep"]))],(function(l,n){l(n,4,0,"warn"),l(n,6,0)}),(function(l,n){l(n,1,0,n.component.setIcon(n.context.$implicit));var t=n.context.$implicit.substring(14);l(n,2,0,t),l(n,3,0,e.Eb(n,4).disabled||null,"NoopAnimations"===e.Eb(n,4)._animationMode),l(n,5,0,e.Eb(n,6).inline,"primary"!==e.Eb(n,6).color&&"accent"!==e.Eb(n,6).color&&"warn"!==e.Eb(n,6).color)}))}function b(l){return e.Ob(0,[(l()(),e.sb(0,0,null,null,13,"div",[["class","row"]],null,null,null,null,null)),(l()(),e.sb(1,0,null,null,12,"div",[["class","col-md-12 mb-3"]],null,null,null,null,null)),(l()(),e.sb(2,0,null,null,11,"div",[["class","myrow"]],null,null,null,null,null)),(l()(),e.sb(3,0,[["file1",1]],null,0,"input",[["accept","application/pdf,.doc,.docx,application/msword,application/vnd.openxmlformats-officedocument.wordprocessingml.document"],["hidden",""],["multiple","false"],["style","display: none;"],["type","file"]],null,[[null,"change"]],(function(l,n,t){var i=!0;return"change"===n&&(i=!1!==l.component.upload(e.Eb(l,3).files)&&i),i}),null,null)),(l()(),e.sb(4,0,null,null,5,"button",[["color","accent"],["mat-raised-button",""],["type","button"]],[[1,"disabled",0],[2,"_mat-animation-noopable",null]],[[null,"click"]],(function(l,n,t){var i=!0;return"click"===n&&(i=!1!==l.component.openInput(e.Eb(l,3))&&i),i}),i.b,i.a)),e.rb(5,180224,null,0,o.b,[e.k,s.h,[2,a.a]],{color:[0,"color"]},null),(l()(),e.sb(6,0,null,0,2,"mat-icon",[["class","mat-icon notranslate"],["role","img"]],[[2,"mat-icon-inline",null],[2,"mat-icon-no-color",null]],null,null,u.b,u.a)),e.rb(7,9158656,null,0,r.b,[e.k,r.d,[8,null],[2,r.a],[2,e.l]],null,null),(l()(),e.Mb(-1,0,["add"])),(l()(),e.Mb(9,0,[" "," "])),(l()(),e.Mb(-1,null,[" \xa0\xa0 "])),(l()(),e.sb(11,0,null,null,2,"div",[["class","myrow"]],null,null,null,null,null)),(l()(),e.hb(16777216,null,null,1,null,p)),e.rb(13,278528,null,0,c.k,[e.O,e.L,e.r],{ngForOf:[0,"ngForOf"]},null)],(function(l,n){var t=n.component;l(n,5,0,"accent"),l(n,7,0),l(n,13,0,t.listOfNames)}),(function(l,n){var t=n.component;l(n,4,0,e.Eb(n,5).disabled||null,"NoopAnimations"===e.Eb(n,5)._animationMode),l(n,6,0,e.Eb(n,7).inline,"primary"!==e.Eb(n,7).color&&"accent"!==e.Eb(n,7).color&&"warn"!==e.Eb(n,7).color),l(n,9,0,t.nameBtn)}))}},Rn7m:function(l,n,t){"use strict";t.d(n,"a",(function(){return o})),t.d(n,"b",(function(){return a}));var e=t("8Y7J"),i=(t("/Co4"),t("SVse")),o=(t("QQfA"),t("IP0z"),t("Xd0L"),t("cUpR"),t("/HVE"),t("zMNK"),t("hOhj"),e.qb({encapsulation:2,styles:[".mat-autocomplete-panel{min-width:112px;max-width:280px;overflow:auto;-webkit-overflow-scrolling:touch;visibility:hidden;max-width:none;max-height:256px;position:relative;width:100%;border-bottom-left-radius:4px;border-bottom-right-radius:4px}.mat-autocomplete-panel.mat-autocomplete-visible{visibility:visible}.mat-autocomplete-panel.mat-autocomplete-hidden{visibility:hidden}.mat-autocomplete-panel-above .mat-autocomplete-panel{border-radius:0;border-top-left-radius:4px;border-top-right-radius:4px}.mat-autocomplete-panel .mat-divider-horizontal{margin-top:-1px}@media (-ms-high-contrast:active){.mat-autocomplete-panel{outline:solid 1px}}"],data:{}}));function s(l){return e.Ob(0,[(l()(),e.sb(0,0,[[2,0],["panel",1]],null,3,"div",[["class","mat-autocomplete-panel"],["role","listbox"]],[[8,"id",0]],null,null,null,null)),e.Jb(512,null,i.x,i.y,[e.r,e.s,e.k,e.D]),e.rb(2,278528,null,0,i.j,[i.x],{klass:[0,"klass"],ngClass:[1,"ngClass"]},null),e.Db(null,0)],(function(l,n){l(n,2,0,"mat-autocomplete-panel",n.component._classList)}),(function(l,n){l(n,0,0,n.component.id)}))}function a(l){return e.Ob(2,[e.Kb(402653184,1,{template:0}),e.Kb(671088640,2,{panel:0}),(l()(),e.hb(0,[[1,2]],null,0,null,s))],null,null)}}}]);