(window.webpackJsonp=window.webpackJsonp||[]).push([[6],{"+Ya6":function(t,e,n){"use strict";n.d(e,"a",(function(){return l}));var i=n("hrfs"),o=n("XNiG"),a=n("DDG+"),r=n("hSFZ");class l{constructor(t,e,n){this.uow=t,this.mytranslate=e,this.dialog=n,this.obs=new o.a,this.showLegend=!1,this.withGraphe=0,this.dataToShowInTable=[],this.title=null,this.pieChartOptions={responsive:!0,cutoutPercentage:50,title:{text:"",display:!0},tooltips:{enabled:!0,callbacks:{label:(t,e)=>e.labels[t.index]}},hover:{mode:"nearest",intersect:!1,onHover:(t,e)=>{}},legend:{position:"right",display:!1,align:"center"},plugins:{labels:{fontColor:["white","white","white","white","white","white","white","white","white","white","white","white"],precision:0,render:"percentage"},pieceLabel:{render:t=>t.label+": "+t.value}}},this.pieChartLabels=[],this.pieChartData=[],this.pieChartType="pie",this.pieChartLegend=!0,this.pieChartPlugins=[r],this.pieChartColors=[{backgroundColor:[]}],this.list=[],this.retate=0,this.arr=[],Object(i.e)(),Object(i.d)()}ngOnInit(){this.mytranslate.lang.subscribe(t=>{this.retate="fr"===t?0:180}),this.pieChartOptions.legend.display=this.showLegend,this.obs.subscribe(t=>{this.title=t.title,this.pieChartLabels=t.chartLabels,this.pieChartData=t.chartData.map(t=>+t.toFixed(0)),this.dataToShowInTable=t.dataToShowInTable.map(t=>+t.toFixed(0)),this.count=t.count,this.pieChartColors[0].backgroundColor=t.chartColors,this.arr=t.chartData.map((t,e)=>e)})}openDialog(){this.dialog.open(a.a,{width:"7100px",disableClose:!1,data:{model:this.list,type:"pie",title:this.title}}).afterClosed().subscribe(t=>{console.log(t)})}getColors(t){const e=["#d97f2a","#2d71a1","#c2c3c6","#ba6446","#7dc460","#fdb93a","#59b8ce","#5c5c5f","#ef4f42","#a5a6aa"],n=[];for(let i=0;i<t;i++)n.push(e[i%e.length]);return n}toInt(t){return parseInt((t/3-1).toFixed(0),10)}toStr(t){return(parseInt(t.toFixed(0),10)*this.count/100).toFixed(0)}}},"/ysL":function(t,e,n){"use strict";n.d(e,"a",(function(){return i}));class i{constructor(t){this.mytranslate=t,this.title=""}ngOnInit(){}}},ExPl:function(t,e,n){"use strict";var i=n("8Y7J"),o=n("SVse"),a=n("hrfs");n("oTHA"),n("J3i2"),n("s6ns"),n.d(e,"a",(function(){return r})),n.d(e,"b",(function(){return s}));var r=i.qb({encapsulation:0,styles:[['p[_ngcontent-%COMP%]{font-family:Lato}.border-left[_ngcontent-%COMP%]{border-left:10px solid #a19b9e}.border-right[_ngcontent-%COMP%]{border-right:10px solid #a19b9e}.super-title[_ngcontent-%COMP%]{height:45px;display:flex;align-items:center}.super-title[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]{background-color:#0070a3;height:35px;display:flex;align-items:center}.super-title[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]   h3[_ngcontent-%COMP%]{color:#fff;margin:0;padding:0 5px}.super-title2[_ngcontent-%COMP%]{height:45px;display:flex;align-items:center}.super-title2[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]{height:35px;display:flex;align-items:center}.super-title2[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]   h3[_ngcontent-%COMP%]{color:#a19b9e;margin:0;padding:0 5px;font-size:1.8em}.host[_ngcontent-%COMP%]{margin:1em!important}  .mat-progress-spinner circle{fill:#00000008!important}h3[_ngcontent-%COMP%]{margin:20px 0 10px;color:var(--primary);text-align:center;font-size:medium}.axes[_ngcontent-%COMP%]{display:flex;flex-direction:column;box-shadow:1px 1px 5px #ddd;padding:5px;margin-bottom:5px}.axes[_ngcontent-%COMP%]   p[_ngcontent-%COMP%]{margin:0;font-size:.8em}.axes[_ngcontent-%COMP%]   .title[_ngcontent-%COMP%]{font-weight:700;margin-bottom:10px;font-size:.9em}@font-face{font-family:Satisfy;font-style:normal;font-weight:400;font-display:swap;src:local("Satisfy Regular"),local("Satisfy-Regular"),url(https://fonts.gstatic.com/s/satisfy/v11/rP2Hp2yn6lkG50LoCZOIHQ.woff2) format("woff2");unicode-range:U+0000-00FF,U+0131,U+0152-0153,U+02BB-02BC,U+02C6,U+02DA,U+02DC,U+2000-206F,U+2074,U+20AC,U+2122,U+2191,U+2193,U+2212,U+2215,U+FEFF,U+FFFD}.textAlign-left[_ngcontent-%COMP%]{text-align:left}.textAlign-right[_ngcontent-%COMP%]{text-align:right}.textSouTitre[_ngcontent-%COMP%]{text-align:right;margin-bottom:2%;font-size:.9em;color:#00000070}']],data:{}});function l(t){return i.Ob(0,[(t()(),i.sb(0,0,null,null,5,"div",[["class","d-flex justify-content-left w-100"],["style","margin-top: 2%;"]],null,null,null,null,null)),(t()(),i.sb(1,0,null,null,4,"section",[],[[8,"className",0]],null,null,null,null)),i.Gb(131072,o.b,[i.h]),(t()(),i.sb(3,0,null,null,2,"div",[],null,null,null,null,null)),(t()(),i.sb(4,0,null,null,1,"h3",[],null,null,null,null,null)),(t()(),i.Mb(5,null,["",""]))],null,(function(t,e){var n=e.component;t(e,1,0,"fr"===i.Nb(e,1,0,i.Eb(e,2).transform(n.mytranslate.lang))?"super-title border-left":"super-title border-right"),t(e,5,0,""===n.title?".......":n.title)}))}function s(t){return i.Ob(0,[(t()(),i.hb(16777216,null,null,1,null,l)),i.rb(1,16384,null,0,o.l,[i.O,i.L],{ngIf:[0,"ngIf"]},null),(t()(),i.sb(2,0,null,null,3,"div",[["class","d-flex flex-column align-items-center justify-content-center"],["style","cursor: pointer;"]],null,[[null,"click"]],(function(t,e,n){var i=!0;return"click"===e&&(i=!1!==t.component.openDialog()&&i),i}),null,null)),(t()(),i.sb(3,0,null,null,2,"div",[["style","display: block; width: 80vw;"]],[[8,"className",0]],null,null,null,null)),(t()(),i.sb(4,0,null,null,1,"canvas",[["baseChart",""]],null,[[null,"chartHover"],[null,"chartClick"]],(function(t,e,n){var i=!0,o=t.component;return"chartHover"===e&&(i=!1!==o.chartHovered(n)&&i),"chartClick"===e&&(i=!1!==o.chartClicked(n)&&i),i}),null,null)),i.rb(5,999424,null,0,a.a,[i.k,a.c],{datasets:[0,"datasets"],labels:[1,"labels"],options:[2,"options"],chartType:[3,"chartType"],colors:[4,"colors"],legend:[5,"legend"],plugins:[6,"plugins"]},{chartClick:"chartClick",chartHover:"chartHover"})],(function(t,e){var n=e.component;t(e,1,0,n.title&&""!==n.title),t(e,5,0,n.barChartData,n.barChartLabels,n.barChartOptions,n.barChartType,n.pieChartColors,n.barChartLegend,n.pieChartPlugins)}),(function(t,e){t(e,3,0,"col-md-"+e.component.col)}))}},ZTdd:function(t,e,n){"use strict";n.d(e,"a",(function(){return o}));var i=n("mrSG");class o{constructor(t,e,n){this.bottomSheetRef=t,this.data=e,this.url=n,this.list=[],this.folder=""}ngOnInit(){const t=this.data.fileName.split(";");t.pop(),this.folder=this.data.folder,console.log(t),this.list=t}openLink(t){return i.a(this,void 0,void 0,(function*(){const e=+t.substring(t.length-1,t.length);t=isNaN(e)?t:t.substring(0,t.length-1),window.open(`${this.url}/${this.folder}/${t}`)}))}show(t){if(""===t)return!1;const e=+t.substring(t.length-1,t.length);return!!isNaN(e)||1===e}}},hSFZ:function(t,e){!function(){"use strict";if("undefined"!=typeof Chart){"function"!=typeof Object.assign&&(Object.assign=function(t,e){if(null==t)throw new TypeError("Cannot convert undefined or null to object");for(var n=Object(t),i=1;i<arguments.length;i++){var o=arguments[i];if(null!=o)for(var a in o)Object.prototype.hasOwnProperty.call(o,a)&&(n[a]=o[a])}return n});var t={};["pie","doughnut","polarArea","bar"].forEach((function(e){t[e]=!0})),e.prototype.setup=function(t,e){this.chart=t,this.ctx=t.ctx,this.args={},this.barTotal={};var n=t.config.options;this.options=Object.assign({position:"default",precision:0,fontSize:n.defaultFontSize,fontColor:n.defaultFontColor,fontStyle:n.defaultFontStyle,fontFamily:n.defaultFontFamily,shadowOffsetX:3,shadowOffsetY:3,shadowColor:"rgba(0,0,0,0.3)",shadowBlur:6,images:[],outsidePadding:2,textMargin:2,overlap:!0},e),"bar"===t.config.type&&(this.options.position="default",this.options.arc=!1,this.options.overlap=!0)},e.prototype.render=function(){this.labelBounds=[],this.chart.data.datasets.forEach(this.renderToDataset)},e.prototype.renderToDataset=function(t,e){this.totalPercentage=0,this.total=null;var n=this.args[e];n.meta.data.forEach((function(e,i){this.renderToElement(t,n,e,i)}).bind(this))},e.prototype.renderToElement=function(t,e,n,i){if(this.shouldRenderToElement(e.meta,n)){this.percentage=null;var o=this.getLabel(t,n,i);if(o){var a=this.ctx;a.save(),a.font=Chart.helpers.fontString(this.options.fontSize,this.options.fontStyle,this.options.fontFamily);var r=this.getRenderInfo(n,o);this.drawable(n,o,r)?(a.beginPath(),a.fillStyle=this.getFontColor(t,n,i),this.renderLabel(o,r),a.restore()):a.restore()}}},e.prototype.renderLabel=function(t,e){return this.options.arc?this.renderArcLabel(t,e):this.renderBaseLabel(t,e)},e.prototype.renderBaseLabel=function(t,e){var n=this.ctx;if("object"==typeof t)n.drawImage(t,e.x-t.width/2,e.y-t.height/2,t.width,t.height);else{n.save(),n.textBaseline="top",n.textAlign="center",this.options.textShadow&&(n.shadowOffsetX=this.options.shadowOffsetX,n.shadowOffsetY=this.options.shadowOffsetY,n.shadowColor=this.options.shadowColor,n.shadowBlur=this.options.shadowBlur);for(var i=t.split("\n"),o=0;o<i.length;o++)n.fillText(i[o],e.x,e.y-this.options.fontSize/2*i.length+this.options.fontSize*o);n.restore()}},e.prototype.renderArcLabel=function(t,e){var n=this.ctx,i=e.radius,o=e.view;if(n.save(),n.translate(o.x,o.y),"string"==typeof t){n.rotate(e.startAngle),n.textBaseline="middle",n.textAlign="left";var a=t.split("\n"),r=0,l=[],s=0;"border"===this.options.position&&(s=(a.length-1)*this.options.fontSize/2);for(var h=0;h<a.length;++h){var c=n.measureText(a[h]);c.width>r&&(r=c.width),l.push(c.width)}for(h=0;h<a.length;++h){var u=a[h],d=(a.length-1-h)*-this.options.fontSize+s;n.save(),n.rotate((r-l[h])/2/i);for(var p=0;p<u.length;p++){var g=u.charAt(p);c=n.measureText(g),n.save(),n.translate(0,-1*i),n.fillText(g,0,d),n.restore(),n.rotate(c.width/i)}n.restore()}}else n.rotate((o.startAngle+Math.PI/2+e.endAngle)/2),n.translate(0,-1*i),this.renderLabel(t,{x:0,y:0});n.restore()},e.prototype.shouldRenderToElement=function(t,e){return!t.hidden&&!e.hidden&&(this.options.showZero||"polarArea"===this.chart.config.type?0!==e._view.outerRadius:0!==e._view.circumference)},e.prototype.getLabel=function(t,e,n){var i;if("function"==typeof this.options.render)i=this.options.render({label:this.chart.config.data.labels[n],value:t.data[n],percentage:this.getPercentage(t,e,n),dataset:t,index:n});else switch(this.options.render){case"value":i=t.data[n];break;case"label":i=this.chart.config.data.labels[n];break;case"image":i=this.options.images[n]?this.loadImage(this.options.images[n]):"";break;case"percentage":default:i=this.getPercentage(t,e,n)+"%"}return"object"==typeof i?i=this.loadImage(i):null!=i&&(i=i.toString()),i},e.prototype.getFontColor=function(t,e,n){var i=this.options.fontColor;return"function"==typeof i?i=i({label:this.chart.config.data.labels[n],value:t.data[n],percentage:this.getPercentage(t,e,n),backgroundColor:t.backgroundColor[n],dataset:t,index:n}):"string"!=typeof i&&(i=i[n]||this.chart.config.options.defaultFontColor),i},e.prototype.getPercentage=function(t,e,n){if(null!==this.percentage)return this.percentage;var i;if("polarArea"===this.chart.config.type){if(null===this.total){this.total=0;for(var o=0;o<t.data.length;++o)this.total+=t.data[o]}i=t.data[n]/this.total*100}else if("bar"===this.chart.config.type){if(void 0===this.barTotal[n])for(this.barTotal[n]=0,o=0;o<this.chart.data.datasets.length;++o)this.barTotal[n]+=this.chart.data.datasets[o].data[n];i=t.data[n]/this.barTotal[n]*100}else i=e._view.circumference/this.chart.config.options.circumference*100;return i=parseFloat(i.toFixed(this.options.precision)),this.options.showActualPercentages||("bar"===this.chart.config.type&&(this.totalPercentage=this.barTotalPercentage[n]||0),this.totalPercentage+=i,this.totalPercentage>100&&(i-=this.totalPercentage-100,i=parseFloat(i.toFixed(this.options.precision))),"bar"===this.chart.config.type&&(this.barTotalPercentage[n]=this.totalPercentage)),this.percentage=i,i},e.prototype.getRenderInfo=function(t,e){return"bar"===this.chart.config.type?this.getBarRenderInfo(t,e):this.options.arc?this.getArcRenderInfo(t,e):this.getBaseRenderInfo(t,e)},e.prototype.getBaseRenderInfo=function(t,e){if("outside"===this.options.position||"border"===this.options.position){var n,i,o=t._view,a=o.startAngle+(o.endAngle-o.startAngle)/2,r=o.outerRadius/2;if("border"===this.options.position?i=(o.outerRadius-r)/2+r:"outside"===this.options.position&&(i=o.outerRadius-r+r+this.options.textMargin),n={x:o.x+Math.cos(a)*i,y:o.y+Math.sin(a)*i},"outside"===this.options.position){var l=this.options.textMargin+this.measureLabel(e).width/2;n.x+=n.x<o.x?-l:l}return n}return t.tooltipPosition()},e.prototype.getArcRenderInfo=function(t,e){var n,i=t._view;n="outside"===this.options.position?i.outerRadius+this.options.fontSize+this.options.textMargin:"border"===this.options.position?(i.outerRadius/2+i.outerRadius)/2:(i.innerRadius+i.outerRadius)/2;var o=i.startAngle,a=i.endAngle,r=a-o;return o+=Math.PI/2,{radius:n,startAngle:o+=((a+=Math.PI/2)-(this.measureLabel(e).width/n+o))/2,endAngle:a,totalAngle:r,view:i}},e.prototype.getBarRenderInfo=function(t,e){var n=t.tooltipPosition();return n.y-=this.measureLabel(e).height/2+this.options.textMargin,n},e.prototype.drawable=function(t,e,n){if(this.options.overlap)return!0;if(this.options.arc)return n.endAngle-n.startAngle<=n.totalAngle;var i=this.measureLabel(e),o=n.x-i.width/2,a=n.x+i.width/2,r=n.y-i.height/2,l=n.y+i.height/2;return"outside"===this.options.renderInfo?this.outsideInRange(o,a,r,l):t.inRange(o,r)&&t.inRange(o,l)&&t.inRange(a,r)&&t.inRange(a,l)},e.prototype.outsideInRange=function(t,e,n,i){for(var o=this.labelBounds,a=0;a<o.length;++a){for(var r=o[a],l=[[t,n],[t,i],[e,n],[e,i]],s=0;s<l.length;++s){var h=l[s][1];if((c=l[s][0])>=r.left&&c<=r.right&&h>=r.top&&h<=r.bottom)return!1}for(l=[[r.left,r.top],[r.left,r.bottom],[r.right,r.top],[r.right,r.bottom]],s=0;s<l.length;++s){var c;if(h=l[s][1],(c=l[s][0])>=t&&c<=e&&h>=n&&h<=i)return!1}}return o.push({left:t,right:e,top:n,bottom:i}),!0},e.prototype.measureLabel=function(t){if("object"==typeof t)return{width:t.width,height:t.height};for(var e=0,n=t.split("\n"),i=0;i<n.length;++i){var o=this.ctx.measureText(n[i]);o.width>e&&(e=o.width)}return{width:e,height:this.options.fontSize*n.length}},e.prototype.loadImage=function(t){var e=new Image;return e.src=t.src,e.width=t.width,e.height=t.height,e},Chart.plugins.register({id:"labels",beforeDatasetsUpdate:function(n,i){if(t[n.config.type]){Array.isArray(i)||(i=[i]);var o=i.length;n._labels&&o===n._labels.length||(n._labels=i.map((function(){return new e})));for(var a=!1,r=0,l=0;l<o;++l){var s=n._labels[l];if(s.setup(n,i[l]),"outside"===s.options.position){a=!0;var h=1.5*s.options.fontSize+s.options.outsidePadding;h>r&&(r=h)}}a&&(n.chartArea.top+=r,n.chartArea.bottom-=r)}},afterDatasetUpdate:function(e,n,i){t[e.config.type]&&e._labels.forEach((function(t){t.args[n.index]=n}))},beforeDraw:function(e){t[e.config.type]&&e._labels.forEach((function(t){t.barTotalPercentage={}}))},afterDatasetsDraw:function(e){t[e.config.type]&&e._labels.forEach((function(t){t.render()}))}})}else console.error("Can not find Chart object.");function e(){this.renderToDataset=this.renderToDataset.bind(this)}}()},oTHA:function(t,e,n){"use strict";n.d(e,"a",(function(){return r}));var i=n("XNiG"),o=n("DDG+"),a=n("hSFZ");class r{constructor(t,e){this.mytranslate=t,this.dialog=e,this.title="",this.barChartOptions={responsive:!0,title:{text:"",display:!0},scales:{xAxes:[{}],yAxes:[{ticks:{beginAtZero:!0}}]},plugins:{labels:{precision:0,render:"value"},pieceLabel:{render:t=>t.label+": "+t.value}}},this.barChartLabels=[],this.barChartType="bar",this.barChartLegend=!0,this.pieChartPlugins=[a],this.barChartData=[{data:[],label:""}],this.pieChartColors=[{backgroundColor:"#d17c36"},{backgroundColor:"#7dc460"},{backgroundColor:"#db0707"}],this.dataSubject=new i.a,this.col=8,this.retate=0,this.list=[]}ngOnInit(){this.mytranslate.lang.subscribe(t=>{this.retate="fr"===t?0:180}),this.dataSubject.subscribe(t=>{this.title=t.title,this.barChartLabels=t.barChartLabels,this.barChartData=t.barChartData,this.barChartLabels.forEach((t,e)=>{this.list.push({name:t.toString(),p:this.barChartData.find(t=>"En cours"===t.label).data[e],r:this.barChartData.find(t=>"R\xe9alis\xe9"===t.label).data[e],t:this.barChartData.find(t=>"Non r\xe9alis\xe9"===t.label).data[e]})})})}openDialog(){this.dialog.open(o.a,{width:"7100px",disableClose:!1,data:{model:this.list,type:"bar",title:this.title}}).afterClosed().subscribe(t=>{console.log(t)})}chartClicked({}){}chartHovered({}){}randomize(){this.barChartType="bar"===this.barChartType?"line":"bar"}getColors(t){const e=["#0074D9","#2ECC40","#FF4136","#FF851B","#7FDBFF","#B10DC9","#FFDC00","#001f3f","#39CCCC","#01FF70","#85144b","#F012BE","#3D9970","#111111","#AAAAAA"],n=[];for(let i=0;i<t;i++)n.push(e[i%e.length]);return n}}},spq3:function(t,e,n){"use strict";var i=n("8Y7J"),o=n("hrfs");n("+Ya6"),n("7q3A"),n("J3i2"),n("s6ns"),n.d(e,"a",(function(){return a})),n.d(e,"b",(function(){return r}));var a=i.qb({encapsulation:0,styles:[['p[_ngcontent-%COMP%]{font-family:Lato}#customers[_ngcontent-%COMP%]{font-family:"Trebuchet MS",Arial,Helvetica,sans-serif;border-collapse:collapse;width:100%;text-align:center;font-size:x-small}#customers[_ngcontent-%COMP%]   td[_ngcontent-%COMP%], #customers[_ngcontent-%COMP%]   th[_ngcontent-%COMP%]{border:1px solid #ddd;padding:8px}#customers[_ngcontent-%COMP%]   tr[_ngcontent-%COMP%]:nth-child(even){background-color:#f2f2f2}#customers[_ngcontent-%COMP%]   tr[_ngcontent-%COMP%]:hover{background-color:#ddd}#customers[_ngcontent-%COMP%]   th[_ngcontent-%COMP%]{padding-top:12px;padding-bottom:12px;text-align:left;background-color:#aaabab;color:#fff}']],data:{}});function r(t){return i.Ob(0,[(t()(),i.sb(0,0,null,null,7,"div",[["class","d-flex flex-column align-items-center justify-content-center mb-3"],["style","cursor: pointer;"]],null,[[null,"click"]],(function(t,e,n){var i=!0;return"click"===e&&(i=!1!==t.component.openDialog()&&i),i}),null,null)),(t()(),i.sb(1,0,null,null,2,"div",[["style","display: block;"]],[[4,"width","px"]],null,null,null,null)),(t()(),i.sb(2,0,null,null,1,"canvas",[["baseChart",""],["class","chart chart-pie"]],null,null,null,null,null)),i.rb(3,999424,null,0,o.a,[i.k,o.c],{data:[0,"data"],labels:[1,"labels"],options:[2,"options"],chartType:[3,"chartType"],colors:[4,"colors"],legend:[5,"legend"],plugins:[6,"plugins"]},null),(t()(),i.sb(4,0,null,null,3,"div",[["class","d-flex flex-column justify-content-center mt-2"]],null,null,null,null,null)),(t()(),i.sb(5,0,null,null,0,"img",[["height","10px"],["src","assets/line.png"],["width","280px"]],[[4,"transform",null]],null,null,null,null)),(t()(),i.sb(6,0,null,null,1,"h5",[["style","color: #737473; margin: 5px 0 10px 5px;"]],null,null,null,null,null)),(t()(),i.Mb(7,null,[" "," "]))],(function(t,e){var n=e.component;t(e,3,0,n.pieChartData,n.pieChartLabels,n.pieChartOptions,n.pieChartType,n.pieChartColors,n.pieChartLegend,n.pieChartPlugins)}),(function(t,e){var n=e.component;t(e,1,0,n.withGraphe),t(e,5,0,"rotateY("+n.retate+"deg)"),t(e,7,0,n.title)}))}},wv6a:function(t,e,n){"use strict";var i=n("8Y7J"),o=n("SVse"),a=n("TtEo"),r=n("02hT");n("/ysL"),n("J3i2"),n.d(e,"a",(function(){return l})),n.d(e,"b",(function(){return s}));var l=i.qb({encapsulation:0,styles:[["section[_ngcontent-%COMP%]{display:flex!important;justify-content:space-between!important;align-items:center!important}.border-left[_ngcontent-%COMP%]{border-left:10px solid #d17c36}.border-right[_ngcontent-%COMP%]{border-right:10px solid #d17c36}.super-title[_ngcontent-%COMP%]{height:45px;display:flex;align-items:center}.super-title[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]{background-color:#a19b9e;height:35px;display:flex;align-items:center}.super-title[_ngcontent-%COMP%]   div[_ngcontent-%COMP%]   h3[_ngcontent-%COMP%]{color:#fff;margin:0;padding:0 5px}"]],data:{}});function s(t){return i.Ob(0,[(t()(),i.sb(0,0,null,null,5,"div",[["class","d-flex w-100 mb-3"]],null,null,null,null,null)),(t()(),i.sb(1,0,null,null,4,"section",[],[[8,"className",0]],null,null,null,null)),i.Gb(131072,o.b,[i.h]),(t()(),i.sb(3,0,null,null,2,"div",[],null,null,null,null,null)),(t()(),i.sb(4,0,null,null,1,"h3",[],null,null,null,null,null)),(t()(),i.Mb(5,null,["",""])),(t()(),i.sb(6,0,null,null,1,"mat-divider",[["class","mat-divider"],["role","separator"]],[[1,"aria-orientation",0],[2,"mat-divider-vertical",null],[2,"mat-divider-horizontal",null],[2,"mat-divider-inset",null]],null,null,a.b,a.a)),i.rb(7,49152,null,0,r.a,[],null,null)],null,(function(t,e){var n=e.component;t(e,1,0,"fr"===i.Nb(e,1,0,i.Eb(e,2).transform(n.mytranslate.lang))?"super-title border-left":"super-title border-right"),t(e,5,0,n.title),t(e,6,0,i.Eb(e,7).vertical?"vertical":"horizontal",i.Eb(e,7).vertical,!i.Eb(e,7).vertical,i.Eb(e,7).inset)}))}}}]);