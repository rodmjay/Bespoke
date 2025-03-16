import{Aa as w,Da as $,ta as r}from"./chunk-ZHGKNXMS.js";import{Hb as b,Ib as m,Q as e,R as u,Uc as y,W as a,Yb as h,ab as d,bb as l,ea as i,eb as s,nb as c,rb as g,sb as f}from"./chunk-DKCBYRU7.js";var x=["*"],M=({dt:p})=>`
.p-inputgroup,
.p-inputgroup .p-floatlabel,
.p-inputgroup .p-iftalabel {
    display: flex;
    align-items: stretch;
    width: 100%;
}

.p-inputgroup .p-inputtext,
.p-inputgroup .p-inputwrapper {
    flex: 1 1 auto;
    width: 1%;
}

.p-inputgroupaddon {
    display: flex;
    align-items: center;
    justify-content: center;
    padding: ${p("inputgroup.addon.padding")};
    background: ${p("inputgroup.addon.background")};
    color: ${p("inputgroup.addon.color")};
    border-block-start: 1px solid ${p("inputgroup.addon.border.color")};
    border-block-end: 1px solid ${p("inputgroup.addon.border.color")};
    min-width: ${p("inputgroup.addon.min.width")};
}

.p-inputgroupaddon:first-child,
.p-inputgroupaddon + .p-inputgroupaddon {
    border-inline-start: 1px solid ${p("inputgroup.addon.border.color")};
}

.p-inputgroupaddon:last-child {
    border-inline-end: 1px solid ${p("inputgroup.addon.border.color")};
}

.p-inputgroupaddon:has(.p-button) {
    padding: 0;
    overflow: hidden;
}

.p-inputgroupaddon .p-button {
    border-radius: 0;
}

.p-inputgroup > .p-component,
.p-inputgroup > .p-inputwrapper > .p-component,
.p-inputgroup:first-child > p-button > .p-button,
.p-inputgroup > .p-floatlabel > .p-component,
.p-inputgroup > .p-floatlabel > .p-inputwrapper > .p-component,
.p-inputgroup > .p-iftalabel > .p-component,
.p-inputgroup > .p-iftalabel > .p-inputwrapper > .p-component {
    border-radius: 0;
    margin: 0;
}

.p-inputgroupaddon:first-child,
.p-inputgroup > .p-component:first-child,
.p-inputgroup > .p-inputwrapper:first-child > .p-component,
.p-inputgroup > .p-floatlabel:first-child > .p-component,
.p-inputgroup > .p-floatlabel:first-child > .p-inputwrapper > .p-component,
.p-inputgroup > .p-iftalabel:first-child > .p-component,
.p-inputgroup > .p-iftalabel:first-child > .p-inputwrapper > .p-component {
    border-start-start-radius: ${p("inputgroup.addon.border.radius")};
    border-end-start-radius: ${p("inputgroup.addon.border.radius")};
}

.p-inputgroupaddon:last-child,
.p-inputgroup > .p-component:last-child,
.p-inputgroup > .p-inputwrapper:last-child > .p-component,
.p-inputgroup > .p-floatlabel:last-child > .p-component,
.p-inputgroup > .p-floatlabel:last-child > .p-inputwrapper > .p-component,
.p-inputgroup > .p-iftalabel:last-child > .p-component,
.p-inputgroup > .p-iftalabel:last-child > .p-inputwrapper > .p-component {
    border-start-end-radius: ${p("inputgroup.addon.border.radius")};
    border-end-end-radius: ${p("inputgroup.addon.border.radius")};
}

.p-inputgroup .p-component:focus,
.p-inputgroup .p-component.p-focus,
.p-inputgroup .p-inputwrapper-focus,
.p-inputgroup .p-component:focus ~ label,
.p-inputgroup .p-component.p-focus ~ label,
.p-inputgroup .p-inputwrapper-focus ~ label {
    z-index: 1;
}

.p-inputgroup > .p-button:not(.p-button-icon-only) {
    width: auto;
}

/*For PrimeNG*/

.p-inputgroup p-button:first-child, .p-inputgroup p-button:last-child {
    display: inline-flex;
}

.p-inputgroup:has(> p-button:first-child) .p-button{
    border-start-start-radius: ${p("inputgroup.addon.border.radius")};
    border-end-start-radius: ${p("inputgroup.addon.border.radius")};
}

.p-inputgroup:has(> p-button:last-child) .p-button {
    border-start-end-radius: ${p("inputgroup.addon.border.radius")};
    border-end-end-radius: ${p("inputgroup.addon.border.radius")};
}
`,I={root:({props:p})=>["p-inputgroup",{"p-inputgroup-fluid":p.fluid}]},v=(()=>{class p extends w{name="inputgroup";theme=M;classes=I;static \u0275fac=(()=>{let t;return function(n){return(t||(t=i(p)))(n||p)}})();static \u0275prov=e({token:p,factory:p.\u0275fac})}return p})();var F=(()=>{class p extends ${style;styleClass;_componentStyle=a(v);static \u0275fac=(()=>{let t;return function(n){return(t||(t=i(p)))(n||p)}})();static \u0275cmp=d({type:p,selectors:[["p-inputgroup"],["p-inputGroup"],["p-input-group"]],hostAttrs:[1,"p-inputgroup"],hostVars:5,hostBindings:function(o,n){o&2&&(c("data-pc-name","inputgroup"),g(n.style),f(n.styleClass))},inputs:{style:"style",styleClass:"styleClass"},features:[h([v]),s],ngContentSelectors:x,decls:1,vars:0,template:function(o,n){o&1&&(b(),m(0))},dependencies:[y,r],encapsulation:2})}return p})(),A=(()=>{class p{static \u0275fac=function(o){return new(o||p)};static \u0275mod=l({type:p});static \u0275inj=u({imports:[F,r,r]})}return p})();export{F as a,A as b};
