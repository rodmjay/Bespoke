import{a as U}from"./chunk-SMJIQ4E4.js";import{c as H}from"./chunk-TI2YGS5M.js";import{Aa as q,Da as P,sa as G,ta as w}from"./chunk-ZHGKNXMS.js";import{Cb as L,Db as O,Fb as y,Gb as A,Jc as N,Kb as k,Lb as B,Mb as d,Nb as u,Oc as j,P as $,Pa as s,Pc as R,Q as v,R as C,Uc as z,W as _,Yb as D,_b as Q,aa as r,ab as S,ba as c,bb as V,ea as b,eb as M,gb as m,ka as T,nb as g,ob as a,rb as F,sb as E,sc as p,tb as I,tc as x,xb as h,yb as f}from"./chunk-DKCBYRU7.js";var Y=["handle"],Z=["input"],ee=e=>({checked:e});function te(e,K){e&1&&L(0)}function ie(e,K){if(e&1&&m(0,te,1,0,"ng-container",4),e&2){let i=A();a("ngTemplateOutlet",i.handleTemplate||i._handleTemplate)("ngTemplateOutletContext",Q(2,ee,i.checked()))}}var oe=({dt:e})=>`
.p-toggleswitch {
    display: inline-block;
    width: ${e("toggleswitch.width")};
    height: ${e("toggleswitch.height")};
}

.p-toggleswitch-input {
    cursor: pointer;
    appearance: none;
    position: absolute;
    top: 0;
    inset-inline-start: 0;
    width: 100%;
    height: 100%;
    padding: 0;
    margin: 0;
    opacity: 0;
    z-index: 1;
    outline: 0 none;
    border-radius: ${e("toggleswitch.border.radius")};
}

.p-toggleswitch-slider {
    display: inline-block;
    cursor: pointer;
    width: 100%;
    height: 100%;
    border-width: ${e("toggleswitch.border.width")};
    border-style: solid;
    border-color: ${e("toggleswitch.border.color")};
    background: ${e("toggleswitch.background")};
    transition: background ${e("toggleswitch.transition.duration")}, color ${e("toggleswitch.transition.duration")}, border-color ${e("toggleswitch.transition.duration")}, outline-color ${e("toggleswitch.transition.duration")}, box-shadow ${e("toggleswitch.transition.duration")};
    border-radius: ${e("toggleswitch.border.radius")};
    outline-color: transparent;
    box-shadow: ${e("toggleswitch.shadow")};
}

.p-toggleswitch-handle {
    position: absolute;
    top: 50%;
    display: flex;
    justify-content: center;
    align-items: center;
    background: ${e("toggleswitch.handle.background")};
    color: ${e("toggleswitch.handle.color")};
    width: ${e("toggleswitch.handle.size")};
    height: ${e("toggleswitch.handle.size")};
    inset-inline-start: ${e("toggleswitch.gap")};
    margin-block-start: calc(-1 * calc(${e("toggleswitch.handle.size")} / 2));
    border-radius: ${e("toggleswitch.handle.border.radius")};
    transition: background ${e("toggleswitch.transition.duration")}, color ${e("toggleswitch.transition.duration")}, inset-inline-start ${e("toggleswitch.slide.duration")}, box-shadow ${e("toggleswitch.slide.duration")};
}

.p-toggleswitch.p-toggleswitch-checked .p-toggleswitch-slider {
    background: ${e("toggleswitch.checked.background")};
    border-color: ${e("toggleswitch.checked.border.color")};
}

.p-toggleswitch.p-toggleswitch-checked .p-toggleswitch-handle {
    background: ${e("toggleswitch.handle.checked.background")};
    color: ${e("toggleswitch.handle.checked.color")};
    inset-inline-start: calc(${e("toggleswitch.width")} - calc(${e("toggleswitch.handle.size")} + ${e("toggleswitch.gap")}));
}

.p-toggleswitch:not(.p-disabled):has(.p-toggleswitch-input:hover) .p-toggleswitch-slider {
    background: ${e("toggleswitch.hover.background")};
    border-color: ${e("toggleswitch.hover.border.color")};
}

.p-toggleswitch:not(.p-disabled):has(.p-toggleswitch-input:hover) .p-toggleswitch-handle {
    background: ${e("toggleswitch.handle.hover.background")};
    color: ${e("toggleswitch.handle.hover.color")};
}

.p-toggleswitch:not(.p-disabled):has(.p-toggleswitch-input:hover).p-toggleswitch-checked .p-toggleswitch-slider {
    background: ${e("toggleswitch.checked.hover.background")};
    border-color: ${e("toggleswitch.checked.hover.border.color")};
}

.p-toggleswitch:not(.p-disabled):has(.p-toggleswitch-input:hover).p-toggleswitch-checked .p-toggleswitch-handle {
    background: ${e("toggleswitch.handle.checked.hover.background")};
    color: ${e("toggleswitch.handle.checked.hover.color")};
}

.p-toggleswitch:not(.p-disabled):has(.p-toggleswitch-input:focus-visible) .p-toggleswitch-slider {
    box-shadow: ${e("toggleswitch.focus.ring.shadow")};
    outline: ${e("toggleswitch.focus.ring.width")} ${e("toggleswitch.focus.ring.style")} ${e("toggleswitch.focus.ring.color")};
    outline-offset: ${e("toggleswitch.focus.ring.offset")};
}

.p-toggleswitch.p-invalid > .p-toggleswitch-slider {
    border-color: ${e("toggleswitch.invalid.border.color")};
}

.p-toggleswitch.p-disabled {
    opacity: 1;
}

.p-toggleswitch.p-disabled .p-toggleswitch-slider {
    background: ${e("toggleswitch.disabled.background")};
}

.p-toggleswitch.p-disabled .p-toggleswitch-handle {
    background: ${e("toggleswitch.handle.disabled.background")};
}

/* For PrimeNG */

p-toggleswitch.ng-invalid.ng-dirty > .p-toggleswitch > .p-toggleswitch-slider {
    border-color: ${e("toggleswitch.invalid.border.color")};
}`,le={root:{position:"relative"}},ne={root:({instance:e})=>({"p-toggleswitch p-component":!0,"p-toggleswitch-checked":e.checked(),"p-disabled":e.disabled,"p-invalid":e.invalid}),input:"p-toggleswitch-input",slider:"p-toggleswitch-slider",handle:"p-toggleswitch-handle"},W=(()=>{class e extends q{name="toggleswitch";theme=oe;classes=ne;inlineStyles=le;static \u0275fac=(()=>{let i;return function(t){return(i||(i=b(e)))(t||e)}})();static \u0275prov=v({token:e,factory:e.\u0275fac})}return e})();var ae={provide:U,useExisting:$(()=>J),multi:!0},J=(()=>{class e extends P{style;styleClass;tabindex;inputId;name;disabled;readonly;trueValue=!0;falseValue=!1;ariaLabel;ariaLabelledBy;autofocus;onChange=new T;input;handleTemplate;_handleTemplate;modelValue=!1;focused=!1;onModelChange=()=>{};onModelTouched=()=>{};_componentStyle=_(W);templates;ngAfterContentInit(){this.templates.forEach(i=>{switch(i.getType()){case"handle":this._handleTemplate=i.template;break;default:this._handleTemplate=i.template;break}})}onClick(i){!this.disabled&&!this.readonly&&(this.modelValue=this.checked()?this.falseValue:this.trueValue,this.onModelChange(this.modelValue),this.onChange.emit({originalEvent:i,checked:this.modelValue}),this.input.nativeElement.focus())}onFocus(){this.focused=!0}onBlur(){this.focused=!1,this.onModelTouched()}writeValue(i){this.modelValue=i,this.cd.markForCheck()}registerOnChange(i){this.onModelChange=i}registerOnTouched(i){this.onModelTouched=i}setDisabledState(i){this.disabled=i,this.cd.markForCheck()}checked(){return this.modelValue===this.trueValue}static \u0275fac=(()=>{let i;return function(t){return(i||(i=b(e)))(t||e)}})();static \u0275cmp=S({type:e,selectors:[["p-toggleswitch"],["p-toggleSwitch"],["p-toggle-switch"]],contentQueries:function(o,t,l){if(o&1&&(k(l,Y,4),k(l,G,4)),o&2){let n;d(n=u())&&(t.handleTemplate=n.first),d(n=u())&&(t.templates=n)}},viewQuery:function(o,t){if(o&1&&B(Z,5),o&2){let l;d(l=u())&&(t.input=l.first)}},inputs:{style:"style",styleClass:"styleClass",tabindex:[2,"tabindex","tabindex",x],inputId:"inputId",name:"name",disabled:[2,"disabled","disabled",p],readonly:[2,"readonly","readonly",p],trueValue:"trueValue",falseValue:"falseValue",ariaLabel:"ariaLabel",ariaLabelledBy:"ariaLabelledBy",autofocus:[2,"autofocus","autofocus",p]},outputs:{onChange:"onChange"},features:[D([ae,W]),M],decls:6,vars:23,consts:[["input",""],[3,"click","ngClass","ngStyle"],["type","checkbox","role","switch",3,"focus","blur","ngClass","checked","disabled","pAutoFocus"],[3,"ngClass"],[4,"ngTemplateOutlet","ngTemplateOutletContext"]],template:function(o,t){if(o&1){let l=O();h(0,"div",1),y("click",function(X){return r(l),c(t.onClick(X))}),h(1,"input",2,0),y("focus",function(){return r(l),c(t.onFocus())})("blur",function(){return r(l),c(t.onBlur())}),f(),h(3,"span",3)(4,"div",3),m(5,ie,1,4,"ng-container"),f()()()}o&2&&(F(t.sx("root")),E(t.styleClass),a("ngClass",t.cx("root"))("ngStyle",t.style),g("data-pc-name","toggleswitch")("data-pc-section","root"),s(),a("ngClass",t.cx("input"))("checked",t.checked())("disabled",t.disabled)("pAutoFocus",t.autofocus),g("id",t.inputId)("aria-checked",t.checked())("aria-labelledby",t.ariaLabelledBy)("aria-label",t.ariaLabel)("name",t.name)("tabindex",t.tabindex)("data-pc-section","hiddenInput"),s(2),a("ngClass",t.cx("slider")),g("data-pc-section","slider"),s(),a("ngClass",t.cx("handle")),s(),I(t.handleTemplate||t._handleTemplate?5:-1))},dependencies:[z,N,R,j,H,w],encapsulation:2,changeDetection:0})}return e})(),Se=(()=>{class e{static \u0275fac=function(o){return new(o||e)};static \u0275mod=V({type:e});static \u0275inj=C({imports:[J,w,w]})}return e})();export{J as a,Se as b};
