<?php

namespace App\Http\Middleware;

use Closure;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Auth;
use Symfony\Component\HttpFoundation\Response;

class KhachHangMiddleWare
{
    /**
     * Handle an incoming request.
     *
     * @param  \Closure(\Illuminate\Http\Request): (\Symfony\Component\HttpFoundation\Response)  $next
     */
    public function handle(Request $request, Closure $next): Response
    {
        $tai_khoang_dang_nhap = Auth::guard('sanctum')->user();
        if($tai_khoang_dang_nhap && $tai_khoang_dang_nhap instanceof \App\Models\KhachHang){
            return $next($request);
        } else {
            return response()->json([
                "status"    => false,
                "message"   => "Bạn cần đăng nhập hệ thống trước"
            ]);
        }
    }
}
