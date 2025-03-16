import{a as M,b as C}from"./chunk-CHR7JGIN.js";import"./chunk-IKWOIRYM.js";import"./chunk-JJQLEQOL.js";import"./chunk-BIL3QBLO.js";import"./chunk-MLPLYTXL.js";import"./chunk-DUGBXOMB.js";import"./chunk-YUUY53IN.js";import"./chunk-3BQEJCHT.js";import"./chunk-BODZH67C.js";import{e as B,f as w}from"./chunk-QXZQXA5D.js";import"./chunk-TI2YGS5M.js";import"./chunk-WCGJ44IN.js";import{Aa as D,Da as _}from"./chunk-ZHGKNXMS.js";import{Fb as d,Hb as h,Ib as x,Pa as p,Q as y,R as v,Rb as i,Uc as k,W as f,Yb as E,ab as s,bb as g,ea as c,eb as S,ob as l,xb as t,yb as e,zb as r}from"./chunk-DKCBYRU7.js";import"./chunk-GAL4ENT6.js";var T=["*"],G=({dt:n})=>`
.p-buttongroup .p-button {
    margin: 0;
}

.p-buttongroup .p-button:not(:last-child),
.p-buttongroup .p-button:not(:last-child):hover {
    border-right: 0 none;
}

.p-buttongroup .p-button:not(:first-of-type):not(:last-of-type) {
    border-radius: 0;
}

.p-buttongroup .p-button:first-of-type:not(:only-of-type) {
    border-start-end-radius: 0;
    border-end-end-radius: 0;
}

.p-buttongroup .p-button:last-of-type:not(:only-of-type) {
    border-start-start-radius: 0;
    border-end-start-radius: 0;
}

.p-buttongroup .p-button:focus {
    position: relative;
    z-index: 1;
}

.p-buttongroup {
    display:flex;
}

.p-buttongroup > .p-button {
    flex: 1;
}

/* For PrimeNG */

.p-buttongroup .p-button:focus,
.p-buttongroup p-button:focus .p-button,
.p-buttonset .p-button:focus,
.p-buttonset .p-button:focus,
.p-buttonset p-button:focus .p-button,
.p-buttonset .p-button:focus {
    position: relative;
    z-index: 1;
}

.p-buttongroup .p-button:not(:last-child),
.p-buttongroup .p-button:not(:last-child):hover,
.p-buttongroup p-button:not(:last-child) .p-button,
.p-buttongroup p-button:not(:last-child) .p-button:hover,
.p-buttonset .p-button:not(:last-child),
.p-buttonset .p-button:not(:last-child):hover,
.p-buttonset p-button:not(:last-child) .p-button,
.p-buttonset p-button:not(:last-child) .p-button:hover {
    border-right: 0 none;
}

.p-buttongroup .p-button:not(:first-of-type):not(:last-of-type),
.p-buttongroup p-button:not(:first-of-type):not(:last-of-type) .p-button,
.p-buttonset .p-button:not(:first-of-type):not(:last-of-type),
.p-buttonset p-button:not(:first-of-type):not(:last-of-type) .p-button {
    border-radius: 0;
}

.p-buttongroup .p-button:first-of-type:not(:only-of-type),
.p-buttongroup p-button:first-of-type:not(:only-of-type) .p-button,
.p-buttonset .p-button:first-of-type:not(:only-of-type),
.p-buttonset p-button:first-of-type:not(:only-of-type) .p-button {
    border-start-end-radius: 0;
    border-end-end-radius: 0;
}

.p-buttongroup .p-button:last-of-type:not(:only-of-type),
.p-buttongroup p-button:last-of-type:not(:only-of-type) .p-button,
.p-buttonset .p-button:last-of-type:not(:only-of-type),
.p-buttonset p-button:last-of-type:not(:only-of-type) .p-button {
    border-start-start-radius: 0;
    border-end-start-radius: 0;
}

p-button[iconpos='right'] spinnericon {
    order: 1;
}
`,j={root:"p-buttongroup p-component"},I=(()=>{class n extends D{name="buttongroup";theme=G;classes=j;static \u0275fac=(()=>{let a;return function(o){return(a||(a=c(n)))(o||n)}})();static \u0275prov=y({token:n,factory:n.\u0275fac})}return n})();var m=(()=>{class n extends _{_componentStyle=f(I);static \u0275fac=(()=>{let a;return function(o){return(a||(a=c(n)))(o||n)}})();static \u0275cmp=s({type:n,selectors:[["p-buttonGroup"],["p-buttongroup"],["p-button-group"]],features:[E([I]),S],ngContentSelectors:T,decls:2,vars:0,consts:[["role","group",1,"p-buttongroup","p-component"]],template:function(u,o){u&1&&(h(),t(0,"span",0),x(1),e())},dependencies:[k],encapsulation:2,changeDetection:0})}return n})(),F=(()=>{class n{static \u0275fac=function(u){return new(u||n)};static \u0275mod=g({type:n});static \u0275inj=v({imports:[m]})}return n})();var Y=(()=>{class n{items=[];loading=[!1,!1,!1,!1];ngOnInit(){this.items=[{label:"Update",icon:"pi pi-refresh"},{label:"Delete",icon:"pi pi-times"},{label:"Angular.io",icon:"pi pi-info",url:"http://angular.io"},{separator:!0},{label:"Setup",icon:"pi pi-cog"}]}load(a){this.loading[a]=!0,setTimeout(()=>this.loading[a]=!1,1e3)}static \u0275fac=function(u){return new(u||n)};static \u0275cmp=s({type:n,selectors:[["app-button-demo"]],decls:148,vars:13,consts:[[1,"flex","flex-col","md:flex-row","gap-8"],[1,"md:w-1/2"],[1,"card","flex","flex-col","gap-4"],[1,"font-semibold","text-xl"],[1,"flex","flex-wrap","gap-2"],["label","Submit"],["label","Disabled",3,"disabled"],["label","Link",1,"p-button-link"],["label","Primary"],["label","Secondary","severity","secondary"],["label","Success","severity","success"],["label","Info","severity","info"],["label","Warn","severity","warn"],["label","Help","severity","help"],["label","Danger","severity","danger"],["label","Contrast","severity","contrast"],["label","Primary","text",""],["label","Secondary","severity","secondary","text",""],["label","Success","severity","success","text",""],["label","Info","severity","info","text",""],["label","Warn","severity","warn","text",""],["label","Help","severity","help","text",""],["label","Danger","severity","danger","text",""],["label","Plain","text",""],["label","Primary","outlined",""],["label","Secondary","severity","secondary","outlined",""],["label","Success","severity","success","outlined",""],["label","Info","severity","info","outlined",""],["label","Warn","severity","warn","outlined",""],["label","Help","severity","help","outlined",""],["label","Danger","severity","danger","outlined",""],["label","Contrast","severity","contrast","outlined",""],["label","Save","icon","pi pi-check"],["label","Delete","icon","pi pi-trash"],["label","Cancel","icon","pi pi-times"],["label","Save",3,"model"],["label","Save","severity","secondary",3,"model"],["label","Save","severity","success",3,"model"],["label","Save","severity","info",3,"model"],["label","Save","severity","warn",3,"model"],["label","Save","severity","help",3,"model"],["label","Save","severity","danger",3,"model"],["label","Save","severity","contrast",3,"model"],["type","button"],["alt","logo","src","https://primefaces.org/cdn/primeng/images/logo.svg",2,"width","1.5rem"],["type","button","outlined","","severity","success"],[1,"text-bold"],["icon","pi pi-star-fill"],["label","Bookmark","icon","pi pi-bookmark"],["label","Bookmark","icon","pi pi-bookmark","iconPos","right"],["label","Primary","raised",""],["label","Secondary","severity","secondary","raised",""],["label","Success","severity","success","raised",""],["label","Info","severity","info","raised",""],["label","Warn","severity","warn","raised",""],["label","Help","severity","help","raised",""],["label","Danger","severity","danger","raised",""],["label","Contrast","severity","contrast","raised",""],["label","Primary","rounded",""],["label","Secondary","severity","secondary","rounded",""],["label","Success","severity","success","rounded",""],["label","Info","severity","info","rounded",""],["label","Warn","severity","warn","rounded",""],["label","Help","severity","help","rounded",""],["label","Danger","severity","danger","rounded",""],["label","Contrast","severity","contrast","rounded",""],["icon","pi pi-check","rounded",""],["icon","pi pi-bookmark","severity","secondary","rounded",""],["icon","pi pi-search","severity","success","rounded",""],["icon","pi pi-user","severity","info","rounded",""],["icon","pi pi-bell","severity","warn","rounded",""],["icon","pi pi-heart","severity","help","rounded",""],["icon","pi pi-times","severity","danger","rounded",""],["icon","pi pi-check","text","","raised","","rounded",""],["icon","pi pi-bookmark","severity","secondary","text","","raised","","rounded",""],["icon","pi pi-search","severity","success","text","","raised","","rounded",""],["icon","pi pi-user","severity","info","text","","raised","","rounded",""],["icon","pi pi-bell","severity","warn","text","","raised","","rounded",""],["icon","pi pi-heart","severity","help","text","","raised","","rounded",""],["icon","pi pi-times","severity","danger","text","","raised","","rounded",""],["icon","pi pi-check","rounded","","outlined",""],["icon","pi pi-bookmark","severity","secondary","rounded","","outlined",""],["icon","pi pi-search","severity","success","rounded","","outlined",""],["icon","pi pi-user","severity","info","rounded","","outlined",""],["icon","pi pi-bell","severity","warn","rounded","","outlined",""],["icon","pi pi-heart","severity","help","rounded","","outlined",""],["icon","pi pi-times","severity","danger","rounded","","outlined",""],["type","button","label","Search","icon","pi pi-search",3,"click","loading"],["type","button","label","Search","icon","pi pi-search","iconPos","right",3,"click","loading"],["type","button","styleClass","h-full","icon","pi pi-search",3,"click","loading"],["type","button","label","Search",3,"click","loading"]],template:function(u,o){u&1&&(t(0,"div",0)(1,"div",1)(2,"div",2)(3,"div",3),i(4,"Default"),e(),t(5,"div",4),r(6,"p-button",5)(7,"p-button",6)(8,"p-button",7),e()(),t(9,"div",2)(10,"div",3),i(11,"Severities"),e(),t(12,"div",4),r(13,"p-button",8)(14,"p-button",9)(15,"p-button",10)(16,"p-button",11)(17,"p-button",12)(18,"p-button",13)(19,"p-button",14)(20,"p-button",15),e()(),t(21,"div",2)(22,"div",3),i(23,"Text"),e(),t(24,"div",4),r(25,"p-button",16)(26,"p-button",17)(27,"p-button",18)(28,"p-button",19)(29,"p-button",20)(30,"p-button",21)(31,"p-button",22)(32,"p-button",23),e()(),t(33,"div",2)(34,"div",3),i(35,"Outlined"),e(),t(36,"div",4),r(37,"p-button",24)(38,"p-button",25)(39,"p-button",26)(40,"p-button",27)(41,"p-button",28)(42,"p-button",29)(43,"p-button",30)(44,"p-button",31),e()(),t(45,"div",2)(46,"div",3),i(47,"Group"),e(),t(48,"div",4)(49,"p-buttongroup"),r(50,"p-button",32)(51,"p-button",33)(52,"p-button",34),e()()(),t(53,"div",2)(54,"div",3),i(55,"SplitButton"),e(),t(56,"div",4),r(57,"p-splitbutton",35)(58,"p-splitbutton",36)(59,"p-splitbutton",37)(60,"p-splitbutton",38)(61,"p-splitbutton",39)(62,"p-splitbutton",40)(63,"p-splitbutton",41)(64,"p-splitbutton",42),e()(),t(65,"div",2)(66,"div",3),i(67,"Templating"),e(),t(68,"div",4)(69,"p-button",43),r(70,"img",44),e(),t(71,"p-button",45),r(72,"img",44),t(73,"span",46),i(74,"PrimeNG"),e()()()()(),t(75,"div",1)(76,"div",2)(77,"div",3),i(78,"Icons"),e(),t(79,"div",4),r(80,"p-button",47)(81,"p-button",48)(82,"p-button",49),e()(),t(83,"div",2)(84,"div",3),i(85,"Raised"),e(),t(86,"div",4),r(87,"p-button",50)(88,"p-button",51)(89,"p-button",52)(90,"p-button",53)(91,"p-button",54)(92,"p-button",55)(93,"p-button",56)(94,"p-button",57),e()(),t(95,"div",2)(96,"div",3),i(97,"Rounded"),e(),t(98,"div",4),r(99,"p-button",58)(100,"p-button",59)(101,"p-button",60)(102,"p-button",61)(103,"p-button",62)(104,"p-button",63)(105,"p-button",64)(106,"p-button",65),e()(),t(107,"div",2)(108,"div",3),i(109,"Rounded Icons"),e(),t(110,"div",4),r(111,"p-button",66)(112,"p-button",67)(113,"p-button",68)(114,"p-button",69)(115,"p-button",70)(116,"p-button",71)(117,"p-button",72),e()(),t(118,"div",2)(119,"div",3),i(120,"Rounded Text"),e(),t(121,"div",4),r(122,"p-button",73)(123,"p-button",74)(124,"p-button",75)(125,"p-button",76)(126,"p-button",77)(127,"p-button",78)(128,"p-button",79),e()(),t(129,"div",2)(130,"div",3),i(131,"Rounded Outlined"),e(),t(132,"div",4),r(133,"p-button",80)(134,"p-button",81)(135,"p-button",82)(136,"p-button",83)(137,"p-button",84)(138,"p-button",85)(139,"p-button",86),e()(),t(140,"div",2)(141,"div",3),i(142,"Loading"),e(),t(143,"div",4)(144,"p-button",87),d("click",function(){return o.load(0)}),e(),t(145,"p-button",88),d("click",function(){return o.load(1)}),e(),t(146,"p-button",89),d("click",function(){return o.load(2)}),e(),t(147,"p-button",90),d("click",function(){return o.load(3)}),e()()()()()),u&2&&(p(7),l("disabled",!0),p(50),l("model",o.items),p(),l("model",o.items),p(),l("model",o.items),p(),l("model",o.items),p(),l("model",o.items),p(),l("model",o.items),p(),l("model",o.items),p(),l("model",o.items),p(80),l("loading",o.loading[0]),p(),l("loading",o.loading[1]),p(),l("loading",o.loading[2]),p(),l("loading",o.loading[3]))},dependencies:[w,B,F,m,C,M],encapsulation:2})}return n})();export{Y as ButtonDemo};
