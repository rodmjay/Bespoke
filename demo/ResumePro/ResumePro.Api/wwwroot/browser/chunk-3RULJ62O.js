import{a as fe}from"./chunk-5ITMLF3G.js";import{c as x}from"./chunk-BODZH67C.js";import{e as ue}from"./chunk-QXZQXA5D.js";import{c as ae,d as E,f as L,h as O,i as M,k as Q}from"./chunk-WCGJ44IN.js";import{Aa as me,Da as he,S as ce,b as V,c as se,e as le,m as de,sa as pe,ta as C}from"./chunk-ZHGKNXMS.js";import{$b as X,Ab as P,Bb as N,Cb as g,Db as I,Fb as D,Gb as s,Hb as H,Ib as G,Jc as ie,Kb as w,Lb as k,Lc as ne,Mb as p,Nb as m,Pa as d,Pc as oe,Q as A,R as B,Rb as K,Sb as U,Uc as re,W as R,Yb as J,_b as W,aa as b,ab as z,ba as y,bb as F,dc as Y,ea as T,eb as Z,gb as c,ka as v,mc as ee,nb as f,ob as a,rb as j,sb as S,sc as h,tb as q,tc as te,xb as u,yb as _,zb as $}from"./chunk-DKCBYRU7.js";var we=["header"],be=["footer"],ye=["content"],ge=["closeicon"],xe=["headless"],ve=["maskRef"],ke=["container"],Ce=["closeButton"],Te=["*"],Se=(t,r,e,o,i,n)=>({"p-drawer":!0,"p-drawer-active":t,"p-drawer-left":r,"p-drawer-right":e,"p-drawer-top":o,"p-drawer-bottom":i,"p-drawer-full":n}),Ie=(t,r)=>({transform:t,transition:r}),De=t=>({value:"visible",params:t});function Ee(t,r){t&1&&g(0)}function Le(t,r){if(t&1&&c(0,Ee,1,0,"ng-container",4),t&2){let e=s(2);a("ngTemplateOutlet",e.headlessTemplate||e._headlessTemplate)}}function Oe(t,r){t&1&&g(0)}function Me(t,r){if(t&1&&(u(0,"div"),K(1),_()),t&2){let e=s(3);S(e.cx("title")),d(),U(e.header)}}function Qe(t,r){t&1&&$(0,"TimesIcon"),t&2&&f("data-pc-section","closeicon")}function Ve(t,r){}function Ae(t,r){t&1&&c(0,Ve,0,0,"ng-template")}function Be(t,r){if(t&1&&c(0,Qe,1,1,"TimesIcon",8)(1,Ae,1,0,null,4),t&2){let e=s(4);a("ngIf",!e.closeIconTemplate&&!e._closeIconTemplate),d(),a("ngTemplateOutlet",e.closeIconTemplate||e._closeIconTemplate)}}function Re(t,r){if(t&1){let e=I();u(0,"p-button",9),D("onClick",function(i){b(e);let n=s(3);return y(n.close(i))})("keydown.enter",function(i){b(e);let n=s(3);return y(n.close(i))}),c(1,Be,2,2,"ng-template",null,1,ee),_()}if(t&2){let e=s(3);a("ngClass",e.cx("closeButton"))("buttonProps",e.closeButtonProps)("ariaLabel",e.ariaCloseLabel),f("data-pc-section","closebutton")("data-pc-group-section","iconcontainer")}}function ze(t,r){t&1&&g(0)}function Fe(t,r){t&1&&g(0)}function Ze(t,r){if(t&1&&(P(0),u(1,"div",5),c(2,Fe,1,0,"ng-container",4),_(),N()),t&2){let e=s(3);d(),a("ngClass",e.cx("footer")),f("data-pc-section","footer"),d(),a("ngTemplateOutlet",e.footerTemplate||e._footerTemplate)}}function je(t,r){if(t&1&&(u(0,"div",5),c(1,Oe,1,0,"ng-container",4)(2,Me,2,3,"div",6)(3,Re,3,5,"p-button",7),_(),u(4,"div",5),G(5),c(6,ze,1,0,"ng-container",4),_(),c(7,Ze,3,3,"ng-container",8)),t&2){let e=s(2);a("ngClass",e.cx("header")),f("data-pc-section","header"),d(),a("ngTemplateOutlet",e.headerTemplate||e._headerTemplate),d(),a("ngIf",e.header),d(),a("ngIf",e.showCloseIcon&&e.closable),d(),a("ngClass",e.cx("content")),f("data-pc-section","content"),d(2),a("ngTemplateOutlet",e.contentTemplate||e._contentTemplate),d(),a("ngIf",e.footerTemplate||e._footerTemplate)}}function qe(t,r){if(t&1){let e=I();u(0,"div",3,0),D("@panelState.start",function(i){b(e);let n=s();return y(n.onAnimationStart(i))})("@panelState.done",function(i){b(e);let n=s();return y(n.onAnimationEnd(i))})("keydown",function(i){b(e);let n=s();return y(n.onKeyDown(i))}),c(2,Le,1,1,"ng-container")(3,je,8,9),_()}if(t&2){let e=s();j(e.style),S(e.styleClass),a("ngClass",Y(9,Se,e.visible,e.position==="left"&&!e.fullScreen,e.position==="right"&&!e.fullScreen,e.position==="top"&&!e.fullScreen,e.position==="bottom"&&!e.fullScreen,e.fullScreen||e.position==="full"))("@panelState",W(19,De,X(16,Ie,e.transformOptions,e.transitionOptions))),f("data-pc-name","sidebar")("data-pc-section","root"),d(2),q(e.headlessTemplate||e._headlessTemplate?2:3)}}var $e=({dt:t})=>`
.p-drawer {
    display: flex;
    flex-direction: column;
    pointer-events: auto;
    transform: translate3d(0px, 0px, 0px);
    position: fixed;
    transition: transform 0.3s;
    background: ${t("drawer.background")};
    color: ${t("drawer.color")};
    border: 1px solid ${t("drawer.border.color")};
    box-shadow: ${t("drawer.shadow")};
}

.p-drawer-content {
    overflow-y: auto;
    flex-grow: 1;
    padding: ${t("drawer.content.padding")};
}

.p-drawer-header {
    display: flex;
    align-items: center;
    justify-content: space-between;
    flex-shrink: 0;
    padding: ${t("drawer.header.padding")};
}

.p-drawer-footer {
    padding: ${t("drawer.header.padding")};
}

.p-drawer-title {
    font-weight: ${t("drawer.title.font.weight")};
    font-size: ${t("drawer.title.font.size")};
}

.p-drawer-full .p-drawer {
    transition: none;
    transform: none;
    width: 100vw !important;
    height: 100vh !important;
    max-height: 100%;
    top: 0px !important;
    left: 0px !important;
    border-width: 1px;
}

.p-drawer-left .p-drawer {
    align-self: start;
    width: 20rem;
    height: 100%;
    border-right-width: 1px;
}

.p-drawer-right .p-drawer {
    align-self: end;
    width: 20rem;
    height: 100%;
    border-left-width: 1px;
}

.p-drawer-top .p-drawer {
    height: 10rem;
    width: 100%;
    border-bottom-width: 1px;
}

.p-drawer-bottom .p-drawer {
    height: 10rem;
    width: 100%;
    border-top-width: 1px;
}

.p-drawer-left .p-drawer-content,
.p-drawer-right .p-drawer-content,
.p-drawer-top .p-drawer-content,
.p-drawer-bottom .p-drawer-content {
    width: 100%;
    height: 100%;
}

.p-drawer-open {
    display: flex;
}

.p-drawer-top {
    justify-content: flex-start;
}

.p-drawer-bottom {
    justify-content: flex-end;
}

.p-drawer {
    position: fixed;
    transition: transform 0.3s;
    display: flex;
    flex-direction: column;
}

.p-drawer-content {
    position: relative;
    overflow-y: auto;
    flex-grow: 1;
}

.p-drawer-header {
    display: flex;
    align-items: center;
}

.p-drawer-footer {
    margin-top: auto;
}

.p-drawer-icon {
    display: flex;
    align-items: center;
    justify-content: center;
    margin-left: auto;
}

.p-drawer-left {
    top: 0;
    left: 0;
    width: 20rem;
    height: 100%;
}

.p-drawer-right {
    top: 0;
    right: 0;
    width: 20rem;
    height: 100%;
}

.p-drawer-top {
    top: 0;
    left: 0;
    width: 100%;
    height: 10rem;
}

.p-drawer-bottom {
    bottom: 0;
    left: 0;
    width: 100%;
    height: 10rem;
}

.p-drawer-full {
    width: 100%;
    height: 100%;
    top: 0;
    left: 0;
    -webkit-transition: none;
    transition: none;
}

.p-drawer-mask {
    background-color: rgba(0, 0, 0, 0.4);
    transition-duration: 0.2s;
}

.p-overlay-mask {
    position: fixed;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%;
}

.p-overlay-mask:dir(rtl) {
    flex-direction: row-reverse;
}

.p-overlay-mask-enter {
    animation: p-overlay-mask-enter-animation 150ms forwards;
}

.p-overlay-mask-leave {
    animation: p-overlay-mask-leave-animation 150ms forwards;
}

@keyframes p-overlay-mask-enter-animation {
    from {
        background-color: transparent;
    }
    to {
        background-color: rgba(0, 0, 0, 0.4);
    }
}
@keyframes p-overlay-mask-leave-animation {
    from {
        background-color: rgba(0, 0, 0, 0.4);
    }
    to {
        background-color: transparent;
    }
}
`,Pe={mask:({instance:t})=>({position:"fixed",height:"100%",width:"100%",left:0,top:0,display:"flex",flexDirection:"column",alignItems:t.position==="top"?"flex-start":t.position==="bottom"?"flex-end":"center"})},Ne={mask:({instance:t})=>({"p-drawer-mask":!0,"p-overlay-mask p-overlay-mask-enter":t.modal,"p-drawer-open":t.containerVisible,"p-drawer-full":t.fullScreen,[`p-drawer-${t.position}`]:!!t.position}),root:({instance:t})=>({"p-drawer p-component":!0,"p-drawer-full":t.fullScreen}),header:"p-drawer-header",title:"p-drawer-title",pcCloseButton:"p-drawer-close-button",content:"p-drawer-content",footer:"p-drawer-footer"},_e=(()=>{class t extends me{name="drawer";theme=$e;classes=Ne;inlineStyles=Pe;static \u0275fac=(()=>{let e;return function(i){return(e||(e=T(t)))(i||t)}})();static \u0275prov=A({token:t,factory:t.\u0275fac})}return t})();var He=M([L({transform:"{{transform}}",opacity:0}),E("{{transition}}")]),Ge=M([E("{{transition}}",L({transform:"{{transform}}",opacity:0}))]),Ke=(()=>{class t extends he{appendTo="body";blockScroll=!1;style;styleClass;ariaCloseLabel;autoZIndex=!0;baseZIndex=0;modal=!0;closeButtonProps={severity:"secondary",text:!0,rounded:!0};dismissible=!0;showCloseIcon=!0;closeOnEscape=!0;transitionOptions="150ms cubic-bezier(0, 0, 0.2, 1)";get visible(){return this._visible}set visible(e){this._visible=e}get position(){return this._position}set position(e){if(this._position=e,e==="full"){this.transformOptions="none";return}switch(e){case"left":this.transformOptions="translate3d(-100%, 0px, 0px)";break;case"right":this.transformOptions="translate3d(100%, 0px, 0px)";break;case"bottom":this.transformOptions="translate3d(0px, 100%, 0px)";break;case"top":this.transformOptions="translate3d(0px, -100%, 0px)";break}}get fullScreen(){return this._fullScreen}set fullScreen(e){this._fullScreen=e,e&&(this.transformOptions="none")}header;maskStyle;closable=!0;onShow=new v;onHide=new v;visibleChange=new v;maskRef;containerViewChild;closeButtonViewChild;initialized;_visible;_position="left";_fullScreen=!1;container;transformOptions="translate3d(-100%, 0px, 0px)";mask;maskClickListener;documentEscapeListener;animationEndListener;_componentStyle=R(_e);ngAfterViewInit(){super.ngAfterViewInit(),this.initialized=!0}headerTemplate;footerTemplate;contentTemplate;closeIconTemplate;headlessTemplate;_headerTemplate;_footerTemplate;_contentTemplate;_closeIconTemplate;_headlessTemplate;templates;ngAfterContentInit(){this.templates?.forEach(e=>{switch(e.getType()){case"content":this._contentTemplate=e.template;break;case"header":this._headerTemplate=e.template;break;case"footer":this._footerTemplate=e.template;break;case"closeicon":this._closeIconTemplate=e.template;break;case"headless":this._headlessTemplate=e.template;break;default:this._contentTemplate=e.template;break}})}onKeyDown(e){e.code==="Escape"&&this.hide(!1)}show(){this.autoZIndex&&x.set("modal",this.container,this.baseZIndex||this.config.zIndex.modal),this.modal&&this.enableModality(),this.onShow.emit({}),this.visibleChange.emit(!0)}hide(e=!0){e&&this.onHide.emit({}),this.modal&&this.disableModality()}close(e){this.hide(),this.visibleChange.emit(!1),e.preventDefault()}enableModality(){let e=this.document.querySelectorAll(".p-drawer-active"),o=e.length,i=o==1?String(parseInt(this.container.style.zIndex)-1):String(parseInt(e[o-1].style.zIndex)-1);this.container.setAttribute(this.attrSelector,""),this.mask||(this.mask=this.renderer.createElement("div"),this.renderer.setStyle(this.mask,"zIndex",i),ce(this.mask,"style",this.maskStyle),V(this.mask,"p-overlay-mask p-drawer-mask p-overlay-mask-enter"),this.dismissible&&(this.maskClickListener=this.renderer.listen(this.mask,"click",n=>{this.dismissible&&this.close(n)})),this.renderer.appendChild(this.document.body,this.mask),this.blockScroll&&se())}disableModality(){this.mask&&(V(this.mask,"p-overlay-mask-leave"),this.animationEndListener=this.renderer.listen(this.mask,"animationend",this.destroyModal.bind(this)))}destroyModal(){this.unbindMaskClickListener(),this.mask&&this.renderer.removeChild(this.document.body,this.mask),this.blockScroll&&le(),this.unbindAnimationEndListener(),this.mask=null}onAnimationStart(e){switch(e.toState){case"visible":this.container=e.element,this.appendContainer(),this.show(),this.closeOnEscape&&this.bindDocumentEscapeListener();break}}onAnimationEnd(e){switch(e.toState){case"void":this.hide(!1),x.clear(this.container),this.unbindGlobalListeners();break}}appendContainer(){this.appendTo&&(this.appendTo==="body"?this.renderer.appendChild(this.document.body,this.container):de(this.appendTo,this.container))}bindDocumentEscapeListener(){let e=this.el?this.el.nativeElement.ownerDocument:this.document;this.documentEscapeListener=this.renderer.listen(e,"keydown",o=>{o.which==27&&parseInt(this.container.style.zIndex)===x.get(this.container)&&this.close(o)})}unbindDocumentEscapeListener(){this.documentEscapeListener&&(this.documentEscapeListener(),this.documentEscapeListener=null)}unbindMaskClickListener(){this.maskClickListener&&(this.maskClickListener(),this.maskClickListener=null)}unbindGlobalListeners(){this.unbindMaskClickListener(),this.unbindDocumentEscapeListener()}unbindAnimationEndListener(){this.animationEndListener&&this.mask&&(this.animationEndListener(),this.animationEndListener=null)}ngOnDestroy(){this.initialized=!1,this.visible&&this.modal&&this.destroyModal(),this.appendTo&&this.container&&this.renderer.appendChild(this.el.nativeElement,this.container),this.container&&this.autoZIndex&&x.clear(this.container),this.container=null,this.unbindGlobalListeners(),this.unbindAnimationEndListener()}static \u0275fac=(()=>{let e;return function(i){return(e||(e=T(t)))(i||t)}})();static \u0275cmp=z({type:t,selectors:[["p-drawer"]],contentQueries:function(o,i,n){if(o&1&&(w(n,we,4),w(n,be,4),w(n,ye,4),w(n,ge,4),w(n,xe,4),w(n,pe,4)),o&2){let l;p(l=m())&&(i.headerTemplate=l.first),p(l=m())&&(i.footerTemplate=l.first),p(l=m())&&(i.contentTemplate=l.first),p(l=m())&&(i.closeIconTemplate=l.first),p(l=m())&&(i.headlessTemplate=l.first),p(l=m())&&(i.templates=l)}},viewQuery:function(o,i){if(o&1&&(k(ve,5),k(ke,5),k(Ce,5)),o&2){let n;p(n=m())&&(i.maskRef=n.first),p(n=m())&&(i.containerViewChild=n.first),p(n=m())&&(i.closeButtonViewChild=n.first)}},inputs:{appendTo:"appendTo",blockScroll:[2,"blockScroll","blockScroll",h],style:"style",styleClass:"styleClass",ariaCloseLabel:"ariaCloseLabel",autoZIndex:[2,"autoZIndex","autoZIndex",h],baseZIndex:[2,"baseZIndex","baseZIndex",te],modal:[2,"modal","modal",h],closeButtonProps:"closeButtonProps",dismissible:[2,"dismissible","dismissible",h],showCloseIcon:[2,"showCloseIcon","showCloseIcon",h],closeOnEscape:[2,"closeOnEscape","closeOnEscape",h],transitionOptions:"transitionOptions",visible:"visible",position:"position",fullScreen:"fullScreen",header:"header",maskStyle:"maskStyle",closable:[2,"closable","closable",h]},outputs:{onShow:"onShow",onHide:"onHide",visibleChange:"visibleChange"},features:[J([_e]),Z],ngContentSelectors:Te,decls:1,vars:1,consts:[["container",""],["icon",""],["role","complementary",3,"ngClass","style","class","keydown",4,"ngIf"],["role","complementary",3,"keydown","ngClass"],[4,"ngTemplateOutlet"],[3,"ngClass"],[3,"class",4,"ngIf"],[3,"ngClass","buttonProps","ariaLabel","onClick","keydown.enter",4,"ngIf"],[4,"ngIf"],[3,"onClick","keydown.enter","ngClass","buttonProps","ariaLabel"]],template:function(o,i){o&1&&(H(),c(0,qe,4,21,"div",2)),o&2&&a("ngIf",i.visible)},dependencies:[re,ie,ne,oe,ue,fe,C],encapsulation:2,data:{animation:[ae("panelState",[O("void => visible",[Q(He)]),O("visible => void",[Q(Ge)])])]},changeDetection:0})}return t})(),wt=(()=>{class t{static \u0275fac=function(o){return new(o||t)};static \u0275mod=F({type:t});static \u0275inj=B({imports:[Ke,C,C]})}return t})();export{Ke as a,wt as b};
