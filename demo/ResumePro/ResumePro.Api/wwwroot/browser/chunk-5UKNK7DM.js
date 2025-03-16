import{Aa as q,Da as R,sa as A,ta as g}from"./chunk-ZHGKNXMS.js";import{$b as $,Cb as M,Gb as m,Jc as N,Kb as v,Lc as Q,Mb as y,Nb as h,Oc as V,Pa as a,Pc as O,Q as _,R as w,Rb as B,Ub as F,Uc as z,W as T,Yb as P,_b as D,ab as k,bb as x,ea as b,eb as S,gb as f,nb as s,ob as r,pb as c,sb as u,sc as j,tc as E,xb as l,yb as p,zb as I}from"./chunk-DKCBYRU7.js";var H=["content"],J=(e,o)=>({"p-progressbar p-component":!0,"p-progressbar-determinate":e,"p-progressbar-indeterminate":o}),K=e=>({$implicit:e});function L(e,o){if(e&1&&(l(0,"div"),B(1),p()),e&2){let t=m(2);c("display",t.value!=null&&t.value!==0?"flex":"none"),s("data-pc-section","label"),a(),F("",t.value,"",t.unit,"")}}function U(e,o){e&1&&M(0)}function W(e,o){if(e&1&&(l(0,"div",3)(1,"div",4),f(2,L,2,5,"div",5)(3,U,1,0,"ng-container",6),p()()),e&2){let t=m();u(t.valueStyleClass),c("width",t.value+"%")("background",t.color),r("ngClass","p-progressbar-value p-progressbar-value-animate"),s("data-pc-section","value"),a(2),r("ngIf",t.showValue&&!t.contentTemplate&&!t._contentTemplate),a(),r("ngTemplateOutlet",t.contentTemplate||t._contentTemplate)("ngTemplateOutletContext",D(11,K,t.value))}}function X(e,o){if(e&1&&(l(0,"div",7),I(1,"div",8),p()),e&2){let t=m();u(t.valueStyleClass),r("ngClass","p-progressbar-indeterminate-container"),s("data-pc-section","container"),a(),c("background",t.color),s("data-pc-section","value")}}var Y=({dt:e})=>`
.p-progressbar {
    position: relative;
    overflow: hidden;
    height: ${e("progressbar.height")};
    background: ${e("progressbar.background")};
    border-radius: ${e("progressbar.border.radius")};
}

.p-progressbar-value {
    margin: 0;
    background: ${e("progressbar.value.background")};
}

.p-progressbar-label {
    color: ${e("progressbar.label.color")};
    font-size: ${e("progressbar.label.font.size")};
    font-weight: ${e("progressbar.label.font.weight")};
}

.p-progressbar-determinate .p-progressbar-value {
    height: 100%;
    width: 0%;
    position: absolute;
    display: none;
    display: flex;
    align-items: center;
    justify-content: center;
    overflow: hidden;
    transition: width 1s ease-in-out;
}

.p-progressbar-determinate .p-progressbar-label {
    display: inline-flex;
}

.p-progressbar-indeterminate .p-progressbar-value::before {
    content: "";
    position: absolute;
    background: inherit;
    top: 0;
    inset-inline-start: 0;
    bottom: 0;
    will-change: inset-inline-start, inset-inline-end;
    animation: p-progressbar-indeterminate-anim 2.1s cubic-bezier(0.65, 0.815, 0.735, 0.395) infinite;
}

.p-progressbar-indeterminate .p-progressbar-value::after {
    content: "";
    position: absolute;
    background: inherit;
    top: 0;
    inset-inline-start: 0;
    bottom: 0;
    will-change: inset-inline-start, inset-inline-end;
    animation: p-progressbar-indeterminate-anim-short 2.1s cubic-bezier(0.165, 0.84, 0.44, 1) infinite;
    animation-delay: 1.15s;
}

@-webkit-keyframes p-progressbar-indeterminate-anim {
    0% {
        inset-inline-start: -35%;
        inset-inline-end: 100%;
    }
    60% {
        inset-inline-start: 100%;
        inset-inline-end: -90%;
    }
    100% {
        inset-inline-start: 100%;
        inset-inline-end: -90%;
    }
}
@keyframes p-progressbar-indeterminate-anim {
    0% {
        inset-inline-start: -35%;
        inset-inline-end: 100%;
    }
    60% {
        inset-inline-start: 100%;
        inset-inline-end: -90%;
    }
    100% {
        inset-inline-start: 100%;
        inset-inline-end: -90%;
    }
}
@-webkit-keyframes p-progressbar-indeterminate-anim-short {
    0% {
        inset-inline-start: -200%;
        inset-inline-end: 100%;
    }
    60% {
        inset-inline-start: 107%;
        inset-inline-end: -8%;
    }
    100% {
        inset-inline-start: 107%;
        inset-inline-end: -8%;
    }
}
@keyframes p-progressbar-indeterminate-anim-short {
    0% {
        inset-inline-start: -200%;
        inset-inline-end: 100%;
    }
    60% {
        inset-inline-start: 107%;
        inset-inline-end: -8%;
    }
    100% {
        inset-inline-start: 107%;
        inset-inline-end: -8%;
    }
}
`,Z={root:({instance:e})=>["p-progressbar p-component",{"p-progressbar-determinate":e.determinate,"p-progressbar-indeterminate":e.indeterminate}],value:"p-progressbar-value",label:"p-progressbar-label"},G=(()=>{class e extends q{name="progressbar";theme=Y;classes=Z;static \u0275fac=(()=>{let t;return function(n){return(t||(t=b(e)))(n||e)}})();static \u0275prov=_({token:e,factory:e.\u0275fac})}return e})();var ee=(()=>{class e extends R{value;showValue=!0;styleClass;valueStyleClass;style;unit="%";mode="determinate";color;contentTemplate;_componentStyle=T(G);templates;_contentTemplate;ngAfterContentInit(){this.templates?.forEach(t=>{switch(t.getType()){case"content":this._contentTemplate=t.template;break;default:this._contentTemplate=t.template}})}static \u0275fac=(()=>{let t;return function(n){return(t||(t=b(e)))(n||e)}})();static \u0275cmp=k({type:e,selectors:[["p-progressBar"],["p-progressbar"],["p-progress-bar"]],contentQueries:function(i,n,C){if(i&1&&(v(C,H,4),v(C,A,4)),i&2){let d;y(d=h())&&(n.contentTemplate=d.first),y(d=h())&&(n.templates=d)}},inputs:{value:[2,"value","value",E],showValue:[2,"showValue","showValue",j],styleClass:"styleClass",valueStyleClass:"valueStyleClass",style:"style",unit:"unit",mode:"mode",color:"color"},features:[P([G]),S],decls:3,vars:15,consts:[["role","progressbar",3,"ngStyle","ngClass"],["style","display:flex",3,"ngClass","class","width","background",4,"ngIf"],[3,"ngClass","class",4,"ngIf"],[2,"display","flex",3,"ngClass"],[1,"p-progressbar-label"],[3,"display",4,"ngIf"],[4,"ngTemplateOutlet","ngTemplateOutletContext"],[3,"ngClass"],[1,"p-progressbar-value","p-progressbar-value-animate"]],template:function(i,n){i&1&&(l(0,"div",0),f(1,W,4,13,"div",1)(2,X,2,7,"div",2),p()),i&2&&(u(n.styleClass),r("ngStyle",n.style)("ngClass",$(12,J,n.mode==="determinate",n.mode==="indeterminate")),s("aria-valuemin",0)("aria-valuenow",n.value)("aria-valuemax",100)("data-pc-name","progressbar")("data-pc-section","root")("aria-label",n.value+n.unit),a(),r("ngIf",n.mode==="determinate"),a(),r("ngIf",n.mode==="indeterminate"))},dependencies:[z,N,Q,O,V,g],encapsulation:2,changeDetection:0})}return e})(),fe=(()=>{class e{static \u0275fac=function(i){return new(i||e)};static \u0275mod=x({type:e});static \u0275inj=w({imports:[ee,g,g]})}return e})();export{ee as a,fe as b};
