import{Aa as E,Ac as se,Ba as S,Bc as ie,Ca as K,Cc as p,Da as q,Ea as J,Fa as Q,Ga as ee,Ha as te,Ia as ne,Ic as ae,Ja as v,O as g,Q as f,Qa as M,Sa as re,T as L,V as c,Vc as ce,Xc as U,Y as G,Zc as le,la as D,ma as H,qa as Y,ra as N,rc as oe,sa as W,ta as C,va as P,wa as X,za as w,zc as k}from"./chunk-DKCBYRU7.js";import{a as I,b as Z}from"./chunk-GAL4ENT6.js";var x=class extends ie{supportsDOMEvents=!0},B=class r extends x{static makeCurrent(){se(new r)}onAndCancel(n,e,t,o){return n.addEventListener(e,t,o),()=>{n.removeEventListener(e,t,o)}}dispatchEvent(n,e){n.dispatchEvent(e)}remove(n){n.remove()}createElement(n,e){return e=e||this.getDefaultDocument(),e.createElement(n)}createHtmlDocument(){return document.implementation.createHTMLDocument("fakeTitle")}getDefaultDocument(){return document}isElementNode(n){return n.nodeType===Node.ELEMENT_NODE}isShadowRoot(n){return n instanceof DocumentFragment}getGlobalEventTarget(n,e){return e==="window"?window:e==="document"?n:e==="body"?n.body:null}getBaseHref(n){let e=Se();return e==null?null:we(e)}resetBaseElement(){T=null}getUserAgent(){return window.navigator.userAgent}getCookie(n){return ae(document.cookie,n)}},T=null;function Se(){return T=T||document.querySelector("base"),T?T.getAttribute("href"):null}function we(r){return new URL(r,document.baseURI).pathname}var Me=(()=>{class r{build(){return new XMLHttpRequest}static \u0275fac=function(t){return new(t||r)};static \u0275prov=f({token:r,factory:r.\u0275fac})}return r})(),F=new L(""),me=(()=>{class r{_zone;_plugins;_eventNameToPlugin=new Map;constructor(e,t){this._zone=t,e.forEach(o=>{o.manager=this}),this._plugins=e.slice().reverse()}addEventListener(e,t,o,s){return this._findPluginFor(t).addEventListener(e,t,o,s)}getZone(){return this._zone}_findPluginFor(e){let t=this._eventNameToPlugin.get(e);if(t)return t;if(t=this._plugins.find(s=>s.supports(e)),!t)throw new g(5101,!1);return this._eventNameToPlugin.set(e,t),t}static \u0275fac=function(t){return new(t||r)(c(F),c(D))};static \u0275prov=f({token:r,factory:r.\u0275fac})}return r})(),A=class{_doc;constructor(n){this._doc=n}manager},b="ng-app-id";function de(r){for(let n of r)n.remove()}function ue(r,n){let e=n.createElement("style");return e.textContent=r,e}function Te(r,n,e,t){let o=r.head?.querySelectorAll(`style[${b}="${n}"],link[${b}="${n}"]`);if(o)for(let s of o)s.removeAttribute(b),s instanceof HTMLLinkElement?t.set(s.href.slice(s.href.lastIndexOf("/")+1),{usage:0,elements:[s]}):s.textContent&&e.set(s.textContent,{usage:0,elements:[s]})}function z(r,n){let e=n.createElement("link");return e.setAttribute("rel","stylesheet"),e.setAttribute("href",r),e}var ge=(()=>{class r{doc;appId;nonce;inline=new Map;external=new Map;hosts=new Set;isServer;constructor(e,t,o,s={}){this.doc=e,this.appId=t,this.nonce=o,this.isServer=U(s),Te(e,t,this.inline,this.external),this.hosts.add(e.head)}addStyles(e,t){for(let o of e)this.addUsage(o,this.inline,ue);t?.forEach(o=>this.addUsage(o,this.external,z))}removeStyles(e,t){for(let o of e)this.removeUsage(o,this.inline);t?.forEach(o=>this.removeUsage(o,this.external))}addUsage(e,t,o){let s=t.get(e);s?s.usage++:t.set(e,{usage:1,elements:[...this.hosts].map(i=>this.addElement(i,o(e,this.doc)))})}removeUsage(e,t){let o=t.get(e);o&&(o.usage--,o.usage<=0&&(de(o.elements),t.delete(e)))}ngOnDestroy(){for(let[,{elements:e}]of[...this.inline,...this.external])de(e);this.hosts.clear()}addHost(e){this.hosts.add(e);for(let[t,{elements:o}]of this.inline)o.push(this.addElement(e,ue(t,this.doc)));for(let[t,{elements:o}]of this.external)o.push(this.addElement(e,z(t,this.doc)))}removeHost(e){this.hosts.delete(e)}addElement(e,t){return this.nonce&&t.setAttribute("nonce",this.nonce),this.isServer&&t.setAttribute(b,this.appId),e.appendChild(t)}static \u0275fac=function(t){return new(t||r)(c(p),c(N),c(P,8),c(C))};static \u0275prov=f({token:r,factory:r.\u0275fac})}return r})(),j={svg:"http://www.w3.org/2000/svg",xhtml:"http://www.w3.org/1999/xhtml",xlink:"http://www.w3.org/1999/xlink",xml:"http://www.w3.org/XML/1998/namespace",xmlns:"http://www.w3.org/2000/xmlns/",math:"http://www.w3.org/1998/Math/MathML"},$=/%COMP%/g;var ve="%COMP%",_e=`_nghost-${ve}`,Re=`_ngcontent-${ve}`,De=!0,Ce=new L("",{providedIn:"root",factory:()=>De});function be(r){return Re.replace($,r)}function Ae(r){return _e.replace($,r)}function ye(r,n){return n.map(e=>e.replace($,r))}var fe=(()=>{class r{eventManager;sharedStylesHost;appId;removeStylesOnCompDestroy;doc;platformId;ngZone;nonce;tracingService;rendererByCompId=new Map;defaultRenderer;platformIsServer;constructor(e,t,o,s,i,a,d,u=null,l=null){this.eventManager=e,this.sharedStylesHost=t,this.appId=o,this.removeStylesOnCompDestroy=s,this.doc=i,this.platformId=a,this.ngZone=d,this.nonce=u,this.tracingService=l,this.platformIsServer=U(a),this.defaultRenderer=new _(e,i,d,this.platformIsServer,this.tracingService)}createRenderer(e,t){if(!e||!t)return this.defaultRenderer;this.platformIsServer&&t.encapsulation===w.ShadowDom&&(t=Z(I({},t),{encapsulation:w.Emulated}));let o=this.getOrCreateRenderer(e,t);return o instanceof O?o.applyToHost(e):o instanceof R&&o.applyStyles(),o}getOrCreateRenderer(e,t){let o=this.rendererByCompId,s=o.get(t.id);if(!s){let i=this.doc,a=this.ngZone,d=this.eventManager,u=this.sharedStylesHost,l=this.removeStylesOnCompDestroy,m=this.platformIsServer,h=this.tracingService;switch(t.encapsulation){case w.Emulated:s=new O(d,u,t,this.appId,l,i,a,m,h);break;case w.ShadowDom:return new V(d,u,e,t,i,a,this.nonce,m,h);default:s=new R(d,u,t,l,i,a,m,h);break}o.set(t.id,s)}return s}ngOnDestroy(){this.rendererByCompId.clear()}componentReplaced(e){this.rendererByCompId.delete(e)}static \u0275fac=function(t){return new(t||r)(c(me),c(ge),c(N),c(Ce),c(p),c(C),c(D),c(P),c(X,8))};static \u0275prov=f({token:r,factory:r.\u0275fac})}return r})(),_=class{eventManager;doc;ngZone;platformIsServer;tracingService;data=Object.create(null);throwOnSyntheticProps=!0;constructor(n,e,t,o,s){this.eventManager=n,this.doc=e,this.ngZone=t,this.platformIsServer=o,this.tracingService=s}destroy(){}destroyNode=null;createElement(n,e){return e?this.doc.createElementNS(j[e]||e,n):this.doc.createElement(n)}createComment(n){return this.doc.createComment(n)}createText(n){return this.doc.createTextNode(n)}appendChild(n,e){(pe(n)?n.content:n).appendChild(e)}insertBefore(n,e,t){n&&(pe(n)?n.content:n).insertBefore(e,t)}removeChild(n,e){e.remove()}selectRootElement(n,e){let t=typeof n=="string"?this.doc.querySelector(n):n;if(!t)throw new g(-5104,!1);return e||(t.textContent=""),t}parentNode(n){return n.parentNode}nextSibling(n){return n.nextSibling}setAttribute(n,e,t,o){if(o){e=o+":"+e;let s=j[o];s?n.setAttributeNS(s,e,t):n.setAttribute(e,t)}else n.setAttribute(e,t)}removeAttribute(n,e,t){if(t){let o=j[t];o?n.removeAttributeNS(o,e):n.removeAttribute(`${t}:${e}`)}else n.removeAttribute(e)}addClass(n,e){n.classList.add(e)}removeClass(n,e){n.classList.remove(e)}setStyle(n,e,t,o){o&(M.DashCase|M.Important)?n.style.setProperty(e,t,o&M.Important?"important":""):n.style[e]=t}removeStyle(n,e,t){t&M.DashCase?n.style.removeProperty(e):n.style[e]=""}setProperty(n,e,t){n!=null&&(n[e]=t)}setValue(n,e){n.nodeValue=e}listen(n,e,t,o){if(typeof n=="string"&&(n=k().getGlobalEventTarget(this.doc,n),!n))throw new g(5102,!1);let s=this.decoratePreventDefault(t);return this.tracingService?.wrapEventListener&&(s=this.tracingService.wrapEventListener(n,e,s)),this.eventManager.addEventListener(n,e,s,o)}decoratePreventDefault(n){return e=>{if(e==="__ngUnwrap__")return n;(this.platformIsServer?this.ngZone.runGuarded(()=>n(e)):n(e))===!1&&e.preventDefault()}}};function pe(r){return r.tagName==="TEMPLATE"&&r.content!==void 0}var V=class extends _{sharedStylesHost;hostEl;shadowRoot;constructor(n,e,t,o,s,i,a,d,u){super(n,s,i,d,u),this.sharedStylesHost=e,this.hostEl=t,this.shadowRoot=t.attachShadow({mode:"open"}),this.sharedStylesHost.addHost(this.shadowRoot);let l=o.styles;l=ye(o.id,l);for(let h of l){let y=document.createElement("style");a&&y.setAttribute("nonce",a),y.textContent=h,this.shadowRoot.appendChild(y)}let m=o.getExternalStyles?.();if(m)for(let h of m){let y=z(h,s);a&&y.setAttribute("nonce",a),this.shadowRoot.appendChild(y)}}nodeOrShadowRoot(n){return n===this.hostEl?this.shadowRoot:n}appendChild(n,e){return super.appendChild(this.nodeOrShadowRoot(n),e)}insertBefore(n,e,t){return super.insertBefore(this.nodeOrShadowRoot(n),e,t)}removeChild(n,e){return super.removeChild(null,e)}parentNode(n){return this.nodeOrShadowRoot(super.parentNode(this.nodeOrShadowRoot(n)))}destroy(){this.sharedStylesHost.removeHost(this.shadowRoot)}},R=class extends _{sharedStylesHost;removeStylesOnCompDestroy;styles;styleUrls;constructor(n,e,t,o,s,i,a,d,u){super(n,s,i,a,d),this.sharedStylesHost=e,this.removeStylesOnCompDestroy=o;let l=t.styles;this.styles=u?ye(u,l):l,this.styleUrls=t.getExternalStyles?.(u)}applyStyles(){this.sharedStylesHost.addStyles(this.styles,this.styleUrls)}destroy(){this.removeStylesOnCompDestroy&&this.sharedStylesHost.removeStyles(this.styles,this.styleUrls)}},O=class extends R{contentAttr;hostAttr;constructor(n,e,t,o,s,i,a,d,u){let l=o+"-"+t.id;super(n,e,t,s,i,a,d,u,l),this.contentAttr=be(l),this.hostAttr=Ae(l)}applyToHost(n){this.applyStyles(),this.setAttribute(n,this.hostAttr,"")}createElement(n,e){let t=super.createElement(n,e);return super.setAttribute(t,this.contentAttr,""),t}},Oe=(()=>{class r extends A{constructor(e){super(e)}supports(e){return!0}addEventListener(e,t,o,s){return e.addEventListener(t,o,s),()=>this.removeEventListener(e,t,o,s)}removeEventListener(e,t,o,s){return e.removeEventListener(t,o,s)}static \u0275fac=function(t){return new(t||r)(c(p))};static \u0275prov=f({token:r,factory:r.\u0275fac})}return r})(),he=["alt","control","meta","shift"],Ie={"\b":"Backspace","	":"Tab","\x7F":"Delete","\x1B":"Escape",Del:"Delete",Esc:"Escape",Left:"ArrowLeft",Right:"ArrowRight",Up:"ArrowUp",Down:"ArrowDown",Menu:"ContextMenu",Scroll:"ScrollLock",Win:"OS"},Le={alt:r=>r.altKey,control:r=>r.ctrlKey,meta:r=>r.metaKey,shift:r=>r.shiftKey},He=(()=>{class r extends A{constructor(e){super(e)}supports(e){return r.parseEventName(e)!=null}addEventListener(e,t,o,s){let i=r.parseEventName(t),a=r.eventCallback(i.fullKey,o,this.manager.getZone());return this.manager.getZone().runOutsideAngular(()=>k().onAndCancel(e,i.domEventName,a,s))}static parseEventName(e){let t=e.toLowerCase().split("."),o=t.shift();if(t.length===0||!(o==="keydown"||o==="keyup"))return null;let s=r._normalizeKey(t.pop()),i="",a=t.indexOf("code");if(a>-1&&(t.splice(a,1),i="code."),he.forEach(u=>{let l=t.indexOf(u);l>-1&&(t.splice(l,1),i+=u+".")}),i+=s,t.length!=0||s.length===0)return null;let d={};return d.domEventName=o,d.fullKey=i,d}static matchEventFullKeyCode(e,t){let o=Ie[e.key]||e.key,s="";return t.indexOf("code.")>-1&&(o=e.code,s="code."),o==null||!o?!1:(o=o.toLowerCase(),o===" "?o="space":o==="."&&(o="dot"),he.forEach(i=>{if(i!==o){let a=Le[i];a(e)&&(s+=i+".")}}),s+=o,s===t)}static eventCallback(e,t,o){return s=>{r.matchEventFullKeyCode(s,e)&&o.runGuarded(()=>t(s))}}static _normalizeKey(e){return e==="esc"?"escape":e}static \u0275fac=function(t){return new(t||r)(c(p))};static \u0275prov=f({token:r,factory:r.\u0275fac})}return r})();function St(r,n){return oe(I({rootComponent:r},Ne(n)))}function Ne(r){return{appProviders:[...xe,...r?.providers??[]],platformProviders:je}}function Pe(){B.makeCurrent()}function ke(){return new H}function Ue(){return Y(document),document}var je=[{provide:C,useValue:ce},{provide:W,useValue:Pe,multi:!0},{provide:p,useFactory:Ue,deps:[]}];var xe=[{provide:G,useValue:"root"},{provide:H,useFactory:ke,deps:[]},{provide:F,useClass:Oe,multi:!0,deps:[p]},{provide:F,useClass:He,multi:!0,deps:[p]},fe,ge,me,{provide:re,useExisting:fe},{provide:le,useClass:Me,deps:[]},[]];var wt=(()=>{class r{_doc;constructor(e){this._doc=e}getTitle(){return this._doc.title}setTitle(e){this._doc.title=e||""}static \u0275fac=function(t){return new(t||r)(c(p))};static \u0275prov=f({token:r,factory:r.\u0275fac,providedIn:"root"})}return r})();var Be=(()=>{class r{static \u0275fac=function(t){return new(t||r)};static \u0275prov=f({token:r,factory:function(t){let o=null;return t?o=new(t||r):o=c(Fe),o},providedIn:"root"})}return r})(),Fe=(()=>{class r extends Be{_doc;constructor(e){super(),this._doc=e}sanitize(e,t){if(t==null)return null;switch(e){case v.NONE:return t;case v.HTML:return S(t,"HTML")?E(t):ne(this._doc,String(t)).toString();case v.STYLE:return S(t,"Style")?E(t):t;case v.SCRIPT:if(S(t,"Script"))return E(t);throw new g(5200,!1);case v.URL:return S(t,"URL")?E(t):te(String(t));case v.RESOURCE_URL:if(S(t,"ResourceURL"))return E(t);throw new g(5201,!1);default:throw new g(5202,!1)}}bypassSecurityTrustHtml(e){return K(e)}bypassSecurityTrustStyle(e){return q(e)}bypassSecurityTrustScript(e){return J(e)}bypassSecurityTrustUrl(e){return Q(e)}bypassSecurityTrustResourceUrl(e){return ee(e)}static \u0275fac=function(t){return new(t||r)(c(p))};static \u0275prov=f({token:r,factory:r.\u0275fac,providedIn:"root"})}return r})();export{fe as a,St as b,wt as c,Be as d};
