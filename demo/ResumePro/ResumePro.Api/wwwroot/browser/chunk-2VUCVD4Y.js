import{a as f,b as i,d as n}from"./chunk-ZHGKNXMS.js";import{Fb as v,R as c,Ta as g,Ua as a,bb as u,cb as m,la as d,oa as C,sc as r}from"./chunk-DKCBYRU7.js";var E=(()=>{class t{el;renderer;zone;constructor(e,s,l){this.el=e,this.renderer=s,this.zone=l}selector;set enterClass(e){this._enterClass=e,console.log("enterClass is deprecated, use enterFromClass instead")}get enterClass(){return this._enterClass}enterFromClass;enterActiveClass;enterToClass;set leaveClass(e){this._leaveClass=e,console.log("leaveClass is deprecated, use leaveFromClass instead")}get leaveClass(){return this._leaveClass}leaveFromClass;leaveActiveClass;leaveToClass;hideOnOutsideClick;toggleClass;hideOnEscape;eventListener;documentClickListener;documentKeydownListener;target;enterListener;leaveListener;animating;_enterClass;_leaveClass;clickListener(){this.target=this.resolveTarget(),this.toggleClass?this.toggle():this.target?.offsetParent===null?this.enter():this.leave()}toggle(){f(this.target,this.toggleClass)?n(this.target,this.toggleClass):i(this.target,this.toggleClass)}enter(){this.enterActiveClass?this.animating||(this.animating=!0,this.enterActiveClass==="animate-slidedown"&&(this.target.style.height="0px",n(this.target,"hidden"),this.target.style.maxHeight=this.target.scrollHeight+"px",i(this.target,"hidden"),this.target.style.height=""),i(this.target,this.enterActiveClass),(this.enterClass||this.enterFromClass)&&n(this.target,this.enterClass||this.enterFromClass),this.enterListener=this.renderer.listen(this.target,"animationend",()=>{n(this.target,this.enterActiveClass),this.enterToClass&&i(this.target,this.enterToClass),this.enterListener&&this.enterListener(),this.enterActiveClass==="animate-slidedown"&&(this.target.style.maxHeight=""),this.animating=!1})):((this.enterClass||this.enterFromClass)&&n(this.target,this.enterClass||this.enterFromClass),this.enterToClass&&i(this.target,this.enterToClass)),this.hideOnOutsideClick&&this.bindDocumentClickListener(),this.hideOnEscape&&this.bindDocumentKeydownListener()}leave(){this.leaveActiveClass?this.animating||(this.animating=!0,i(this.target,this.leaveActiveClass),(this.leaveClass||this.leaveFromClass)&&n(this.target,this.leaveClass||this.leaveFromClass),this.leaveListener=this.renderer.listen(this.target,"animationend",()=>{n(this.target,this.leaveActiveClass),this.leaveToClass&&i(this.target,this.leaveToClass),this.leaveListener&&this.leaveListener(),this.animating=!1})):((this.leaveClass||this.leaveFromClass)&&n(this.target,this.leaveClass||this.leaveFromClass),this.leaveToClass&&i(this.target,this.leaveToClass)),this.hideOnOutsideClick&&this.unbindDocumentClickListener(),this.hideOnEscape&&this.unbindDocumentKeydownListener()}resolveTarget(){if(this.target)return this.target;switch(this.selector){case"@next":return this.el.nativeElement.nextElementSibling;case"@prev":return this.el.nativeElement.previousElementSibling;case"@parent":return this.el.nativeElement.parentElement;case"@grandparent":return this.el.nativeElement.parentElement.parentElement;default:return document.querySelector(this.selector)}}bindDocumentClickListener(){this.documentClickListener||(this.documentClickListener=this.renderer.listen(this.el.nativeElement.ownerDocument,"click",e=>{!this.isVisible()||getComputedStyle(this.target).getPropertyValue("position")==="static"?this.unbindDocumentClickListener():this.isOutsideClick(e)&&this.leave()}))}bindDocumentKeydownListener(){this.documentKeydownListener||this.zone.runOutsideAngular(()=>{this.documentKeydownListener=this.renderer.listen(this.el.nativeElement.ownerDocument,"keydown",e=>{let{key:s,keyCode:l,which:h,type:o}=e;(!this.isVisible()||getComputedStyle(this.target).getPropertyValue("position")==="static")&&this.unbindDocumentKeydownListener(),this.isVisible()&&s==="Escape"&&l===27&&h===27&&this.leave()})})}isVisible(){return this.target.offsetParent!==null}isOutsideClick(e){return!this.el.nativeElement.isSameNode(e.target)&&!this.el.nativeElement.contains(e.target)&&!this.target.contains(e.target)}unbindDocumentClickListener(){this.documentClickListener&&(this.documentClickListener(),this.documentClickListener=null)}unbindDocumentKeydownListener(){this.documentKeydownListener&&(this.documentKeydownListener(),this.documentKeydownListener=null)}ngOnDestroy(){this.target=null,this.eventListener&&this.eventListener(),this.unbindDocumentClickListener(),this.unbindDocumentKeydownListener()}static \u0275fac=function(s){return new(s||t)(a(C),a(g),a(d))};static \u0275dir=m({type:t,selectors:[["","pStyleClass",""]],hostBindings:function(s,l){s&1&&v("click",function(o){return l.clickListener(o)})},inputs:{selector:[0,"pStyleClass","selector"],enterClass:"enterClass",enterFromClass:"enterFromClass",enterActiveClass:"enterActiveClass",enterToClass:"enterToClass",leaveClass:"leaveClass",leaveFromClass:"leaveFromClass",leaveActiveClass:"leaveActiveClass",leaveToClass:"leaveToClass",hideOnOutsideClick:[2,"hideOnOutsideClick","hideOnOutsideClick",r],toggleClass:"toggleClass",hideOnEscape:[2,"hideOnEscape","hideOnEscape",r]}})}return t})(),b=(()=>{class t{static \u0275fac=function(s){return new(s||t)};static \u0275mod=u({type:t});static \u0275inj=c({})}return t})();export{E as a,b};
