import{a as q,b as G}from"./chunk-Y6HZP4KD.js";import{a as J}from"./chunk-RSYUMYAF.js";import{a as O,b as P}from"./chunk-COXNR3KN.js";import{b as j,d as T}from"./chunk-JJQLEQOL.js";import"./chunk-MLPLYTXL.js";import"./chunk-DUGBXOMB.js";import{d as L,g as z,k as A}from"./chunk-SMJIQ4E4.js";import{d as N,f as W}from"./chunk-QXZQXA5D.js";import{g as F,h as H}from"./chunk-TI2YGS5M.js";import{oa as V}from"./chunk-ZHGKNXMS.js";import{Db as C,Fb as v,Gb as s,Hc as D,Ka as _,L as M,Lc as E,Pa as o,Rb as c,Sb as b,Tb as h,Ua as l,Uc as R,Vb as S,Wb as k,Xb as I,Zb as B,aa as u,ab as y,ba as f,gb as g,ob as m,rb as w,xb as n,yb as r,zb as p}from"./chunk-DKCBYRU7.js";import"./chunk-GAL4ENT6.js";var X=()=>({height:"250px"});function Y(i,K){if(i&1&&p(0,"p-avatar",20),i&2){let e=s(2);m("image","/demo/images/avatar/"+e.mail.image)}}function Z(i,K){if(i&1){let e=C();n(0,"div")(1,"div",1)(2,"div",2)(3,"button",3),v("click",function(){u(e);let t=s();return f(t.goBack())}),r(),g(4,Y,1,1,"p-avatar",4),n(5,"div",5)(6,"span",6),c(7),r(),n(8,"span",7),c(9),r()()(),n(10,"div",8)(11,"span",9),c(12),r(),p(13,"button",10)(14,"button",11),r()(),n(15,"div",12)(16,"div",13),c(17),r(),p(18,"p",14),n(19,"p-editor",15),I("ngModelChange",function(t){u(e);let d=s();return k(d.newMail.message,t)||(d.newMail.message=t),f(t)}),r(),n(20,"div",16),p(21,"button",17)(22,"button",18),n(23,"button",19),v("click",function(){u(e);let t=s();return f(t.sendMail())}),r()()()()}if(i&2){let e=s();o(4),m("ngIf",e.mail&&e.mail.image),o(3),b(e.mail.from),o(2),h("To: ",e.mail.email||e.mail.to,""),o(3),b(e.mail.date),o(5),h(" ",e.mail.title," "),o(),m("innerHTML",e.mail.message,_),o(),w(B(9,X)),S("ngModel",e.newMail.message)}}var ge=(()=>{class i{route;mailService;location;router;messageService;newMail={id:"",to:"",email:"",image:"",title:"",message:"",date:"",important:!1,starred:!1,trash:!1,spam:!1,archived:!1,sent:!0};subscription;mail={};id;constructor(e,a,t,d,Q){this.route=e,this.mailService=a,this.location=t,this.router=d,this.messageService=Q,this.subscription=this.route.params.pipe(M(x=>(this.id=x.id,this.mailService.mails$))).subscribe(x=>{this.mail=x.filter(U=>U.id==this.id)[0]})}goBack(){this.location.back()}sendMail(){this.newMail.message&&(this.newMail.to=this.mail.from?this.mail.from:this.mail.to,this.newMail.image=this.mail.image,this.mailService.onSend(this.newMail),this.messageService.add({severity:"success",summary:"Success",detail:"Mail sent"}),this.router.navigate(["apps/mail/inbox"]))}ngOnDestroy(){this.subscription.unsubscribe()}static \u0275fac=function(a){return new(a||i)(l(j),l(J),l(D),l(T),l(V))};static \u0275cmp=y({type:i,selectors:[["ng-component"]],decls:1,vars:1,consts:[[4,"ngIf"],[1,"flex","flex-col","md:flex-row","md:items-center","md:justify-between","mb-8","pt-8","md:pt-0","gap-6","md:border-t-0","border-t","border-surface-200","dark:border-surface-700"],[1,"flex","items-center","md:justify-start"],["pButton","","pRipple","","type","button","icon","pi pi-chevron-left","text","","plain","",1,"md:mr-4",3,"click"],["size","large","shape","circle","styleClass","border-2 border-surface-200 dark:border-surface-700",3,"image",4,"ngIf"],[1,"flex","flex-col","mx-4"],[1,"block","text-surface-900","dark:text-surface-0","font-bold","text-lg"],[1,"block","text-surface-900","dark:text-surface-0","font-semibold"],[1,"flex","items-center","justify-end","gap-x-4","px-6","md:px-0"],[1,"text-surface-900","dark:text-surface-0","font-semibold","whitespace-nowrap","mr-auto"],["pButton","","pRipple","","type","button","icon","pi pi-reply","text","","plain","",1,"flex-shrink-0"],["pButton","","pRipple","","type","button","icon","pi pi-ellipsis-v","text","","plain","",1,"flex-shrink-0"],[1,"border-surface-200","dark:border-surface-700","border","rounded","p-6"],[1,"text-surface-900","dark:text-surface-0","font-semibold","text-lg","mb-4"],[1,"leading-normal","mt-0","mb-4",3,"innerHTML"],[3,"ngModelChange","ngModel"],[1,"flex","gap-x-4","justify-end","mt-4"],["pButton","","pRipple","","type","button","outlined","","icon","pi pi-image"],["pButton","","pRipple","","type","button","outlined","","icon","pi pi-paperclip"],["pButton","","pRipple","","type","button","icon","pi pi-send","label","Send",3,"click"],["size","large","shape","circle","styleClass","border-2 border-surface-200 dark:border-surface-700",3,"image"]],template:function(a,t){a&1&&g(0,Z,24,10,"div",0),a&2&&m("ngIf",t.mail)},dependencies:[P,O,W,N,H,F,R,E,G,q,A,L,z],encapsulation:2})}return i})();export{ge as MailDetailComponent};
