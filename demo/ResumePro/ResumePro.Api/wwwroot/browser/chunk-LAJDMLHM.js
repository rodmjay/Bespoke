import{Aa as I,Da as v,ta as h}from"./chunk-ZHGKNXMS.js";import{Hb as u,Ib as m,Q as s,R as c,Uc as y,W as r,Yb as g,ab as l,bb as a,ea as o,eb as f,qb as p,sb as d}from"./chunk-DKCBYRU7.js";var D=["*"],$=({dt:e})=>`
.p-iconfield {
    position: relative;
    display: block;
}

.p-inputicon {
    position: absolute;
    top: 50%;
    margin-top: calc(-1 * (${e("icon.size")} / 2));
    color: ${e("iconfield.icon.color")};
    line-height: 1;
}

.p-iconfield .p-inputicon:first-child {
    inset-inline-start: ${e("form.field.padding.x")};
}

.p-iconfield .p-inputicon:last-child {
    inset-inline-end: ${e("form.field.padding.x")};
}

.p-iconfield .p-inputtext:not(:first-child) {
    padding-inline-start: calc((${e("form.field.padding.x")} * 2) + ${e("icon.size")});
}

.p-iconfield .p-inputtext:not(:last-child) {
    padding-inline-end: calc((${e("form.field.padding.x")} * 2) + ${e("icon.size")});
}

.p-iconfield:has(.p-inputfield-sm) .p-inputicon {
    font-size: ${e("form.field.sm.font.size")};
    width: ${e("form.field.sm.font.size")};
    height: ${e("form.field.sm.font.size")};
    margin-top: calc(-1 * (${e("form.field.sm.font.size")} / 2));
}

.p-iconfield:has(.p-inputfield-lg) .p-inputicon {
    font-size: ${e("form.field.lg.font.size")};
    width: ${e("form.field.lg.font.size")};
    height: ${e("form.field.lg.font.size")};
    margin-top: calc(-1 * (${e("form.field.lg.font.size")} / 2));
}
`,j={root:"p-iconfield"},C=(()=>{class e extends I{name="iconfield";theme=$;classes=j;static \u0275fac=(()=>{let i;return function(n){return(i||(i=o(e)))(n||e)}})();static \u0275prov=s({token:e,factory:e.\u0275fac})}return e})();var B=(()=>{class e extends v{iconPosition="left";get _styleClass(){return this.styleClass}styleClass;_componentStyle=r(C);static \u0275fac=(()=>{let i;return function(n){return(i||(i=o(e)))(n||e)}})();static \u0275cmp=l({type:e,selectors:[["p-iconfield"],["p-iconField"],["p-icon-field"]],hostAttrs:[1,"p-iconfield"],hostVars:6,hostBindings:function(t,n){t&2&&(d(n._styleClass),p("p-iconfield-left",n.iconPosition==="left")("p-iconfield-right",n.iconPosition==="right"))},inputs:{iconPosition:"iconPosition",styleClass:"styleClass"},features:[g([C]),f],ngContentSelectors:D,decls:1,vars:0,template:function(t,n){t&1&&(u(),m(0))},dependencies:[y],encapsulation:2,changeDetection:0})}return e})(),q=(()=>{class e{static \u0275fac=function(t){return new(t||e)};static \u0275mod=a({type:e});static \u0275inj=c({imports:[B]})}return e})();var z=["*"],x={root:"p-inputicon"},F=(()=>{class e extends I{name="inputicon";classes=x;static \u0275fac=(()=>{let i;return function(n){return(i||(i=o(e)))(n||e)}})();static \u0275prov=s({token:e,factory:e.\u0275fac})}return e})(),P=(()=>{class e extends v{styleClass;get hostClasses(){return this.styleClass}_componentStyle=r(F);static \u0275fac=(()=>{let i;return function(n){return(i||(i=o(e)))(n||e)}})();static \u0275cmp=l({type:e,selectors:[["p-inputicon"],["p-inputIcon"]],hostVars:4,hostBindings:function(t,n){t&2&&(d(n.hostClasses),p("p-inputicon",!0))},inputs:{styleClass:"styleClass"},features:[g([F]),f],ngContentSelectors:z,decls:1,vars:0,template:function(t,n){t&1&&(u(),m(0))},dependencies:[y,h],encapsulation:2,changeDetection:0})}return e})(),ie=(()=>{class e{static \u0275fac=function(t){return new(t||e)};static \u0275mod=a({type:e});static \u0275inj=c({imports:[P,h,h]})}return e})();export{B as a,q as b,P as c,ie as d};
