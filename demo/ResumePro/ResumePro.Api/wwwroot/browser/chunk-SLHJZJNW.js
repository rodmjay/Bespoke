import{a as Q,c as G}from"./chunk-SMJIQ4E4.js";import{c as U}from"./chunk-TI2YGS5M.js";import{Aa as R,Da as T,ta as h}from"./chunk-ZHGKNXMS.js";import{Db as _,Fb as x,Jc as A,Lb as N,Mb as z,Nb as E,Oc as L,P as $,Pa as b,Q as f,R as w,Uc as O,W as u,Yb as S,aa as s,ab as F,ba as c,bb as I,cc as D,ea as m,eb as B,ga as C,ka as l,nb as d,ob as g,sb as M,sc as p,tc as j,xb as v,yb as y,zb as V}from"./chunk-DKCBYRU7.js";var H=["input"],J=(o,n,t,e,i)=>({"p-radiobutton p-component":!0,"p-radiobutton-checked":o,"p-disabled":n,"p-variant-filled":t,"p-radiobutton-sm p-inputfield-sm":e,"p-radiobutton-lg p-inputfield-lg":i}),K=({dt:o})=>`
.p-radiobutton {
    position: relative;
    display: inline-flex;
    user-select: none;
    vertical-align: bottom;
    width: ${o("radiobutton.width")};
    height: ${o("radiobutton.height")};
}

.p-radiobutton-input {
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
    border: 1px solid transparent;
    border-radius: 50%;
}

.p-radiobutton-box {
    display: flex;
    justify-content: center;
    align-items: center;
    border-radius: 50%;
    border: 1px solid ${o("radiobutton.border.color")};
    background: ${o("radiobutton.background")};
    width: ${o("radiobutton.width")};
    height: ${o("radiobutton.height")};
    transition: background ${o("radiobutton.transition.duration")}, color ${o("radiobutton.transition.duration")}, border-color ${o("radiobutton.transition.duration")}, box-shadow ${o("radiobutton.transition.duration")}, outline-color ${o("radiobutton.transition.duration")};
    outline-color: transparent;
    box-shadow: ${o("radiobutton.shadow")};
}

.p-radiobutton-icon {
    transition-duration: ${o("radiobutton.transition.duration")};
    background: transparent;
    font-size: ${o("radiobutton.icon.size")};
    width: ${o("radiobutton.icon.size")};
    height: ${o("radiobutton.icon.size")};
    border-radius: 50%;
    backface-visibility: hidden;
    transform: translateZ(0) scale(0.1);
}

.p-radiobutton:not(.p-disabled):has(.p-radiobutton-input:hover) .p-radiobutton-box {
    border-color: ${o("radiobutton.hover.border.color")};
}

.p-radiobutton-checked .p-radiobutton-box {
    border-color: ${o("radiobutton.checked.border.color")};
    background: ${o("radiobutton.checked.background")};
}

.p-radiobutton-checked .p-radiobutton-box .p-radiobutton-icon {
    background: ${o("radiobutton.icon.checked.color")};
    transform: translateZ(0) scale(1, 1);
    visibility: visible;
}

.p-radiobutton-checked:not(.p-disabled):has(.p-radiobutton-input:hover) .p-radiobutton-box {
    border-color: ${o("radiobutton.checked.hover.border.color")};
    background: ${o("radiobutton.checked.hover.background")};
}

.p-radiobutton:not(.p-disabled):has(.p-radiobutton-input:hover).p-radiobutton-checked .p-radiobutton-box .p-radiobutton-icon {
    background: ${o("radiobutton.icon.checked.hover.color")};
}

.p-radiobutton:not(.p-disabled):has(.p-radiobutton-input:focus-visible) .p-radiobutton-box {
    border-color: ${o("radiobutton.focus.border.color")};
    box-shadow: ${o("radiobutton.focus.ring.shadow")};
    outline: ${o("radiobutton.focus.ring.width")} ${o("radiobutton.focus.ring.style")} ${o("radiobutton.focus.ring.color")};
    outline-offset: ${o("radiobutton.focus.ring.offset")};
}

.p-radiobutton-checked:not(.p-disabled):has(.p-radiobutton-input:focus-visible) .p-radiobutton-box {
    border-color: ${o("radiobutton.checked.focus.border.color")};
}

p-radiobutton.ng-invalid.ng-dirty .p-radiobutton-box {
    border-color: ${o("radiobutton.invalid.border.color")};
}

.p-radiobutton.p-variant-filled .p-radiobutton-box {
    background: ${o("radiobutton.filled.background")};
}

.p-radiobutton.p-variant-filled.p-radiobutton-checked .p-radiobutton-box {
    background: ${o("radiobutton.checked.background")};
}

.p-radiobutton.p-variant-filled:not(.p-disabled):has(.p-radiobutton-input:hover).p-radiobutton-checked .p-radiobutton-box {
    background: ${o("radiobutton.checked.hover.background")};
}

.p-radiobutton.p-disabled {
    opacity: 1;
}

.p-radiobutton.p-disabled .p-radiobutton-box {
    background: ${o("radiobutton.disabled.background")};
    border-color: ${o("radiobutton.checked.disabled.border.color")};
}

.p-radiobutton-checked.p-disabled .p-radiobutton-box .p-radiobutton-icon {
    background: ${o("radiobutton.icon.disabled.color")};
}

.p-radiobutton-sm,
.p-radiobutton-sm .p-radiobutton-box {
    width: ${o("radiobutton.sm.width")};
    height: ${o("radiobutton.sm.height")};
}

.p-radiobutton-sm .p-radiobutton-icon {
    font-size: ${o("radiobutton.icon.sm.size")};
    width: ${o("radiobutton.icon.sm.size")};
    height: ${o("radiobutton.icon.sm.size")};
}

.p-radiobutton-lg,
.p-radiobutton-lg .p-radiobutton-box {
    width: ${o("radiobutton.lg.width")};
    height: ${o("radiobutton.lg.height")};
}

.p-radiobutton-lg .p-radiobutton-icon {
    font-size: ${o("radiobutton.icon.lg.size")};
    width: ${o("radiobutton.icon.lg.size")};
    height: ${o("radiobutton.icon.lg.size")};
}
`,W={root:({instance:o,props:n})=>["p-radiobutton p-component",{"p-radiobutton-checked":o.checked,"p-disabled":n.disabled,"p-invalid":n.invalid,"p-variant-filled":n.variant?n.variant==="filled":o.config.inputStyle==="filled"||o.config.inputVariant==="filled"}],box:"p-radiobutton-box",input:"p-radiobutton-input",icon:"p-radiobutton-icon"},Z=(()=>{class o extends R{name="radiobutton";theme=K;classes=W;static \u0275fac=(()=>{let t;return function(i){return(t||(t=m(o)))(i||o)}})();static \u0275prov=f({token:o,factory:o.\u0275fac})}return o})();var X={provide:Q,useExisting:$(()=>q),multi:!0},Y=(()=>{class o{accessors=[];add(t,e){this.accessors.push([t,e])}remove(t){this.accessors=this.accessors.filter(e=>e[1]!==t)}select(t){this.accessors.forEach(e=>{this.isSameGroup(e,t)&&e[1]!==t&&e[1].writeValue(t.value)})}isSameGroup(t,e){return t[0].control?t[0].control.root===e.control.control.root&&t[1].name===e.name:!1}static \u0275fac=function(e){return new(e||o)};static \u0275prov=f({token:o,factory:o.\u0275fac,providedIn:"root"})}return o})(),q=(()=>{class o extends T{value;formControlName;name;disabled;variant;size;tabindex;inputId;ariaLabelledBy;ariaLabel;style;styleClass;autofocus;binary;onClick=new l;onFocus=new l;onBlur=new l;inputViewChild;onModelChange=()=>{};onModelTouched=()=>{};checked;focused;control;_componentStyle=u(Z);injector=u(C);registry=u(Y);ngOnInit(){super.ngOnInit(),this.control=this.injector.get(G),this.checkName(),this.registry.add(this.control,this)}onChange(t){this.disabled||this.select(t)}select(t){this.disabled||(this.checked=!0,this.onModelChange(this.value),this.registry.select(this),this.onClick.emit({originalEvent:t,value:this.value}))}writeValue(t){this.binary?this.checked=!!t:this.checked=t==this.value,this.inputViewChild&&this.inputViewChild.nativeElement&&(this.inputViewChild.nativeElement.checked=this.checked),this.cd.markForCheck()}registerOnChange(t){this.onModelChange=t}registerOnTouched(t){this.onModelTouched=t}setDisabledState(t){this.disabled=t,this.cd.markForCheck()}onInputFocus(t){this.focused=!0,this.onFocus.emit(t)}onInputBlur(t){this.focused=!1,this.onModelTouched(),this.onBlur.emit(t)}focus(){this.inputViewChild.nativeElement.focus()}ngOnDestroy(){this.registry.remove(this),super.ngOnDestroy()}checkName(){this.name&&this.formControlName&&this.name!==this.formControlName&&this.throwNameError(),!this.name&&this.formControlName&&(this.name=this.formControlName)}throwNameError(){throw new Error(`
          If you define both a name and a formControlName attribute on your radio button, their values
          must match. Ex: <p-radioButton formControlName="food" name="food"></p-radioButton>
        `)}static \u0275fac=(()=>{let t;return function(i){return(t||(t=m(o)))(i||o)}})();static \u0275cmp=F({type:o,selectors:[["p-radioButton"],["p-radiobutton"],["p-radio-button"]],viewQuery:function(e,i){if(e&1&&N(H,5),e&2){let r;z(r=E())&&(i.inputViewChild=r.first)}},inputs:{value:"value",formControlName:"formControlName",name:"name",disabled:[2,"disabled","disabled",p],variant:"variant",size:"size",tabindex:[2,"tabindex","tabindex",j],inputId:"inputId",ariaLabelledBy:"ariaLabelledBy",ariaLabel:"ariaLabel",style:"style",styleClass:"styleClass",autofocus:[2,"autofocus","autofocus",p],binary:[2,"binary","binary",p]},outputs:{onClick:"onClick",onFocus:"onFocus",onBlur:"onBlur"},features:[S([X,Z]),B],decls:5,vars:24,consts:[["input",""],[3,"ngStyle","ngClass"],["type","radio",1,"p-radiobutton-input",3,"focus","blur","change","checked","disabled","value","pAutoFocus"],[1,"p-radiobutton-box"],[1,"p-radiobutton-icon"]],template:function(e,i){if(e&1){let r=_();v(0,"div",1)(1,"input",2,0),x("focus",function(a){return s(r),c(i.onInputFocus(a))})("blur",function(a){return s(r),c(i.onInputBlur(a))})("change",function(a){return s(r),c(i.onChange(a))}),y(),v(3,"div",3),V(4,"div",4),y()()}e&2&&(M(i.styleClass),g("ngStyle",i.style)("ngClass",D(18,J,i.checked,i.disabled,i.variant==="filled"||i.config.inputStyle()==="filled"||i.config.inputVariant()==="filled",i.size==="small",i.size==="large")),d("data-pc-name","radiobutton")("data-pc-section","root"),b(),g("checked",i.checked)("disabled",i.disabled)("value",i.value)("pAutoFocus",i.autofocus),d("id",i.inputId)("name",i.name)("aria-labelledby",i.ariaLabelledBy)("aria-label",i.ariaLabel)("tabindex",i.tabindex)("aria-checked",i.checked),b(2),d("data-pc-section","input"),b(),d("data-pc-section","icon"))},dependencies:[O,A,L,U,h],encapsulation:2,changeDetection:0})}return o})(),mo=(()=>{class o{static \u0275fac=function(e){return new(e||o)};static \u0275mod=I({type:o});static \u0275inj=w({imports:[q,h,h]})}return o})();export{q as a,mo as b};
