!function(){function t(t,e){if(!(t instanceof e))throw new TypeError("Cannot call a class as a function")}function e(t,e){for(var n=0;n<e.length;n++){var a=e[n];a.enumerable=a.enumerable||!1,a.configurable=!0,"value"in a&&(a.writable=!0),Object.defineProperty(t,a.key,a)}}(self.webpackChunkmy_app=self.webpackChunkmy_app||[]).push([[224],{40224:function(n,a,o){"use strict";o.r(a),o.d(a,{HomeModule:function(){return w}});var r=o(31041),i=o(61116),l=o(42693),c=o(57823),s=o(63337),u=o(64762),m=o(55959),d=o(35366),g=o(92572),p=o(50545),f=o(31496),h=o(16056),b=o(60649);function x(t,e){if(1&t&&(d.TgZ(0,"div",4),d.TgZ(1,"div",5),d.TgZ(2,"div",6),d.TgZ(3,"div",7),d._UZ(4,"img",8),d.TgZ(5,"h2",9),d._uU(6),d.ALo(7,"translate"),d.qZA(),d.qZA(),d.TgZ(8,"div",5),d._UZ(9,"app-bar",10),d.qZA(),d.TgZ(10,"div",11),d.TgZ(11,"div",12),d._UZ(12,"app-bar",13),d.qZA(),d.TgZ(13,"div",12),d._UZ(14,"app-bar",13),d.qZA(),d.TgZ(15,"div",14),d._UZ(16,"app-bar",10),d.qZA(),d.qZA(),d.qZA(),d.qZA(),d.qZA()),2&t){var n=d.oxw();d.xp6(6),d.hij(" ",d.lcZ(7,11,"admin.home.Etatdavancementdesrecommandations\u2013d\xe9partements")," "),d.xp6(3),d.Q6J("col",12)("height","60vh")("dataSubject",n.departementSubjectPE),d.xp6(3),d.Q6J("col",12)("dataSubject",n.departementSubjectAutre),d.xp6(2),d.Q6J("col",12)("dataSubject",n.departementSubjectPJ),d.xp6(2),d.Q6J("col",12)("height","55vh")("dataSubject",n.departementSubjectIN)}}var y,P,C=[{path:"home",redirectTo:"",pathMatch:"full"},{path:"",component:(y=function(){function n(e,a,o){t(this,n),this.uow=e,this.session=a,this.mytranslate=o,this.departementSubjectPE=new m.xQ,this.departementSubjectAutre=new m.xQ,this.departementSubjectIN=new m.xQ,this.departementSubjectPJ=new m.xQ}var a,o,r;return a=n,(o=[{key:"ngOnInit",value:function(){this.stateRecommendationByOrganisme()}},{key:"stateRecommendationByOrganisme",value:function(){var t,e;return(0,u.mG)(this,void 0,void 0,regeneratorRuntime.mark(function n(){var a,o,r,i,l=this;return regeneratorRuntime.wrap(function(n){for(;;)switch(n.prev=n.next){case 0:return n.next=2,this.uow.organismeHomePE.toPromise();case 2:if(n.t1=t=n.sent,n.t0=null===n.t1,n.t0){n.next=6;break}n.t0=void 0===t;case 6:if(!n.t0){n.next=10;break}n.t2=void 0,n.next=11;break;case 10:n.t2=t.fr;case 11:return a=n.t2,n.next=14,this.uow.organismeHomePE.toPromise();case 14:if(n.t4=e=n.sent,n.t3=null===n.t4,n.t3){n.next=18;break}n.t3=void 0===e;case 18:if(!n.t3){n.next=22;break}n.t5=void 0,n.next=23;break;case 22:n.t5=e.ar;case 23:o=n.t5,r=["Observatoire National des Droits de l\u2019Enfant"],i=[],this.uow.recommendations.stateRecommendationByOrganisme().subscribe(function(t){(t=t.filter(function(t){return t.type&&""!==t.type&&!1===r.includes(t.name)&&void 0!==t.name})).forEach(function(t){o.forEach(function(e,n){if(e.includes(t.nameAr)){var o={nameAr:e,one:t.one,two:t.two,three:t.three,four:t.four,total:t.total,type:t.type,name:a[n]},r=i.findIndex(function(t){return t.name.includes(o.name)});-1!==r?(i[r].one+=o.one,i[r].two+=o.two,i[r].three+=o.three,i[r].four+=o.four,i[r].total+=o.total):i.push(o)}})}),t=t.filter(function(t){return t});var e=i.filter(function(t){return"PE"===t.type}).map(function(t){return"fr"===l.mytranslate.langSync?t.name:t.nameAr}),n=t.filter(function(t){return"IN"===t.type}).map(function(t){return"fr"===l.mytranslate.langSync?t.name:t.nameAr}),c=t.filter(function(t){return"PJ"===t.type}).map(function(t){return"fr"===l.mytranslate.langSync?t.name:t.nameAr}),s=t.filter(function(t){return"Autre"===t.type}).map(function(t){return"fr"===l.mytranslate.langSync?t.name:t.nameAr}),u=i.filter(function(t){return"PE"===t.type}),m=[{data:u.map(function(t){return+(100*t.four/t.total).toFixed(0)}),label:l.mytranslate.get("R\xe9alis\xe9")},{data:u.map(function(t){return+(100*t.three/t.total).toFixed(0)}),label:l.mytranslate.get("Recommendation_continue")},{data:u.map(function(t){return+(100*t.two/t.total).toFixed(0)}),label:l.mytranslate.get("EnCours")},{data:u.map(function(t){return+(100*t.one/t.total).toFixed(0)}),label:l.mytranslate.get("NonR\xe9alis\xe9")}],d=t.filter(function(t){return"Autre"===t.type}),g=[{data:d.map(function(t){return+(100*t.four/t.total).toFixed(0)}),label:l.mytranslate.get("R\xe9alis\xe9")},{data:d.map(function(t){return+(100*t.three/t.total).toFixed(0)}),label:l.mytranslate.get("Recommendation_continue")},{data:d.map(function(t){return+(100*t.two/t.total).toFixed(0)}),label:l.mytranslate.get("EnCours")},{data:d.map(function(t){return+(100*t.one/t.total).toFixed(0)}),label:l.mytranslate.get("NonR\xe9alis\xe9")}],p=t.filter(function(t){return"IN"===t.type}),f=[{data:p.map(function(t){return+(100*t.four/t.total).toFixed(0)}),label:l.mytranslate.get("R\xe9alis\xe9")},{data:p.map(function(t){return+(100*t.three/t.total).toFixed(0)}),label:l.mytranslate.get("Recommendation_continue")},{data:p.map(function(t){return+(100*t.two/t.total).toFixed(0)}),label:l.mytranslate.get("EnCours")},{data:p.map(function(t){return+(100*t.one/t.total).toFixed(0)}),label:l.mytranslate.get("NonR\xe9alis\xe9")}],h=t.filter(function(t){return"PJ"===t.type}),b=[{data:h.map(function(t){return+(100*t.four/t.total).toFixed(0)}),label:l.mytranslate.get("R\xe9alis\xe9")},{data:h.map(function(t){return+(100*t.three/t.total).toFixed(0)}),label:l.mytranslate.get("Recommendation_continue")},{data:h.map(function(t){return+(100*t.two/t.total).toFixed(0)}),label:l.mytranslate.get("EnCours")},{data:h.map(function(t){return+(100*t.one/t.total).toFixed(0)}),label:l.mytranslate.get("NonR\xe9alis\xe9")}];l.departementSubjectAutre.next({barChartLabels:s,barChartData:g,title:l.mytranslate.get("admin.home.Parlement")}),l.departementSubjectPE.next({barChartLabels:e,barChartData:m,title:l.mytranslate.get("admin.home.D\xe9partementsgouvernementaux")}),l.departementSubjectPJ.next({barChartLabels:c,barChartData:b,title:l.mytranslate.get("admin.home.D\xe9partement\xe0pouvoirjudiciaire")}),l.departementSubjectIN.next({barChartLabels:n,barChartData:f,title:l.mytranslate.get("admin.home.InstitutionsNationales")})});case 27:case"end":return n.stop()}},n,this)}))}}])&&e(a.prototype,o),r&&e(a,r),n}(),y.\u0275fac=function(t){return new(t||y)(d.Y36(g.Z),d.Y36(p.m),d.Y36(f.n))},y.\u0275cmp=d.Xpm({type:y,selectors:[["app-home"]],decls:5,vars:4,consts:[[1,"host"],[1,"d-flex","justify-content-center","mb-5"],["alt","","srcset","",2,"width","100%",3,"src"],["class","row mb-10",4,"ngIf"],[1,"row","mb-10"],[1,"col-md-12"],[1,"mb-5"],[1,"d-flex","align-items-center"],["src","assets/points.png","alt","points.png","srcset","",2,"height","30px"],[2,"color","rgb(94, 94, 94)","margin","0"],[3,"col","height","dataSubject"],[1,"row",2,"height","70vh"],[1,"col-md-3"],[3,"col","dataSubject"],[1,"col-md-6"]],template:function(t,e){1&t&&(d.TgZ(0,"div",0),d.TgZ(1,"div",1),d._UZ(2,"img",2),d.ALo(3,"async"),d.qZA(),d.YNc(4,x,17,13,"div",3),d.qZA()),2&t&&(d.xp6(2),d.Q6J("src","fr"===d.lcZ(3,2,e.mytranslate.lang)?"assets/1.jpg":"assets/1_ar.jpg",d.LSH),d.xp6(2),d.Q6J("ngIf",!e.session.isPublic))},directives:[i.O5,h.R],pipes:[i.Ov,b.X$],styles:['.border-left[_ngcontent-%COMP%]{border-left:10px solid #a19b9e}.border-right[_ngcontent-%COMP%]{border-right:10px solid #a19b9e}.super-title[_ngcontent-%COMP%]{height:45px}.super-title[_ngcontent-%COMP%], .super-title[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]{display:flex;align-items:center}.super-title[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]{background-color:#d17c36;height:35px}.super-title[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]   h3[_ngcontent-%COMP%]{color:#fff;margin:0;padding:0 5px}.super-title2[_ngcontent-%COMP%]{height:45px;display:flex;align-items:center}.super-title2[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]{height:35px;display:flex;align-items:center}.super-title2[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]   h3[_ngcontent-%COMP%]{color:#a19b9e;margin:0;padding:0 5px;font-size:1.8em}.host[_ngcontent-%COMP%]{margin:0 1em 1em!important}  .mat-progress-spinner circle{fill:#00000008!important}h3[_ngcontent-%COMP%]{margin:4px 0 10px;color:var(--primary);text-align:center}.axes[_ngcontent-%COMP%]{display:flex;flex-direction:column;box-shadow:1px 1px 5px #ddd;padding:5px;margin-bottom:5px}.axes[_ngcontent-%COMP%]   p[_ngcontent-%COMP%]{margin:0;font-size:.8em}.axes[_ngcontent-%COMP%]   .title[_ngcontent-%COMP%]{font-weight:700;margin-bottom:10px;font-size:.9em}@font-face{font-family:Satisfy;font-style:normal;font-weight:400;font-display:swap;src:local("Satisfy Regular"),local("Satisfy-Regular"),url(https://fonts.gstatic.com/s/satisfy/v11/rP2Hp2yn6lkG50LoCZOIHQ.woff2) format("woff2");unicode-range:u+00??,u+0131,u+0152-0153,u+02bb-02bc,u+02c6,u+02da,u+02dc,u+2000-206f,u+2074,u+20ac,u+2122,u+2191,u+2193,u+2212,u+2215,u+feff,u+fffd}.textAlign-left[_ngcontent-%COMP%]{text-align:left}.textAlign-right[_ngcontent-%COMP%], .textSouTitre[_ngcontent-%COMP%]{text-align:right}.textSouTitre[_ngcontent-%COMP%]{font-size:.9em;color:#00000070}.legend[_ngcontent-%COMP%]{list-style:none;height:10px;width:280px}.legend[_ngcontent-%COMP%]   li[_ngcontent-%COMP%]{margin-right:10px}.legend[_ngcontent-%COMP%]   span[_ngcontent-%COMP%]{border:1px solid #ccc;float:left;width:12px;height:12px;margin:2px}.legend[_ngcontent-%COMP%]   .superawesome[_ngcontent-%COMP%]{background-color:#2b6a97}.legend[_ngcontent-%COMP%]   .awesome[_ngcontent-%COMP%], .legend[_ngcontent-%COMP%]   .superawesome[_ngcontent-%COMP%]{width:40px;height:22px;font-size:small;padding:2%}.legend[_ngcontent-%COMP%]   .awesome[_ngcontent-%COMP%]{background-color:#ca7834}.legend[_ngcontent-%COMP%]   .kindaawesome[_ngcontent-%COMP%]{background-color:#7dc460;width:40px;height:22px;font-size:small;padding:2%}.legend[_ngcontent-%COMP%]   li[_ngcontent-%COMP%]{font-size:14px;font-weight:100}']}),y)}],_=function(){var e=function e(){t(this,e)};return e.\u0275fac=function(t){return new(t||e)},e.\u0275mod=d.oAB({type:e}),e.\u0275inj=d.cJS({imports:[[s.Bz.forChild(C)],s.Bz]}),e}(),O=o(23928),v=o(97866),w=((P=function e(){t(this,e)}).\u0275fac=function(t){return new(t||P)},P.\u0275mod=d.oAB({type:P}),P.\u0275inj=d.cJS({imports:[[b.aw,i.ez,_,l.JF,c.R,r.u5,r.UX,O.N,v.i]]}),P)}}])}();