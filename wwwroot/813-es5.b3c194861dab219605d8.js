!function(){function t(t,e){if(!(t instanceof e))throw new TypeError("Cannot call a class as a function")}function e(t,e){for(var n=0;n<e.length;n++){var i=e[n];i.enumerable=i.enumerable||!1,i.configurable=!0,"value"in i&&(i.writable=!0),Object.defineProperty(t,i.key,i)}}function n(t,n,i){return n&&e(t.prototype,n),i&&e(t,i),t}(self.webpackChunkmy_app=self.webpackChunkmy_app||[]).push([[813],{17813:function(e,i,a){"use strict";a.r(i),a.d(i,{AuthModule:function(){return Q}});var o=a(61116),r=a(63337),u=a(35366),l=function(){var e=function(){function e(){t(this,e)}return n(e,[{key:"ngOnInit",value:function(){}}]),e}();return e.\u0275fac=function(t){return new(t||e)},e.\u0275cmp=u.Xpm({type:e,selectors:[["app-auth"]],decls:1,vars:0,template:function(t,e){1&t&&u._UZ(0,"router-outlet")},directives:[r.lC],styles:[""]}),e}(),s=a(64762),m=a(31041),c=a(18314),p=a(529),d=a(92572),f=a(50545),h=a(31496),g=a(22797),Z=a(13070),y=a(9550),v=a(77307),w=a(84369),x=a(13841),q=a(87064),A=a(47340),b=a(60649);function _(t,e){1&t&&(u.TgZ(0,"mat-error"),u._uU(1),u.ALo(2,"translate"),u.qZA()),2&t&&(u.xp6(1),u.Oqu(u.lcZ(2,1,"admin.auth.Emailestpasvalider")))}function T(t,e){1&t&&(u.TgZ(0,"th",29),u._uU(1," EMAIL "),u.qZA())}function k(t,e){if(1&t&&(u.TgZ(0,"td",30),u._uU(1),u.qZA()),2&t){var n=e.$implicit;u.xp6(1),u.hij(" ",n.email," ")}}function C(t,e){1&t&&(u.TgZ(0,"th",29),u._uU(1," MOTPASS "),u.qZA())}function O(t,e){if(1&t&&(u.TgZ(0,"td",30),u._uU(1),u.qZA()),2&t){var n=e.$implicit;u.xp6(1),u.hij(" ",n.password," ")}}function U(t,e){1&t&&(u.TgZ(0,"th",29),u._uU(1," PROFIL "),u.qZA())}function D(t,e){if(1&t&&(u.TgZ(0,"td",30),u._uU(1),u.qZA()),2&t){var n=e.$implicit;u.xp6(1),u.hij(" ",n.profil," ")}}function N(t,e){1&t&&u._UZ(0,"tr",31)}function Y(t,e){1&t&&u._UZ(0,"tr",32)}function J(t,e){if(1&t&&(u.TgZ(0,"table",21),u.ynx(1,22),u.YNc(2,T,2,0,"th",23),u.YNc(3,k,2,1,"td",24),u.BQk(),u.ynx(4,25),u.YNc(5,C,2,0,"th",23),u.YNc(6,O,2,1,"td",24),u.BQk(),u.ynx(7,26),u.YNc(8,U,2,0,"th",23),u.YNc(9,D,2,1,"td",24),u.BQk(),u.YNc(10,N,1,0,"tr",27),u.YNc(11,Y,1,0,"tr",28),u.qZA()),2&t){var n=u.oxw();u.Q6J("dataSource",n.dataSource),u.xp6(10),u.Q6J("matHeaderRowDef",n.displayedColumns),u.xp6(1),u.Q6J("matRowDefColumns",n.displayedColumns)}}var M,S,F=function(){return["/admin"]},P=[{path:"",redirectTo:"",pathMatch:"full"},{path:"",component:l,children:[{path:"",redirectTo:"login",pathMatch:"full"},{path:"login",component:(M=function(){function e(n,i,a,o,r){t(this,e),this.fb=n,this.uow=i,this.router=a,this.session=o,this.mytranslate=r,this.isDev=!1===p.N.production,this.displayedColumns=["email","password","profil"],this.dataSource=[{email:"mourabit@angular.io",password:"123",profil:"Administrateur"},{email:"mehdi@angular.io",password:"123",profil:"Superviseur"},{email:"soufiane@angular.io",password:"123",profil:"Point focal"},{email:"ahmed@angular.io",password:"123",profil:"Propri\xe9taire"}],this.o=new c.n5,this.hide=!0}return n(e,[{key:"ngOnInit",value:function(){return(0,s.mG)(this,void 0,void 0,regeneratorRuntime.mark(function t(){return regeneratorRuntime.wrap(function(t){for(;;)switch(t.prev=t.next){case 0:this.o.email=this.isDev?"mourabit@angular.io":"",this.o.password=this.isDev?"123":"",this.createForm();case 1:case"end":return t.stop()}},t,this)}))}},{key:"createForm",value:function(){this.myForm=this.fb.group({email:[this.o.email,[m.kI.required,m.kI.email]],password:[this.o.password,[m.kI.required]]})}},{key:"email",get:function(){return this.myForm.get("email")}},{key:"password",get:function(){return this.myForm.get("password")}},{key:"emailError",get:function(){return this.email.hasError("required")?"You must enter a value":this.email.hasError("email")?"Not a valid email":""}},{key:"passwordError",get:function(){return this.password.hasError("required")?"You must enter a value":""}},{key:"submit",value:function(t){var e=this;this.uow.users.login(t.value).subscribe(function(t){e.session.doSignIn(t.user,t.token,t.idRole),setTimeout(function(){return e.router.navigate(["/admin"])},500)})}},{key:"resetForm",value:function(){this.o=new c.n5,this.createForm()}},{key:"ngOnDestroy",value:function(){}}]),e}(),M.\u0275fac=function(t){return new(t||M)(u.Y36(m.qu),u.Y36(d.Z),u.Y36(r.F0),u.Y36(f.m),u.Y36(h.n))},M.\u0275cmp=u.Xpm({type:M,selectors:[["app-login"]],decls:46,vars:28,consts:[[1,"flex-container"],[1,"flex-item","mat-elevation-z8"],[3,"formGroup","ngSubmit"],[1,"logo"],["src","assets/logo-ddh.jpg","alt","marit logo","width","210"],[1,"systeme","auth-title"],[1,"example-container","mtb-2","text-center"],["appearance","fill"],[1,"mat-label"],["matInput","","formControlName","email"],[4,"ngIf"],["matInput","","formControlName","password",3,"type"],["matSuffix","",3,"click"],["mat-raised-button","","color","primary","type","submit"],["mat-raised-button","","color","warn","type","button",3,"routerLink"],[1,"row","justify-content-center"],[1,"d-flex"],[3,"selectionChange"],["value","fr"],["value","ar"],["mat-table","","class","mat-elevation-z8","style","width: 450px !important;",3,"dataSource",4,"ngIf"],["mat-table","",1,"mat-elevation-z8",2,"width","450px !important",3,"dataSource"],["matColumnDef","email"],["mat-header-cell","",4,"matHeaderCellDef"],["mat-cell","",4,"matCellDef"],["matColumnDef","password"],["matColumnDef","profil"],["mat-header-row","",4,"matHeaderRowDef"],["mat-row","",4,"matRowDef","matRowDefColumns"],["mat-header-cell",""],["mat-cell",""],["mat-header-row",""],["mat-row",""]],template:function(t,e){1&t&&(u.TgZ(0,"div",0),u.TgZ(1,"mat-card",1),u.TgZ(2,"form",2),u.NdJ("ngSubmit",function(){return e.submit(e.myForm)}),u.TgZ(3,"mat-card-content"),u.TgZ(4,"div",3),u._UZ(5,"img",4),u.qZA(),u.TgZ(6,"p",5),u._uU(7),u.ALo(8,"translate"),u.qZA(),u.TgZ(9,"div",6),u.TgZ(10,"mat-form-field",7),u.TgZ(11,"mat-label",8),u._uU(12),u.ALo(13,"translate"),u.qZA(),u._UZ(14,"input",9),u.YNc(15,_,3,3,"mat-error",10),u.qZA(),u.TgZ(16,"mat-form-field",7),u.TgZ(17,"mat-label"),u._uU(18),u.ALo(19,"translate"),u.qZA(),u._UZ(20,"input",11),u.TgZ(21,"mat-icon",12),u.NdJ("click",function(){return e.hide=!e.hide}),u._uU(22),u.qZA(),u.qZA(),u._UZ(23,"br"),u.TgZ(24,"button",13),u._uU(25),u.ALo(26,"translate"),u.qZA(),u._UZ(27,"br"),u.TgZ(28,"button",14),u.TgZ(29,"mat-icon"),u._uU(30,"home"),u.qZA(),u.qZA(),u.qZA(),u.qZA(),u.qZA(),u._UZ(31,"div",15),u._UZ(32,"mat-card-actions"),u.qZA(),u.TgZ(33,"div",16),u.TgZ(34,"mat-form-field"),u.TgZ(35,"mat-label"),u._uU(36),u.ALo(37,"translate"),u.qZA(),u.TgZ(38,"mat-select",17),u.NdJ("selectionChange",function(t){return e.mytranslate.changeLanguage(t.value)}),u.TgZ(39,"mat-option",18),u._uU(40),u.ALo(41,"async"),u.qZA(),u.TgZ(42,"mat-option",19),u._uU(43),u.ALo(44,"async"),u.qZA(),u.qZA(),u.qZA(),u.qZA(),u.YNc(45,J,12,3,"table",20),u.qZA()),2&t&&(u.xp6(2),u.Q6J("formGroup",e.myForm),u.xp6(5),u.Oqu(u.lcZ(8,13,"admin.home.Syst\xe8medeSuividesrecommandations")),u.xp6(5),u.Oqu(u.lcZ(13,15,"admin.auth.Email")),u.xp6(3),u.Q6J("ngIf",e.myForm.get("email").invalid),u.xp6(3),u.Oqu(u.lcZ(19,17,"admin.auth.Motdepasse")),u.xp6(2),u.Q6J("type",e.hide?"password":"text"),u.xp6(2),u.Oqu(e.hide?"visibility_off":"visibility"),u.xp6(3),u.Oqu(u.lcZ(26,19,"admin.auth.Connexion")),u.xp6(3),u.Q6J("routerLink",u.DdM(27,F)),u.xp6(8),u.Oqu(u.lcZ(37,21,"admin.auth.Choisirunlangue")),u.xp6(4),u.Oqu("fr"===u.lcZ(41,23,e.mytranslate.lang)?"Fran\xe7ais":"\u0641\u0631\u0646\u0633\u064a"),u.xp6(3),u.Oqu("fr"===u.lcZ(44,25,e.mytranslate.lang)?"Arabe":"\u0639\u0631\u0628\u064a"),u.xp6(2),u.Q6J("ngIf",e.isDev))},directives:[g.a8,m._Y,m.JL,m.sg,g.dn,Z.KE,Z.hX,y.Nt,m.Fj,m.JJ,m.u,o.O5,v.Hw,Z.R9,w.lW,r.rH,g.hq,x.gD,q.ey,Z.TO,A.BZ,A.w1,A.fO,A.Dz,A.as,A.nj,A.ge,A.ev,A.XQ,A.Gk],pipes:[b.X$,o.Ov],styles:[".flex-container[_ngcontent-%COMP%]{padding:0;margin:0;display:flex;align-items:center;justify-content:center;height:100vh;flex-direction:column}.flex-item[_ngcontent-%COMP%]{background-color:#fff;height:auto;width:450px;min-width:200px;line-height:20px;font-weight:700;font-size:2em;text-align:center;margin:15px;display:inline-block;border-radius:0}.example-container[_ngcontent-%COMP%]{display:flex;flex-direction:column}.img1[_ngcontent-%COMP%]{background-position:50%;background-repeat:no-repeat;background-size:cover;height:100%}.mat-cell[_ngcontent-%COMP%]:last-child, .mat-header-cell[_ngcontent-%COMP%]:last-child{width:auto!important;padding-right:0!important}.logo[_ngcontent-%COMP%]{display:flex;justify-content:center;align-items:center}.logo[_ngcontent-%COMP%]   img[_ngcontent-%COMP%]{width:100%}.systeme[_ngcontent-%COMP%]{font-weight:700;margin:25px 0 50px;line-height:30px}"]}),M),data:{state:"login"}}]}],I=function(){var e=function e(){t(this,e)};return e.\u0275fac=function(t){return new(t||e)},e.\u0275mod=u.oAB({type:e}),e.\u0275inj=u.cJS({imports:[[r.Bz.forChild(P)],r.Bz]}),e}(),L=a(57823),j=a(42693),Q=((S=function e(){t(this,e)}).\u0275fac=function(t){return new(t||S)},S.\u0275mod=u.oAB({type:S}),S.\u0275inj=u.cJS({imports:[[o.ez,I,L.R,j.JF,m.u5,m.UX,L.R,b.aw]]}),S)}}])}();