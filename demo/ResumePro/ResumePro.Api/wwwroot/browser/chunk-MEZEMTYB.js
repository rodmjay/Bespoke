import{g as y}from"./chunk-SMJIQ4E4.js";import{Aa as m,Da as $,T as b}from"./chunk-ZHGKNXMS.js";import{Fb as x,Q as r,R as p,Ua as d,W as u,Yb as v,bb as s,cb as c,ea as a,eb as f,qb as g,sc as h}from"./chunk-DKCBYRU7.js";var z=({dt:t})=>`
.p-inputtext {
    font-family: inherit;
    font-feature-settings: inherit;
    font-size: 1rem;
    color: ${t("inputtext.color")};
    background: ${t("inputtext.background")};
    padding-block: ${t("inputtext.padding.y")};
    padding-inline: ${t("inputtext.padding.x")};
    border: 1px solid ${t("inputtext.border.color")};
    transition: background ${t("inputtext.transition.duration")}, color ${t("inputtext.transition.duration")}, border-color ${t("inputtext.transition.duration")}, outline-color ${t("inputtext.transition.duration")}, box-shadow ${t("inputtext.transition.duration")};
    appearance: none;
    border-radius: ${t("inputtext.border.radius")};
    outline-color: transparent;
    box-shadow: ${t("inputtext.shadow")};
}

.p-inputtext.ng-invalid.ng-dirty {
    border-color: ${t("inputtext.invalid.border.color")};
}

.p-inputtext:enabled:hover {
    border-color: ${t("inputtext.hover.border.color")};
}

.p-inputtext:enabled:focus {
    border-color: ${t("inputtext.focus.border.color")};
    box-shadow: ${t("inputtext.focus.ring.shadow")};
    outline: ${t("inputtext.focus.ring.width")} ${t("inputtext.focus.ring.style")} ${t("inputtext.focus.ring.color")};
    outline-offset: ${t("inputtext.focus.ring.offset")};
}

.p-inputtext.p-invalid {
    border-color: ${t("inputtext.invalid.border.color")};
}

.p-inputtext.p-variant-filled {
    background: ${t("inputtext.filled.background")};
}
    
.p-inputtext.p-variant-filled:enabled:hover {
    background: ${t("inputtext.filled.hover.background")};
}

.p-inputtext.p-variant-filled:enabled:focus {
    background: ${t("inputtext.filled.focus.background")};
}

.p-inputtext:disabled {
    opacity: 1;
    background: ${t("inputtext.disabled.background")};
    color: ${t("inputtext.disabled.color")};
}

.p-inputtext::placeholder {
    color: ${t("inputtext.placeholder.color")};
}

.p-inputtext.ng-invalid.ng-dirty::placeholder {
    color: ${t("inputtext.invalid.placeholder.color")};
}

.p-inputtext-sm {
    font-size: ${t("inputtext.sm.font.size")};
    padding-block: ${t("inputtext.sm.padding.y")};
    padding-inline: ${t("inputtext.sm.padding.x")};
}

.p-inputtext-lg {
    font-size: ${t("inputtext.lg.font.size")};
    padding-block: ${t("inputtext.lg.padding.y")};
    padding-inline: ${t("inputtext.lg.padding.x")};
}

.p-inputtext-fluid {
    width: 100%;
}
`,M={root:({instance:t,props:o})=>["p-inputtext p-component",{"p-filled":t.filled,"p-inputtext-sm":o.size==="small","p-inputtext-lg":o.size==="large","p-invalid":o.invalid,"p-variant-filled":o.variant==="filled","p-inputtext-fluid":o.fluid}]},k=(()=>{class t extends m{name="inputtext";theme=z;classes=M;static \u0275fac=(()=>{let n;return function(e){return(n||(n=a(t)))(e||t)}})();static \u0275prov=r({token:t,factory:t.\u0275fac})}return t})();var N=(()=>{class t extends ${ngModel;variant;fluid;pSize;filled;_componentStyle=u(k);get hasFluid(){let i=this.el.nativeElement.closest("p-fluid");return b(this.fluid)?!!i:this.fluid}constructor(n){super(),this.ngModel=n}ngAfterViewInit(){super.ngAfterViewInit(),this.updateFilledState(),this.cd.detectChanges()}ngDoCheck(){this.updateFilledState()}onInput(){this.updateFilledState()}updateFilledState(){this.filled=this.el.nativeElement.value&&this.el.nativeElement.value.length||this.ngModel&&this.ngModel.model}static \u0275fac=function(i){return new(i||t)(d(y,8))};static \u0275dir=c({type:t,selectors:[["","pInputText",""]],hostAttrs:[1,"p-inputtext","p-component"],hostVars:14,hostBindings:function(i,e){if(i&1&&x("input",function(I){return e.onInput(I)}),i&2){let l;g("p-filled",e.filled)("p-variant-filled",((l=e.variant)!==null&&l!==void 0?l:e.config.inputStyle()||e.config.inputVariant())==="filled")("p-inputtext-fluid",e.hasFluid)("p-inputtext-sm",e.pSize==="small")("p-inputfield-sm",e.pSize==="small")("p-inputtext-lg",e.pSize==="large")("p-inputfield-lg",e.pSize==="large")}},inputs:{variant:"variant",fluid:[2,"fluid","fluid",h],pSize:"pSize"},features:[v([k]),f]})}return t})(),P=(()=>{class t{static \u0275fac=function(i){return new(i||t)};static \u0275mod=s({type:t});static \u0275inj=p({})}return t})();export{N as a,P as b};
