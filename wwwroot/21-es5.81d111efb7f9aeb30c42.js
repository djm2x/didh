(window.webpackJsonp=window.webpackJsonp||[]).push([[21],{AT23:function(l,n,e){"use strict";var a=e("8Y7J"),t=e("lzlj"),u=e("igqZ"),i=e("omvX"),b=e("hrfs");e("oz3B"),e("7q3A"),e.d(n,"a",(function(){return o})),e.d(n,"b",(function(){return r}));var o=a.qb({encapsulation:0,styles:[["p[_ngcontent-%COMP%]{font-family:Lato}"]],data:{}});function r(l){return a.Ob(0,[(l()(),a.sb(0,0,null,null,7,"mat-card",[["class","mat-card"]],[[2,"_mat-animation-noopable",null]],null,null,t.b,t.a)),a.rb(1,49152,null,0,u.a,[[2,i.a]],null,null),(l()(),a.sb(2,0,null,0,2,"div",[["class","d-flex justify-content-center"]],null,null,null,null,null)),(l()(),a.sb(3,0,null,null,1,"h5",[["style","color: rgb(94, 94, 94); margin: 0 0 10px 0;"]],null,null,null,null,null)),(l()(),a.Mb(4,null,["",""])),(l()(),a.sb(5,0,null,0,2,"div",[["style","display: block;"]],null,null,null,null,null)),(l()(),a.sb(6,0,null,null,1,"canvas",[["baseChart",""]],null,null,null,null,null)),a.rb(7,999424,null,0,b.a,[a.k,b.c],{data:[0,"data"],labels:[1,"labels"],options:[2,"options"],chartType:[3,"chartType"],colors:[4,"colors"],legend:[5,"legend"],plugins:[6,"plugins"]},null)],(function(l,n){var e=n.component;l(n,7,0,e.pieChartData,e.pieChartLabels,e.pieChartOptions,e.pieChartType,e.pieChartColors,e.pieChartLegend,e.pieChartPlugins)}),(function(l,n){var e=n.component;l(n,0,0,"NoopAnimations"===a.Eb(n,1)._animationMode),l(n,4,0,e.title)}))}},"Ry++":function(l,n,e){"use strict";e.d(n,"a",(function(){return a}));var a=function(){}},iKnG:function(l,n,e){"use strict";e.r(n);var a=e("8Y7J"),t=function(){},u=e("pMnS"),i=e("MlvX"),b=e("Xd0L"),o=e("NvT6"),r=e("W5yJ"),c=e("/HVE"),s=e("SVse"),d=e("omvX"),p=e("dJrM"),C=e("HsOI"),m=e("IP0z"),h=e("Azqq"),f=e("JjoW"),g=e("hOhj"),v=e("s7LF"),E=e("5GAg"),y=e("AT23"),w=e("oz3B"),x=e("7q3A"),_=e("lzlj"),F=e("igqZ"),k=e("2Vo4"),O=function(){function l(l,n){this.uow=l,this.session=n,this.mecanismes=this.uow.mecanismes,this.pieChartSubject=new k.a({table:"axe",type:"count",title:"Etat d\u2019avancement des recommandations par axe"}),this.pieChartSubjectC=new k.a({table:"axe",type:"taux",title:"Taux de recommandations par axe"}),this.list=[]}return l.prototype.ngOnInit=function(){this.stateRecommendationByOrganisme()},l.prototype.stateRecommendationByOrganisme=function(){var l=this;return this.uow.recommendations.stateRecommendationByOrganisme().subscribe((function(n){l.list=n}))},l.prototype.selectChange=function(l){var n=l.toLocaleLowerCase().includes("organe"),e=l.toLocaleLowerCase().includes("examen"),a=n?"organe":e?"axe":"visite";this.pieChartSubjectC.next({table:a,type:"count",title:"Etat d\u2019avancement des recommandations par "+l}),this.pieChartSubject.next({table:a,type:"taux",title:"Taux de recommandations par "+l})},l}(),q=e("0hB7"),j=a.qb({encapsulation:0,styles:[[".host[_ngcontent-%COMP%]{margin:1em!important}  .mat-progress-spinner circle{fill:#00000012!important}"]],data:{}});function A(l){return a.Ob(0,[(l()(),a.sb(0,0,null,null,2,"mat-option",[["class","mat-option"],["role","option"]],[[1,"tabindex",0],[2,"mat-selected",null],[2,"mat-option-multiple",null],[2,"mat-active",null],[8,"id",0],[1,"aria-selected",0],[1,"aria-disabled",0],[2,"mat-option-disabled",null]],[[null,"click"],[null,"keydown"]],(function(l,n,e){var t=!0;return"click"===n&&(t=!1!==a.Eb(l,1)._selectViaInteraction()&&t),"keydown"===n&&(t=!1!==a.Eb(l,1)._handleKeydown(e)&&t),t}),i.c,i.a)),a.rb(1,8568832,[[10,4]],0,b.s,[a.k,a.h,[2,b.l],[2,b.r]],{value:[0,"value"]},null),(l()(),a.Mb(2,0,["",""]))],(function(l,n){l(n,1,0,n.context.$implicit)}),(function(l,n){l(n,0,0,a.Eb(n,1)._getTabIndex(),a.Eb(n,1).selected,a.Eb(n,1).multiple,a.Eb(n,1).active,a.Eb(n,1).id,a.Eb(n,1)._getAriaSelected(),a.Eb(n,1).disabled.toString(),a.Eb(n,1).disabled),l(n,2,0,n.context.$implicit)}))}function L(l){return a.Ob(0,[(l()(),a.sb(0,0,null,null,8,"div",[],null,null,null,null,null)),(l()(),a.sb(1,0,null,null,7,"div",[["class","d-flex flex-column pl-2 pr-2 mb-3 mt-3"]],null,null,null,null,null)),(l()(),a.sb(2,0,null,null,4,"div",[["class"," pl-4 pr-4"],["style","height: 110px;"]],null,null,null,null,null)),(l()(),a.sb(3,0,null,null,1,"mat-progress-spinner",[["class","mat-progress-spinner"],["mode","determinate"],["role","progressbar"]],[[2,"_mat-animation-noopable",null],[4,"width","px"],[4,"height","px"],[1,"aria-valuemin",0],[1,"aria-valuemax",0],[1,"aria-valuenow",0],[1,"mode",0]],null,null,o.c,o.a)),a.rb(4,114688,null,0,r.b,[a.k,c.a,[2,s.d],[2,d.a],r.a],{mode:[0,"mode"],value:[1,"value"]},null),(l()(),a.sb(5,0,null,null,1,"div",[["style","position:relative; top: -60px; left: 30px;"]],null,null,null,null,null)),(l()(),a.Mb(6,null,[""," %"])),(l()(),a.sb(7,0,null,null,1,"p",[["style","width: 170px; margin: 0; font-size: .9em; text-align: center;"]],null,null,null,null,null)),(l()(),a.Mb(8,null,["",""]))],(function(l,n){l(n,4,0,"determinate",0!==n.context.$implicit.value?n.context.$implicit.value:1)}),(function(l,n){l(n,3,0,a.Eb(n,4)._noopAnimations,a.Eb(n,4).diameter,a.Eb(n,4).diameter,"determinate"===a.Eb(n,4).mode?0:null,"determinate"===a.Eb(n,4).mode?100:null,"determinate"===a.Eb(n,4).mode?a.Eb(n,4).value:null,a.Eb(n,4).mode),l(n,6,0,n.context.$implicit.value),l(n,8,0,n.context.$implicit.name)}))}function S(l){return a.Ob(0,[(l()(),a.sb(0,0,null,null,42,"div",[["class","host"]],null,null,null,null,null)),(l()(),a.sb(1,0,null,null,31,"div",[["class","row"]],null,null,null,null,null)),(l()(),a.sb(2,0,null,null,22,"mat-form-field",[["class","col-md-6 mat-form-field"]],[[2,"mat-form-field-appearance-standard",null],[2,"mat-form-field-appearance-fill",null],[2,"mat-form-field-appearance-outline",null],[2,"mat-form-field-appearance-legacy",null],[2,"mat-form-field-invalid",null],[2,"mat-form-field-can-float",null],[2,"mat-form-field-should-float",null],[2,"mat-form-field-has-label",null],[2,"mat-form-field-hide-placeholder",null],[2,"mat-form-field-disabled",null],[2,"mat-form-field-autofilled",null],[2,"mat-focused",null],[2,"mat-accent",null],[2,"mat-warn",null],[2,"ng-untouched",null],[2,"ng-touched",null],[2,"ng-pristine",null],[2,"ng-dirty",null],[2,"ng-valid",null],[2,"ng-invalid",null],[2,"ng-pending",null],[2,"_mat-animation-noopable",null]],null,null,p.b,p.a)),a.rb(3,7520256,null,9,C.c,[a.k,a.h,[2,b.j],[2,m.b],[2,C.a],c.a,a.y,[2,d.a]],null,null),a.Kb(603979776,1,{_controlNonStatic:0}),a.Kb(335544320,2,{_controlStatic:0}),a.Kb(603979776,3,{_labelChildNonStatic:0}),a.Kb(335544320,4,{_labelChildStatic:0}),a.Kb(603979776,5,{_placeholderChild:0}),a.Kb(603979776,6,{_errorChildren:1}),a.Kb(603979776,7,{_hintChildren:1}),a.Kb(603979776,8,{_prefixChildren:1}),a.Kb(603979776,9,{_suffixChildren:1}),(l()(),a.sb(13,0,null,3,2,"mat-label",[],null,null,null,null,null)),a.rb(14,16384,[[3,4],[4,4]],0,C.f,[],null,null),(l()(),a.Mb(-1,null,["Mecanismes"])),(l()(),a.sb(16,0,null,1,8,"mat-select",[["class","mat-select"],["role","listbox"],["value","Examen p\xe9riodique universal"]],[[1,"id",0],[1,"tabindex",0],[1,"aria-label",0],[1,"aria-labelledby",0],[1,"aria-required",0],[1,"aria-disabled",0],[1,"aria-invalid",0],[1,"aria-owns",0],[1,"aria-multiselectable",0],[1,"aria-describedby",0],[1,"aria-activedescendant",0],[2,"mat-select-disabled",null],[2,"mat-select-invalid",null],[2,"mat-select-required",null],[2,"mat-select-empty",null]],[[null,"selectionChange"],[null,"keydown"],[null,"focus"],[null,"blur"]],(function(l,n,e){var t=!0,u=l.component;return"keydown"===n&&(t=!1!==a.Eb(l,18)._handleKeydown(e)&&t),"focus"===n&&(t=!1!==a.Eb(l,18)._onFocus()&&t),"blur"===n&&(t=!1!==a.Eb(l,18)._onBlur()&&t),"selectionChange"===n&&(t=!1!==u.selectChange(e.value)&&t),t}),h.b,h.a)),a.Jb(6144,null,b.l,null,[f.c]),a.rb(18,2080768,null,3,f.c,[g.e,a.h,a.y,b.d,a.k,[2,m.b],[2,v.p],[2,v.i],[2,C.c],[8,null],[8,null],f.a,E.j],{value:[0,"value"]},{selectionChange:"selectionChange"}),a.Kb(603979776,10,{options:1}),a.Kb(603979776,11,{optionGroups:1}),a.Kb(603979776,12,{customTrigger:0}),a.Jb(2048,[[1,4],[2,4]],C.d,null,[f.c]),(l()(),a.hb(16777216,null,1,1,null,A)),a.rb(24,278528,null,0,s.k,[a.O,a.L,a.r],{ngForOf:[0,"ngForOf"]},null),(l()(),a.sb(25,0,null,null,7,"div",[["class","col-md-12"]],null,null,null,null,null)),(l()(),a.sb(26,0,null,null,6,"div",[["class","row w-100"]],null,null,null,null,null)),(l()(),a.sb(27,0,null,null,2,"div",[["class","col-md-6"]],null,null,null,null,null)),(l()(),a.sb(28,0,null,null,1,"app-pie-chart",[],null,null,null,y.b,y.a)),a.rb(29,114688,null,0,w.a,[x.a],{obs:[0,"obs"]},null),(l()(),a.sb(30,0,null,null,2,"div",[["class","col-md-6"]],null,null,null,null,null)),(l()(),a.sb(31,0,null,null,1,"app-pie-chart",[],null,null,null,y.b,y.a)),a.rb(32,114688,null,0,w.a,[x.a],{obs:[0,"obs"]},null),(l()(),a.sb(33,0,null,null,9,"div",[["class","row"]],null,null,null,null,null)),(l()(),a.sb(34,0,null,null,8,"div",[["class","col-md-12"]],null,null,null,null,null)),(l()(),a.sb(35,0,null,null,7,"mat-card",[["class","mat-card"]],[[2,"_mat-animation-noopable",null]],null,null,_.b,_.a)),a.rb(36,49152,null,0,F.a,[[2,d.a]],null,null),(l()(),a.sb(37,0,null,0,2,"div",[["class","d-flex justify-content-center"]],null,null,null,null,null)),(l()(),a.sb(38,0,null,null,1,"h5",[["style","color: rgb(94, 94, 94); margin: 0 0 10px 0;"]],null,null,null,null,null)),(l()(),a.Mb(-1,null,["Etat d\u2019avancement des recommandations \u2013 d\xe9partements"])),(l()(),a.sb(40,0,null,0,2,"div",[["class","d-flex flex-wrap justify-content-center"]],null,null,null,null,null)),(l()(),a.hb(16777216,null,null,1,null,L)),a.rb(42,278528,null,0,s.k,[a.O,a.L,a.r],{ngForOf:[0,"ngForOf"]},null)],(function(l,n){var e=n.component;l(n,18,0,"Examen p\xe9riodique universal"),l(n,24,0,e.mecanismes),l(n,29,0,e.pieChartSubject),l(n,32,0,e.pieChartSubjectC),l(n,42,0,e.list)}),(function(l,n){l(n,2,1,["standard"==a.Eb(n,3).appearance,"fill"==a.Eb(n,3).appearance,"outline"==a.Eb(n,3).appearance,"legacy"==a.Eb(n,3).appearance,a.Eb(n,3)._control.errorState,a.Eb(n,3)._canLabelFloat,a.Eb(n,3)._shouldLabelFloat(),a.Eb(n,3)._hasFloatingLabel(),a.Eb(n,3)._hideControlPlaceholder(),a.Eb(n,3)._control.disabled,a.Eb(n,3)._control.autofilled,a.Eb(n,3)._control.focused,"accent"==a.Eb(n,3).color,"warn"==a.Eb(n,3).color,a.Eb(n,3)._shouldForward("untouched"),a.Eb(n,3)._shouldForward("touched"),a.Eb(n,3)._shouldForward("pristine"),a.Eb(n,3)._shouldForward("dirty"),a.Eb(n,3)._shouldForward("valid"),a.Eb(n,3)._shouldForward("invalid"),a.Eb(n,3)._shouldForward("pending"),!a.Eb(n,3)._animationsEnabled]),l(n,16,1,[a.Eb(n,18).id,a.Eb(n,18).tabIndex,a.Eb(n,18)._getAriaLabel(),a.Eb(n,18)._getAriaLabelledby(),a.Eb(n,18).required.toString(),a.Eb(n,18).disabled.toString(),a.Eb(n,18).errorState,a.Eb(n,18).panelOpen?a.Eb(n,18)._optionIds:null,a.Eb(n,18).multiple,a.Eb(n,18)._ariaDescribedby||null,a.Eb(n,18)._getAriaActiveDescendant(),a.Eb(n,18).disabled,a.Eb(n,18).errorState,a.Eb(n,18).required,a.Eb(n,18).empty]),l(n,35,0,"NoopAnimations"===a.Eb(n,36)._animationMode)}))}var K=a.ob("app-home",O,(function(l){return a.Ob(0,[(l()(),a.sb(0,0,null,null,1,"app-home",[],null,null,null,S,j)),a.rb(1,114688,null,0,O,[x.a,q.a],null,null)],(function(l,n){l(n,1,0)}),null)}),{},{},[]),B=e("yWMr"),M=e("t68o"),T=e("zbXB"),D=e("NcP4"),z=e("xYTU"),N=e("IheW"),J=e("DkaU"),P=e("QQfA"),I=e("/Co4"),R=e("POq0"),X=e("qJ5m"),V=e("s6ns"),Z=e("821u"),G=e("gavF"),H=e("fgD+"),Q=e("Mz6y"),W=e("cUpR"),$=e("OIZN"),U=e("7kcP"),Y=e("iInd"),ll=function(){},nl=e("zQui"),el=e("zMNK"),al=e("KPQW"),tl=e("lwm9"),ul=e("Fwaw"),il=e("mkRZ"),bl=e("r0V8"),ol=e("kNGD"),rl=e("qJ50"),cl=e("Gi4r"),sl=e("02hT"),dl=e("5Bek"),pl=e("c9fC"),Cl=e("FVPZ"),ml=e("oapL"),hl=e("ZwOa"),fl=e("Q+lL"),gl=e("8P0U"),vl=e("elxJ"),El=e("BV1i"),yl=e("lT8R"),wl=e("pBi1"),xl=e("dFDH"),_l=e("8rEH"),Fl=e("rWV4"),kl=e("BzsH"),Ol=e("AaDx"),ql=e("2thQ"),jl=e("hrfs"),Al=e("Ry++"),Ll=e("dvZr");e.d(n,"HomeModuleNgFactory",(function(){return Sl}));var Sl=a.pb(t,[],(function(l){return a.Bb([a.Cb(512,a.j,a.ab,[[8,[u.a,K,B.a,M.a,T.b,T.a,D.a,z.a,z.b]],[3,a.j],a.w]),a.Cb(4608,s.n,s.m,[a.t,[2,s.C]]),a.Cb(4608,N.j,N.p,[s.d,a.A,N.n]),a.Cb(4608,N.q,N.q,[N.j,N.o]),a.Cb(5120,N.a,(function(l){return[l]}),[N.q]),a.Cb(4608,N.m,N.m,[]),a.Cb(6144,N.k,null,[N.m]),a.Cb(4608,N.i,N.i,[N.k]),a.Cb(6144,N.b,null,[N.i]),a.Cb(4608,N.g,N.l,[N.b,a.q]),a.Cb(4608,N.c,N.c,[N.g]),a.Cb(135680,E.h,E.h,[a.y,c.a]),a.Cb(4608,J.e,J.e,[a.L]),a.Cb(4608,P.c,P.c,[P.i,P.e,a.j,P.h,P.f,a.q,a.y,s.d,m.b,[2,s.h]]),a.Cb(5120,P.j,P.k,[P.c]),a.Cb(5120,I.b,I.c,[P.c]),a.Cb(4608,R.c,R.c,[]),a.Cb(4608,b.d,b.d,[]),a.Cb(5120,X.b,X.a,[[3,X.b]]),a.Cb(5120,V.c,V.d,[P.c]),a.Cb(135680,V.e,V.e,[P.c,a.q,[2,s.h],[2,V.b],V.c,[3,V.e],P.e]),a.Cb(4608,Z.i,Z.i,[]),a.Cb(5120,Z.a,Z.b,[P.c]),a.Cb(5120,G.c,G.j,[P.c]),a.Cb(4608,b.c,H.d,[b.h,H.a]),a.Cb(5120,f.a,f.b,[P.c]),a.Cb(5120,Q.b,Q.c,[P.c]),a.Cb(4608,W.e,b.e,[[2,b.i],[2,b.n]]),a.Cb(5120,$.c,$.a,[[3,$.c]]),a.Cb(5120,U.d,U.a,[[3,U.d]]),a.Cb(4608,v.u,v.u,[]),a.Cb(4608,v.e,v.e,[]),a.Cb(1073742336,s.c,s.c,[]),a.Cb(1073742336,Y.q,Y.q,[[2,Y.v],[2,Y.m]]),a.Cb(1073742336,ll,ll,[]),a.Cb(1073742336,N.e,N.e,[]),a.Cb(1073742336,N.d,N.d,[]),a.Cb(1073742336,nl.p,nl.p,[]),a.Cb(1073742336,J.c,J.c,[]),a.Cb(1073742336,m.a,m.a,[]),a.Cb(1073742336,b.n,b.n,[[2,b.f],[2,W.f]]),a.Cb(1073742336,c.b,c.b,[]),a.Cb(1073742336,b.y,b.y,[]),a.Cb(1073742336,b.w,b.w,[]),a.Cb(1073742336,b.t,b.t,[]),a.Cb(1073742336,el.g,el.g,[]),a.Cb(1073742336,g.c,g.c,[]),a.Cb(1073742336,P.g,P.g,[]),a.Cb(1073742336,I.e,I.e,[]),a.Cb(1073742336,R.d,R.d,[]),a.Cb(1073742336,E.a,E.a,[]),a.Cb(1073742336,al.a,al.a,[]),a.Cb(1073742336,tl.e,tl.e,[]),a.Cb(1073742336,ul.c,ul.c,[]),a.Cb(1073742336,il.a,il.a,[]),a.Cb(1073742336,F.e,F.e,[]),a.Cb(1073742336,bl.d,bl.d,[]),a.Cb(1073742336,bl.c,bl.c,[]),a.Cb(1073742336,ol.b,ol.b,[]),a.Cb(1073742336,rl.e,rl.e,[]),a.Cb(1073742336,cl.c,cl.c,[]),a.Cb(1073742336,X.c,X.c,[]),a.Cb(1073742336,V.k,V.k,[]),a.Cb(1073742336,Z.j,Z.j,[]),a.Cb(1073742336,sl.b,sl.b,[]),a.Cb(1073742336,dl.c,dl.c,[]),a.Cb(1073742336,pl.d,pl.d,[]),a.Cb(1073742336,b.p,b.p,[]),a.Cb(1073742336,Cl.a,Cl.a,[]),a.Cb(1073742336,ml.c,ml.c,[]),a.Cb(1073742336,C.e,C.e,[]),a.Cb(1073742336,hl.c,hl.c,[]),a.Cb(1073742336,fl.c,fl.c,[]),a.Cb(1073742336,G.i,G.i,[]),a.Cb(1073742336,G.f,G.f,[]),a.Cb(1073742336,b.A,b.A,[]),a.Cb(1073742336,b.q,b.q,[]),a.Cb(1073742336,f.d,f.d,[]),a.Cb(1073742336,Q.e,Q.e,[]),a.Cb(1073742336,$.d,$.d,[]),a.Cb(1073742336,gl.c,gl.c,[]),a.Cb(1073742336,r.c,r.c,[]),a.Cb(1073742336,vl.a,vl.a,[]),a.Cb(1073742336,El.h,El.h,[]),a.Cb(1073742336,yl.a,yl.a,[]),a.Cb(1073742336,wl.b,wl.b,[]),a.Cb(1073742336,wl.a,wl.a,[]),a.Cb(1073742336,xl.e,xl.e,[]),a.Cb(1073742336,U.e,U.e,[]),a.Cb(1073742336,_l.l,_l.l,[]),a.Cb(1073742336,Fl.k,Fl.k,[]),a.Cb(1073742336,kl.b,kl.b,[]),a.Cb(1073742336,Ol.a,Ol.a,[]),a.Cb(1073742336,H.e,H.e,[]),a.Cb(1073742336,H.c,H.c,[]),a.Cb(1073742336,ql.a,ql.a,[]),a.Cb(1073742336,v.t,v.t,[]),a.Cb(1073742336,v.j,v.j,[]),a.Cb(1073742336,v.q,v.q,[]),a.Cb(1073742336,jl.b,jl.b,[]),a.Cb(1073742336,Al.a,Al.a,[]),a.Cb(1073742336,t,t,[]),a.Cb(1024,Y.k,(function(){return[[{path:"home",redirectTo:"",pathMatch:"full"},{path:"",component:O}]]}),[]),a.Cb(256,N.n,"XSRF-TOKEN",[]),a.Cb(256,N.o,"X-XSRF-TOKEN",[]),a.Cb(256,ol.a,{separatorKeyCodes:[Ll.f]},[]),a.Cb(256,b.g,H.b,[])])}))},oz3B:function(l,n,e){"use strict";e.d(n,"a",(function(){return u}));var a=e("hrfs"),t=e("XNiG"),u=function(){function l(l){this.uow=l,this.obs=new t.a,this.title="",this.pieChartOptions={responsive:!0,title:{text:"",display:!1},legend:{position:"chartArea",display:!1}},this.pieChartLabels=[],this.pieChartData=[],this.pieChartType="pie",this.pieChartLegend=!0,this.pieChartPlugins=[],this.pieChartColors=[{backgroundColor:[]}],Object(a.e)(),Object(a.d)()}return l.prototype.ngOnInit=function(){var l=this;this.obs.subscribe((function(n){l.title=n.title,l.uow.recommendations.genericByRecommendation(n.table,n.type).subscribe((function(n){l.pieChartLabels=n.map((function(l){return l.table})),l.pieChartData=n.map((function(l){return l.value})),l.pieChartColors[0].backgroundColor=l.getColors(l.pieChartLabels.length)}))}))},l.prototype.getColors=function(l){for(var n=["#0074D9","#FF4136","#2ECC40","#FF851B","#7FDBFF","#B10DC9","#FFDC00","#001f3f","#39CCCC","#01FF70","#85144b","#F012BE","#3D9970","#111111","#AAAAAA"],e=[],a=0;a<l;a++)e.push(n[a%n.length]);return e},l}()}}]);