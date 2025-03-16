import{a as ie}from"./chunk-LAKTUHSI.js";import{a as ee,c as oe}from"./chunk-SMJIQ4E4.js";import{a as ce}from"./chunk-BDXJXXVS.js";import{Aa as Y,Da as Z,Y as X,Z as J,sa as W,ta as C}from"./chunk-ZHGKNXMS.js";import{$ as B,Ab as w,Bb as T,Db as L,Fb as Q,Gb as f,Jc as U,Kb as V,Lb as N,Lc as G,Mb as m,Nb as g,P as M,Pa as l,Pc as H,Q as F,R as S,Uc as K,W as z,Yb as j,Zb as A,_b as R,aa as u,ab as O,ba as p,bb as q,ea as y,eb as D,gb as d,ka as k,nb as s,ob as t,pa as E,rb as _,sb as v,sc as h,tc as P,xb as $,yb as I,zb as x}from"./chunk-DKCBYRU7.js";var ae=["checkboxicon"],re=["input"],le=()=>({"p-checkbox-input":!0}),he=e=>({checked:e,class:"p-checkbox-icon"});function se(e,a){if(e&1&&x(0,"span",8),e&2){let o=f(3);t("ngClass",o.checkboxIcon),s("data-pc-section","icon")}}function be(e,a){e&1&&x(0,"CheckIcon",9),e&2&&(t("styleClass","p-checkbox-icon"),s("data-pc-section","icon"))}function de(e,a){if(e&1&&(w(0),d(1,se,1,2,"span",7)(2,be,1,2,"CheckIcon",6),T()),e&2){let o=f(2);l(),t("ngIf",o.checkboxIcon),l(),t("ngIf",!o.checkboxIcon)}}function ue(e,a){e&1&&x(0,"MinusIcon",9),e&2&&(t("styleClass","p-checkbox-icon"),s("data-pc-section","icon"))}function pe(e,a){if(e&1&&(w(0),d(1,de,3,2,"ng-container",4)(2,ue,1,2,"MinusIcon",6),T()),e&2){let o=f();l(),t("ngIf",o.checked),l(),t("ngIf",o._indeterminate())}}function ke(e,a){}function xe(e,a){e&1&&d(0,ke,0,0,"ng-template")}var fe=({dt:e})=>`
.p-checkbox {
    position: relative;
    display: inline-flex;
    user-select: none;
    vertical-align: bottom;
    width: ${e("checkbox.width")};
    height: ${e("checkbox.height")};
}

.p-checkbox-input {
    cursor: pointer;
    appearance: none;
    position: absolute;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%;
    padding: 0;
    margin: 0;
    opacity: 0;
    z-index: 1;
    outline: 0 none;
    border: 1px solid transparent;
    border-radius: ${e("checkbox.border.radius")};
}

.p-checkbox-box {
    display: flex;
    justify-content: center;
    align-items: center;
    border-radius: ${e("checkbox.border.radius")};
    border: 1px solid ${e("checkbox.border.color")};
    background: ${e("checkbox.background")};
    width: ${e("checkbox.width")};
    height: ${e("checkbox.height")};
    transition: background ${e("checkbox.transition.duration")}, color ${e("checkbox.transition.duration")}, border-color ${e("checkbox.transition.duration")}, box-shadow ${e("checkbox.transition.duration")}, outline-color ${e("checkbox.transition.duration")};
    outline-color: transparent;
    box-shadow: ${e("checkbox.shadow")};
}

.p-checkbox-icon {
    transition-duration: ${e("checkbox.transition.duration")};
    color: ${e("checkbox.icon.color")};
    font-size: ${e("checkbox.icon.size")};
    width: ${e("checkbox.icon.size")};
    height: ${e("checkbox.icon.size")};
}

.p-checkbox:not(.p-disabled):has(.p-checkbox-input:hover) .p-checkbox-box {
    border-color: ${e("checkbox.hover.border.color")};
}

.p-checkbox-checked .p-checkbox-box {
    border-color: ${e("checkbox.checked.border.color")};
    background: ${e("checkbox.checked.background")};
}

.p-checkbox-checked .p-checkbox-icon {
    color: ${e("checkbox.icon.checked.color")};
}

.p-checkbox-checked:not(.p-disabled):has(.p-checkbox-input:hover) .p-checkbox-box {
    background: ${e("checkbox.checked.hover.background")};
    border-color: ${e("checkbox.checked.hover.border.color")};
}

.p-checkbox-checked:not(.p-disabled):has(.p-checkbox-input:hover) .p-checkbox-icon {
    color: ${e("checkbox.icon.checked.hover.color")};
}

.p-checkbox:not(.p-disabled):has(.p-checkbox-input:focus-visible) .p-checkbox-box {
    border-color: ${e("checkbox.focus.border.color")};
    box-shadow: ${e("checkbox.focus.ring.shadow")};
    outline: ${e("checkbox.focus.ring.width")} ${e("checkbox.focus.ring.style")} ${e("checkbox.focus.ring.color")};
    outline-offset: ${e("checkbox.focus.ring.offset")};
}

.p-checkbox-checked:not(.p-disabled):has(.p-checkbox-input:focus-visible) .p-checkbox-box {
    border-color: ${e("checkbox.checked.focus.border.color")};
}

p-checkbox.ng-invalid.ng-dirty .p-checkbox-box {
    border-color: ${e("checkbox.invalid.border.color")};
}

.p-checkbox.p-variant-filled .p-checkbox-box {
    background: ${e("checkbox.filled.background")};
}

.p-checkbox-checked.p-variant-filled .p-checkbox-box {
    background: ${e("checkbox.checked.background")};
}

.p-checkbox-checked.p-variant-filled:not(.p-disabled):has(.p-checkbox-input:hover) .p-checkbox-box {
    background: ${e("checkbox.checked.hover.background")};
}

.p-checkbox.p-disabled {
    opacity: 1;
}

.p-checkbox.p-disabled .p-checkbox-box {
    background: ${e("checkbox.disabled.background")};
    border-color: ${e("checkbox.checked.disabled.border.color")};
}

.p-checkbox.p-disabled .p-checkbox-box .p-checkbox-icon {
    color: ${e("checkbox.icon.disabled.color")};
}

.p-checkbox-sm,
.p-checkbox-sm .p-checkbox-box {
    width: ${e("checkbox.sm.width")};
    height: ${e("checkbox.sm.height")};
}

.p-checkbox-sm .p-checkbox-icon {
    font-size: ${e("checkbox.icon.sm.size")};
    width: ${e("checkbox.icon.sm.size")};
    height: ${e("checkbox.icon.sm.size")};
}

.p-checkbox-lg,
.p-checkbox-lg .p-checkbox-box {
    width: ${e("checkbox.lg.width")};
    height: ${e("checkbox.lg.height")};
}

.p-checkbox-lg .p-checkbox-icon {
    font-size: ${e("checkbox.icon.lg.size")};
    width: ${e("checkbox.icon.lg.size")};
    height: ${e("checkbox.icon.lg.size")};
}
`,me={root:({instance:e,props:a})=>["p-checkbox p-component",{"p-checkbox-checked":e.checked,"p-disabled":a.disabled,"p-invalid":a.invalid,"p-variant-filled":a.variant?a.variant==="filled":e.config.inputStyle==="filled"||e.config.inputVariant==="filled"}],box:"p-checkbox-box",input:"p-checkbox-input",icon:"p-checkbox-icon"},ne=(()=>{class e extends Y{name="checkbox";theme=fe;classes=me;static \u0275fac=(()=>{let o;return function(c){return(o||(o=y(e)))(c||e)}})();static \u0275prov=F({token:e,factory:e.\u0275fac})}return e})();var ge={provide:ee,useExisting:M(()=>te),multi:!0},te=(()=>{class e extends Z{value;name;disabled;binary;ariaLabelledBy;ariaLabel;tabindex;inputId;style;inputStyle;styleClass;inputClass;indeterminate=!1;size;formControl;checkboxIcon;readonly;required;autofocus;trueValue=!0;falseValue=!1;variant;onChange=new k;onFocus=new k;onBlur=new k;inputViewChild;get checked(){return this._indeterminate()?!1:this.binary?this.model===this.trueValue:J(this.value,this.model)}get containerClass(){return{"p-checkbox p-component":!0,"p-checkbox-checked p-highlight":this.checked,"p-disabled":this.disabled,"p-variant-filled":this.variant==="filled"||this.config.inputStyle()==="filled"||this.config.inputVariant()==="filled","p-checkbox-sm p-inputfield-sm":this.size==="small","p-checkbox-lg p-inputfield-lg":this.size==="large"}}_indeterminate=E(void 0);checkboxIconTemplate;templates;_checkboxIconTemplate;model;onModelChange=()=>{};onModelTouched=()=>{};focused=!1;_componentStyle=z(ne);ngAfterContentInit(){this.templates.forEach(o=>{switch(o.getType()){case"icon":this._checkboxIconTemplate=o.template;break;case"checkboxicon":this._checkboxIconTemplate=o.template;break}})}ngOnChanges(o){super.ngOnChanges(o),o.indeterminate&&this._indeterminate.set(o.indeterminate.currentValue)}updateModel(o){let i,c=this.injector.get(oe,null,{optional:!0,self:!0}),n=c&&!this.formControl?c.value:this.model;this.binary?(i=this._indeterminate()?this.trueValue:this.checked?this.falseValue:this.trueValue,this.model=i,this.onModelChange(i)):(this.checked||this._indeterminate()?i=n.filter(r=>!X(r,this.value)):i=n?[...n,this.value]:[this.value],this.onModelChange(i),this.model=i,this.formControl&&this.formControl.setValue(i)),this._indeterminate()&&this._indeterminate.set(!1),this.onChange.emit({checked:i,originalEvent:o})}handleChange(o){this.readonly||this.updateModel(o)}onInputFocus(o){this.focused=!0,this.onFocus.emit(o)}onInputBlur(o){this.focused=!1,this.onBlur.emit(o),this.onModelTouched()}focus(){this.inputViewChild.nativeElement.focus()}writeValue(o){this.model=o,this.cd.markForCheck()}registerOnChange(o){this.onModelChange=o}registerOnTouched(o){this.onModelTouched=o}setDisabledState(o){setTimeout(()=>{this.disabled=o,this.cd.markForCheck()})}static \u0275fac=(()=>{let o;return function(c){return(o||(o=y(e)))(c||e)}})();static \u0275cmp=O({type:e,selectors:[["p-checkbox"],["p-checkBox"],["p-check-box"]],contentQueries:function(i,c,n){if(i&1&&(V(n,ae,4),V(n,W,4)),i&2){let r;m(r=g())&&(c.checkboxIconTemplate=r.first),m(r=g())&&(c.templates=r)}},viewQuery:function(i,c){if(i&1&&N(re,5),i&2){let n;m(n=g())&&(c.inputViewChild=n.first)}},inputs:{value:"value",name:"name",disabled:[2,"disabled","disabled",h],binary:[2,"binary","binary",h],ariaLabelledBy:"ariaLabelledBy",ariaLabel:"ariaLabel",tabindex:[2,"tabindex","tabindex",P],inputId:"inputId",style:"style",inputStyle:"inputStyle",styleClass:"styleClass",inputClass:"inputClass",indeterminate:[2,"indeterminate","indeterminate",h],size:"size",formControl:"formControl",checkboxIcon:"checkboxIcon",readonly:[2,"readonly","readonly",h],required:[2,"required","required",h],autofocus:[2,"autofocus","autofocus",h],trueValue:"trueValue",falseValue:"falseValue",variant:"variant"},outputs:{onChange:"onChange",onFocus:"onFocus",onBlur:"onBlur"},features:[j([ge,ne]),D,B],decls:6,vars:29,consts:[["input",""],[3,"ngClass"],["type","checkbox",3,"focus","blur","change","value","checked","disabled","readonly","ngClass"],[1,"p-checkbox-box"],[4,"ngIf"],[4,"ngTemplateOutlet","ngTemplateOutletContext"],[3,"styleClass",4,"ngIf"],["class","p-checkbox-icon",3,"ngClass",4,"ngIf"],[1,"p-checkbox-icon",3,"ngClass"],[3,"styleClass"]],template:function(i,c){if(i&1){let n=L();$(0,"div",1)(1,"input",2,0),Q("focus",function(b){return u(n),p(c.onInputFocus(b))})("blur",function(b){return u(n),p(c.onInputBlur(b))})("change",function(b){return u(n),p(c.handleChange(b))}),I(),$(3,"div",3),d(4,pe,3,2,"ng-container",4)(5,xe,1,0,null,5),I()()}i&2&&(_(c.style),v(c.styleClass),t("ngClass",c.containerClass),s("data-p-highlight",c.checked)("data-p-checked",c.checked)("data-p-disabled",c.disabled),l(),_(c.inputStyle),v(c.inputClass),t("value",c.value)("checked",c.checked)("disabled",c.disabled)("readonly",c.readonly)("ngClass",A(26,le)),s("id",c.inputId)("name",c.name)("tabindex",c.tabindex)("required",c.required?!0:null)("aria-labelledby",c.ariaLabelledBy)("aria-label",c.ariaLabel),l(3),t("ngIf",!c.checkboxIconTemplate&&!c._checkboxIconTemplate),l(),t("ngTemplateOutlet",c.checkboxIconTemplate||c._checkboxIconTemplate)("ngTemplateOutletContext",R(27,he,c.checked)))},dependencies:[K,U,G,H,ce,ie,C],encapsulation:2,changeDetection:0})}return e})(),Ne=(()=>{class e{static \u0275fac=function(i){return new(i||e)};static \u0275mod=q({type:e});static \u0275inj=S({imports:[te,C,C]})}return e})();export{te as a,Ne as b};
