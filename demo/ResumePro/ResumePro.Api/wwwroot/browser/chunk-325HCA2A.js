import{c as y,g as $}from"./chunk-SMJIQ4E4.js";import{Aa as b,Da as m}from"./chunk-ZHGKNXMS.js";import{Fb as x,Q as l,R as s,Ua as r,W as d,Yb as v,bb as p,cb as f,ea as u,eb as g,ka as c,qb as h,sc as o}from"./chunk-DKCBYRU7.js";var M=({dt:e})=>`
.p-textarea {
    font-family: inherit;
    font-feature-settings: inherit;
    font-size: 1rem;
    color: ${e("textarea.color")};
    background: ${e("textarea.background")};
    padding: ${e("textarea.padding.y")} ${e("textarea.padding.x")};
    border: 1px solid ${e("textarea.border.color")};
    transition: background ${e("textarea.transition.duration")}, color ${e("textarea.transition.duration")}, border-color ${e("textarea.transition.duration")}, outline-color ${e("textarea.transition.duration")}, box-shadow ${e("textarea.transition.duration")};
    appearance: none;
    border-radius: ${e("textarea.border.radius")};
    outline-color: transparent;
    box-shadow: ${e("textarea.shadow")};
}

.p-textarea.ng-invalid.ng-dirty {
    border-color: ${e("textarea.invalid.border.color")};
}

.p-textarea:enabled:hover {
    border-color: ${e("textarea.hover.border.color")};
}

.p-textarea:enabled:focus {
    border-color: ${e("textarea.focus.border.color")};
    box-shadow: ${e("textarea.focus.ring.shadow")};
    outline: ${e("textarea.focus.ring.width")} ${e("textarea.focus.ring.style")} ${e("textarea.focus.ring.color")};
    outline-offset: ${e("textarea.focus.ring.offset")};
}

.p-textarea.p-invalid {
    border-color: ${e("textarea.invalid.border.color")};
}

.p-textarea.p-variant-filled {
    background: ${e("textarea.filled.background")};
}

.p-textarea.p-variant-filled:enabled:focus {
    background: ${e("textarea.filled.focus.background")};
}

.p-textarea:disabled {
    opacity: 1;
    background: ${e("textarea.disabled.background")};
    color: ${e("textarea.disabled.color")};
}

.p-textarea::placeholder {
    color: ${e("textarea.placeholder.color")};
}

.p-textarea.ng-invalid.ng-dirty::placeholder {
    color: ${e("textarea.invalid.placeholder.color")};
}

.p-textarea-fluid {
    width: 100%;
}

.p-textarea-resizable {
    overflow: hidden;
    resize: none;
}

.p-textarea-sm {
    font-size: ${e("textarea.sm.font.size")};
    padding-block: ${e("textarea.sm.padding.y")};
    padding-inline: ${e("textarea.sm.padding.x")};
}

.p-textarea-lg {
    font-size: ${e("textarea.lg.font.size")};
    padding-block: ${e("textarea.lg.padding.y")};
    padding-inline: ${e("textarea.lg.padding.x")};
}
`,E={root:({instance:e,props:n})=>["p-textarea p-component",{"p-filled":e.filled,"p-textarea-resizable ":n.autoResize,"p-invalid":n.invalid,"p-variant-filled":n.variant?n.variant==="filled":e.config.inputStyle==="filled"||e.config.inputVariant==="filled","p-textarea-fluid":n.fluid}]},z=(()=>{class e extends b{name="textarea";theme=M;classes=E;static \u0275fac=(()=>{let i;return function(t){return(i||(i=u(e)))(t||e)}})();static \u0275prov=l({token:e,factory:e.\u0275fac})}return e})();var A=(()=>{class e extends m{ngModel;control;autoResize;variant;fluid=!1;pSize;onResize=new c;filled;cachedScrollHeight;ngModelSubscription;ngControlSubscription;_componentStyle=d(z);constructor(i,a){super(),this.ngModel=i,this.control=a}ngOnInit(){super.ngOnInit(),this.ngModel&&(this.ngModelSubscription=this.ngModel.valueChanges.subscribe(()=>{this.updateState()})),this.control&&(this.ngControlSubscription=this.control.valueChanges.subscribe(()=>{this.updateState()}))}get hasFluid(){let a=this.el.nativeElement.closest("p-fluid");return this.fluid||!!a}ngAfterViewInit(){super.ngAfterViewInit(),this.autoResize&&this.resize(),this.updateFilledState(),this.cd.detectChanges()}onInput(i){this.updateState()}updateFilledState(){this.filled=this.el.nativeElement.value&&this.el.nativeElement.value.length}resize(i){this.el.nativeElement.style.height="auto",this.el.nativeElement.style.height=this.el.nativeElement.scrollHeight+"px",parseFloat(this.el.nativeElement.style.height)>=parseFloat(this.el.nativeElement.style.maxHeight)?(this.el.nativeElement.style.overflowY="scroll",this.el.nativeElement.style.height=this.el.nativeElement.style.maxHeight):this.el.nativeElement.style.overflow="hidden",this.onResize.emit(i||{})}updateState(){this.updateFilledState(),this.autoResize&&this.resize()}ngOnDestroy(){this.ngModelSubscription&&this.ngModelSubscription.unsubscribe(),this.ngControlSubscription&&this.ngControlSubscription.unsubscribe(),super.ngOnDestroy()}static \u0275fac=function(a){return new(a||e)(r($,8),r(y,8))};static \u0275dir=f({type:e,selectors:[["","pTextarea",""]],hostAttrs:[1,"p-textarea","p-component"],hostVars:16,hostBindings:function(a,t){a&1&&x("input",function(S){return t.onInput(S)}),a&2&&h("p-filled",t.filled)("p-textarea-resizable",t.autoResize)("p-variant-filled",t.variant==="filled"||t.config.inputStyle()==="filled"||t.config.inputVariant()==="filled")("p-textarea-fluid",t.hasFluid)("p-textarea-sm",t.pSize==="small")("p-inputfield-sm",t.pSize==="small")("p-textarea-lg",t.pSize==="large")("p-inputfield-lg",t.pSize==="large")},inputs:{autoResize:[2,"autoResize","autoResize",o],variant:"variant",fluid:[2,"fluid","fluid",o],pSize:"pSize"},outputs:{onResize:"onResize"},features:[v([z]),g]})}return e})(),N=(()=>{class e{static \u0275fac=function(a){return new(a||e)};static \u0275mod=p({type:e});static \u0275inj=s({})}return e})();export{A as a,N as b};
