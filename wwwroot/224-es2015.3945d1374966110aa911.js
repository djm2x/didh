(self.webpackChunkmy_app=self.webpackChunkmy_app||[]).push([[224],{40224:function(t,e,n){"use strict";n.r(e),n.d(e,{HomeModule:function(){return C}});var a=n(31041),o=n(61116),i=n(42693),r=n(57823),l=n(63337),s=n(64762),c=n(55959),m=n(35366),d=n(92572),g=n(50545),p=n(31496),h=n(16056),u=n(60649);function f(t,e){if(1&t&&(m.TgZ(0,"div",4),m.TgZ(1,"div",5),m.TgZ(2,"div",6),m.TgZ(3,"div",7),m._UZ(4,"img",8),m.TgZ(5,"h2",9),m._uU(6),m.ALo(7,"translate"),m.qZA(),m.qZA(),m.TgZ(8,"div",5),m._UZ(9,"app-bar",10),m.qZA(),m.TgZ(10,"div",11),m.TgZ(11,"div",12),m._UZ(12,"app-bar",13),m.qZA(),m.TgZ(13,"div",12),m._UZ(14,"app-bar",13),m.qZA(),m.TgZ(15,"div",14),m._UZ(16,"app-bar",10),m.qZA(),m.qZA(),m.qZA(),m.qZA(),m.qZA()),2&t){const t=m.oxw();m.xp6(6),m.hij(" ",m.lcZ(7,11,"admin.home.Etatdavancementdesrecommandations\u2013d\xe9partements")," "),m.xp6(3),m.Q6J("col",12)("height","60vh")("dataSubject",t.departementSubjectPE),m.xp6(3),m.Q6J("col",12)("dataSubject",t.departementSubjectAutre),m.xp6(2),m.Q6J("col",12)("dataSubject",t.departementSubjectPJ),m.xp6(2),m.Q6J("col",12)("height","55vh")("dataSubject",t.departementSubjectIN)}}const x=[{path:"home",redirectTo:"",pathMatch:"full"},{path:"",component:(()=>{class t{constructor(t,e,n){this.uow=t,this.session=e,this.mytranslate=n,this.departementSubjectPE=new c.xQ,this.departementSubjectAutre=new c.xQ,this.departementSubjectIN=new c.xQ,this.departementSubjectPJ=new c.xQ}ngOnInit(){this.stateRecommendationByOrganisme()}stateRecommendationByOrganisme(){var t,e;return(0,s.mG)(this,void 0,void 0,function*(){const n=null===(t=yield this.uow.organismeHomePE.toPromise())||void 0===t?void 0:t.fr,a=null===(e=yield this.uow.organismeHomePE.toPromise())||void 0===e?void 0:e.ar,o=["Observatoire National des Droits de l\u2019Enfant"],i=[];this.uow.recommendations.stateRecommendationByOrganisme().subscribe(t=>{(t=t.filter(t=>t.type&&""!==t.type&&!1===o.includes(t.name)&&void 0!==t.name)).forEach(t=>{a.forEach((e,a)=>{if(e.includes(t.nameAr)){const o={nameAr:e,one:t.one,two:t.two,three:t.three,four:t.four,total:t.total,type:t.type,name:n[a]},r=i.findIndex(t=>t.name.includes(o.name));-1!==r?(i[r].one+=o.one,i[r].two+=o.two,i[r].three+=o.three,i[r].four+=o.four,i[r].total+=o.total):i.push(o)}})}),t=t.filter(t=>t);const e=i.filter(t=>"PE"===t.type).map(t=>"fr"===this.mytranslate.langSync?t.name:t.nameAr),r=t.filter(t=>"IN"===t.type).map(t=>"fr"===this.mytranslate.langSync?t.name:t.nameAr),l=t.filter(t=>"PJ"===t.type).map(t=>"fr"===this.mytranslate.langSync?t.name:t.nameAr),s=t.filter(t=>"Autre"===t.type).map(t=>"fr"===this.mytranslate.langSync?t.name:t.nameAr),c=i.filter(t=>"PE"===t.type),m=[{data:c.map(t=>+(100*t.four/t.total).toFixed(0)),label:this.mytranslate.get("R\xe9alis\xe9")},{data:c.map(t=>+(100*t.three/t.total).toFixed(0)),label:this.mytranslate.get("Recommendation_continue")},{data:c.map(t=>+(100*t.two/t.total).toFixed(0)),label:this.mytranslate.get("EnCours")},{data:c.map(t=>+(100*t.one/t.total).toFixed(0)),label:this.mytranslate.get("NonR\xe9alis\xe9")}],d=t.filter(t=>"Autre"===t.type),g=[{data:d.map(t=>+(100*t.four/t.total).toFixed(0)),label:this.mytranslate.get("R\xe9alis\xe9")},{data:d.map(t=>+(100*t.three/t.total).toFixed(0)),label:this.mytranslate.get("Recommendation_continue")},{data:d.map(t=>+(100*t.two/t.total).toFixed(0)),label:this.mytranslate.get("EnCours")},{data:d.map(t=>+(100*t.one/t.total).toFixed(0)),label:this.mytranslate.get("NonR\xe9alis\xe9")}],p=t.filter(t=>"IN"===t.type),h=[{data:p.map(t=>+(100*t.four/t.total).toFixed(0)),label:this.mytranslate.get("R\xe9alis\xe9")},{data:p.map(t=>+(100*t.three/t.total).toFixed(0)),label:this.mytranslate.get("Recommendation_continue")},{data:p.map(t=>+(100*t.two/t.total).toFixed(0)),label:this.mytranslate.get("EnCours")},{data:p.map(t=>+(100*t.one/t.total).toFixed(0)),label:this.mytranslate.get("NonR\xe9alis\xe9")}],u=t.filter(t=>"PJ"===t.type),f=[{data:u.map(t=>+(100*t.four/t.total).toFixed(0)),label:this.mytranslate.get("R\xe9alis\xe9")},{data:u.map(t=>+(100*t.three/t.total).toFixed(0)),label:this.mytranslate.get("Recommendation_continue")},{data:u.map(t=>+(100*t.two/t.total).toFixed(0)),label:this.mytranslate.get("EnCours")},{data:u.map(t=>+(100*t.one/t.total).toFixed(0)),label:this.mytranslate.get("NonR\xe9alis\xe9")}];this.departementSubjectAutre.next({barChartLabels:s,barChartData:g,title:this.mytranslate.get("admin.home.Parlement")}),this.departementSubjectPE.next({barChartLabels:e,barChartData:m,title:this.mytranslate.get("admin.home.D\xe9partementsgouvernementaux")}),this.departementSubjectPJ.next({barChartLabels:l,barChartData:f,title:this.mytranslate.get("admin.home.D\xe9partement\xe0pouvoirjudiciaire")}),this.departementSubjectIN.next({barChartLabels:r,barChartData:h,title:this.mytranslate.get("admin.home.InstitutionsNationales")})})})}}return t.\u0275fac=function(e){return new(e||t)(m.Y36(d.Z),m.Y36(g.m),m.Y36(p.n))},t.\u0275cmp=m.Xpm({type:t,selectors:[["app-home"]],decls:5,vars:4,consts:[[1,"host"],[1,"d-flex","justify-content-center","mb-5"],["alt","","srcset","",2,"width","100%",3,"src"],["class","row mb-10",4,"ngIf"],[1,"row","mb-10"],[1,"col-md-12"],[1,"mb-5"],[1,"d-flex","align-items-center"],["src","assets/points.png","alt","points.png","srcset","",2,"height","30px"],[2,"color","rgb(94, 94, 94)","margin","0"],[3,"col","height","dataSubject"],[1,"row",2,"height","70vh"],[1,"col-md-3"],[3,"col","dataSubject"],[1,"col-md-6"]],template:function(t,e){1&t&&(m.TgZ(0,"div",0),m.TgZ(1,"div",1),m._UZ(2,"img",2),m.ALo(3,"async"),m.qZA(),m.YNc(4,f,17,13,"div",3),m.qZA()),2&t&&(m.xp6(2),m.Q6J("src","fr"===m.lcZ(3,2,e.mytranslate.lang)?"assets/1.jpg":"assets/1_ar.jpg",m.LSH),m.xp6(2),m.Q6J("ngIf",!e.session.isPublic))},directives:[o.O5,h.R],pipes:[o.Ov,u.X$],styles:['.border-left[_ngcontent-%COMP%]{border-left:10px solid #a19b9e}.border-right[_ngcontent-%COMP%]{border-right:10px solid #a19b9e}.super-title[_ngcontent-%COMP%]{height:45px}.super-title[_ngcontent-%COMP%], .super-title[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]{display:flex;align-items:center}.super-title[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]{background-color:#d17c36;height:35px}.super-title[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]   h3[_ngcontent-%COMP%]{color:#fff;margin:0;padding:0 5px}.super-title2[_ngcontent-%COMP%]{height:45px;display:flex;align-items:center}.super-title2[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]{height:35px;display:flex;align-items:center}.super-title2[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]   h3[_ngcontent-%COMP%]{color:#a19b9e;margin:0;padding:0 5px;font-size:1.8em}.host[_ngcontent-%COMP%]{margin:0 1em 1em!important}  .mat-progress-spinner circle{fill:#00000008!important}h3[_ngcontent-%COMP%]{margin:4px 0 10px;color:var(--primary);text-align:center}.axes[_ngcontent-%COMP%]{display:flex;flex-direction:column;box-shadow:1px 1px 5px #ddd;padding:5px;margin-bottom:5px}.axes[_ngcontent-%COMP%]   p[_ngcontent-%COMP%]{margin:0;font-size:.8em}.axes[_ngcontent-%COMP%]   .title[_ngcontent-%COMP%]{font-weight:700;margin-bottom:10px;font-size:.9em}@font-face{font-family:Satisfy;font-style:normal;font-weight:400;font-display:swap;src:local("Satisfy Regular"),local("Satisfy-Regular"),url(https://fonts.gstatic.com/s/satisfy/v11/rP2Hp2yn6lkG50LoCZOIHQ.woff2) format("woff2");unicode-range:u+00??,u+0131,u+0152-0153,u+02bb-02bc,u+02c6,u+02da,u+02dc,u+2000-206f,u+2074,u+20ac,u+2122,u+2191,u+2193,u+2212,u+2215,u+feff,u+fffd}.textAlign-left[_ngcontent-%COMP%]{text-align:left}.textAlign-right[_ngcontent-%COMP%], .textSouTitre[_ngcontent-%COMP%]{text-align:right}.textSouTitre[_ngcontent-%COMP%]{font-size:.9em;color:#00000070}.legend[_ngcontent-%COMP%]{list-style:none;height:10px;width:280px}.legend[_ngcontent-%COMP%]   li[_ngcontent-%COMP%]{margin-right:10px}.legend[_ngcontent-%COMP%]   span[_ngcontent-%COMP%]{border:1px solid #ccc;float:left;width:12px;height:12px;margin:2px}.legend[_ngcontent-%COMP%]   .superawesome[_ngcontent-%COMP%]{background-color:#2b6a97}.legend[_ngcontent-%COMP%]   .awesome[_ngcontent-%COMP%], .legend[_ngcontent-%COMP%]   .superawesome[_ngcontent-%COMP%]{width:40px;height:22px;font-size:small;padding:2%}.legend[_ngcontent-%COMP%]   .awesome[_ngcontent-%COMP%]{background-color:#ca7834}.legend[_ngcontent-%COMP%]   .kindaawesome[_ngcontent-%COMP%]{background-color:#7dc460;width:40px;height:22px;font-size:small;padding:2%}.legend[_ngcontent-%COMP%]   li[_ngcontent-%COMP%]{font-size:14px;font-weight:100}']}),t})()}];let b=(()=>{class t{}return t.\u0275fac=function(e){return new(e||t)},t.\u0275mod=m.oAB({type:t}),t.\u0275inj=m.cJS({imports:[[l.Bz.forChild(x)],l.Bz]}),t})();var y=n(23928),P=n(97866);let C=(()=>{class t{}return t.\u0275fac=function(e){return new(e||t)},t.\u0275mod=m.oAB({type:t}),t.\u0275inj=m.cJS({imports:[[u.aw,o.ez,b,i.JF,r.R,a.u5,a.UX,y.N,P.i]]}),t})()}}]);