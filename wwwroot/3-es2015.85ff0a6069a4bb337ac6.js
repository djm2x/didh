(window.webpackJsonp=window.webpackJsonp||[]).push([[3],{"+Ya6":function(t,e,i){"use strict";i.d(e,"a",function(){return d});var n=i("LPYB"),o=i("XNiG"),a=i("DDG+"),r=i("hSFZ"),s=i("fXoL"),l=i("7q3A"),c=i("J3i2"),h=i("0IaG");let d=(()=>{class t{constructor(t,e,i){this.uow=t,this.mytranslate=e,this.dialog=i,this.obs=new o.a,this.showLegend=!0,this.withGraphe="100%",this.height="50vh",this.dataToShowInTable=[],this.title=null,this.arr2=new o.a,this.index=0,this.pieChartOptions={responsive:!0,maintainAspectRatio:!1,cutoutPercentage:50,title:{text:"",display:!0},tooltips:{enabled:!0,callbacks:{label:(t,e)=>e.labels[t.index]}},hover:{mode:"nearest",intersect:!1,onHover:(t,e)=>{}},legend:{position:"bottom",display:!1,align:"center",labels:{fontSize:16}},plugins:{labels:{fontColor:["white","white","white","white","white","white","white","white","white","white","white","white"],precision:0,fontSize:14,fontStyle:"bold",render:"percentage"},pieceLabel:{render:t=>{const e=t.label,i=t.value;return this.arr2.next(t),e+": "+i}}}},this.pieChartLabels=[],this.pieChartData=[],this.pieChartType="pie",this.pieChartLegend=!0,this.pieChartPlugins=[r],this.pieChartColors=[{backgroundColor:[]}],this.list=[],this.retate=0,this.arr=[],Object(n.d)(),Object(n.c)()}ngOnInit(){this.mytranslate.lang.subscribe(t=>{this.retate="fr"===t?0:180}),this.pieChartOptions.legend.display=this.showLegend,this.obs.subscribe(t=>{this.title=t.title,this.pieChartLabels=t.chartLabels,this.pieChartData=t.chartData.map(t=>+t.toFixed(0)),this.pieChartColors[0].backgroundColor=t.chartColors;const e=100-t.chartData.map(t=>+t.toFixed(0)).reduce((t,e)=>t+e);e>10&&(this.pieChartLabels.push(""),this.pieChartData.push(e),this.pieChartColors[0].backgroundColor.push("#fff"),console.log("there is alot of space here",e)),this.dataToShowInTable=t.dataToShowInTable.map(t=>t),this.count=t.count,this.arr=t.chartData.map((t,e)=>e),this.list=[],this.pieChartLabels.forEach((t,e)=>{0!==this.pieChartData[e]&&this.list.push({name:t.toString(),value:this.pieChartData[e]})})})}openDialog(){this.dialog.open(a.a,{width:"7100px",disableClose:!1,data:{model:this.list,type:"pie",title:this.title}}).afterClosed().subscribe(t=>{console.log(t)})}getColors(t){const e=["#d97f2a","#2d71a1","#c2c3c6","#ba6446","#7dc460","#fdb93a","#59b8ce","#5c5c5f","#ef4f42","#a5a6aa"],i=[];for(let n=0;n<t;n++)i.push(e[n%e.length]);return i}toInt(t){return parseInt((t/3-1).toFixed(0),10)}toStr(t){return(parseInt(t.toFixed(0),10)*this.count/100).toFixed(0)}}return t.\u0275fac=function(e){return new(e||t)(s.Nb(l.a),s.Nb(c.a),s.Nb(h.b))},t.\u0275cmp=s.Hb({type:t,selectors:[["app-pie"]],inputs:{obs:"obs",showLegend:"showLegend",withGraphe:"withGraphe",height:"height",pieChartType:"pieChartType"},decls:7,vars:14,consts:[[1,"d-flex","flex-column","align-items-center","justify-content-center","mb-3",2,"cursor","pointer",3,"click"],[2,"display","block"],["baseChart","",1,"chart","chart-pie",3,"data","labels","chartType","options","plugins","colors","legend"],[1,"d-flex","flex-column","justify-content-center","mt-2"],["src","assets/line.png","height","10px","width","280px"],[1,"pie-title",2,"color","#737473","margin","5px 0 10px 5px"]],template:function(t,e){1&t&&(s.Tb(0,"div",0),s.ac("click",function(){return e.openDialog()}),s.Tb(1,"div",1),s.Ob(2,"canvas",2),s.Sb(),s.Tb(3,"div",3),s.Ob(4,"img",4),s.Tb(5,"h5",5),s.Dc(6),s.Sb(),s.Sb(),s.Sb()),2&t&&(s.Bb(1),s.yc("width",e.withGraphe)("height",e.height),s.Bb(1),s.kc("data",e.pieChartData)("labels",e.pieChartLabels)("chartType",e.pieChartType)("options",e.pieChartOptions)("plugins",e.pieChartPlugins)("colors",e.pieChartColors)("legend",e.pieChartLegend),s.Bb(2),s.yc("transform","rotateY("+e.retate+"deg)"),s.Bb(2),s.Fc(" ",e.title," "))},directives:[n.a],styles:["p[_ngcontent-%COMP%]{font-family:Lato}#customers[_ngcontent-%COMP%]{font-family:Trebuchet MS,Arial,Helvetica,sans-serif;border-collapse:collapse;width:100%;text-align:center;font-size:x-small}#customers[_ngcontent-%COMP%]   td[_ngcontent-%COMP%], #customers[_ngcontent-%COMP%]   th[_ngcontent-%COMP%]{border:1px solid #ddd;padding:8px}#customers[_ngcontent-%COMP%]   tr[_ngcontent-%COMP%]:nth-child(2n){background-color:#f2f2f2}#customers[_ngcontent-%COMP%]   tr[_ngcontent-%COMP%]:hover{background-color:#ddd}#customers[_ngcontent-%COMP%]   th[_ngcontent-%COMP%]{padding-top:12px;padding-bottom:12px;text-align:left;background-color:#aaabab;color:#fff}"]}),t})()},"/ysL":function(t,e,i){"use strict";i.d(e,"a",function(){return s});var n=i("fXoL"),o=i("J3i2"),a=i("f0Cb"),r=i("ofXK");let s=(()=>{class t{constructor(t){this.mytranslate=t,this.title=""}ngOnInit(){}}return t.\u0275fac=function(e){return new(e||t)(n.Nb(o.a))},t.\u0275cmp=n.Hb({type:t,selectors:[["app-title"]],inputs:{title:"title"},decls:7,vars:4,consts:[[1,"d-flex","w-100","mb-3"],[3,"className"]],template:function(t,e){1&t&&(n.Tb(0,"div",0),n.Tb(1,"section",1),n.fc(2,"async"),n.Tb(3,"div"),n.Tb(4,"h3"),n.Dc(5),n.Sb(),n.Sb(),n.Sb(),n.Sb(),n.Ob(6,"mat-divider")),2&t&&(n.Bb(1),n.kc("className","fr"===n.gc(2,2,e.mytranslate.lang)?"super-title border-left":"super-title border-right"),n.Bb(4),n.Ec(e.title))},directives:[a.a],pipes:[r.b],styles:["section[_ngcontent-%COMP%]{display:flex!important;justify-content:space-between!important;align-items:center!important}.border-left[_ngcontent-%COMP%]{border-left:10px solid #d17c36}.border-right[_ngcontent-%COMP%]{border-right:10px solid #d17c36}.super-title[_ngcontent-%COMP%]{height:45px}.super-title[_ngcontent-%COMP%], .super-title[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]{display:flex;align-items:center}.super-title[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]{background-color:#a19b9e;height:35px}.super-title[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]   h3[_ngcontent-%COMP%]{color:#fff;margin:0;padding:0 5px}"]}),t})()},"5F3i":function(t,e,i){"use strict";i.d(e,"a",function(){return c});var n=i("0IaG"),o=i("fXoL"),a=i("/t3+"),r=i("f0Cb"),s=i("bTqV");let l=(()=>{class t{constructor(t,e){this.dialogRef=t,this.data=e,this.model=""}ngOnInit(){this.model=this.data.model}onNoClick(){this.dialogRef.close()}onOkClick(){this.dialogRef.close("ok")}}return t.\u0275fac=function(e){return new(e||t)(o.Nb(n.g),o.Nb(n.a))},t.\u0275cmp=o.Hb({type:t,selectors:[["app-delete"]],decls:15,vars:1,consts:[[1,"dialog"],["mat-dialog-title",""],["role","toolbar",1,"task-header"],[1,"content"],["mat-dialog-content",""],["mat-dialog-actions","",1,"actions"],["mat-button","","type","button",3,"click"],["mat-button","","color","primary","type","button","cdkFocusInitial","",3,"mat-dialog-close","click"]],template:function(t,e){1&t&&(o.Tb(0,"div",0),o.Tb(1,"h1",1),o.Tb(2,"mat-toolbar",2),o.Tb(3,"span"),o.Dc(4),o.Sb(),o.Sb(),o.Ob(5,"mat-divider"),o.Sb(),o.Tb(6,"div",3),o.Tb(7,"div",4),o.Tb(8,"p"),o.Dc(9,"Voulez-vous vraiment supprimer?"),o.Sb(),o.Sb(),o.Tb(10,"div",5),o.Tb(11,"button",6),o.ac("click",function(){return e.onNoClick()}),o.Dc(12,"Annuler"),o.Sb(),o.Tb(13,"button",7),o.ac("click",function(){return e.onOkClick()}),o.Dc(14,"Ok"),o.Sb(),o.Sb(),o.Sb(),o.Sb()),2&t&&(o.Bb(4),o.Fc("Suppression ",e.model," "))},directives:[n.h,a.a,r.a,n.e,n.c,s.a,n.d],styles:[".dialog[_ngcontent-%COMP%]{overflow-x:hidden;overflow-y:hidden}.dialog[_ngcontent-%COMP%]   h1[_ngcontent-%COMP%]   span[_ngcontent-%COMP%]{padding:0 5px}.dialog[_ngcontent-%COMP%]   .content[_ngcontent-%COMP%]{padding:0 20px 25px}.dialog[_ngcontent-%COMP%]   .actions[_ngcontent-%COMP%]{display:flex;flex-direction:row-reverse}"]}),t})(),c=(()=>{class t{constructor(t){this.dialog=t}openDialog(t){return this.dialog.open(l,{width:"750px",disableClose:!0,data:{model:t}}).afterClosed()}}return t.\u0275fac=function(e){return new(e||t)(o.Xb(n.b))},t.\u0275prov=o.Jb({token:t,factory:t.\u0275fac,providedIn:"root"}),t})()},ZTdd:function(t,e,i){"use strict";i.d(e,"a",function(){return d});var n=i("mrSG"),o=i("2ChS"),a=i("fXoL"),r=i("MutI"),s=i("ofXK"),l=i("FKr1");function c(t,e){if(1&t){const t=a.Ub();a.Tb(0,"a",2),a.ac("click",function(){a.sc(t);const e=a.ec().$implicit;return a.ec().openLink(e)}),a.Tb(1,"span",3),a.Dc(2),a.Sb(),a.Sb()}if(2&t){const t=a.ec().$implicit;a.Bb(2),a.Fc("- ",t.substring(14,t.length-1),"")}}function h(t,e){if(1&t&&(a.Tb(0,"div"),a.Bc(1,c,3,1,"a",1),a.Sb()),2&t){const t=e.$implicit,i=a.ec();a.Bb(1),a.kc("ngIf",i.show(t))}}let d=(()=>{class t{constructor(t,e,i){this.bottomSheetRef=t,this.data=e,this.url=i,this.list=[],this.folder=""}ngOnInit(){if(this.data.fileName){const t=this.data.fileName.split(";");t.pop(),this.folder=this.data.folder,console.log(t),this.list=t}}openLink(t){return Object(n.a)(this,void 0,void 0,function*(){const e=+t.substring(t.length-1,t.length);t=isNaN(e)?t:t.substring(0,t.length-1),window.open(`${this.url}/${this.folder}/${t}`)})}show(t){if(""===t)return!1;const e=+t.substring(t.length-1,t.length);return!!isNaN(e)||1===e}}return t.\u0275fac=function(e){return new(e||t)(a.Nb(o.d),a.Nb(o.a),a.Nb("BASE_URL"))},t.\u0275cmp=a.Hb({type:t,selectors:[["app-download-sheet"]],decls:2,vars:1,consts:[[4,"ngFor","ngForOf"],["mat-list-item","",3,"click",4,"ngIf"],["mat-list-item","",3,"click"],["mat-line",""]],template:function(t,e){1&t&&(a.Tb(0,"mat-nav-list"),a.Bc(1,h,2,1,"div",0),a.Sb()),2&t&&(a.Bb(1),a.kc("ngForOf",e.list))},directives:[r.d,s.l,s.m,r.b,l.k],styles:[""]}),t})()},hSFZ:function(t,e){!function(){"use strict";if("undefined"!=typeof Chart){"function"!=typeof Object.assign&&(Object.assign=function(t,e){if(null==t)throw new TypeError("Cannot convert undefined or null to object");for(var i=Object(t),n=1;n<arguments.length;n++){var o=arguments[n];if(null!=o)for(var a in o)Object.prototype.hasOwnProperty.call(o,a)&&(i[a]=o[a])}return i});var t={};["pie","doughnut","polarArea","bar"].forEach(function(e){t[e]=!0}),e.prototype.setup=function(t,e){this.chart=t,this.ctx=t.ctx,this.args={},this.barTotal={};var i=t.config.options;this.options=Object.assign({position:"default",precision:0,fontSize:i.defaultFontSize,fontColor:i.defaultFontColor,fontStyle:i.defaultFontStyle,fontFamily:i.defaultFontFamily,shadowOffsetX:3,shadowOffsetY:3,shadowColor:"rgba(0,0,0,0.3)",shadowBlur:6,images:[],outsidePadding:2,textMargin:2,overlap:!0},e),"bar"===t.config.type&&(this.options.position="default",this.options.arc=!1,this.options.overlap=!0)},e.prototype.render=function(){this.labelBounds=[],this.chart.data.datasets.forEach(this.renderToDataset)},e.prototype.renderToDataset=function(t,e){this.totalPercentage=0,this.total=null;var i=this.args[e];i.meta.data.forEach((function(e,n){this.renderToElement(t,i,e,n)}).bind(this))},e.prototype.renderToElement=function(t,e,i,n){if(this.shouldRenderToElement(e.meta,i)){this.percentage=null;var o=this.getLabel(t,i,n);if(o){var a=this.ctx;a.save(),a.font=Chart.helpers.fontString(this.options.fontSize,this.options.fontStyle,this.options.fontFamily);var r=this.getRenderInfo(i,o);this.drawable(i,o,r)?(a.beginPath(),a.fillStyle=this.getFontColor(t,i,n),this.renderLabel(o,r),a.restore()):a.restore()}}},e.prototype.renderLabel=function(t,e){return this.options.arc?this.renderArcLabel(t,e):this.renderBaseLabel(t,e)},e.prototype.renderBaseLabel=function(t,e){var i=this.ctx;if("object"==typeof t)i.drawImage(t,e.x-t.width/2,e.y-t.height/2,t.width,t.height);else{i.save(),i.textBaseline="top",i.textAlign="center",this.options.textShadow&&(i.shadowOffsetX=this.options.shadowOffsetX,i.shadowOffsetY=this.options.shadowOffsetY,i.shadowColor=this.options.shadowColor,i.shadowBlur=this.options.shadowBlur);for(var n=t.split("\n"),o=0;o<n.length;o++)i.fillText(n[o],e.x,e.y-this.options.fontSize/2*n.length+this.options.fontSize*o);i.restore()}},e.prototype.renderArcLabel=function(t,e){var i=this.ctx,n=e.radius,o=e.view;if(i.save(),i.translate(o.x,o.y),"string"==typeof t){i.rotate(e.startAngle),i.textBaseline="middle",i.textAlign="left";var a=t.split("\n"),r=0,s=[],l=0;"border"===this.options.position&&(l=(a.length-1)*this.options.fontSize/2);for(var c=0;c<a.length;++c){var h=i.measureText(a[c]);h.width>r&&(r=h.width),s.push(h.width)}for(c=0;c<a.length;++c){var d=a[c],p=(a.length-1-c)*-this.options.fontSize+l;i.save(),i.rotate((r-s[c])/2/n);for(var g=0;g<d.length;g++){var f=d.charAt(g);h=i.measureText(f),i.save(),i.translate(0,-1*n),i.fillText(f,0,p),i.restore(),i.rotate(h.width/n)}i.restore()}}else i.rotate((o.startAngle+Math.PI/2+e.endAngle)/2),i.translate(0,-1*n),this.renderLabel(t,{x:0,y:0});i.restore()},e.prototype.shouldRenderToElement=function(t,e){return!t.hidden&&!e.hidden&&(this.options.showZero||"polarArea"===this.chart.config.type?0!==e._view.outerRadius:0!==e._view.circumference)},e.prototype.getLabel=function(t,e,i){var n;if("function"==typeof this.options.render)n=this.options.render({label:this.chart.config.data.labels[i],value:t.data[i],percentage:this.getPercentage(t,e,i),dataset:t,index:i});else switch(this.options.render){case"value":n=t.data[i];break;case"label":n=this.chart.config.data.labels[i];break;case"image":n=this.options.images[i]?this.loadImage(this.options.images[i]):"";break;case"percentage":default:n=this.getPercentage(t,e,i)+"%"}return"object"==typeof n?n=this.loadImage(n):null!=n&&(n=n.toString()),n},e.prototype.getFontColor=function(t,e,i){var n=this.options.fontColor;return"function"==typeof n?n=n({label:this.chart.config.data.labels[i],value:t.data[i],percentage:this.getPercentage(t,e,i),backgroundColor:t.backgroundColor[i],dataset:t,index:i}):"string"!=typeof n&&(n=n[i]||this.chart.config.options.defaultFontColor),n},e.prototype.getPercentage=function(t,e,i){if(null!==this.percentage)return this.percentage;var n;if("polarArea"===this.chart.config.type){if(null===this.total){this.total=0;for(var o=0;o<t.data.length;++o)this.total+=t.data[o]}n=t.data[i]/this.total*100}else if("bar"===this.chart.config.type){if(void 0===this.barTotal[i])for(this.barTotal[i]=0,o=0;o<this.chart.data.datasets.length;++o)this.barTotal[i]+=this.chart.data.datasets[o].data[i];n=t.data[i]/this.barTotal[i]*100}else n=e._view.circumference/this.chart.config.options.circumference*100;return n=parseFloat(n.toFixed(this.options.precision)),this.options.showActualPercentages||("bar"===this.chart.config.type&&(this.totalPercentage=this.barTotalPercentage[i]||0),this.totalPercentage+=n,this.totalPercentage>100&&(n-=this.totalPercentage-100,n=parseFloat(n.toFixed(this.options.precision))),"bar"===this.chart.config.type&&(this.barTotalPercentage[i]=this.totalPercentage)),this.percentage=n,n},e.prototype.getRenderInfo=function(t,e){return"bar"===this.chart.config.type?this.getBarRenderInfo(t,e):this.options.arc?this.getArcRenderInfo(t,e):this.getBaseRenderInfo(t,e)},e.prototype.getBaseRenderInfo=function(t,e){if("outside"===this.options.position||"border"===this.options.position){var i,n,o=t._view,a=o.startAngle+(o.endAngle-o.startAngle)/2,r=o.outerRadius/2;if("border"===this.options.position?n=(o.outerRadius-r)/2+r:"outside"===this.options.position&&(n=o.outerRadius-r+r+this.options.textMargin),i={x:o.x+Math.cos(a)*n,y:o.y+Math.sin(a)*n},"outside"===this.options.position){var s=this.options.textMargin+this.measureLabel(e).width/2;i.x+=i.x<o.x?-s:s}return i}return t.tooltipPosition()},e.prototype.getArcRenderInfo=function(t,e){var i,n=t._view;i="outside"===this.options.position?n.outerRadius+this.options.fontSize+this.options.textMargin:"border"===this.options.position?(n.outerRadius/2+n.outerRadius)/2:(n.innerRadius+n.outerRadius)/2;var o=n.startAngle,a=n.endAngle,r=a-o;return o+=Math.PI/2,{radius:i,startAngle:o+=((a+=Math.PI/2)-(this.measureLabel(e).width/i+o))/2,endAngle:a,totalAngle:r,view:n}},e.prototype.getBarRenderInfo=function(t,e){var i=t.tooltipPosition();return i.y-=this.measureLabel(e).height/2+this.options.textMargin,i},e.prototype.drawable=function(t,e,i){if(this.options.overlap)return!0;if(this.options.arc)return i.endAngle-i.startAngle<=i.totalAngle;var n=this.measureLabel(e),o=i.x-n.width/2,a=i.x+n.width/2,r=i.y-n.height/2,s=i.y+n.height/2;return"outside"===this.options.renderInfo?this.outsideInRange(o,a,r,s):t.inRange(o,r)&&t.inRange(o,s)&&t.inRange(a,r)&&t.inRange(a,s)},e.prototype.outsideInRange=function(t,e,i,n){for(var o=this.labelBounds,a=0;a<o.length;++a){for(var r=o[a],s=[[t,i],[t,n],[e,i],[e,n]],l=0;l<s.length;++l){var c=s[l][1];if((h=s[l][0])>=r.left&&h<=r.right&&c>=r.top&&c<=r.bottom)return!1}for(s=[[r.left,r.top],[r.left,r.bottom],[r.right,r.top],[r.right,r.bottom]],l=0;l<s.length;++l){var h;if(c=s[l][1],(h=s[l][0])>=t&&h<=e&&c>=i&&c<=n)return!1}}return o.push({left:t,right:e,top:i,bottom:n}),!0},e.prototype.measureLabel=function(t){if("object"==typeof t)return{width:t.width,height:t.height};for(var e=0,i=t.split("\n"),n=0;n<i.length;++n){var o=this.ctx.measureText(i[n]);o.width>e&&(e=o.width)}return{width:e,height:this.options.fontSize*i.length}},e.prototype.loadImage=function(t){var e=new Image;return e.src=t.src,e.width=t.width,e.height=t.height,e},Chart.plugins.register({id:"labels",beforeDatasetsUpdate:function(i,n){if(t[i.config.type]){Array.isArray(n)||(n=[n]);var o=n.length;i._labels&&o===i._labels.length||(i._labels=n.map(function(){return new e}));for(var a=!1,r=0,s=0;s<o;++s){var l=i._labels[s];if(l.setup(i,n[s]),"outside"===l.options.position){a=!0;var c=1.5*l.options.fontSize+l.options.outsidePadding;c>r&&(r=c)}}a&&(i.chartArea.top+=r,i.chartArea.bottom-=r)}},afterDatasetUpdate:function(e,i,n){t[e.config.type]&&e._labels.forEach(function(t){t.args[i.index]=i})},beforeDraw:function(e){t[e.config.type]&&e._labels.forEach(function(t){t.barTotalPercentage={}})},afterDatasetsDraw:function(e){t[e.config.type]&&e._labels.forEach(function(t){t.render()})}})}else console.error("Can not find Chart object.");function e(){this.renderToDataset=this.renderToDataset.bind(this)}}()},oTHA:function(t,e,i){"use strict";i.d(e,"a",function(){return p});var n=i("XNiG"),o=i("DDG+"),a=i("hSFZ"),r=i("fXoL"),s=i("J3i2"),l=i("0IaG"),c=i("ofXK"),h=i("LPYB");function d(t,e){if(1&t&&(r.Tb(0,"div",4),r.Tb(1,"section",5),r.fc(2,"async"),r.Tb(3,"div"),r.Tb(4,"h3",6),r.Dc(5),r.Sb(),r.Sb(),r.Sb(),r.Sb()),2&t){const t=r.ec();r.Bb(1),r.kc("className","fr"===r.gc(2,2,t.mytranslate.lang)?"super-title border-left":"super-title border-right"),r.Bb(4),r.Ec(""===t.title?".......":t.title)}}let p=(()=>{class t{constructor(t,e){this.mytranslate=t,this.dialog=e,this.title="",this.barChartOptions={responsive:!0,maintainAspectRatio:!1,title:{text:"",display:!0},scales:{xAxes:[{ticks:{fontSize:16}}],yAxes:[{ticks:{beginAtZero:!0},scaleLabel:{display:!1,labelString:"%"},position:"top"}]},legend:{position:"top",align:"center",labels:{fontSize:16,padding:10}},plugins:{labels:{precision:0,render:"value"},pieceLabel:{render:t=>t.label+": "+t.value}}},this.barChartLabels=[],this.barChartType="bar",this.barChartLegend=!0,this.pieChartPlugins=[a,{beforeInit:(t,e)=>{t.legend.afterFit=function(){this.height+=15}}}],this.barChartData=[{data:[],label:""}],this.pieChartColors=[{backgroundColor:"#d17c36"},{backgroundColor:"#7dc460"},{backgroundColor:"#db0707"},{backgroundColor:"#a19b9e"}],this.dataSubject=new n.a,this.height="40vh",this.col=12,this.retate=0,this.list=[]}ngOnInit(){this.mytranslate.lang.subscribe(t=>{this.retate="fr"===t?0:180}),this.dataSubject.subscribe(t=>{this.title=t.title,this.barChartLabels=t.barChartLabels,this.barChartData=t.barChartData,t.barChartLabels.forEach((t,e)=>{this.list.push({name:t.toString(),p:+this.barChartData.find((t,e)=>0===e).data[e],r:+this.barChartData.find((t,e)=>1===e).data[e],n:+this.barChartData.find((t,e)=>2===e).data[e]})})})}openDialog(){this.dialog.open(o.a,{width:"7100px",disableClose:!1,data:{model:this.list,type:"bar",title:this.title}}).afterClosed().subscribe(t=>{console.log(t)})}chartClicked({}){}chartHovered({}){}randomize(){this.barChartType="bar"===this.barChartType?"line":"bar"}getColors(t){const e=["#0074D9","#2ECC40","#FF4136","#FF851B","#7FDBFF","#B10DC9","#FFDC00","#001f3f","#39CCCC","#01FF70","#85144b","#F012BE","#3D9970","#111111","#AAAAAA"],i=[];for(let n=0;n<t;n++)i.push(e[n%e.length]);return i}}return t.\u0275fac=function(e){return new(e||t)(r.Nb(s.a),r.Nb(l.b))},t.\u0275cmp=r.Hb({type:t,selectors:[["app-bar"]],inputs:{dataSubject:"dataSubject",height:"height",col:"col"},decls:5,vars:12,consts:[["class","d-flex justify-content-left w-100","style","margin-top: 2%; ",4,"ngIf"],[1,"mb-5",2,"cursor","pointer",3,"click"],[2,"display","block","width","100vw"],["baseChart","",3,"datasets","labels","options","legend","chartType","plugins","colors","chartHover","chartClick"],[1,"d-flex","justify-content-left","w-100",2,"margin-top","2%"],[3,"className"],[2,"font-size","1.2em"]],template:function(t,e){1&t&&(r.Tb(0,"div"),r.Bc(1,d,6,4,"div",0),r.Tb(2,"div",1),r.ac("click",function(){return e.openDialog()}),r.Tb(3,"div",2),r.Tb(4,"canvas",3),r.ac("chartHover",function(t){return e.chartHovered(t)})("chartClick",function(t){return e.chartClicked(t)}),r.Sb(),r.Sb(),r.Sb(),r.Sb()),2&t&&(r.Bb(1),r.kc("ngIf",e.title&&""!==e.title),r.Bb(2),r.Db("col-md-"+e.col),r.yc("height",e.height),r.Bb(1),r.kc("datasets",e.barChartData)("labels",e.barChartLabels)("options",e.barChartOptions)("legend",e.barChartLegend)("chartType",e.barChartType)("plugins",e.pieChartPlugins)("colors",e.pieChartColors))},directives:[c.m,h.a],pipes:[c.b],styles:['p[_ngcontent-%COMP%]{font-family:Lato}.XChart[_ngcontent-%COMP%]{margin-top:0;margin-bottom:-40px;margin-left:30px;display:flex;flex-direction:row-reverse;color:grey;direction:rtl}.border-left[_ngcontent-%COMP%]{border-left:10px solid #d17c36}.border-right[_ngcontent-%COMP%]{border-right:10px solid #d17c36}.super-title[_ngcontent-%COMP%]{height:45px}.super-title[_ngcontent-%COMP%], .super-title[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]{display:flex;align-items:center}.super-title[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]{background-color:#a19b9e;height:35px}.super-title[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]   h3[_ngcontent-%COMP%]{color:#fff;margin:0;padding:0 5px}.super-title2[_ngcontent-%COMP%]{height:45px;display:flex;align-items:center}.super-title2[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]{height:35px;display:flex;align-items:center}.super-title2[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]   h3[_ngcontent-%COMP%]{color:#a19b9e;margin:0;padding:0 5px;font-size:1.8em}.host[_ngcontent-%COMP%]{margin:1em!important}  .mat-progress-spinner circle{fill:rgba(0,0,0,.03137254901960784)!important}h3[_ngcontent-%COMP%]{margin:20px 0 10px;color:var(--primary);text-align:center;font-size:medium}.axes[_ngcontent-%COMP%]{display:flex;flex-direction:column;box-shadow:1px 1px 5px #ddd;padding:5px;margin-bottom:5px}.axes[_ngcontent-%COMP%]   p[_ngcontent-%COMP%]{margin:0;font-size:.8em}.axes[_ngcontent-%COMP%]   .title[_ngcontent-%COMP%]{font-weight:700;margin-bottom:10px;font-size:.9em}@font-face{font-family:Satisfy;font-style:normal;font-weight:400;font-display:swap;src:local("Satisfy Regular"),local("Satisfy-Regular"),url(https://fonts.gstatic.com/s/satisfy/v11/rP2Hp2yn6lkG50LoCZOIHQ.woff2) format("woff2");unicode-range:u+00??,u+0131,u+0152-0153,u+02bb-02bc,u+02c6,u+02da,u+02dc,u+2000-206f,u+2074,u+20ac,u+2122,u+2191,u+2193,u+2212,u+2215,u+feff,u+fffd}.textAlign-left[_ngcontent-%COMP%]{text-align:left}.textAlign-right[_ngcontent-%COMP%], .textSouTitre[_ngcontent-%COMP%]{text-align:right}.textSouTitre[_ngcontent-%COMP%]{margin-bottom:2%;font-size:.9em;color:rgba(0,0,0,.4392156862745098)}']}),t})()}}]);