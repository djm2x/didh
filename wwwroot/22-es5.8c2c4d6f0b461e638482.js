(window.webpackJsonp=window.webpackJsonp||[]).push([[22],{ExPl:function(t,e,n){"use strict";var a=n("8Y7J"),l=n("SVse"),i=n("hrfs");n("oTHA"),n("J3i2"),n("s6ns"),n.d(e,"a",(function(){return o})),n.d(e,"b",(function(){return s}));var o=a.qb({encapsulation:0,styles:[['p[_ngcontent-%COMP%]{font-family:Lato}.border-left[_ngcontent-%COMP%]{border-left:10px solid #d17c36}.border-right[_ngcontent-%COMP%]{border-right:10px solid #d17c36}.super-title[_ngcontent-%COMP%]{height:45px;display:flex;align-items:center}.super-title[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]{background-color:#a19b9e;height:35px;display:flex;align-items:center}.super-title[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]   h3[_ngcontent-%COMP%]{color:#fff;margin:0;padding:0 5px}.super-title2[_ngcontent-%COMP%]{height:45px;display:flex;align-items:center}.super-title2[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]{height:35px;display:flex;align-items:center}.super-title2[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]   h3[_ngcontent-%COMP%]{color:#a19b9e;margin:0;padding:0 5px;font-size:1.8em}.host[_ngcontent-%COMP%]{margin:1em!important}  .mat-progress-spinner circle{fill:#00000008!important}h3[_ngcontent-%COMP%]{margin:20px 0 10px;color:var(--primary);text-align:center;font-size:medium}.axes[_ngcontent-%COMP%]{display:flex;flex-direction:column;box-shadow:1px 1px 5px #ddd;padding:5px;margin-bottom:5px}.axes[_ngcontent-%COMP%]   p[_ngcontent-%COMP%]{margin:0;font-size:.8em}.axes[_ngcontent-%COMP%]   .title[_ngcontent-%COMP%]{font-weight:700;margin-bottom:10px;font-size:.9em}@font-face{font-family:Satisfy;font-style:normal;font-weight:400;font-display:swap;src:local("Satisfy Regular"),local("Satisfy-Regular"),url(https://fonts.gstatic.com/s/satisfy/v11/rP2Hp2yn6lkG50LoCZOIHQ.woff2) format("woff2");unicode-range:U+0000-00FF,U+0131,U+0152-0153,U+02BB-02BC,U+02C6,U+02DA,U+02DC,U+2000-206F,U+2074,U+20AC,U+2122,U+2191,U+2193,U+2212,U+2215,U+FEFF,U+FFFD}.textAlign-left[_ngcontent-%COMP%]{text-align:left}.textAlign-right[_ngcontent-%COMP%]{text-align:right}.textSouTitre[_ngcontent-%COMP%]{text-align:right;margin-bottom:2%;font-size:.9em;color:#00000070}']],data:{}});function r(t){return a.Ob(0,[(t()(),a.sb(0,0,null,null,5,"div",[["class","d-flex justify-content-left w-100"],["style","margin-top: 2%; "]],null,null,null,null,null)),(t()(),a.sb(1,0,null,null,4,"section",[],[[8,"className",0]],null,null,null,null)),a.Gb(131072,l.b,[a.h]),(t()(),a.sb(3,0,null,null,2,"div",[],null,null,null,null,null)),(t()(),a.sb(4,0,null,null,1,"h3",[["style","font-size: 1.2em;"]],null,null,null,null,null)),(t()(),a.Mb(5,null,["",""]))],null,(function(t,e){var n=e.component;t(e,1,0,"fr"===a.Nb(e,1,0,a.Eb(e,2).transform(n.mytranslate.lang))?"super-title border-left":"super-title border-right"),t(e,5,0,""===n.title?".......":n.title)}))}function s(t){return a.Ob(0,[(t()(),a.sb(0,0,null,null,6,"div",[],null,null,null,null,null)),(t()(),a.hb(16777216,null,null,1,null,r)),a.rb(2,16384,null,0,l.l,[a.O,a.L],{ngIf:[0,"ngIf"]},null),(t()(),a.sb(3,0,null,null,3,"div",[["class"," mb-5"],["style","cursor: pointer;"]],null,[[null,"click"]],(function(t,e,n){var a=!0;return"click"===e&&(a=!1!==t.component.openDialog()&&a),a}),null,null)),(t()(),a.sb(4,0,null,null,2,"div",[["style","display: block; width: 100vw;height: 100%;"]],[[8,"className",0]],null,null,null,null)),(t()(),a.sb(5,0,null,null,1,"canvas",[["baseChart",""]],null,[[null,"chartHover"],[null,"chartClick"]],(function(t,e,n){var a=!0,l=t.component;return"chartHover"===e&&(a=!1!==l.chartHovered(n)&&a),"chartClick"===e&&(a=!1!==l.chartClicked(n)&&a),a}),null,null)),a.rb(6,999424,null,0,i.a,[a.k,i.c],{datasets:[0,"datasets"],labels:[1,"labels"],options:[2,"options"],chartType:[3,"chartType"],colors:[4,"colors"],legend:[5,"legend"],plugins:[6,"plugins"]},{chartClick:"chartClick",chartHover:"chartHover"})],(function(t,e){var n=e.component;t(e,2,0,n.title&&""!==n.title),t(e,6,0,n.barChartData,n.barChartLabels,n.barChartOptions,n.barChartType,n.pieChartColors,n.barChartLegend,n.pieChartPlugins)}),(function(t,e){t(e,4,0,"col-md-"+e.component.col)}))}},hSFZ:function(t,e){!function(){"use strict";if("undefined"!=typeof Chart){"function"!=typeof Object.assign&&(Object.assign=function(t,e){if(null==t)throw new TypeError("Cannot convert undefined or null to object");for(var n=Object(t),a=1;a<arguments.length;a++){var l=arguments[a];if(null!=l)for(var i in l)Object.prototype.hasOwnProperty.call(l,i)&&(n[i]=l[i])}return n});var t={};["pie","doughnut","polarArea","bar"].forEach((function(e){t[e]=!0})),e.prototype.setup=function(t,e){this.chart=t,this.ctx=t.ctx,this.args={},this.barTotal={};var n=t.config.options;this.options=Object.assign({position:"default",precision:0,fontSize:n.defaultFontSize,fontColor:n.defaultFontColor,fontStyle:n.defaultFontStyle,fontFamily:n.defaultFontFamily,shadowOffsetX:3,shadowOffsetY:3,shadowColor:"rgba(0,0,0,0.3)",shadowBlur:6,images:[],outsidePadding:2,textMargin:2,overlap:!0},e),"bar"===t.config.type&&(this.options.position="default",this.options.arc=!1,this.options.overlap=!0)},e.prototype.render=function(){this.labelBounds=[],this.chart.data.datasets.forEach(this.renderToDataset)},e.prototype.renderToDataset=function(t,e){this.totalPercentage=0,this.total=null;var n=this.args[e];n.meta.data.forEach((function(e,a){this.renderToElement(t,n,e,a)}).bind(this))},e.prototype.renderToElement=function(t,e,n,a){if(this.shouldRenderToElement(e.meta,n)){this.percentage=null;var l=this.getLabel(t,n,a);if(l){var i=this.ctx;i.save(),i.font=Chart.helpers.fontString(this.options.fontSize,this.options.fontStyle,this.options.fontFamily);var o=this.getRenderInfo(n,l);this.drawable(n,l,o)?(i.beginPath(),i.fillStyle=this.getFontColor(t,n,a),this.renderLabel(l,o),i.restore()):i.restore()}}},e.prototype.renderLabel=function(t,e){return this.options.arc?this.renderArcLabel(t,e):this.renderBaseLabel(t,e)},e.prototype.renderBaseLabel=function(t,e){var n=this.ctx;if("object"==typeof t)n.drawImage(t,e.x-t.width/2,e.y-t.height/2,t.width,t.height);else{n.save(),n.textBaseline="top",n.textAlign="center",this.options.textShadow&&(n.shadowOffsetX=this.options.shadowOffsetX,n.shadowOffsetY=this.options.shadowOffsetY,n.shadowColor=this.options.shadowColor,n.shadowBlur=this.options.shadowBlur);for(var a=t.split("\n"),l=0;l<a.length;l++)n.fillText(a[l],e.x,e.y-this.options.fontSize/2*a.length+this.options.fontSize*l);n.restore()}},e.prototype.renderArcLabel=function(t,e){var n=this.ctx,a=e.radius,l=e.view;if(n.save(),n.translate(l.x,l.y),"string"==typeof t){n.rotate(e.startAngle),n.textBaseline="middle",n.textAlign="left";var i=t.split("\n"),o=0,r=[],s=0;"border"===this.options.position&&(s=(i.length-1)*this.options.fontSize/2);for(var u=0;u<i.length;++u){var c=n.measureText(i[u]);c.width>o&&(o=c.width),r.push(c.width)}for(u=0;u<i.length;++u){var h=i[u],d=(i.length-1-u)*-this.options.fontSize+s;n.save(),n.rotate((o-r[u])/2/a);for(var p=0;p<h.length;p++){var b=h.charAt(p);c=n.measureText(b),n.save(),n.translate(0,-1*a),n.fillText(b,0,d),n.restore(),n.rotate(c.width/a)}n.restore()}}else n.rotate((l.startAngle+Math.PI/2+e.endAngle)/2),n.translate(0,-1*a),this.renderLabel(t,{x:0,y:0});n.restore()},e.prototype.shouldRenderToElement=function(t,e){return!t.hidden&&!e.hidden&&(this.options.showZero||"polarArea"===this.chart.config.type?0!==e._view.outerRadius:0!==e._view.circumference)},e.prototype.getLabel=function(t,e,n){var a;if("function"==typeof this.options.render)a=this.options.render({label:this.chart.config.data.labels[n],value:t.data[n],percentage:this.getPercentage(t,e,n),dataset:t,index:n});else switch(this.options.render){case"value":a=t.data[n];break;case"label":a=this.chart.config.data.labels[n];break;case"image":a=this.options.images[n]?this.loadImage(this.options.images[n]):"";break;case"percentage":default:a=this.getPercentage(t,e,n)+"%"}return"object"==typeof a?a=this.loadImage(a):null!=a&&(a=a.toString()),a},e.prototype.getFontColor=function(t,e,n){var a=this.options.fontColor;return"function"==typeof a?a=a({label:this.chart.config.data.labels[n],value:t.data[n],percentage:this.getPercentage(t,e,n),backgroundColor:t.backgroundColor[n],dataset:t,index:n}):"string"!=typeof a&&(a=a[n]||this.chart.config.options.defaultFontColor),a},e.prototype.getPercentage=function(t,e,n){if(null!==this.percentage)return this.percentage;var a;if("polarArea"===this.chart.config.type){if(null===this.total){this.total=0;for(var l=0;l<t.data.length;++l)this.total+=t.data[l]}a=t.data[n]/this.total*100}else if("bar"===this.chart.config.type){if(void 0===this.barTotal[n])for(this.barTotal[n]=0,l=0;l<this.chart.data.datasets.length;++l)this.barTotal[n]+=this.chart.data.datasets[l].data[n];a=t.data[n]/this.barTotal[n]*100}else a=e._view.circumference/this.chart.config.options.circumference*100;return a=parseFloat(a.toFixed(this.options.precision)),this.options.showActualPercentages||("bar"===this.chart.config.type&&(this.totalPercentage=this.barTotalPercentage[n]||0),this.totalPercentage+=a,this.totalPercentage>100&&(a-=this.totalPercentage-100,a=parseFloat(a.toFixed(this.options.precision))),"bar"===this.chart.config.type&&(this.barTotalPercentage[n]=this.totalPercentage)),this.percentage=a,a},e.prototype.getRenderInfo=function(t,e){return"bar"===this.chart.config.type?this.getBarRenderInfo(t,e):this.options.arc?this.getArcRenderInfo(t,e):this.getBaseRenderInfo(t,e)},e.prototype.getBaseRenderInfo=function(t,e){if("outside"===this.options.position||"border"===this.options.position){var n,a,l=t._view,i=l.startAngle+(l.endAngle-l.startAngle)/2,o=l.outerRadius/2;if("border"===this.options.position?a=(l.outerRadius-o)/2+o:"outside"===this.options.position&&(a=l.outerRadius-o+o+this.options.textMargin),n={x:l.x+Math.cos(i)*a,y:l.y+Math.sin(i)*a},"outside"===this.options.position){var r=this.options.textMargin+this.measureLabel(e).width/2;n.x+=n.x<l.x?-r:r}return n}return t.tooltipPosition()},e.prototype.getArcRenderInfo=function(t,e){var n,a=t._view;n="outside"===this.options.position?a.outerRadius+this.options.fontSize+this.options.textMargin:"border"===this.options.position?(a.outerRadius/2+a.outerRadius)/2:(a.innerRadius+a.outerRadius)/2;var l=a.startAngle,i=a.endAngle,o=i-l;return l+=Math.PI/2,{radius:n,startAngle:l+=((i+=Math.PI/2)-(this.measureLabel(e).width/n+l))/2,endAngle:i,totalAngle:o,view:a}},e.prototype.getBarRenderInfo=function(t,e){var n=t.tooltipPosition();return n.y-=this.measureLabel(e).height/2+this.options.textMargin,n},e.prototype.drawable=function(t,e,n){if(this.options.overlap)return!0;if(this.options.arc)return n.endAngle-n.startAngle<=n.totalAngle;var a=this.measureLabel(e),l=n.x-a.width/2,i=n.x+a.width/2,o=n.y-a.height/2,r=n.y+a.height/2;return"outside"===this.options.renderInfo?this.outsideInRange(l,i,o,r):t.inRange(l,o)&&t.inRange(l,r)&&t.inRange(i,o)&&t.inRange(i,r)},e.prototype.outsideInRange=function(t,e,n,a){for(var l=this.labelBounds,i=0;i<l.length;++i){for(var o=l[i],r=[[t,n],[t,a],[e,n],[e,a]],s=0;s<r.length;++s){var u=r[s][1];if((c=r[s][0])>=o.left&&c<=o.right&&u>=o.top&&u<=o.bottom)return!1}for(r=[[o.left,o.top],[o.left,o.bottom],[o.right,o.top],[o.right,o.bottom]],s=0;s<r.length;++s){var c;if(u=r[s][1],(c=r[s][0])>=t&&c<=e&&u>=n&&u<=a)return!1}}return l.push({left:t,right:e,top:n,bottom:a}),!0},e.prototype.measureLabel=function(t){if("object"==typeof t)return{width:t.width,height:t.height};for(var e=0,n=t.split("\n"),a=0;a<n.length;++a){var l=this.ctx.measureText(n[a]);l.width>e&&(e=l.width)}return{width:e,height:this.options.fontSize*n.length}},e.prototype.loadImage=function(t){var e=new Image;return e.src=t.src,e.width=t.width,e.height=t.height,e},Chart.plugins.register({id:"labels",beforeDatasetsUpdate:function(n,a){if(t[n.config.type]){Array.isArray(a)||(a=[a]);var l=a.length;n._labels&&l===n._labels.length||(n._labels=a.map((function(){return new e})));for(var i=!1,o=0,r=0;r<l;++r){var s=n._labels[r];if(s.setup(n,a[r]),"outside"===s.options.position){i=!0;var u=1.5*s.options.fontSize+s.options.outsidePadding;u>o&&(o=u)}}i&&(n.chartArea.top+=o,n.chartArea.bottom-=o)}},afterDatasetUpdate:function(e,n,a){t[e.config.type]&&e._labels.forEach((function(t){t.args[n.index]=n}))},beforeDraw:function(e){t[e.config.type]&&e._labels.forEach((function(t){t.barTotalPercentage={}}))},afterDatasetsDraw:function(e){t[e.config.type]&&e._labels.forEach((function(t){t.render()}))}})}else console.error("Can not find Chart object.");function e(){this.renderToDataset=this.renderToDataset.bind(this)}}()},iKnG:function(t,e,n){"use strict";n.r(e);var a=n("8Y7J"),l=function(){},i=n("pMnS"),o=n("SVse"),r=n("TSSN"),s=n("ExPl"),u=n("oTHA"),c=n("J3i2"),h=n("s6ns"),d=n("2Vo4"),p=n("XNiG"),b=function(){function t(t,e,n){this.uow=t,this.session=e,this.mytranslate=n,this.mecanismes=this.uow.mecanismes,this.pieChartSubjectEPU=new d.a({type:"stateEPU",title:"Examen P\xe9riodique universel"}),this.pieChartSubjectOT=new d.a({type:"stateOT",title:"Organes de Trait\xe9s"}),this.pieChartSubjectPS=new d.a({type:"statePS",title:"Proc\xe9dures sp\xe9ciales"}),this.list=[],this.axesValue=[],this.listSubject=[],this.dataEpu=new p.a,this.dataOt=new p.a,this.dataPs=new p.a,this.dataMec=new p.a,this.dataMec1=new p.a,this.dataValues=new p.a,this.departementSubjectPE=new p.a,this.departementSubjectAutre=new p.a,this.departementSubjectIN=new p.a,this.departementSubjectPJ=new p.a,this.e=new p.a}return t.prototype.ngOnInit=function(){this.stateRecommendationByOrganisme(),this.stateRecommendationByAxe(),this.stateMecanisme1(),this.stateDepartement(),this.RecommandationValues()},t.prototype.stateMecanisme1=function(){var t=this;this.uow.recommendations.stateMecanisme().subscribe((function(e){var n=[];n.push(t.mytranslate.get("admin.header.ExamenP\xe9riodiqueuniverselle")),n.push(t.mytranslate.get("admin.header.OrganesdeTrait\xe9s")),n.push(t.mytranslate.get("admin.header.Proc\xe9duressp\xe9ciales"));var a=[];a.push(e.epu.t),a.push(e.ot.t),a.push(e.ps.t);var l=[];l.push("#f47942"),l.push("#95979a"),l.push("#0070a3"),t.dataMec1.next({chartLabels:n,chartData:a,chartColors:l,dataToShowInTable:[],count:e.count,title:"Mise en \u0153uvre des recommandations par m\xe9canismes"})}))},t.prototype.stateMecanisme=function(){var t=this;this.uow.recommendations.stateMecanisme().subscribe((function(e){var n=[];n.push(t.mytranslate.get("admin.header.ExamenP\xe9riodiqueuniverselleEnCours")),n.push(t.mytranslate.get("admin.header.ExamenP\xe9riodiqueuniverselleRealise")),n.push(t.mytranslate.get("admin.header.ExamenP\xe9riodiqueuniverselleNonRealise")),n.push(t.mytranslate.get("admin.header.OrganesdeTrait\xe9sEnCours")),n.push(t.mytranslate.get("admin.header.OrganesdeTrait\xe9sRealise")),n.push(t.mytranslate.get("admin.header.OrganesdeTrait\xe9sNonRealise")),n.push(t.mytranslate.get("admin.header.Proc\xe9duressp\xe9cialesEnCours")),n.push(t.mytranslate.get("admin.header.Proc\xe9duressp\xe9cialesRealise")),n.push(t.mytranslate.get("admin.header.Proc\xe9duressp\xe9cialesNonRealise"));var a=[],l=[];a.push(e.epu.p*e.epu.t/100),a.push(e.epu.r*e.epu.t/100),a.push(e.epu.t-e.epu.p*e.epu.t/100-e.epu.r*e.epu.t/100),l.push(a[2]),a.push(e.ot.p*e.ot.t/100),a.push(e.ot.r*e.ot.t/100),a.push(e.ot.t-e.ot.p*e.ot.t/100-e.ot.r*e.ot.t/100),l.push(a[5]),a.push(e.ps.p*e.ps.t/100),a.push(e.ps.r*e.ps.t/100),a.push(e.ps.t-e.ps.p*e.ps.t/100-e.ps.r*e.ps.t/100),l.push(a[8]);for(var i=[],o=["#f4cf3b","#838383","#ec6e62"],r=0;r<3;r++)i.push("#d17c36"),i.push("#7dc460"),i.push(o[r]);t.dataMec.next({chartLabels:n,chartData:a,chartColors:i,dataToShowInTable:l,count:e.count,title:"Mise en \u0153uvre des recommandations par m\xe9canismes Detail\xe9e"})}))},t.prototype.RecommandationValues=function(){var t=this;this.uow.recommendations.recommandationValues().subscribe((function(e){var n=[];n.push("Recommandations r\xe9alis\xe9es"),n.push("Recommandations en cours de r\xe9alisation"),n.push("Recommandations non r\xe9alis\xe9es");var a=[];a.push(e.realise*e.count/100),a.push(e.enCours*e.count/100),a.push(e.nonRealise*e.count/100);var l=[];l.push("#14933f"),l.push("#fcb534"),l.push("#c12a1b"),t.dataValues.next({chartLabels:n,chartData:a,chartColors:l,dataToShowInTable:[],count:e.count,title:"Mise en \u0153uvre des recommandations par m\xe9canismes"})}))},t.prototype.stateMecanisme0=function(){var t=this;this.uow.recommendations.stateMecanisme().subscribe((function(e){e.epu.name=t.mytranslate.getObs("admin.home.ExamenP\xe9riodiqueuniversell"),t.dataEpu.next(e.epu),e.ot.name=t.mytranslate.getObs("admin.home.OrganesdeTrait\xe9s"),t.dataOt.next(e.ot),e.ps.name=t.mytranslate.getObs("admin.home.Proc\xe9duressp\xe9ciales"),t.dataPs.next(e.ps)}))},t.prototype.stateRecommendationByOrganisme=function(){var t=this;return this.uow.recommendations.stateRecommendationByOrganisme().subscribe((function(e){t.list=e}))},t.prototype.stateDepartement=function(){var t=this,e=["Int\xe9rieur et DGSN","Economie et Finances et Fonction Public","Agriculture et P\xeache maritime","Equipement, Eau et Environnement","Communication et Culture","D\xe9fense Nationale et Gendarmerie Royale","Droits de l\u2019Homme et Relations avec parlement","D\xe9veloppement Social et Solidarit\xe9"],n=["\u0627\u0644\u062f\u0627\u062e\u0644\u064a\u0629 \u0648 DGSN","\u0627\u0644\u0627\u0642\u062a\u0635\u0627\u062f \u0648\u0627\u0644\u0645\u0627\u0644\u064a\u0629 \u0648\u0627\u0644\u062e\u062f\u0645\u0629 \u0627\u0644\u0639\u0627\u0645\u0629","\u0627\u0644\u0632\u0631\u0627\u0639\u0629 \u0648\u0645\u0635\u0627\u064a\u062f \u0627\u0644\u0623\u0633\u0645\u0627\u0643 \u0627\u0644\u0628\u062d\u0631\u064a\u0629","\u0627\u0644\u0645\u0639\u062f\u0627\u062a \u0648\u0627\u0644\u0645\u064a\u0627\u0647 \u0648\u0627\u0644\u0628\u064a\u0626\u0629","\u0627\u0644\u062a\u0648\u0627\u0635\u0644 \u0648\u0627\u0644\u062b\u0642\u0627\u0641\u0629","\u0627\u0644\u062f\u0641\u0627\u0639 \u0627\u0644\u0648\u0637\u0646\u064a \u0648\u0627\u0644\u062f\u0631\u0643 \u0627\u0644\u0645\u0644\u0643\u064a","\u062d\u0642\u0648\u0642 \u0627\u0644\u0625\u0646\u0633\u0627\u0646 \u0648\u0627\u0644\u0639\u0644\u0627\u0642\u0627\u062a \u0645\u0639 \u0627\u0644\u0628\u0631\u0644\u0645\u0627\u0646","\u0627\u0644\u062a\u0646\u0645\u064a\u0629 \u0627\u0644\u0627\u062c\u062a\u0645\u0627\u0639\u064a\u0629 \u0648\u0627\u0644\u062a\u0636\u0627\u0645\u0646"],a=["Chef du Gouvernement","Observatoire National des Droits de l\u2019Enfant"],l=[];this.uow.recommendations.stateRecommendationByOrganisme().subscribe((function(i){console.log(i),(i=i.filter((function(t){return t.type&&""!==t.type&&!1===a.includes(t.name)&&void 0!==t.name}))).forEach((function(t){e.forEach((function(e,a){if(e.includes(t.name)){var i={name:e,p:t.p,r:t.r,n:t.n,t:t.t,type:t.type,nameAr:n[a]},o=l.findIndex((function(t){return t.name.includes(i.name)}));-1!==o?(l[o].p+=i.p,l[o].r+=i.r,l[o].n+=i.n,l[o].t+=i.t):l.push(i)}}))}));var o=l.filter((function(t){return"PE"===t.type})).map((function(e){return"fr"===t.mytranslate.langSync?e.name:e.nameAr})),r=i.filter((function(t){return"IN"===t.type})).map((function(e){return"fr"===t.mytranslate.langSync?e.name:e.nameAr})),s=i.filter((function(t){return"PJ"===t.type})).map((function(e){return"fr"===t.mytranslate.langSync?e.name:e.nameAr})),u=i.filter((function(t){return"Autre"===t.type})).map((function(e){return"fr"===t.mytranslate.langSync?e.name:e.nameAr})),c=[{data:[],label:t.mytranslate.get("admin.organe.list.Etatavancement")},{data:[],label:t.mytranslate.get("admin.organe.list.R\xe9alis\xe9")},{data:[],label:t.mytranslate.get("admin.organe.list.NonR\xe9alis\xe9")}],h=[{data:[],label:t.mytranslate.get("admin.organe.list.Etatavancement")},{data:[],label:t.mytranslate.get("admin.organe.list.R\xe9alis\xe9")},{data:[],label:t.mytranslate.get("admin.organe.list.NonR\xe9alis\xe9")}],d=[{data:[],label:t.mytranslate.get("admin.organe.list.Etatavancement")},{data:[],label:t.mytranslate.get("admin.organe.list.R\xe9alis\xe9")},{data:[],label:t.mytranslate.get("admin.organe.list.NonR\xe9alis\xe9")}],p=[{data:[],label:t.mytranslate.get("admin.organe.list.Etatavancement")},{data:[],label:t.mytranslate.get("admin.organe.list.R\xe9alis\xe9")},{data:[],label:t.mytranslate.get("admin.organe.list.NonR\xe9alis\xe9")}];l.forEach((function(t){"PE"===t.type&&(c[0].data.push((100*t.p/t.t).toFixed(2)),c[1].data.push((100*t.r/t.t).toFixed(2)),c[2].data.push((100*t.n/t.t).toFixed(2)))})),i.forEach((function(t){"Autre"===t.type?(p[0].data.push((100*t.p/t.t).toFixed(2)),p[1].data.push((100*t.r/t.t).toFixed(2)),p[2].data.push((100*t.n/t.t).toFixed(2))):"IN"===t.type?(h[0].data.push((100*t.p/t.t).toFixed(2)),h[1].data.push((100*t.r/t.t).toFixed(2)),h[2].data.push((100*t.n/t.t).toFixed(2))):"PJ"===t.type&&(d[0].data.push((100*t.p/t.t).toFixed(2)),d[1].data.push((100*t.r/t.t).toFixed(2)),d[2].data.push((100*t.n/t.t).toFixed(2)))})),t.departementSubjectAutre.next({barChartLabels:u,barChartData:p,title:t.mytranslate.get("admin.home.Parlement")}),t.departementSubjectPE.next({barChartLabels:o,barChartData:c,title:t.mytranslate.get("admin.home.D\xe9partementsgouvernementaux")}),t.departementSubjectPJ.next({barChartLabels:s,barChartData:d,title:t.mytranslate.get("admin.home.D\xe9partement\xe0pouvoirjudiciaire")}),t.departementSubjectIN.next({barChartLabels:r,barChartData:h,title:t.mytranslate.get("admin.home.InstitutionsNationales")})}))},t.prototype.stateRecommendationByAxe=function(){var t=this;return this.uow.recommendations.stateRecommendationByAxe().subscribe((function(e){e.pop(),t.axesValue=e}))},t.prototype.selectChange=function(t){t.toLocaleLowerCase().includes("organe"),t.toLocaleLowerCase().includes("examen")},t}(),g=n("7q3A"),f=n("0hB7"),m=a.qb({encapsulation:0,styles:[['.border-left[_ngcontent-%COMP%]{border-left:10px solid #a19b9e}.border-right[_ngcontent-%COMP%]{border-right:10px solid #a19b9e}.super-title[_ngcontent-%COMP%]{height:45px;display:flex;align-items:center}.super-title[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]{background-color:#d17c36;height:35px;display:flex;align-items:center}.super-title[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]   h3[_ngcontent-%COMP%]{color:#fff;margin:0;padding:0 5px}.super-title2[_ngcontent-%COMP%]{height:45px;display:flex;align-items:center}.super-title2[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]{height:35px;display:flex;align-items:center}.super-title2[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]   h3[_ngcontent-%COMP%]{color:#a19b9e;margin:0;padding:0 5px;font-size:1.8em}.host[_ngcontent-%COMP%]{margin:0 1em 1em!important}  .mat-progress-spinner circle{fill:#00000008!important}h3[_ngcontent-%COMP%]{margin:4px 0 10px;color:var(--primary);text-align:center}.axes[_ngcontent-%COMP%]{display:flex;flex-direction:column;box-shadow:1px 1px 5px #ddd;padding:5px;margin-bottom:5px}.axes[_ngcontent-%COMP%]   p[_ngcontent-%COMP%]{margin:0;font-size:.8em}.axes[_ngcontent-%COMP%]   .title[_ngcontent-%COMP%]{font-weight:700;margin-bottom:10px;font-size:.9em}@font-face{font-family:Satisfy;font-style:normal;font-weight:400;font-display:swap;src:local("Satisfy Regular"),local("Satisfy-Regular"),url(https://fonts.gstatic.com/s/satisfy/v11/rP2Hp2yn6lkG50LoCZOIHQ.woff2) format("woff2");unicode-range:U+0000-00FF,U+0131,U+0152-0153,U+02BB-02BC,U+02C6,U+02DA,U+02DC,U+2000-206F,U+2074,U+20AC,U+2122,U+2191,U+2193,U+2212,U+2215,U+FEFF,U+FFFD}.textAlign-left[_ngcontent-%COMP%]{text-align:left}.textAlign-right[_ngcontent-%COMP%]{text-align:right}.textSouTitre[_ngcontent-%COMP%]{text-align:right;font-size:.9em;color:#00000070}.legend[_ngcontent-%COMP%]{list-style:none;height:10px;width:280px}.legend[_ngcontent-%COMP%]   li[_ngcontent-%COMP%]{margin-right:10px;font-size:14px;font-weight:100}.legend[_ngcontent-%COMP%]   span[_ngcontent-%COMP%]{border:1px solid #ccc;float:left;width:12px;height:12px;margin:2px}.legend[_ngcontent-%COMP%]   .superawesome[_ngcontent-%COMP%]{background-color:#2b6a97;width:40px;height:22px;font-size:small;padding:2%}.legend[_ngcontent-%COMP%]   .awesome[_ngcontent-%COMP%]{background-color:#ca7834;width:40px;height:22px;font-size:small;padding:2%}.legend[_ngcontent-%COMP%]   .kindaawesome[_ngcontent-%COMP%]{background-color:#7dc460;width:40px;height:22px;font-size:small;padding:2%}']],data:{}});function C(t){return a.Ob(0,[(t()(),a.sb(0,0,null,null,27,"div",[["class","host"]],null,null,null,null,null)),(t()(),a.sb(1,0,null,null,2,"div",[["class","d-flex justify-content-center mb-5"]],null,null,null,null,null)),(t()(),a.sb(2,0,null,null,1,"img",[["alt",""],["srcset",""],["style","width: 100%;"]],[[8,"src",4]],null,null,null,null)),a.Gb(131072,o.b,[a.h]),(t()(),a.sb(4,0,null,null,2,"div",[["class","row mt-3 justify-content-center"]],null,null,null,null,null)),(t()(),a.sb(5,0,null,null,1,"div",[["class","col-md-12"]],null,null,null,null,null)),(t()(),a.sb(6,0,null,null,0,"div",[["class","row w-100"]],null,null,null,null,null)),(t()(),a.sb(7,0,null,null,20,"div",[["class","row mb-10"]],null,null,null,null,null)),(t()(),a.sb(8,0,null,null,19,"div",[["class","col-md-12"]],null,null,null,null,null)),(t()(),a.sb(9,0,null,null,18,"div",[],null,null,null,null,null)),(t()(),a.sb(10,0,null,null,4,"div",[["class","d-flex align-items-center"]],null,null,null,null,null)),(t()(),a.sb(11,0,null,null,0,"img",[["alt","points.png"],["src","assets/points.png"],["srcset",""],["style","height: 30px;"]],null,null,null,null,null)),(t()(),a.sb(12,0,null,null,2,"h2",[["style","color: rgb(94, 94, 94); margin: 0;"]],null,null,null,null,null)),(t()(),a.Mb(13,null,[" "," "])),a.Gb(131072,r.i,[r.j,a.h]),(t()(),a.sb(15,0,null,null,2,"div",[["class","col-md-12"]],null,null,null,null,null)),(t()(),a.sb(16,0,null,null,1,"app-bar",[],null,null,null,s.b,s.a)),a.rb(17,114688,null,0,u.a,[c.a,h.e],{dataSubject:[0,"dataSubject"],col:[1,"col"]},null),(t()(),a.sb(18,0,null,null,9,"div",[["class","row"]],null,null,null,null,null)),(t()(),a.sb(19,0,null,null,2,"div",[["class","col-md-3"]],null,null,null,null,null)),(t()(),a.sb(20,0,null,null,1,"app-bar",[],null,null,null,s.b,s.a)),a.rb(21,114688,null,0,u.a,[c.a,h.e],{dataSubject:[0,"dataSubject"],col:[1,"col"]},null),(t()(),a.sb(22,0,null,null,2,"div",[["class","col-md-4"]],null,null,null,null,null)),(t()(),a.sb(23,0,null,null,1,"app-bar",[],null,null,null,s.b,s.a)),a.rb(24,114688,null,0,u.a,[c.a,h.e],{dataSubject:[0,"dataSubject"],col:[1,"col"]},null),(t()(),a.sb(25,0,null,null,2,"div",[["class","col-md-5"]],null,null,null,null,null)),(t()(),a.sb(26,0,null,null,1,"app-bar",[],null,null,null,s.b,s.a)),a.rb(27,114688,null,0,u.a,[c.a,h.e],{dataSubject:[0,"dataSubject"],col:[1,"col"]},null)],(function(t,e){var n=e.component;t(e,17,0,n.departementSubjectPE,12),t(e,21,0,n.departementSubjectAutre,12),t(e,24,0,n.departementSubjectPJ,12),t(e,27,0,n.departementSubjectIN,12)}),(function(t,e){var n=e.component;t(e,2,0,"fr"===a.Nb(e,2,0,a.Eb(e,3).transform(n.mytranslate.lang))?"assets/1.jpg":"assets/1_ar.jpg"),t(e,13,0,a.Nb(e,13,0,a.Eb(e,14).transform("admin.home.Etatdavancementdesrecommandations\u2013d\xe9partements")))}))}var y=a.ob("app-home",b,(function(t){return a.Ob(0,[(t()(),a.sb(0,0,null,null,1,"app-home",[],null,null,null,C,m)),a.rb(1,114688,null,0,b,[g.a,f.a,c.a],null,null)],(function(t,e){t(e,1,0)}),null)}),{},{},[]),x=n("yWMr"),v=n("t68o"),P=n("zbXB"),w=n("NcP4"),O=n("xYTU"),M=n("ft5n"),S=n("IheW"),_=n("5GAg"),A=n("/HVE"),F=n("DkaU"),R=n("QQfA"),D=n("IP0z"),E=n("/Co4"),j=n("POq0"),T=n("Xd0L"),L=n("qJ5m"),k=n("821u"),U=n("gavF"),I=n("fgD+"),B=n("JjoW"),z=n("Mz6y"),N=n("cUpR"),q=n("OIZN"),H=n("7kcP"),G=n("s7LF"),J=n("iInd"),V=function(){},Z=n("zQui"),X=n("zMNK"),Q=n("hOhj"),K=n("KPQW"),W=n("lwm9"),Y=n("Fwaw"),$=n("mkRZ"),tt=n("igqZ"),et=n("r0V8"),nt=n("kNGD"),at=n("qJ50"),lt=n("Gi4r"),it=n("02hT"),ot=n("5Bek"),rt=n("c9fC"),st=n("FVPZ"),ut=n("oapL"),ct=n("HsOI"),ht=n("ZwOa"),dt=n("Q+lL"),pt=n("8P0U"),bt=n("W5yJ"),gt=n("elxJ"),ft=n("BV1i"),mt=n("lT8R"),Ct=n("pBi1"),yt=n("dFDH"),xt=n("8rEH"),vt=n("rWV4"),Pt=n("BzsH"),wt=n("AaDx"),Ot=n("2thQ"),Mt=n("hrfs"),St=n("Ry++"),_t=n("Dgsr"),At=n("dvZr");n.d(e,"HomeModuleNgFactory",(function(){return Ft}));var Ft=a.pb(l,[],(function(t){return a.Bb([a.Cb(512,a.j,a.ab,[[8,[i.a,y,x.a,v.a,P.b,P.a,w.a,O.a,O.b,M.a]],[3,a.j],a.w]),a.Cb(4608,o.n,o.m,[a.t,[2,o.C]]),a.Cb(4608,S.j,S.p,[o.d,a.A,S.n]),a.Cb(4608,S.q,S.q,[S.j,S.o]),a.Cb(5120,S.a,(function(t){return[t]}),[S.q]),a.Cb(4608,S.m,S.m,[]),a.Cb(6144,S.k,null,[S.m]),a.Cb(4608,S.i,S.i,[S.k]),a.Cb(6144,S.b,null,[S.i]),a.Cb(4608,S.g,S.l,[S.b,a.q]),a.Cb(4608,S.c,S.c,[S.g]),a.Cb(135680,_.h,_.h,[a.y,A.a]),a.Cb(4608,F.e,F.e,[a.L]),a.Cb(4608,R.c,R.c,[R.i,R.e,a.j,R.h,R.f,a.q,a.y,o.d,D.c,[2,o.h]]),a.Cb(5120,R.j,R.k,[R.c]),a.Cb(5120,E.b,E.c,[R.c]),a.Cb(4608,j.c,j.c,[]),a.Cb(4608,T.d,T.d,[]),a.Cb(5120,L.b,L.a,[[3,L.b]]),a.Cb(5120,h.c,h.d,[R.c]),a.Cb(135680,h.e,h.e,[R.c,a.q,[2,o.h],[2,h.b],h.c,[3,h.e],R.e]),a.Cb(4608,k.i,k.i,[]),a.Cb(5120,k.a,k.b,[R.c]),a.Cb(5120,U.c,U.j,[R.c]),a.Cb(4608,T.c,I.d,[T.h,I.a]),a.Cb(5120,B.a,B.b,[R.c]),a.Cb(5120,z.b,z.c,[R.c]),a.Cb(4608,N.e,T.e,[[2,T.i],[2,T.n]]),a.Cb(5120,q.c,q.a,[[3,q.c]]),a.Cb(5120,H.d,H.a,[[3,H.d]]),a.Cb(4608,G.v,G.v,[]),a.Cb(4608,G.e,G.e,[]),a.Cb(1073742336,r.g,r.g,[]),a.Cb(1073742336,o.c,o.c,[]),a.Cb(1073742336,J.q,J.q,[[2,J.v],[2,J.m]]),a.Cb(1073742336,V,V,[]),a.Cb(1073742336,S.e,S.e,[]),a.Cb(1073742336,S.d,S.d,[]),a.Cb(1073742336,Z.p,Z.p,[]),a.Cb(1073742336,F.c,F.c,[]),a.Cb(1073742336,D.a,D.a,[]),a.Cb(1073742336,T.n,T.n,[[2,T.f],[2,N.f]]),a.Cb(1073742336,A.b,A.b,[]),a.Cb(1073742336,T.y,T.y,[]),a.Cb(1073742336,T.w,T.w,[]),a.Cb(1073742336,T.t,T.t,[]),a.Cb(1073742336,X.g,X.g,[]),a.Cb(1073742336,Q.c,Q.c,[]),a.Cb(1073742336,R.g,R.g,[]),a.Cb(1073742336,E.e,E.e,[]),a.Cb(1073742336,j.d,j.d,[]),a.Cb(1073742336,_.a,_.a,[]),a.Cb(1073742336,K.a,K.a,[]),a.Cb(1073742336,W.e,W.e,[]),a.Cb(1073742336,Y.c,Y.c,[]),a.Cb(1073742336,$.a,$.a,[]),a.Cb(1073742336,tt.e,tt.e,[]),a.Cb(1073742336,et.d,et.d,[]),a.Cb(1073742336,et.c,et.c,[]),a.Cb(1073742336,nt.b,nt.b,[]),a.Cb(1073742336,at.e,at.e,[]),a.Cb(1073742336,lt.c,lt.c,[]),a.Cb(1073742336,L.c,L.c,[]),a.Cb(1073742336,h.k,h.k,[]),a.Cb(1073742336,k.j,k.j,[]),a.Cb(1073742336,it.b,it.b,[]),a.Cb(1073742336,ot.c,ot.c,[]),a.Cb(1073742336,rt.d,rt.d,[]),a.Cb(1073742336,T.p,T.p,[]),a.Cb(1073742336,st.a,st.a,[]),a.Cb(1073742336,ut.c,ut.c,[]),a.Cb(1073742336,ct.e,ct.e,[]),a.Cb(1073742336,ht.c,ht.c,[]),a.Cb(1073742336,dt.c,dt.c,[]),a.Cb(1073742336,U.i,U.i,[]),a.Cb(1073742336,U.f,U.f,[]),a.Cb(1073742336,T.A,T.A,[]),a.Cb(1073742336,T.q,T.q,[]),a.Cb(1073742336,B.d,B.d,[]),a.Cb(1073742336,z.e,z.e,[]),a.Cb(1073742336,q.d,q.d,[]),a.Cb(1073742336,pt.c,pt.c,[]),a.Cb(1073742336,bt.c,bt.c,[]),a.Cb(1073742336,gt.a,gt.a,[]),a.Cb(1073742336,ft.h,ft.h,[]),a.Cb(1073742336,mt.a,mt.a,[]),a.Cb(1073742336,Ct.b,Ct.b,[]),a.Cb(1073742336,Ct.a,Ct.a,[]),a.Cb(1073742336,yt.e,yt.e,[]),a.Cb(1073742336,H.e,H.e,[]),a.Cb(1073742336,xt.l,xt.l,[]),a.Cb(1073742336,vt.k,vt.k,[]),a.Cb(1073742336,Pt.b,Pt.b,[]),a.Cb(1073742336,wt.a,wt.a,[]),a.Cb(1073742336,I.e,I.e,[]),a.Cb(1073742336,I.c,I.c,[]),a.Cb(1073742336,Ot.a,Ot.a,[]),a.Cb(1073742336,G.u,G.u,[]),a.Cb(1073742336,G.j,G.j,[]),a.Cb(1073742336,G.r,G.r,[]),a.Cb(1073742336,Mt.b,Mt.b,[]),a.Cb(1073742336,St.a,St.a,[]),a.Cb(1073742336,_t.a,_t.a,[]),a.Cb(1073742336,l,l,[]),a.Cb(1024,J.k,(function(){return[[{path:"home",redirectTo:"",pathMatch:"full"},{path:"",component:b}]]}),[]),a.Cb(256,S.n,"XSRF-TOKEN",[]),a.Cb(256,S.o,"X-XSRF-TOKEN",[]),a.Cb(256,nt.a,{separatorKeyCodes:[At.f]},[]),a.Cb(256,T.g,I.b,[])])}))},oTHA:function(t,e,n){"use strict";n.d(e,"a",(function(){return o}));var a=n("XNiG"),l=n("DDG+"),i=n("hSFZ"),o=function(){function t(t,e){this.mytranslate=t,this.dialog=e,this.title="",this.barChartOptions={responsive:!0,title:{text:"",display:!0},scales:{xAxes:[{ticks:{fontSize:16}}],yAxes:[{ticks:{beginAtZero:!0}}]},legend:{position:"right",align:"center",labels:{fontSize:16}},plugins:{labels:{precision:0,render:"value"},pieceLabel:{render:function(t){return t.label+": "+t.value}}}},this.barChartLabels=[],this.barChartType="bar",this.barChartLegend=!0,this.pieChartPlugins=[i],this.barChartData=[{data:[],label:""}],this.pieChartColors=[{backgroundColor:"#d17c36"},{backgroundColor:"#7dc460"},{backgroundColor:"#db0707"}],this.dataSubject=new a.a,this.col=12,this.retate=0,this.list=[]}return t.prototype.ngOnInit=function(){var t=this;this.mytranslate.lang.subscribe((function(e){t.retate="fr"===e?0:180,t.barChartOptions.legend.position="fr"===e?"right":"left"})),this.dataSubject.subscribe((function(e){t.title=e.title,t.barChartLabels=e.barChartLabels.map((function(t){return t.toString().substring(0,35)+" ..."})),t.barChartData=e.barChartData,console.log(t.barChartData[0].data[0]),console.log(t.barChartData[1].data[0]),console.log(t.barChartData[2].data[0]),e.barChartLabels.forEach((function(e,n){t.list.push({name:e.toString(),p:+t.barChartData.find((function(t){return"En cours"===t.label})).data[n],r:+t.barChartData.find((function(t){return"R\xe9alis\xe9"===t.label})).data[n],n:+t.barChartData.find((function(t){return t.label.toLowerCase()==="Non r\xe9alis\xe9".toLowerCase()})).data[n]})}))}))},t.prototype.openDialog=function(){this.dialog.open(l.a,{width:"7100px",disableClose:!1,data:{model:this.list,type:"bar",title:this.title}}).afterClosed().subscribe((function(t){console.log(t)}))},t.prototype.chartClicked=function(t){},t.prototype.chartHovered=function(t){},t.prototype.randomize=function(){this.barChartType="bar"===this.barChartType?"line":"bar"},t.prototype.getColors=function(t){for(var e=["#0074D9","#2ECC40","#FF4136","#FF851B","#7FDBFF","#B10DC9","#FFDC00","#001f3f","#39CCCC","#01FF70","#85144b","#F012BE","#3D9970","#111111","#AAAAAA"],n=[],a=0;a<t;a++)n.push(e[a%e.length]);return n},t}()}}]);