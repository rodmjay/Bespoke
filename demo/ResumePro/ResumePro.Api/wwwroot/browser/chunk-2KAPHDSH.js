import{a as oe,b as ne}from"./chunk-Y6HZP4KD.js";import{a as ie,b as re}from"./chunk-UKFDZ5NH.js";import{a as H,b as J}from"./chunk-LWRNMYQW.js";import{a as ee,b as te}from"./chunk-6RLAFWZQ.js";import"./chunk-ZLFPCGC4.js";import"./chunk-5UKNK7DM.js";import"./chunk-PAEO5PSF.js";import"./chunk-THVSKX6G.js";import"./chunk-MLPLYTXL.js";import"./chunk-DUGBXOMB.js";import{c as X,d as Y}from"./chunk-RO6F6Z3R.js";import"./chunk-AGR62YLL.js";import"./chunk-LAJDMLHM.js";import{a as D,b as z}from"./chunk-MEZEMTYB.js";import{b as O,d as R,g as L,k as j}from"./chunk-SMJIQ4E4.js";import"./chunk-YUUY53IN.js";import"./chunk-3BQEJCHT.js";import{a as Z,b as $}from"./chunk-S4KTNRWB.js";import"./chunk-BDXJXXVS.js";import"./chunk-5ITMLF3G.js";import"./chunk-BODZH67C.js";import{c as K,d as q,f as G}from"./chunk-QXZQXA5D.js";import{g as A,h as Q}from"./chunk-TI2YGS5M.js";import"./chunk-WCGJ44IN.js";import"./chunk-ZHGKNXMS.js";import{Db as v,Fb as h,Gb as f,Kc as B,La as M,Lb as E,Lc as U,Mb as V,Nb as N,Pa as d,Qb as T,Rb as u,Sb as I,Uc as W,Vb as w,Wb as y,Xb as x,Zb as S,aa as p,ab as C,ba as c,gb as b,mc as F,ob as s,rb as k,sb as P,xb as r,yb as o,zb as _}from"./chunk-DKCBYRU7.js";import"./chunk-GAL4ENT6.js";var le=["buttonEl"],ae=()=>({height:"250px"}),de=()=>({cursor:"copy"}),pe=()=>({padding:"1px"}),ce=()=>({"border-radius":"20px"});function se(l,g){l&1&&(r(0,"div",38),_(1,"i",39),r(2,"span",40),u(3,"Drop or select a cover image"),o()())}function ue(l,g){if(l&1){let t=v();r(0,"div",43),h("mouseenter",function(){let e=p(t).$implicit,a=f(3);return c(a.onImageMouseOver(e))})("mouseleave",function(){let e=p(t).$implicit,a=f(3);return c(a.onImageMouseLeave(e))}),r(1,"div",44),_(2,"img",45),r(3,"button",46,2),h("click",function(e){let a=p(t).$implicit,m=f(3);return c(m.removeImage(e,a))}),_(5,"i",47),o()()()}if(l&2){let t=g.$implicit;d(),k(S(5,pe)),d(),s("src",t.objectURL,M)("alt",t.name),d(),s("id",t.name)}}function me(l,g){if(l&1&&(r(0,"div",41),b(1,ue,6,6,"div",42),o()),l&2){let t=f(2);k(S(3,de)),d(),s("ngForOf",t.product.images)}}function fe(l,g){if(l&1){let t=v();r(0,"div",35),h("click",function(){p(t),f();let e=T(18);return c(e.advancedFileInput.nativeElement.click())}),b(1,se,4,0,"div",36)(2,me,2,4,"div",37),o()}if(l&2){let t=f();d(),s("ngIf",!t.product.images.length),d(),s("ngIf",t.product.images.length)}}function ge(l,g){if(l&1){let t=v();r(0,"p-chip",48)(1,"span",49),u(2),o(),r(3,"span",50),h("click",function(){let e=p(t).$implicit,a=f();return c(a.onChipRemove(e))}),_(4,"i",51),o()()}if(l&2){let t=g.$implicit;k(S(3,ce)),d(2),I(t)}}function _e(l,g){l&1&&_(0,"i",54)}function we(l,g){if(l&1){let t=v();r(0,"div",52),h("click",function(){let e=p(t).$implicit,a=f();return c(a.onColorSelect(e.name))}),b(1,_e,1,0,"i",53),o()}if(l&2){let t=g.$implicit,n=f();P(t.background),d(),s("ngIf",n.product.colors.indexOf(t.name)!==-1)}}var De=(()=>{class l{buttonEl;text="";categoryOptions=["Sneakers","Apparel","Socks"];colorOptions=[{name:"Black",background:"bg-gray-900"},{name:"Orange",background:"bg-orange-500"},{name:"Navy",background:"bg-blue-500"}];product={name:"",price:"",code:"",sku:"",status:"Draft",tags:["Nike","Sneaker"],category:"Sneakers",colors:["Blue"],stock:"Sneakers",inStock:!0,description:"",images:[]};uploadedFiles=[];showRemove=!1;onChipRemove(t){this.product.tags=this.product.tags.filter(n=>n!==t)}onColorSelect(t){this.product.colors.indexOf(t)==-1?this.product.colors.push(t):this.product.colors.splice(this.product.colors.indexOf(t),1)}onUpload(t){for(let n of t.files)this.product.images.push(n)}onImageMouseOver(t){this.buttonEl.toArray().forEach(n=>{n.nativeElement.id===t.name&&(n.nativeElement.style.display="flex")})}onImageMouseLeave(t){this.buttonEl.toArray().forEach(n=>{n.nativeElement.id===t.name&&(n.nativeElement.style.display="none")})}removeImage(t,n){t.stopPropagation(),this.product.images=this.product.images.filter(e=>e!==n)}static \u0275fac=function(n){return new(n||l)};static \u0275cmp=C({type:l,selectors:[["app-new-product"]],viewQuery:function(n,e){if(n&1&&E(le,5),n&2){let a;V(a=N())&&(e.buttonEl=a)}},decls:54,vars:18,consts:[["fileUploader",""],["content",""],["buttonEl",""],[1,"card"],[1,"block","text-surface-900","dark:text-surface-0","font-bold","text-xl","mb-6"],[1,"grid","grid-cols-12","gap-4","flex-wrap"],[1,"col-span-12","lg:col-span-8"],[1,"grid","grid-cols-12","gap-4"],[1,"col-span-12"],["pInputText","","type","text","placeholder","Product Name","label","Product Name",3,"ngModelChange","ngModel"],[1,"col-span-12","lg:col-span-4"],["pInputText","","type","text","placeholder","Price","label","Price",3,"ngModelChange","ngModel"],["pInputText","","type","text","placeholder","Product Code","label","Product Code",3,"ngModelChange","ngModel"],["pInputText","","type","text","placeholder","Product SKU","label","SKU",3,"ngModelChange","ngModel"],[3,"ngModelChange","ngModel"],[1,"col-span-12","mt-4"],["name","demo[]","url","./upload.php","accept","image/*","styleClass","border border-surface-200 dark:border-surface-700 bg-surface-0 dark:bg-surface-900 p-0 rounded h-80",3,"onUpload","onSelect","customUpload","multiple","showUploadButton","showCancelButton","auto"],[1,"col-span-12","lg:col-span-4","flex","flex-col","gap-y-4"],[1,"border","border-surface-200","dark:border-surface-700","rounded"],[1,"text-surface-900","dark:text-surface-0","font-bold","block","border-b","border-surface-200","dark:border-surface-700","p-4"],[1,"p-4"],[1,"bg-surface-100","dark:bg-surface-700","py-2","px-4","flex","items-center","rounded"],[1,"text-black/90","dark:!text-surface-0","font-bold","mr-4"],[1,"text-black/60","dark:!text-surface-0","font-semibold"],["pButton","","pRipple","","type","button","icon","pi pi-fw pi-pencil","text","","rounded","",1,"ml-auto"],[1,"p-4","flex","flex-wrap","gap-1"],["styleClass","mr-2 py-2 px-4 text-surface-900 dark:text-surface-0 font-bold bg-surface-0 dark:bg-surface-900 border border-surface-200 dark:border-surface-700",3,"style",4,"ngFor","ngForOf"],["placeholder","Select a category",3,"ngModelChange","options","ngModel"],[1,"p-4","flex"],["class","w-8 h-8 mr-2 border border-surface-200 dark:border-surface-700 rounded-full cursor-pointer flex justify-center items-center",3,"class","click",4,"ngFor","ngForOf"],[1,"border","border-surface-200","dark:border-surface-700","flex","justify-between","items-center","px-4","rounded"],[1,"text-surface-900","dark:text-surface-0","font-bold","p-4"],[1,"flex","justify-between","gap-4"],["pButton","","pRipple","","severity","danger","outlined","","label","Discard","icon","pi pi-fw pi-trash"],["pButton","","pRipple","","label","Save","icon","pi pi-fw pi-check"],[1,"w-full","h-full","py-4",2,"cursor","copy",3,"click"],["class","h-full flex flex-col justify-center items-center",4,"ngIf"],["class","w-full py-4",3,"style",4,"ngIf"],[1,"h-full","flex","flex-col","justify-center","items-center"],[1,"pi","pi-file","text-primary","text-4xl","mb-4"],[1,"block","font-semibold","text-surface-900","dark:text-surface-0","text-lg"],[1,"w-full","py-4"],["class","flex flex-wrap gap-8","style","padding: 1px;",3,"mouseenter","mouseleave",4,"ngFor","ngForOf"],[1,"flex","flex-wrap","gap-8",2,"padding","1px",3,"mouseenter","mouseleave"],[1,"remove-file-wrapper","relative","w-full","h-60","border-4","border-transparent","rounded","hover:bg-primary","hover:text-primary-contrast","duration-100","cursor-auto"],[1,"w-full","h-full","rounded","shadow",3,"src","alt"],["pButton","","pRipple","","rounded","","type","button",1,"remove-button","text-sm","absolute","justify-center","items-center","cursor-pointer",2,"top","-10px","right","-10px","display","none",3,"click","id"],["pButtonIcon","",1,"pi","pi-times"],["styleClass","mr-2 py-2 px-4 text-surface-900 dark:text-surface-0 font-bold bg-surface-0 dark:bg-surface-900 border border-surface-200 dark:border-surface-700"],[1,"mr-4"],[1,"flex","w-4","h-4","items-center","justify-center","border","border-surface-200","dark:border-surface-700","bg-gray-100","rounded-full","cursor-pointer",3,"click"],[1,"pi","pi-fw","pi-times","text-black/60",2,"font-size","9px"],[1,"w-8","h-8","mr-2","border","border-surface-200","dark:border-surface-700","rounded-full","cursor-pointer","flex","justify-center","items-center",3,"click"],["class","pi pi-check text-sm text-white z-50",4,"ngIf"],[1,"pi","pi-check","text-sm","text-white","z-50"]],template:function(n,e){if(n&1){let a=v();r(0,"div",3)(1,"span",4),u(2,"Create Product"),o(),r(3,"p-fluid",5)(4,"div",6)(5,"div",7)(6,"div",8)(7,"input",9),x("ngModelChange",function(i){return p(a),y(e.product.name,i)||(e.product.name=i),c(i)}),o()(),r(8,"div",10)(9,"input",11),x("ngModelChange",function(i){return p(a),y(e.product.price,i)||(e.product.price=i),c(i)}),o()(),r(10,"div",10)(11,"input",12),x("ngModelChange",function(i){return p(a),y(e.product.code,i)||(e.product.code=i),c(i)}),o()(),r(12,"div",10)(13,"input",13),x("ngModelChange",function(i){return p(a),y(e.product.sku,i)||(e.product.sku=i),c(i)}),o()(),r(14,"div",8)(15,"p-editor",14),x("ngModelChange",function(i){return p(a),y(e.product.description,i)||(e.product.description=i),c(i)}),o()(),r(16,"div",15)(17,"p-fileUpload",16,0),h("onUpload",function(i){return p(a),c(e.onUpload(i))})("onSelect",function(i){return p(a),c(e.onUpload(i))}),b(19,fe,3,2,"ng-template",null,1,F),o()()()(),r(21,"div",17)(22,"div",18)(23,"span",19),u(24,"Publish"),o(),r(25,"div",20)(26,"div",21)(27,"span",22),u(28,"Status:"),o(),r(29,"span",23),u(30,"Draft"),o(),_(31,"button",24),o()()(),r(32,"div",18)(33,"span",19),u(34,"Tags"),o(),r(35,"div",25),b(36,ge,5,4,"p-chip",26),o()(),r(37,"div",18)(38,"span",19),u(39,"Category"),o(),r(40,"div",20)(41,"p-select",27),x("ngModelChange",function(i){return p(a),y(e.product.category,i)||(e.product.category=i),c(i)}),o()()(),r(42,"div",18)(43,"span",19),u(44,"Colors"),o(),r(45,"div",28),b(46,we,2,3,"div",29),o()(),r(47,"div",30)(48,"span",31),u(49,"In stock"),o(),r(50,"p-toggleswitch",14),x("ngModelChange",function(i){return p(a),y(e.product.inStock,i)||(e.product.inStock=i),c(i)}),o()(),r(51,"div",32),_(52,"button",33)(53,"button",34),o()()()()}n&2&&(d(7),w("ngModel",e.product.name),d(2),w("ngModel",e.product.price),d(2),w("ngModel",e.product.code),d(2),w("ngModel",e.product.sku),d(2),k(S(17,ae)),w("ngModel",e.product.description),d(2),s("customUpload",!0)("multiple",!0)("showUploadButton",!0)("showCancelButton",!1)("auto",!0),d(19),s("ngForOf",e.product.tags),d(5),s("options",e.categoryOptions),w("ngModel",e.product.category),d(5),s("ngForOf",e.colorOptions),d(4),w("ngModel",e.product.inStock))},dependencies:[W,B,U,ne,oe,z,D,j,O,R,L,te,ee,G,q,K,Y,X,J,H,Q,A,re,ie,$,Z],styles:["[_nghost-%COMP%]     .p-fileupload-header{display:none}[_nghost-%COMP%]     .p-fileupload-file-list{display:none}[_nghost-%COMP%]     .p-fileupload-content{height:20rem}"]})}return l})();export{De as NewProduct};
