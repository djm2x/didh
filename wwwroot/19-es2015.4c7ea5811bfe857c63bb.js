(window.webpackJsonp=window.webpackJsonp||[]).push([[19],{"7q3A":function(t,e,n){"use strict";var l=n("kZa3"),r=n("8Y7J");let s=(()=>{class t extends l.a{constructor(){super("Pays")}}return t.ngInjectableDef=r.Sb({factory:function(){return new t},token:t,providedIn:"root"}),t})(),o=(()=>{class t extends l.a{constructor(){super("SituationReserves"),this.getFirst=()=>this.http.get(`${this.urlApi}/${this.controller}/getFirst`)}}return t.ngInjectableDef=r.Sb({factory:function(){return new t},token:t,providedIn:"root"}),t})(),i=(()=>{class t extends l.a{constructor(){super("organes")}}return t.ngInjectableDef=r.Sb({factory:function(){return new t},token:t,providedIn:"root"}),t})(),a=(()=>{class t extends l.a{constructor(){super("traites")}getCount(t){return this.http.get(`${this.urlApi}/traites/getCount/${t}`)}getAll(t,e,n,l,r){return this.http.get(`${this.urlApi}/${this.controller}/getAll/${t}/${e}/${n}/${l}/${r}`)}put$(t){return this.http.post(`${this.urlApi}/traites/put`,t)}}return t.ngInjectableDef=r.Sb({factory:function(){return new t},token:t,providedIn:"root"}),t})(),u=(()=>{class t extends l.a{constructor(){super("notifications")}getAll(t,e,n,l,r){return this.http.get(`${this.urlApi}/${this.controller}/getAll/${t}/${e}/${n}/${l}/${r}`)}}return t.ngInjectableDef=r.Sb({factory:function(){return new t},token:t,providedIn:"root"}),t})(),c=(()=>{class t extends l.a{constructor(){super("cycles")}}return t.ngInjectableDef=r.Sb({factory:function(){return new t},token:t,providedIn:"root"}),t})(),p=(()=>{class t extends l.a{constructor(){super("recommendations")}getCount(t){return this.http.get(`${this.urlApi}/${this.controller}/getCount/${t}`)}recommandationByOrganisme(){return this.http.get(`${this.urlApi}/${this.controller}/recommandationByOrganisme`)}recommandationByCycle(){return this.http.get(`${this.urlApi}/${this.controller}/recommandationByCycle`)}recommandationByAxe(t){return this.http.get(`${this.urlApi}/${this.controller}/recommandationByAxe/${t}`)}recommandationByConvention(t){return this.http.get(`${this.urlApi}/${this.controller}/recommandationByConvention/${t}`)}recommandationByMecanisme(t,e,n){return this.http.get(`${this.urlApi}/${this.controller}/recommandationByMecanisme/${t}/${e}/${n}`)}searchAndGet(t){return this.http.post(`${this.urlApi}/${this.controller}/searchAndGet`,t)}stateParamAxe(t){return this.http.post(`${this.urlApi}/${this.controller}/stateParamAxe`,t)}stateParamOrganisme(t){return this.http.post(`${this.urlApi}/${this.controller}/stateParamOrganisme`,t)}getAllForSynthese(t,e,n,l,r,s,o,i,a){return this.http.get(`${this.urlApi}/${this.controller}/getAllForSynthese/${t}\n      /${e}/${n}/${l}/${r}/${s}/${o}/${i}/${a}`)}getDetail(t){return this.http.get(`${this.urlApi}/${this.controller}/getDetail/${t}`)}getByIdSynthese(t){return this.http.get(`${this.urlApi}/${this.controller}/getByIdSynthese/${t}`)}genericByRecommendation(t,e){return this.http.get(`${this.urlApi}/${this.controller}/genericByRecommendation/${t}/${e}`)}stateRecommendationByOrganisme(){return this.http.get(`${this.urlApi}/${this.controller}/stateRecommendationByOrganisme`)}stateRecommendationByMecanismeTaux(){return this.http.get(`${this.urlApi}/${this.controller}/stateRecommendationByMecanismeTaux`)}stateRecommendationByMecanismePercentage(){return this.http.get(`${this.urlApi}/${this.controller}/stateRecommendationByMecanismePercentage`)}stateRecommendationByAxe(){return this.http.get(`${this.urlApi}/${this.controller}/stateRecommendationByAxe`)}stateEPU(){return this.http.get(`${this.urlApi}/${this.controller}/stateEPU`)}stateOT(){return this.http.get(`${this.urlApi}/${this.controller}/stateOT`)}statePS(){return this.http.get(`${this.urlApi}/${this.controller}/statePS`)}}return t.ngInjectableDef=r.Sb({factory:function(){return new t},token:t,providedIn:"root"}),t})(),h=(()=>{class t extends l.a{constructor(){super("visites")}getDate(t,e){return this.http.get(`${this.urlApi}/${this.controller}/getDate/${t}/${e}`)}}return t.ngInjectableDef=r.Sb({factory:function(){return new t},token:t,providedIn:"root"}),t})(),d=(()=>{class t extends l.a{constructor(){super("profils")}}return t.ngInjectableDef=r.Sb({factory:function(){return new t},token:t,providedIn:"root"}),t})(),m=(()=>{class t extends l.a{constructor(){super("organisme")}getAll(t,e,n,l,r){return this.http.get(`${this.urlApi}/${this.controller}/getAll/${t}/${e}/${n}/${l}/${r}`)}}return t.ngInjectableDef=r.Sb({factory:function(){return new t},token:t,providedIn:"root"}),t})(),g=(()=>{class t extends l.a{constructor(){super("users")}getUsers(t,e,n,l,r){return this.http.get(`${this.urlApi}/users/getUsers?start=`+(t-1)*e+"&number="+e+"&nom="+n+"&prenom="+l+"&organisme="+r)}getAll(t,e,n,l,r="*",s="*",o=0){return this.http.get(`${this.urlApi}/${this.controller}/GetAll/${t}/${e}/${n}/${l}/${r}/${s}/${o}`)}login(t){return this.http.post(`${this.urlApi}/users/login`,t)}}return t.ngInjectableDef=r.Sb({factory:function(){return new t},token:t,providedIn:"root"}),t})();var b=n("WTxg");let f=(()=>{class t extends l.a{constructor(){super("sousAxes")}getByIdAxe(t){return this.http.get(`${this.urlApi}/${this.controller}/getByIdAxe/${t}`)}}return t.ngInjectableDef=r.Sb({factory:function(){return new t},token:t,providedIn:"root"}),t})(),$=(()=>{class t extends l.a{constructor(){super("axes")}}return t.ngInjectableDef=r.Sb({factory:function(){return new t},token:t,providedIn:"root"}),t})(),C=(()=>{class t extends l.a{constructor(){super("syntheses")}getAll(t,e,n,l,r,s,o,i,a,u){return this.http.get(`${this.urlApi}/${this.controller}/getAll/${t}/${e}/${n}/${l}`+`/${r}/${s}/${o}/${i}/${a}/${u}`)}getAllWithNoRapport(t,e,n,l,r){return this.http.get(`${this.urlApi}/${this.controller}/getAllWithNoRapport/${t}/${e}/${n}/${l}/${r}`)}getDetail(t){return this.http.get(`${this.urlApi}/${this.controller}/getDetail/${t}`)}updateRange(t){return this.http.post(`${this.urlApi}/${this.controller}/updateRange`,t)}}return t.ngInjectableDef=r.Sb({factory:function(){return new t},token:t,providedIn:"root"}),t})();var x=n("LRne");let y=(()=>{class t extends l.a{constructor(){super("rapports")}getAllByTraite(t,e,n,l,r){return this.http.get(`${this.urlApi}/${this.controller}/getAllByTraite/${t}/${e}/${n}/${l}/${r}`)}uploadFiles(t){return t?this.http.post(`${this.urlApi}/${this.controller}/uploadFiles`,t,{reportProgress:!0}):Object(x.a)(null)}getByIdTraite(t){return this.http.get(`${this.urlApi}/${this.controller}/getByIdTraite/${t}`)}getByTraite(t){return this.http.get(`${this.urlApi}/${this.controller}/getByTraite/${t}`)}postFile(t){return this.http.post(`${this.urlApi}/files/postFile`,t,{reportProgress:!0})}deleteFile(t,e){return this.http.post(`${this.urlApi}/files/deleteFile/`,{filename:t,folder:e},{reportProgress:!0})}deleteFiles(t,e){return 0===t.length?Object(x.a)(null):this.http.post(`${this.urlApi}/files/deleteFiles/`,{filenames:t,folder:e},{reportProgress:!0})}download(t){return this.http.get(`${this.url}/rapport/${t}`)}}return t.ngInjectableDef=r.Sb({factory:function(){return new t},token:t,providedIn:"root"}),t})(),v=(()=>{class t extends l.a{constructor(){super("recomOrgs")}postRange(t){return this.http.post(`${this.urlApi}/recomOrgs/postRange`,t)}putRange(t,e){return this.http.post(`${this.urlApi}/recomOrgs/putRange`,{modelsToDelete:t,modelsToAdd:e})}deleteRangeCutm(t,e){return this.http.post(`${this.urlApi}/recomOrgs/deleteRange`,{modelsToDelete:t,modelsToAdd:e})}}return t.ngInjectableDef=r.Sb({factory:function(){return new t},token:t,providedIn:"root"}),t})(),k=(()=>{class t extends l.a{constructor(){super("ficheSyntheses")}getAll(t,e,n,l,r){return this.http.get(`${this.urlApi}/${this.controller}/getAll/${t}/${e}/${n}/${l}/${r}`)}}return t.ngInjectableDef=r.Sb({factory:function(){return new t},token:t,providedIn:"root"}),t})(),A=(()=>{class t extends l.a{constructor(){super("SyntheseRecommandations")}putRange(t,e){return this.http.post(`${this.urlApi}/${this.controller}/putRange`,{modelsToDelete:t,modelsToAdd:e})}}return t.ngInjectableDef=r.Sb({factory:function(){return new t},token:t,providedIn:"root"}),t})(),w=(()=>{class t extends l.a{constructor(){super("Examens")}}return t.ngInjectableDef=r.Sb({factory:function(){return new t},token:t,providedIn:"root"}),t})(),O=(()=>{class t extends l.a{constructor(){super("Questionnaires")}getAll(t,e,n,l,r,s){return this.http.get(`${this.urlApi}/${this.controller}/getAll/${t}/${e}/${n}/${l}/${r}/${s}`)}}return t.ngInjectableDef=r.Sb({factory:function(){return new t},token:t,providedIn:"root"}),t})(),S=(()=>{class t extends l.a{constructor(){super("ParticipationSessions")}getAll(t,e,n,l,r){return this.http.get(`${this.urlApi}/${this.controller}/getAll/${t}/${e}/${n}/${l}/${r}`)}}return t.ngInjectableDef=r.Sb({factory:function(){return new t},token:t,providedIn:"root"}),t})(),I=(()=>{class t extends l.a{constructor(){super("evenements")}getAll(t,e,n,l,r){return this.http.get(`${this.urlApi}/${this.controller}/getAll/${t}/${e}/${n}/${l}/${r}`)}}return t.ngInjectableDef=r.Sb({factory:function(){return new t},token:t,providedIn:"root"}),t})();n.d(e,"a",(function(){return P}));let P=(()=>{class t{constructor(){this.users=new g,this.profils=new d,this.organismes=new m,this.visites=new h,this.files=new b.a,this.cycles=new c,this.organes=new i,this.notifications=new u,this.sousAxes=new f,this.axes=new $,this.pays=new s,this.recommendations=new p,this.syntheses=new C,this.rapports=new y,this.traites=new a,this.recomOrgs=new v,this.ficheSyntheses=new k,this.examens=new w,this.syntheseRecommandations=new A,this.situationReserves=new o,this.questionnaires=new O,this.participations=new S,this.evenements=new I,this.mecanismes=["Examen p\xe9riodique universal","Organes de trait\xe9s","Proc\xe9dure sp\xe9ciale"],this.etats=["R\xe9alis\xe9","En cours","En continue","Non r\xe9alis\xe9"],this.monthsAlpha=["Janvier","Fevrier","Mars","Avril","Mai","Juin","Juillet","Ao\xfbt","Septembre","Octobre","Novembre","D\xe9cembre"].map((t,e)=>({id:e+1,name:t}))}valideDate(t){const e=(t=new Date(t)).getHours()-t.getTimezoneOffset()/60,n=(t.getHours()-t.getTimezoneOffset())%60;return t.setHours(e),t.setMinutes(n),t}decoupe(t){const e=t.split(";");return e.pop(),e}}return t.ngInjectableDef=r.Sb({factory:function(){return new t},token:t,providedIn:"root"}),t})()},NvT6:function(t,e,n){"use strict";n.d(e,"a",(function(){return s})),n.d(e,"c",(function(){return a})),n.d(e,"b",(function(){return u})),n.d(e,"d",(function(){return h}));var l=n("8Y7J"),r=(n("W5yJ"),n("SVse")),s=(n("IP0z"),n("Xd0L"),n("cUpR"),n("/HVE"),n("omvX"),l.qb({encapsulation:2,styles:[".mat-progress-spinner{display:block;position:relative}.mat-progress-spinner svg{position:absolute;transform:rotate(-90deg);top:0;left:0;transform-origin:center;overflow:visible}.mat-progress-spinner circle{fill:transparent;transform-origin:center;transition:stroke-dashoffset 225ms linear}._mat-animation-noopable.mat-progress-spinner circle{transition:none;animation:none}.mat-progress-spinner.mat-progress-spinner-indeterminate-animation[mode=indeterminate]{animation:mat-progress-spinner-linear-rotate 2s linear infinite}._mat-animation-noopable.mat-progress-spinner.mat-progress-spinner-indeterminate-animation[mode=indeterminate]{transition:none;animation:none}.mat-progress-spinner.mat-progress-spinner-indeterminate-animation[mode=indeterminate] circle{transition-property:stroke;animation-duration:4s;animation-timing-function:cubic-bezier(.35,0,.25,1);animation-iteration-count:infinite}._mat-animation-noopable.mat-progress-spinner.mat-progress-spinner-indeterminate-animation[mode=indeterminate] circle{transition:none;animation:none}.mat-progress-spinner.mat-progress-spinner-indeterminate-fallback-animation[mode=indeterminate]{animation:mat-progress-spinner-stroke-rotate-fallback 10s cubic-bezier(.87,.03,.33,1) infinite}._mat-animation-noopable.mat-progress-spinner.mat-progress-spinner-indeterminate-fallback-animation[mode=indeterminate]{transition:none;animation:none}.mat-progress-spinner.mat-progress-spinner-indeterminate-fallback-animation[mode=indeterminate] circle{transition-property:stroke}._mat-animation-noopable.mat-progress-spinner.mat-progress-spinner-indeterminate-fallback-animation[mode=indeterminate] circle{transition:none;animation:none}@keyframes mat-progress-spinner-linear-rotate{0%{transform:rotate(0)}100%{transform:rotate(360deg)}}@keyframes mat-progress-spinner-stroke-rotate-100{0%{stroke-dashoffset:268.60617px;transform:rotate(0)}12.5%{stroke-dashoffset:56.54867px;transform:rotate(0)}12.5001%{stroke-dashoffset:56.54867px;transform:rotateX(180deg) rotate(72.5deg)}25%{stroke-dashoffset:268.60617px;transform:rotateX(180deg) rotate(72.5deg)}25.0001%{stroke-dashoffset:268.60617px;transform:rotate(270deg)}37.5%{stroke-dashoffset:56.54867px;transform:rotate(270deg)}37.5001%{stroke-dashoffset:56.54867px;transform:rotateX(180deg) rotate(161.5deg)}50%{stroke-dashoffset:268.60617px;transform:rotateX(180deg) rotate(161.5deg)}50.0001%{stroke-dashoffset:268.60617px;transform:rotate(180deg)}62.5%{stroke-dashoffset:56.54867px;transform:rotate(180deg)}62.5001%{stroke-dashoffset:56.54867px;transform:rotateX(180deg) rotate(251.5deg)}75%{stroke-dashoffset:268.60617px;transform:rotateX(180deg) rotate(251.5deg)}75.0001%{stroke-dashoffset:268.60617px;transform:rotate(90deg)}87.5%{stroke-dashoffset:56.54867px;transform:rotate(90deg)}87.5001%{stroke-dashoffset:56.54867px;transform:rotateX(180deg) rotate(341.5deg)}100%{stroke-dashoffset:268.60617px;transform:rotateX(180deg) rotate(341.5deg)}}@keyframes mat-progress-spinner-stroke-rotate-fallback{0%{transform:rotate(0)}25%{transform:rotate(1170deg)}50%{transform:rotate(2340deg)}75%{transform:rotate(3510deg)}100%{transform:rotate(4680deg)}}"],data:{}}));function o(t){return l.Ob(0,[(t()(),l.sb(0,0,null,null,0,":svg:circle",[["cx","50%"],["cy","50%"]],[[1,"r",0],[4,"animation-name",null],[4,"stroke-dashoffset","px"],[4,"stroke-dasharray","px"],[4,"stroke-width","%"]],null,null,null,null))],null,(function(t,e){var n=e.component;t(e,0,0,n._circleRadius,"mat-progress-spinner-stroke-rotate-"+n.diameter,n._strokeDashOffset,n._strokeCircumference,n._circleStrokeWidth)}))}function i(t){return l.Ob(0,[(t()(),l.sb(0,0,null,null,0,":svg:circle",[["cx","50%"],["cy","50%"]],[[1,"r",0],[4,"stroke-dashoffset","px"],[4,"stroke-dasharray","px"],[4,"stroke-width","%"]],null,null,null,null))],null,(function(t,e){var n=e.component;t(e,0,0,n._circleRadius,n._strokeDashOffset,n._strokeCircumference,n._circleStrokeWidth)}))}function a(t){return l.Ob(2,[(t()(),l.sb(0,0,null,null,5,":svg:svg",[["focusable","false"],["preserveAspectRatio","xMidYMid meet"]],[[4,"width","px"],[4,"height","px"],[1,"viewBox",0]],null,null,null,null)),l.rb(1,16384,null,0,r.p,[],{ngSwitch:[0,"ngSwitch"]},null),(t()(),l.hb(16777216,null,null,1,null,o)),l.rb(3,278528,null,0,r.q,[l.O,l.L,r.p],{ngSwitchCase:[0,"ngSwitchCase"]},null),(t()(),l.hb(16777216,null,null,1,null,i)),l.rb(5,278528,null,0,r.q,[l.O,l.L,r.p],{ngSwitchCase:[0,"ngSwitchCase"]},null)],(function(t,e){t(e,1,0,"indeterminate"===e.component.mode),t(e,3,0,!0),t(e,5,0,!1)}),(function(t,e){var n=e.component;t(e,0,0,n.diameter,n.diameter,n._viewBox)}))}var u=l.qb({encapsulation:2,styles:[".mat-progress-spinner{display:block;position:relative}.mat-progress-spinner svg{position:absolute;transform:rotate(-90deg);top:0;left:0;transform-origin:center;overflow:visible}.mat-progress-spinner circle{fill:transparent;transform-origin:center;transition:stroke-dashoffset 225ms linear}._mat-animation-noopable.mat-progress-spinner circle{transition:none;animation:none}.mat-progress-spinner.mat-progress-spinner-indeterminate-animation[mode=indeterminate]{animation:mat-progress-spinner-linear-rotate 2s linear infinite}._mat-animation-noopable.mat-progress-spinner.mat-progress-spinner-indeterminate-animation[mode=indeterminate]{transition:none;animation:none}.mat-progress-spinner.mat-progress-spinner-indeterminate-animation[mode=indeterminate] circle{transition-property:stroke;animation-duration:4s;animation-timing-function:cubic-bezier(.35,0,.25,1);animation-iteration-count:infinite}._mat-animation-noopable.mat-progress-spinner.mat-progress-spinner-indeterminate-animation[mode=indeterminate] circle{transition:none;animation:none}.mat-progress-spinner.mat-progress-spinner-indeterminate-fallback-animation[mode=indeterminate]{animation:mat-progress-spinner-stroke-rotate-fallback 10s cubic-bezier(.87,.03,.33,1) infinite}._mat-animation-noopable.mat-progress-spinner.mat-progress-spinner-indeterminate-fallback-animation[mode=indeterminate]{transition:none;animation:none}.mat-progress-spinner.mat-progress-spinner-indeterminate-fallback-animation[mode=indeterminate] circle{transition-property:stroke}._mat-animation-noopable.mat-progress-spinner.mat-progress-spinner-indeterminate-fallback-animation[mode=indeterminate] circle{transition:none;animation:none}@keyframes mat-progress-spinner-linear-rotate{0%{transform:rotate(0)}100%{transform:rotate(360deg)}}@keyframes mat-progress-spinner-stroke-rotate-100{0%{stroke-dashoffset:268.60617px;transform:rotate(0)}12.5%{stroke-dashoffset:56.54867px;transform:rotate(0)}12.5001%{stroke-dashoffset:56.54867px;transform:rotateX(180deg) rotate(72.5deg)}25%{stroke-dashoffset:268.60617px;transform:rotateX(180deg) rotate(72.5deg)}25.0001%{stroke-dashoffset:268.60617px;transform:rotate(270deg)}37.5%{stroke-dashoffset:56.54867px;transform:rotate(270deg)}37.5001%{stroke-dashoffset:56.54867px;transform:rotateX(180deg) rotate(161.5deg)}50%{stroke-dashoffset:268.60617px;transform:rotateX(180deg) rotate(161.5deg)}50.0001%{stroke-dashoffset:268.60617px;transform:rotate(180deg)}62.5%{stroke-dashoffset:56.54867px;transform:rotate(180deg)}62.5001%{stroke-dashoffset:56.54867px;transform:rotateX(180deg) rotate(251.5deg)}75%{stroke-dashoffset:268.60617px;transform:rotateX(180deg) rotate(251.5deg)}75.0001%{stroke-dashoffset:268.60617px;transform:rotate(90deg)}87.5%{stroke-dashoffset:56.54867px;transform:rotate(90deg)}87.5001%{stroke-dashoffset:56.54867px;transform:rotateX(180deg) rotate(341.5deg)}100%{stroke-dashoffset:268.60617px;transform:rotateX(180deg) rotate(341.5deg)}}@keyframes mat-progress-spinner-stroke-rotate-fallback{0%{transform:rotate(0)}25%{transform:rotate(1170deg)}50%{transform:rotate(2340deg)}75%{transform:rotate(3510deg)}100%{transform:rotate(4680deg)}}"],data:{}});function c(t){return l.Ob(0,[(t()(),l.sb(0,0,null,null,0,":svg:circle",[["cx","50%"],["cy","50%"]],[[1,"r",0],[4,"animation-name",null],[4,"stroke-dashoffset","px"],[4,"stroke-dasharray","px"],[4,"stroke-width","%"]],null,null,null,null))],null,(function(t,e){var n=e.component;t(e,0,0,n._circleRadius,"mat-progress-spinner-stroke-rotate-"+n.diameter,n._strokeDashOffset,n._strokeCircumference,n._circleStrokeWidth)}))}function p(t){return l.Ob(0,[(t()(),l.sb(0,0,null,null,0,":svg:circle",[["cx","50%"],["cy","50%"]],[[1,"r",0],[4,"stroke-dashoffset","px"],[4,"stroke-dasharray","px"],[4,"stroke-width","%"]],null,null,null,null))],null,(function(t,e){var n=e.component;t(e,0,0,n._circleRadius,n._strokeDashOffset,n._strokeCircumference,n._circleStrokeWidth)}))}function h(t){return l.Ob(2,[(t()(),l.sb(0,0,null,null,5,":svg:svg",[["focusable","false"],["preserveAspectRatio","xMidYMid meet"]],[[4,"width","px"],[4,"height","px"],[1,"viewBox",0]],null,null,null,null)),l.rb(1,16384,null,0,r.p,[],{ngSwitch:[0,"ngSwitch"]},null),(t()(),l.hb(16777216,null,null,1,null,c)),l.rb(3,278528,null,0,r.q,[l.O,l.L,r.p],{ngSwitchCase:[0,"ngSwitchCase"]},null),(t()(),l.hb(16777216,null,null,1,null,p)),l.rb(5,278528,null,0,r.q,[l.O,l.L,r.p],{ngSwitchCase:[0,"ngSwitchCase"]},null)],(function(t,e){t(e,1,0,"indeterminate"===e.component.mode),t(e,3,0,!0),t(e,5,0,!1)}),(function(t,e){var n=e.component;t(e,0,0,n.diameter,n.diameter,n._viewBox)}))}},WTxg:function(t,e,n){"use strict";n.d(e,"a",(function(){return o}));var l=n("kZa3"),r=n("LRne"),s=n("8Y7J");let o=(()=>{class t extends l.a{constructor(){super("files")}postFile(t){return this.http.post(`${this.urlApi}/files/postFile`,t,{reportProgress:!0})}deleteFile(t,e){return this.http.post(`${this.urlApi}/files/deleteFile/`,{filename:t,folder:e},{reportProgress:!0})}download(t){return this.http.get(`${this.url}/Visite/${t}`)}deleteFiles2(t,e){return 0===t.length?Object(r.a)(null):this.http.post(`${this.urlApi}/${this.controller}/deleteFiles/`,{filenames:t,folder:e},{reportProgress:!0})}deleteFiles(t,e){return 0===t.length?Object(r.a)(null):this.http.post(`${this.urlApi}/files/deleteFiles/`,{filenames:t,folder:e},{reportProgress:!0})}uploadFiles(t,e){return t?this.http.post(`${this.urlApi}/${this.controller}/uploadFiles/${e}`,t,{reportProgress:!0}):Object(r.a)(null)}}return t.ngInjectableDef=s.Sb({factory:function(){return new t},token:t,providedIn:"root"}),t})()},iKnG:function(t,e,n){"use strict";n.r(e);var l=n("8Y7J");class r{}var s=n("pMnS"),o=n("NvT6"),i=n("W5yJ"),a=n("/HVE"),u=n("SVse"),c=n("omvX"),p=n("hrfs"),h=n("XNiG");class d{constructor(t){this.uow=t,this.obs=new h.a,this.title="",this.pieChartOptions={responsive:!0,title:{text:"",display:!1},legend:{position:"chartArea",display:!1}},this.pieChartLabels=[],this.pieChartData=[],this.pieChartType="pie",this.pieChartLegend=!0,this.pieChartPlugins=[],this.pieChartColors=[{backgroundColor:[]}],Object(p.e)(),Object(p.d)()}ngOnInit(){const t=["Taux","Etat d\u2019avancement",""];this.obs.subscribe(e=>{"stateEPU"===e.type?(this.title=e.title,this.uow.recommendations.stateEPU().subscribe(e=>{this.pieChartLabels=t,this.pieChartData=[e.t,e.p,100-e.p],this.pieChartColors[0].backgroundColor=this.getColors(this.pieChartLabels.length)})):"stateOT"===e.type?(this.title=e.title,this.uow.recommendations.stateOT().subscribe(e=>{this.pieChartLabels=t,this.pieChartData=[e.t,e.p,100-e.p],this.pieChartColors[0].backgroundColor=this.getColors(this.pieChartLabels.length)})):(this.title=e.title,this.uow.recommendations.statePS().subscribe(e=>{this.pieChartLabels=t,this.pieChartData=[e.t,e.p,100-e.p],this.pieChartColors[0].backgroundColor=this.getColors(this.pieChartLabels.length)}))})}getColors(t){const e=["#d17c36","#496488","#c5c5c500"],n=[];for(let l=0;l<t;l++)n.push(e[l%e.length]);return n}}var m=n("7q3A"),g=l.qb({encapsulation:0,styles:[["p[_ngcontent-%COMP%]{font-family:Lato}"]],data:{}});function b(t){return l.Ob(0,[(t()(),l.sb(0,0,null,null,7,"div",[["class","d-flex flex-column align-items-center justify-content-center"]],null,null,null,null,null)),(t()(),l.sb(1,0,null,null,2,"div",[["style","display: block; width: 300px;"]],null,null,null,null,null)),(t()(),l.sb(2,0,null,null,1,"canvas",[["baseChart",""]],null,null,null,null,null)),l.rb(3,999424,null,0,p.a,[l.k,p.c],{data:[0,"data"],labels:[1,"labels"],options:[2,"options"],chartType:[3,"chartType"],colors:[4,"colors"],legend:[5,"legend"],plugins:[6,"plugins"]},null),(t()(),l.sb(4,0,null,null,3,"div",[["class","d-flex flex-column justify-content-center mt-2"]],null,null,null,null,null)),(t()(),l.sb(5,0,null,null,0,"img",[["height","10px"],["src","assets/line.png"],["width","280px"]],null,null,null,null,null)),(t()(),l.sb(6,0,null,null,1,"h5",[["style","color: #737473; margin: 5px 0 10px 5px;"]],null,null,null,null,null)),(t()(),l.Mb(7,null,[" "," "]))],(function(t,e){var n=e.component;t(e,3,0,n.pieChartData,n.pieChartLabels,n.pieChartOptions,n.pieChartType,n.pieChartColors,n.pieChartLegend,n.pieChartPlugins)}),(function(t,e){t(e,7,0,e.component.title)}))}var f=n("2Vo4");class ${constructor(t,e){this.uow=t,this.session=e,this.mecanismes=this.uow.mecanismes,this.pieChartSubjectEPU=new f.a({type:"stateEPU",title:"Recommandations par m\xe9canismes / Examen P\xe9riodique universell"}),this.pieChartSubjectOT=new f.a({type:"stateOT",title:"Taux de recommandations par m\xe9canismes / Organes de Trait\xe9s"}),this.pieChartSubjectPS=new f.a({type:"statePS",title:"Taux de recommandations par m\xe9canismes / Proc\xe9dures sp\xe9ciales"}),this.list=[],this.axesValue=[]}ngOnInit(){this.stateRecommendationByOrganisme(),this.stateRecommendationByAxe()}stateRecommendationByOrganisme(){return this.uow.recommendations.stateRecommendationByOrganisme().subscribe(t=>{this.list=t})}stateRecommendationByAxe(){return this.uow.recommendations.stateRecommendationByAxe().subscribe(t=>{console.log(t),this.axesValue=t})}selectChange(t){t.toLocaleLowerCase().includes("organe"),t.toLocaleLowerCase().includes("examen")}}var C=n("0hB7"),x=l.qb({encapsulation:0,styles:[[".super-title[_ngcontent-%COMP%]{border-left:10px solid #a19b9e;height:45px;display:flex;align-items:center}.super-title[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]{background-color:#d17c36;height:35px;display:flex;align-items:center}.super-title[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]   h3[_ngcontent-%COMP%]{color:#fff;margin:0;padding:0 5px}.host[_ngcontent-%COMP%]{margin:1em!important}  .mat-progress-spinner circle{fill:#00000012!important}h3[_ngcontent-%COMP%]{margin:20px 0 10px;color:var(--primary);text-align:center}.axes[_ngcontent-%COMP%]{display:flex;flex-direction:column;box-shadow:1px 1px 5px #ddd;padding:5px;margin-bottom:5px}.axes[_ngcontent-%COMP%]   p[_ngcontent-%COMP%]{margin:0;font-size:.8em}.axes[_ngcontent-%COMP%]   .title[_ngcontent-%COMP%]{font-weight:700;margin-bottom:10px;font-size:.9em}"]],data:{}});function y(t){return l.Ob(0,[(t()(),l.sb(0,0,null,null,1,"span",[["style","color: white; font-weight: bold;"]],[[4,"margin-left","px"]],null,null,null,null)),(t()(),l.Mb(1,null,[" "," % "]))],null,(function(t,e){t(e,0,0,0===e.context.index?16:"147.5"),t(e,1,0,e.context.$implicit.value)}))}function v(t){return l.Ob(0,[(t()(),l.sb(0,0,null,null,8,"div",[],null,null,null,null,null)),(t()(),l.sb(1,0,null,null,7,"div",[["class","d-flex flex-column pl-2 pr-2 mb-3 mt-3"]],null,null,null,null,null)),(t()(),l.sb(2,0,null,null,4,"div",[["class"," pl-4 pr-4"],["style","height: 110px;"]],null,null,null,null,null)),(t()(),l.sb(3,0,null,null,1,"mat-progress-spinner",[["class","mat-progress-spinner"],["mode","determinate"],["role","progressbar"]],[[2,"_mat-animation-noopable",null],[4,"width","px"],[4,"height","px"],[1,"aria-valuemin",0],[1,"aria-valuemax",0],[1,"aria-valuenow",0],[1,"mode",0]],null,null,o.c,o.a)),l.rb(4,114688,null,0,i.b,[l.k,a.a,[2,u.d],[2,c.a],i.a],{mode:[0,"mode"],value:[1,"value"]},null),(t()(),l.sb(5,0,null,null,1,"div",[["style","position:relative; top: -60px; left: 30px;"]],null,null,null,null,null)),(t()(),l.Mb(6,null,[""," %"])),(t()(),l.sb(7,0,null,null,1,"p",[["style","width: 170px; margin: 0; font-size: .9em; text-align: center;"]],null,null,null,null,null)),(t()(),l.Mb(8,null,["",""]))],(function(t,e){t(e,4,0,"determinate",0!==e.context.$implicit.value?e.context.$implicit.value:1)}),(function(t,e){t(e,3,0,l.Eb(e,4)._noopAnimations,l.Eb(e,4).diameter,l.Eb(e,4).diameter,"determinate"===l.Eb(e,4).mode?0:null,"determinate"===l.Eb(e,4).mode?100:null,"determinate"===l.Eb(e,4).mode?l.Eb(e,4).value:null,l.Eb(e,4).mode),t(e,6,0,e.context.$implicit.value),t(e,8,0,e.context.$implicit.name)}))}function k(t){return l.Ob(0,[(t()(),l.sb(0,0,null,null,45,"div",[["class","host"]],null,null,null,null,null)),(t()(),l.sb(1,0,null,null,4,"div",[["class","d-flex justify-content-center w-100"]],null,null,null,null,null)),(t()(),l.sb(2,0,null,null,3,"section",[["class","super-title"]],null,null,null,null,null)),(t()(),l.sb(3,0,null,null,2,"div",[],null,null,null,null,null)),(t()(),l.sb(4,0,null,null,1,"h3",[],null,null,null,null,null)),(t()(),l.Mb(-1,null,["Syst\xe8me de Suivi des recommandations des m\xe9canismes onusiens des droits de l\u2019homme"])),(t()(),l.sb(6,0,null,null,1,"h3",[["style","font-size: 1.4em;"]],null,null,null,null,null)),(t()(),l.Mb(-1,null,["\xab \ufea3\ufed8\ufeee\u0642 \u0627\ufefb\ufee7\ufeb4\ufe8e\u0646 \ufefb \ufe97\ufe84\u062a\u064a \ufed3\ufed8\ufec2 \ufe91\ufe8e\ufccc\ufec4\ufe8e\ufedf\ufe92\ufe94 \ufe91\ufede \u0623\ufef3\ufec0\ufe8e \ufe91\ufe84\u062f\u0627\u0621 \u0627\ufedf\ufeee\u0627\ufe9f\ufe90 \xbb"])),(t()(),l.sb(8,0,null,null,14,"div",[["class","row mt-3"]],null,null,null,null,null)),(t()(),l.sb(9,0,null,null,13,"div",[["class","col-md-12"]],null,null,null,null,null)),(t()(),l.sb(10,0,null,null,12,"div",[["class","row w-100"]],null,null,null,null,null)),(t()(),l.sb(11,0,null,null,3,"div",[["class","col-md-12"]],null,null,null,null,null)),(t()(),l.sb(12,0,null,null,2,"div",[["class","chart-size"]],null,null,null,null,null)),(t()(),l.sb(13,0,null,null,1,"app-doughnut",[],null,null,null,b,g)),l.rb(14,114688,null,0,d,[m.a],{obs:[0,"obs"],pieChartType:[1,"pieChartType"]},null),(t()(),l.sb(15,0,null,null,3,"div",[["class","col-md-6"]],null,null,null,null,null)),(t()(),l.sb(16,0,null,null,2,"div",[["class","chart-size"]],null,null,null,null,null)),(t()(),l.sb(17,0,null,null,1,"app-doughnut",[],null,null,null,b,g)),l.rb(18,114688,null,0,d,[m.a],{obs:[0,"obs"],pieChartType:[1,"pieChartType"]},null),(t()(),l.sb(19,0,null,null,3,"div",[["class","col-md-6"]],null,null,null,null,null)),(t()(),l.sb(20,0,null,null,2,"div",[["class","chart-size"]],null,null,null,null,null)),(t()(),l.sb(21,0,null,null,1,"app-doughnut",[],null,null,null,b,g)),l.rb(22,114688,null,0,d,[m.a],{obs:[0,"obs"],pieChartType:[1,"pieChartType"]},null),(t()(),l.sb(23,0,null,null,4,"div",[["class","d-flex justify-content-center w-100 mt-5 mb-5"]],null,null,null,null,null)),(t()(),l.sb(24,0,null,null,3,"section",[["class","super-title"]],null,null,null,null,null)),(t()(),l.sb(25,0,null,null,2,"div",[],null,null,null,null,null)),(t()(),l.sb(26,0,null,null,1,"h3",[],null,null,null,null,null)),(t()(),l.Mb(-1,null,["Mise en \u0153uvre des recommandations"])),(t()(),l.sb(28,0,null,null,6,"div",[["class","row"]],null,null,null,null,null)),(t()(),l.sb(29,0,null,null,5,"div",[["class","col-md-12"]],null,null,null,null,null)),(t()(),l.sb(30,0,null,null,4,"div",[["style","position: relative;height: 350px;"]],null,null,null,null,null)),(t()(),l.sb(31,0,null,null,2,"div",[["class","d-flex flex-nowrap"],["style","position: absolute;top: 87px;z-index: 10;width: 1500px;"]],null,null,null,null,null)),(t()(),l.hb(16777216,null,null,1,null,y)),l.rb(33,278528,null,0,u.k,[l.O,l.L,l.r],{ngForOf:[0,"ngForOf"]},null),(t()(),l.sb(34,0,null,null,0,"img",[["src","assets/meo.png"],["style","position: absolute;width: 1500px;"]],null,null,null,null,null)),(t()(),l.sb(35,0,null,null,4,"div",[["class","d-flex justify-content-center w-100 mb-5"],["style","margin-top: 50px;"]],null,null,null,null,null)),(t()(),l.sb(36,0,null,null,3,"section",[["class","super-title"]],null,null,null,null,null)),(t()(),l.sb(37,0,null,null,2,"div",[],null,null,null,null,null)),(t()(),l.sb(38,0,null,null,1,"h3",[],null,null,null,null,null)),(t()(),l.Mb(-1,null,["Etat d\u2019avancement des recommandations \u2013 d\xe9partements"])),(t()(),l.sb(40,0,null,null,5,"div",[["class","row mb-5"]],null,null,null,null,null)),(t()(),l.sb(41,0,null,null,4,"div",[["class","col-md-12"]],null,null,null,null,null)),(t()(),l.sb(42,0,null,null,3,"div",[],null,null,null,null,null)),(t()(),l.sb(43,0,null,null,2,"div",[["class","d-flex flex-wrap justify-content-center"]],null,null,null,null,null)),(t()(),l.hb(16777216,null,null,1,null,v)),l.rb(45,278528,null,0,u.k,[l.O,l.L,l.r],{ngForOf:[0,"ngForOf"]},null)],(function(t,e){var n=e.component;t(e,14,0,n.pieChartSubjectEPU,"doughnut"),t(e,18,0,n.pieChartSubjectOT,"doughnut"),t(e,22,0,n.pieChartSubjectPS,"doughnut"),t(e,33,0,n.axesValue),t(e,45,0,n.list)}),null)}function A(t){return l.Ob(0,[(t()(),l.sb(0,0,null,null,1,"app-home",[],null,null,null,k,x)),l.rb(1,114688,null,0,$,[m.a,C.a],null,null)],(function(t,e){t(e,1,0)}),null)}var w=l.ob("app-home",$,A,{},{},[]),O=n("yWMr"),S=n("t68o"),I=n("zbXB"),P=n("NcP4"),j=n("xYTU"),R=n("IheW"),D=n("5GAg"),B=n("DkaU"),T=n("QQfA"),_=n("IP0z"),M=n("/Co4"),F=n("POq0"),L=n("Xd0L"),E=n("qJ5m"),q=n("s6ns"),X=n("821u"),z=n("gavF"),U=n("fgD+"),W=n("JjoW"),J=n("Mz6y"),N=n("cUpR"),V=n("OIZN"),H=n("7kcP"),Z=n("s7LF"),G=n("iInd");class Q{}var Y=n("zQui"),K=n("zMNK"),tt=n("hOhj"),et=n("KPQW"),nt=n("lwm9"),lt=n("Fwaw"),rt=n("mkRZ"),st=n("igqZ"),ot=n("r0V8"),it=n("kNGD"),at=n("qJ50"),ut=n("Gi4r"),ct=n("02hT"),pt=n("5Bek"),ht=n("c9fC"),dt=n("FVPZ"),mt=n("oapL"),gt=n("HsOI"),bt=n("ZwOa"),ft=n("Q+lL"),$t=n("8P0U"),Ct=n("elxJ"),xt=n("BV1i"),yt=n("lT8R"),vt=n("pBi1"),kt=n("dFDH"),At=n("8rEH"),wt=n("rWV4"),Ot=n("BzsH"),St=n("AaDx"),It=n("2thQ"),Pt=n("Ry++"),jt=n("Dgsr"),Rt=n("dvZr");n.d(e,"HomeModuleNgFactory",(function(){return Dt}));var Dt=l.pb(r,[],(function(t){return l.Bb([l.Cb(512,l.j,l.ab,[[8,[s.a,w,O.a,S.a,I.b,I.a,P.a,j.a,j.b]],[3,l.j],l.w]),l.Cb(4608,u.n,u.m,[l.t,[2,u.C]]),l.Cb(4608,R.j,R.p,[u.d,l.A,R.n]),l.Cb(4608,R.q,R.q,[R.j,R.o]),l.Cb(5120,R.a,(function(t){return[t]}),[R.q]),l.Cb(4608,R.m,R.m,[]),l.Cb(6144,R.k,null,[R.m]),l.Cb(4608,R.i,R.i,[R.k]),l.Cb(6144,R.b,null,[R.i]),l.Cb(4608,R.g,R.l,[R.b,l.q]),l.Cb(4608,R.c,R.c,[R.g]),l.Cb(135680,D.h,D.h,[l.y,a.a]),l.Cb(4608,B.e,B.e,[l.L]),l.Cb(4608,T.c,T.c,[T.i,T.e,l.j,T.h,T.f,l.q,l.y,u.d,_.b,[2,u.h]]),l.Cb(5120,T.j,T.k,[T.c]),l.Cb(5120,M.b,M.c,[T.c]),l.Cb(4608,F.c,F.c,[]),l.Cb(4608,L.d,L.d,[]),l.Cb(5120,E.b,E.a,[[3,E.b]]),l.Cb(5120,q.c,q.d,[T.c]),l.Cb(135680,q.e,q.e,[T.c,l.q,[2,u.h],[2,q.b],q.c,[3,q.e],T.e]),l.Cb(4608,X.i,X.i,[]),l.Cb(5120,X.a,X.b,[T.c]),l.Cb(5120,z.c,z.j,[T.c]),l.Cb(4608,L.c,U.d,[L.h,U.a]),l.Cb(5120,W.a,W.b,[T.c]),l.Cb(5120,J.b,J.c,[T.c]),l.Cb(4608,N.e,L.e,[[2,L.i],[2,L.n]]),l.Cb(5120,V.c,V.a,[[3,V.c]]),l.Cb(5120,H.d,H.a,[[3,H.d]]),l.Cb(4608,Z.v,Z.v,[]),l.Cb(4608,Z.e,Z.e,[]),l.Cb(1073742336,u.c,u.c,[]),l.Cb(1073742336,G.q,G.q,[[2,G.v],[2,G.m]]),l.Cb(1073742336,Q,Q,[]),l.Cb(1073742336,R.e,R.e,[]),l.Cb(1073742336,R.d,R.d,[]),l.Cb(1073742336,Y.p,Y.p,[]),l.Cb(1073742336,B.c,B.c,[]),l.Cb(1073742336,_.a,_.a,[]),l.Cb(1073742336,L.n,L.n,[[2,L.f],[2,N.f]]),l.Cb(1073742336,a.b,a.b,[]),l.Cb(1073742336,L.y,L.y,[]),l.Cb(1073742336,L.w,L.w,[]),l.Cb(1073742336,L.t,L.t,[]),l.Cb(1073742336,K.g,K.g,[]),l.Cb(1073742336,tt.c,tt.c,[]),l.Cb(1073742336,T.g,T.g,[]),l.Cb(1073742336,M.e,M.e,[]),l.Cb(1073742336,F.d,F.d,[]),l.Cb(1073742336,D.a,D.a,[]),l.Cb(1073742336,et.a,et.a,[]),l.Cb(1073742336,nt.e,nt.e,[]),l.Cb(1073742336,lt.c,lt.c,[]),l.Cb(1073742336,rt.a,rt.a,[]),l.Cb(1073742336,st.e,st.e,[]),l.Cb(1073742336,ot.d,ot.d,[]),l.Cb(1073742336,ot.c,ot.c,[]),l.Cb(1073742336,it.b,it.b,[]),l.Cb(1073742336,at.e,at.e,[]),l.Cb(1073742336,ut.c,ut.c,[]),l.Cb(1073742336,E.c,E.c,[]),l.Cb(1073742336,q.k,q.k,[]),l.Cb(1073742336,X.j,X.j,[]),l.Cb(1073742336,ct.b,ct.b,[]),l.Cb(1073742336,pt.c,pt.c,[]),l.Cb(1073742336,ht.d,ht.d,[]),l.Cb(1073742336,L.p,L.p,[]),l.Cb(1073742336,dt.a,dt.a,[]),l.Cb(1073742336,mt.c,mt.c,[]),l.Cb(1073742336,gt.e,gt.e,[]),l.Cb(1073742336,bt.c,bt.c,[]),l.Cb(1073742336,ft.c,ft.c,[]),l.Cb(1073742336,z.i,z.i,[]),l.Cb(1073742336,z.f,z.f,[]),l.Cb(1073742336,L.A,L.A,[]),l.Cb(1073742336,L.q,L.q,[]),l.Cb(1073742336,W.d,W.d,[]),l.Cb(1073742336,J.e,J.e,[]),l.Cb(1073742336,V.d,V.d,[]),l.Cb(1073742336,$t.c,$t.c,[]),l.Cb(1073742336,i.c,i.c,[]),l.Cb(1073742336,Ct.a,Ct.a,[]),l.Cb(1073742336,xt.h,xt.h,[]),l.Cb(1073742336,yt.a,yt.a,[]),l.Cb(1073742336,vt.b,vt.b,[]),l.Cb(1073742336,vt.a,vt.a,[]),l.Cb(1073742336,kt.e,kt.e,[]),l.Cb(1073742336,H.e,H.e,[]),l.Cb(1073742336,At.l,At.l,[]),l.Cb(1073742336,wt.k,wt.k,[]),l.Cb(1073742336,Ot.b,Ot.b,[]),l.Cb(1073742336,St.a,St.a,[]),l.Cb(1073742336,U.e,U.e,[]),l.Cb(1073742336,U.c,U.c,[]),l.Cb(1073742336,It.a,It.a,[]),l.Cb(1073742336,Z.u,Z.u,[]),l.Cb(1073742336,Z.j,Z.j,[]),l.Cb(1073742336,Z.r,Z.r,[]),l.Cb(1073742336,p.b,p.b,[]),l.Cb(1073742336,Pt.a,Pt.a,[]),l.Cb(1073742336,jt.a,jt.a,[]),l.Cb(1073742336,r,r,[]),l.Cb(1024,G.k,(function(){return[[{path:"home",redirectTo:"",pathMatch:"full"},{path:"",component:$}]]}),[]),l.Cb(256,R.n,"XSRF-TOKEN",[]),l.Cb(256,R.o,"X-XSRF-TOKEN",[]),l.Cb(256,it.a,{separatorKeyCodes:[Rt.f]},[]),l.Cb(256,L.g,U.b,[])])}))},kZa3:function(t,e,n){"use strict";n.d(e,"a",(function(){return s}));var l=n("IheW"),r=n("zg4H");class s{constructor(t){this.controller=t,this.http=r.a.injector.get(l.c),this.urlApi=r.a.injector.get("API_URL"),this.url=r.a.injector.get("BASE_URL"),this.get=()=>this.http.get(`${this.urlApi}/${this.controller}/get`),this.count=()=>this.http.get(`${this.urlApi}/${this.controller}/count`),this.getOne=t=>this.http.get(`${this.urlApi}/${this.controller}/get/${t}`),this.post=t=>this.http.post(`${this.urlApi}/${this.controller}/post`,t),this.put=(t,e)=>this.http.put(`${this.urlApi}/${this.controller}/put/${t}`,e),this.delete=t=>this.http.delete(`${this.urlApi}/${this.controller}/delete/${t}`)}getList(t,e,n,l){return this.http.get(`${this.urlApi}/${this.controller}/getAll/${t}/${e}/${n}/${l}`)}updateRange(t){return this.http.post(`${this.urlApi}/${this.controller}/updateRange`,t)}deleteRange(t){return this.http.post(`${this.urlApi}/${this.controller}/deleteRange`,t)}postRange(t){return this.http.post(`${this.urlApi}/${this.controller}/postRange`,t)}autocomplete(t,e){return this.http.get(`${this.urlApi}/${this.controller}/autocomplete/${t}/${e}`)}autocompletePost(t,e){return this.http.post(`${this.urlApi}/${this.controller}/autocompletePost`,{column:t,name:e})}}}}]);