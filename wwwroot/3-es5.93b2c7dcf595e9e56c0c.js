!function(){function t(t,e){if(!(t instanceof e))throw new TypeError("Cannot call a class as a function")}function e(t,e){for(var n=0;n<e.length;n++){var i=e[n];i.enumerable=i.enumerable||!1,i.configurable=!0,"value"in i&&(i.writable=!0),Object.defineProperty(t,i.key,i)}}function n(t,n,i){return n&&e(t.prototype,n),i&&e(t,i),t}(window.webpackJsonp=window.webpackJsonp||[]).push([[3],{"+Ya6":function(e,i,o){"use strict";o.d(i,"a",function(){return g});var r=o("LPYB"),a=o("XNiG"),s=o("DDG+"),l=o("hSFZ"),c=o("fXoL"),h=o("7q3A"),d=o("J3i2"),p=o("0IaG"),f=o("ofXK");function u(t,e){if(1&t&&(c.Tb(0,"div",8),c.Ob(1,"div",9),c.Tb(2,"span",10),c.Cc(3),c.Sb(),c.Sb()),2&t){var n=e.$implicit,i=e.index,o=c.ec();c.Bb(1),c.yc("background-color",o.pieChartColors[0].backgroundColor[i]),c.Bb(2),c.Dc(n)}}var g=function(){var e=function(){function e(n,i,o){t(this,e),this.uow=n,this.mytranslate=i,this.dialog=o,this.obs=new a.a,this.showLegend=!0,this.withGraphe="100%",this.height="50vh",this.dataToShowInTable=[],this.title=null,this.arr2=new a.a,this.pieChartOptions={responsive:!0,maintainAspectRatio:!1,cutoutPercentage:50,title:{text:"",display:!0},tooltips:{enabled:!0,callbacks:{label:function(t,e){return e.labels[t.index]}}},hover:{mode:"nearest",intersect:!1,onHover:function(t,e){}},legend:{position:"bottom",display:!1,align:"center",fullWidth:!0,labels:{fontSize:16}},plugins:{labels:{fontColor:["white","white","white","white","white","white","white","white","white","white","white","white"],precision:0,fontSize:14,fontStyle:"bold",render:"percentage"},pieceLabel:{render:function(t){return t.label+": "+t.value}}}},this.pieChartLabels=[],this.pieChartData=[],this.pieChartType="pie",this.pieChartLegend=!0,this.pieChartPlugins=[l],this.pieChartColors=[{backgroundColor:[]}],this.list=[],this.retate=0,this.arr=[],Object(r.d)(),Object(r.c)()}return n(e,[{key:"ngOnInit",value:function(){var t=this;this.mytranslate.lang.subscribe(function(e){t.retate="fr"===e?0:180}),this.obs.subscribe(function(e){t.title=e.title,t.pieChartLabels=e.chartLabels,t.pieChartData=e.chartData.map(function(t){return+t.toFixed(0)}),t.pieChartColors[0].backgroundColor=0===e.chartColors.length?t.getColors(t.pieChartLabels.length):e.chartColors})}},{key:"openDialog",value:function(){this.dialog.open(s.a,{width:"7100px",disableClose:!1,data:{model:this.list,type:"pie",title:this.title}}).afterClosed().subscribe(function(t){})}},{key:"getColors",value:function(t){for(var e=["#2b960b","#db0707","#f7801e","#2d71a1","#7dc460","#fdb93a","#59b8ce","#5c5c5f","#ef4f42","#a5a6aa"],n=[],i=0;i<t;i++)n.push(e[i%e.length]);return n}},{key:"toInt",value:function(t){return parseInt((t/3-1).toFixed(0),10)}},{key:"toStr",value:function(t){return(parseInt(t.toFixed(0),10)*this.count/100).toFixed(0)}}]),e}();return e.\u0275fac=function(t){return new(t||e)(c.Nb(h.a),c.Nb(d.a),c.Nb(p.b))},e.\u0275cmp=c.Hb({type:e,selectors:[["app-pie"]],inputs:{obs:"obs",showLegend:"showLegend",withGraphe:"withGraphe",height:"height",pieChartType:"pieChartType"},decls:9,vars:15,consts:[[1,"d-flex","flex-column","align-items-center","justify-content-center","mb-3",2,"cursor","pointer"],[2,"display","block"],["baseChart","",1,"chart","chart-pie",3,"data","labels","chartType","options","plugins","colors","legend"],[1,"mt-3"],["style","display: flex;margin-bottom: 7px;max-width: 50vw;width: 100%;",4,"ngFor","ngForOf"],[1,"d-flex","flex-column","justify-content-center","mt-2"],["src","assets/line.png","height","10px","width","280px"],[1,"pie-title",2,"color","#737473","margin","5px 0 10px 5px"],[2,"display","flex","margin-bottom","7px","max-width","50vw","width","100%"],[2,"width","43px","height","18px","border","1px solid white"],[2,"color","gray","font-size","1em","margin","0 10px"]],template:function(t,e){1&t&&(c.Tb(0,"div",0),c.Tb(1,"div",1),c.Ob(2,"canvas",2),c.Sb(),c.Tb(3,"div",3),c.Bc(4,u,4,3,"div",4),c.Sb(),c.Tb(5,"div",5),c.Ob(6,"img",6),c.Tb(7,"h5",7),c.Cc(8),c.Sb(),c.Sb(),c.Sb()),2&t&&(c.Bb(1),c.yc("width",e.withGraphe)("height",e.height),c.Bb(1),c.kc("data",e.pieChartData)("labels",e.pieChartLabels)("chartType",e.pieChartType)("options",e.pieChartOptions)("plugins",e.pieChartPlugins)("colors",e.pieChartColors)("legend",e.pieChartLegend),c.Bb(2),c.kc("ngForOf",e.pieChartLabels),c.Bb(2),c.yc("transform","rotateY("+e.retate+"deg)"),c.Bb(2),c.Ec(" ",e.title," "))},directives:[r.a,f.l],styles:["p[_ngcontent-%COMP%]{font-family:Lato}#customers[_ngcontent-%COMP%]{font-family:Trebuchet MS,Arial,Helvetica,sans-serif;border-collapse:collapse;width:100%;text-align:center;font-size:x-small}#customers[_ngcontent-%COMP%]   td[_ngcontent-%COMP%], #customers[_ngcontent-%COMP%]   th[_ngcontent-%COMP%]{border:1px solid #ddd;padding:8px}#customers[_ngcontent-%COMP%]   tr[_ngcontent-%COMP%]:nth-child(2n){background-color:#f2f2f2}#customers[_ngcontent-%COMP%]   tr[_ngcontent-%COMP%]:hover{background-color:#ddd}#customers[_ngcontent-%COMP%]   th[_ngcontent-%COMP%]{padding-top:12px;padding-bottom:12px;text-align:left;background-color:#aaabab;color:#fff}"]}),e}()},"/ysL":function(e,i,o){"use strict";o.d(i,"a",function(){return c});var r=o("fXoL"),a=o("J3i2"),s=o("f0Cb"),l=o("ofXK"),c=function(){var e=function(){function e(n){t(this,e),this.mytranslate=n,this.title=""}return n(e,[{key:"ngOnInit",value:function(){}}]),e}();return e.\u0275fac=function(t){return new(t||e)(r.Nb(a.a))},e.\u0275cmp=r.Hb({type:e,selectors:[["app-title"]],inputs:{title:"title"},decls:7,vars:4,consts:[[1,"d-flex","w-100","mb-3"],[3,"className"]],template:function(t,e){1&t&&(r.Tb(0,"div",0),r.Tb(1,"section",1),r.fc(2,"async"),r.Tb(3,"div"),r.Tb(4,"h3"),r.Cc(5),r.Sb(),r.Sb(),r.Sb(),r.Sb(),r.Ob(6,"mat-divider")),2&t&&(r.Bb(1),r.kc("className","fr"===r.gc(2,2,e.mytranslate.lang)?"super-title border-left":"super-title border-right"),r.Bb(4),r.Dc(e.title))},directives:[s.a],pipes:[l.b],styles:["section[_ngcontent-%COMP%]{display:flex!important;justify-content:space-between!important;align-items:center!important}.border-left[_ngcontent-%COMP%]{border-left:10px solid #d17c36}.border-right[_ngcontent-%COMP%]{border-right:10px solid #d17c36}.super-title[_ngcontent-%COMP%]{height:45px}.super-title[_ngcontent-%COMP%], .super-title[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]{display:flex;align-items:center}.super-title[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]{background-color:#a19b9e;height:35px}.super-title[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]   h3[_ngcontent-%COMP%]{color:#fff;margin:0;padding:0 5px}"]}),e}()},"5F3i":function(e,i,o){"use strict";o.d(i,"a",function(){return f});var r,a,s=o("0IaG"),l=o("fXoL"),c=o("/t3+"),h=o("f0Cb"),d=o("bTqV"),p=((a=function(){function e(n,i){t(this,e),this.dialogRef=n,this.data=i,this.model=""}return n(e,[{key:"ngOnInit",value:function(){this.model=this.data.model}},{key:"onNoClick",value:function(){this.dialogRef.close()}},{key:"onOkClick",value:function(){this.dialogRef.close("ok")}}]),e}()).\u0275fac=function(t){return new(t||a)(l.Nb(s.g),l.Nb(s.a))},a.\u0275cmp=l.Hb({type:a,selectors:[["app-delete"]],decls:15,vars:1,consts:[[1,"dialog"],["mat-dialog-title",""],["role","toolbar",1,"task-header"],[1,"content"],["mat-dialog-content",""],["mat-dialog-actions","",1,"actions"],["mat-button","","type","button",3,"click"],["mat-button","","color","primary","type","button","cdkFocusInitial","",3,"mat-dialog-close","click"]],template:function(t,e){1&t&&(l.Tb(0,"div",0),l.Tb(1,"h1",1),l.Tb(2,"mat-toolbar",2),l.Tb(3,"span"),l.Cc(4),l.Sb(),l.Sb(),l.Ob(5,"mat-divider"),l.Sb(),l.Tb(6,"div",3),l.Tb(7,"div",4),l.Tb(8,"p"),l.Cc(9,"Voulez-vous vraiment supprimer?"),l.Sb(),l.Sb(),l.Tb(10,"div",5),l.Tb(11,"button",6),l.ac("click",function(){return e.onNoClick()}),l.Cc(12,"Annuler"),l.Sb(),l.Tb(13,"button",7),l.ac("click",function(){return e.onOkClick()}),l.Cc(14,"Ok"),l.Sb(),l.Sb(),l.Sb(),l.Sb()),2&t&&(l.Bb(4),l.Ec("Suppression ",e.model," "))},directives:[s.h,c.a,h.a,s.e,s.c,d.a,s.d],styles:[".dialog[_ngcontent-%COMP%]{overflow-x:hidden;overflow-y:hidden}.dialog[_ngcontent-%COMP%]   h1[_ngcontent-%COMP%]   span[_ngcontent-%COMP%]{padding:0 5px}.dialog[_ngcontent-%COMP%]   .content[_ngcontent-%COMP%]{padding:0 20px 25px}.dialog[_ngcontent-%COMP%]   .actions[_ngcontent-%COMP%]{display:flex;flex-direction:row-reverse}"]}),a),f=((r=function(){function e(n){t(this,e),this.dialog=n}return n(e,[{key:"openDialog",value:function(t){return this.dialog.open(p,{width:"750px",disableClose:!0,data:{model:t}}).afterClosed()}}]),e}()).\u0275fac=function(t){return new(t||r)(l.Xb(s.b))},r.\u0275prov=l.Jb({token:r,factory:r.\u0275fac,providedIn:"root"}),r)},ZTdd:function(e,i,o){"use strict";o.d(i,"a",function(){return f});var r=o("mrSG"),a=o("2ChS"),s=o("fXoL"),l=o("MutI"),c=o("ofXK"),h=o("FKr1");function d(t,e){if(1&t){var n=s.Ub();s.Tb(0,"a",2),s.ac("click",function(){s.sc(n);var t=s.ec().$implicit;return s.ec().openLink(t)}),s.Tb(1,"span",3),s.Cc(2),s.Sb(),s.Sb()}if(2&t){var i=s.ec().$implicit;s.Bb(2),s.Ec("- ",i.substring(14,i.length-1),"")}}function p(t,e){if(1&t&&(s.Tb(0,"div"),s.Bc(1,d,3,1,"a",1),s.Sb()),2&t){var n=e.$implicit,i=s.ec();s.Bb(1),s.kc("ngIf",i.show(n))}}var f=function(){var e=function(){function e(n,i,o){t(this,e),this.bottomSheetRef=n,this.data=i,this.url=o,this.list=[],this.folder=""}return n(e,[{key:"ngOnInit",value:function(){if(this.data.fileName){var t=this.data.fileName.split(";");t.pop(),this.folder=this.data.folder,this.list=t}}},{key:"openLink",value:function(t){return Object(r.a)(this,void 0,void 0,regeneratorRuntime.mark(function e(){var n;return regeneratorRuntime.wrap(function(e){for(;;)switch(e.prev=e.next){case 0:n=+t.substring(t.length-1,t.length),t=isNaN(n)?t:t.substring(0,t.length-1),window.open("".concat(this.url,"/").concat(this.folder,"/").concat(t));case 2:case"end":return e.stop()}},e,this)}))}},{key:"show",value:function(t){if(""===t)return!1;var e=+t.substring(t.length-1,t.length);return!!isNaN(e)||1===e}}]),e}();return e.\u0275fac=function(t){return new(t||e)(s.Nb(a.d),s.Nb(a.a),s.Nb("BASE_URL"))},e.\u0275cmp=s.Hb({type:e,selectors:[["app-download-sheet"]],decls:2,vars:1,consts:[[4,"ngFor","ngForOf"],["mat-list-item","",3,"click",4,"ngIf"],["mat-list-item","",3,"click"],["mat-line",""]],template:function(t,e){1&t&&(s.Tb(0,"mat-nav-list"),s.Bc(1,p,2,1,"div",0),s.Sb()),2&t&&(s.Bb(1),s.kc("ngForOf",e.list))},directives:[l.d,c.l,c.m,l.b,h.k],styles:[""]}),e}()},hSFZ:function(t,e){!function(){"use strict";if("undefined"!=typeof Chart){"function"!=typeof Object.assign&&(Object.assign=function(t,e){if(null==t)throw new TypeError("Cannot convert undefined or null to object");for(var n=Object(t),i=1;i<arguments.length;i++){var o=arguments[i];if(null!=o)for(var r in o)Object.prototype.hasOwnProperty.call(o,r)&&(n[r]=o[r])}return n});var t={};["pie","doughnut","polarArea","bar"].forEach(function(e){t[e]=!0}),e.prototype.setup=function(t,e){this.chart=t,this.ctx=t.ctx,this.args={},this.barTotal={};var n=t.config.options;this.options=Object.assign({position:"default",precision:0,fontSize:n.defaultFontSize,fontColor:n.defaultFontColor,fontStyle:n.defaultFontStyle,fontFamily:n.defaultFontFamily,shadowOffsetX:3,shadowOffsetY:3,shadowColor:"rgba(0,0,0,0.3)",shadowBlur:6,images:[],outsidePadding:2,textMargin:2,overlap:!0},e),"bar"===t.config.type&&(this.options.position="default",this.options.arc=!1,this.options.overlap=!0)},e.prototype.render=function(){this.labelBounds=[],this.chart.data.datasets.forEach(this.renderToDataset)},e.prototype.renderToDataset=function(t,e){this.totalPercentage=0,this.total=null;var n=this.args[e];n.meta.data.forEach((function(e,i){this.renderToElement(t,n,e,i)}).bind(this))},e.prototype.renderToElement=function(t,e,n,i){if(this.shouldRenderToElement(e.meta,n)){this.percentage=null;var o=this.getLabel(t,n,i);if(o){var r=this.ctx;r.save(),r.font=Chart.helpers.fontString(this.options.fontSize,this.options.fontStyle,this.options.fontFamily);var a=this.getRenderInfo(n,o);this.drawable(n,o,a)?(r.beginPath(),r.fillStyle=this.getFontColor(t,n,i),this.renderLabel(o,a),r.restore()):r.restore()}}},e.prototype.renderLabel=function(t,e){return this.options.arc?this.renderArcLabel(t,e):this.renderBaseLabel(t,e)},e.prototype.renderBaseLabel=function(t,e){var n=this.ctx;if("object"==typeof t)n.drawImage(t,e.x-t.width/2,e.y-t.height/2,t.width,t.height);else{n.save(),n.textBaseline="top",n.textAlign="center",this.options.textShadow&&(n.shadowOffsetX=this.options.shadowOffsetX,n.shadowOffsetY=this.options.shadowOffsetY,n.shadowColor=this.options.shadowColor,n.shadowBlur=this.options.shadowBlur);for(var i=t.split("\n"),o=0;o<i.length;o++)n.fillText(i[o],e.x,e.y-this.options.fontSize/2*i.length+this.options.fontSize*o);n.restore()}},e.prototype.renderArcLabel=function(t,e){var n=this.ctx,i=e.radius,o=e.view;if(n.save(),n.translate(o.x,o.y),"string"==typeof t){n.rotate(e.startAngle),n.textBaseline="middle",n.textAlign="left";var r=t.split("\n"),a=0,s=[],l=0;"border"===this.options.position&&(l=(r.length-1)*this.options.fontSize/2);for(var c=0;c<r.length;++c){var h=n.measureText(r[c]);h.width>a&&(a=h.width),s.push(h.width)}for(c=0;c<r.length;++c){var d=r[c],p=(r.length-1-c)*-this.options.fontSize+l;n.save(),n.rotate((a-s[c])/2/i);for(var f=0;f<d.length;f++){var u=d.charAt(f);h=n.measureText(u),n.save(),n.translate(0,-1*i),n.fillText(u,0,p),n.restore(),n.rotate(h.width/i)}n.restore()}}else n.rotate((o.startAngle+Math.PI/2+e.endAngle)/2),n.translate(0,-1*i),this.renderLabel(t,{x:0,y:0});n.restore()},e.prototype.shouldRenderToElement=function(t,e){return!t.hidden&&!e.hidden&&(this.options.showZero||"polarArea"===this.chart.config.type?0!==e._view.outerRadius:0!==e._view.circumference)},e.prototype.getLabel=function(t,e,n){var i;if("function"==typeof this.options.render)i=this.options.render({label:this.chart.config.data.labels[n],value:t.data[n],percentage:this.getPercentage(t,e,n),dataset:t,index:n});else switch(this.options.render){case"value":i=t.data[n];break;case"label":i=this.chart.config.data.labels[n];break;case"image":i=this.options.images[n]?this.loadImage(this.options.images[n]):"";break;case"percentage":default:i=this.getPercentage(t,e,n)+"%"}return"object"==typeof i?i=this.loadImage(i):null!=i&&(i=i.toString()),i},e.prototype.getFontColor=function(t,e,n){var i=this.options.fontColor;return"function"==typeof i?i=i({label:this.chart.config.data.labels[n],value:t.data[n],percentage:this.getPercentage(t,e,n),backgroundColor:t.backgroundColor[n],dataset:t,index:n}):"string"!=typeof i&&(i=i[n]||this.chart.config.options.defaultFontColor),i},e.prototype.getPercentage=function(t,e,n){if(null!==this.percentage)return this.percentage;var i;if("polarArea"===this.chart.config.type){if(null===this.total){this.total=0;for(var o=0;o<t.data.length;++o)this.total+=t.data[o]}i=t.data[n]/this.total*100}else if("bar"===this.chart.config.type){if(void 0===this.barTotal[n])for(this.barTotal[n]=0,o=0;o<this.chart.data.datasets.length;++o)this.barTotal[n]+=this.chart.data.datasets[o].data[n];i=t.data[n]/this.barTotal[n]*100}else i=e._view.circumference/this.chart.config.options.circumference*100;return i=parseFloat(i.toFixed(this.options.precision)),this.options.showActualPercentages||("bar"===this.chart.config.type&&(this.totalPercentage=this.barTotalPercentage[n]||0),this.totalPercentage+=i,this.totalPercentage>100&&(i-=this.totalPercentage-100,i=parseFloat(i.toFixed(this.options.precision))),"bar"===this.chart.config.type&&(this.barTotalPercentage[n]=this.totalPercentage)),this.percentage=i,i},e.prototype.getRenderInfo=function(t,e){return"bar"===this.chart.config.type?this.getBarRenderInfo(t,e):this.options.arc?this.getArcRenderInfo(t,e):this.getBaseRenderInfo(t,e)},e.prototype.getBaseRenderInfo=function(t,e){if("outside"===this.options.position||"border"===this.options.position){var n,i,o=t._view,r=o.startAngle+(o.endAngle-o.startAngle)/2,a=o.outerRadius/2;if("border"===this.options.position?i=(o.outerRadius-a)/2+a:"outside"===this.options.position&&(i=o.outerRadius-a+a+this.options.textMargin),n={x:o.x+Math.cos(r)*i,y:o.y+Math.sin(r)*i},"outside"===this.options.position){var s=this.options.textMargin+this.measureLabel(e).width/2;n.x+=n.x<o.x?-s:s}return n}return t.tooltipPosition()},e.prototype.getArcRenderInfo=function(t,e){var n,i=t._view;n="outside"===this.options.position?i.outerRadius+this.options.fontSize+this.options.textMargin:"border"===this.options.position?(i.outerRadius/2+i.outerRadius)/2:(i.innerRadius+i.outerRadius)/2;var o=i.startAngle,r=i.endAngle,a=r-o;return o+=Math.PI/2,{radius:n,startAngle:o+=((r+=Math.PI/2)-(this.measureLabel(e).width/n+o))/2,endAngle:r,totalAngle:a,view:i}},e.prototype.getBarRenderInfo=function(t,e){var n=t.tooltipPosition();return n.y-=this.measureLabel(e).height/2+this.options.textMargin,n},e.prototype.drawable=function(t,e,n){if(this.options.overlap)return!0;if(this.options.arc)return n.endAngle-n.startAngle<=n.totalAngle;var i=this.measureLabel(e),o=n.x-i.width/2,r=n.x+i.width/2,a=n.y-i.height/2,s=n.y+i.height/2;return"outside"===this.options.renderInfo?this.outsideInRange(o,r,a,s):t.inRange(o,a)&&t.inRange(o,s)&&t.inRange(r,a)&&t.inRange(r,s)},e.prototype.outsideInRange=function(t,e,n,i){for(var o=this.labelBounds,r=0;r<o.length;++r){for(var a=o[r],s=[[t,n],[t,i],[e,n],[e,i]],l=0;l<s.length;++l){var c=s[l][1];if((h=s[l][0])>=a.left&&h<=a.right&&c>=a.top&&c<=a.bottom)return!1}for(s=[[a.left,a.top],[a.left,a.bottom],[a.right,a.top],[a.right,a.bottom]],l=0;l<s.length;++l){var h;if(c=s[l][1],(h=s[l][0])>=t&&h<=e&&c>=n&&c<=i)return!1}}return o.push({left:t,right:e,top:n,bottom:i}),!0},e.prototype.measureLabel=function(t){if("object"==typeof t)return{width:t.width,height:t.height};for(var e=0,n=t.split("\n"),i=0;i<n.length;++i){var o=this.ctx.measureText(n[i]);o.width>e&&(e=o.width)}return{width:e,height:this.options.fontSize*n.length}},e.prototype.loadImage=function(t){var e=new Image;return e.src=t.src,e.width=t.width,e.height=t.height,e},Chart.plugins.register({id:"labels",beforeDatasetsUpdate:function(n,i){if(t[n.config.type]){Array.isArray(i)||(i=[i]);var o=i.length;n._labels&&o===n._labels.length||(n._labels=i.map(function(){return new e}));for(var r=!1,a=0,s=0;s<o;++s){var l=n._labels[s];if(l.setup(n,i[s]),"outside"===l.options.position){r=!0;var c=1.5*l.options.fontSize+l.options.outsidePadding;c>a&&(a=c)}}r&&(n.chartArea.top+=a,n.chartArea.bottom-=a)}},afterDatasetUpdate:function(e,n,i){t[e.config.type]&&e._labels.forEach(function(t){t.args[n.index]=n})},beforeDraw:function(e){t[e.config.type]&&e._labels.forEach(function(t){t.barTotalPercentage={}})},afterDatasetsDraw:function(e){t[e.config.type]&&e._labels.forEach(function(t){t.render()})}})}else console.error("Can not find Chart object.");function e(){this.renderToDataset=this.renderToDataset.bind(this)}}()}}])}();